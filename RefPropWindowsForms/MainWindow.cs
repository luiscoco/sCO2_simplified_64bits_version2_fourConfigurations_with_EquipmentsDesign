using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sc.net;

namespace RefPropWindowsForms
{
    public partial class MainWindow : Form
    {
        public About About_dialog;
        public PTC_Solar_Field PTC_Solar_Field_dialog;

        public Configurations_Summary Configurations_Summary_dialog;
        public WizardOne Wizard_dialog;
      
        public AdobePDFViewer AdobePDFViewer_dialog;
        public ChartsExample ChartsExample_dialog;
        public Receiver_Forristall Receiver_Forristall_dialog;

        public Configuration_Form Configuration_window;
        public Recompression_Brayton_Power_Cycle RCwindow;

        public PCRC PCRC_design_dialog;
        public RCMCI RCMCI_design_dialog;
        public RC_without_ReHeating RC_without_ReHeating;    
        public PCRC_without_ReHeating PCRC_without_ReHeating_Dialog;
        public RCMCI_without_ReHeating RCMCI_without_ReHeating_Dialog;

        public snl_compressor_tsr SNL_Compressor;
        public snl_radial_turbine SNL_Turbine;
        public Radial_Turbine RadialTurbine;
        public TurboMachineOutlet TurboMachine_Outlet;
        public IsoentropicEfficiency Isoentropic_effc;
        public REFPROP_Interface REFPROP_properties;
        public REFPROP_Interface_Mixture REFPROP_Interface_Mixture_dialogue;
        public Radial_Turbine_Design Radial_Turbine_Design_dialogue;
        public TOPGEN_V3 TOPGEN_V3_dialogue;

        public HeatExchangerUA HX_Conductance;

        public core CoreHX = new core();
        public RefrigerantCategory category;
        public ReferenceState referencestate;

        public String Fluids_Path_LCE;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        //Recompression (RC) Brayton Power cycle Design-Point.
        public void DesignPoint_Click(object sender, EventArgs e)
        {
            //Create a new Form for the RC Design-Point
            RCwindow = new Recompression_Brayton_Power_Cycle(this);
            RCwindow.MdiParent = this;
            RCwindow.Show();

        }

        //Heat Exchanger (HX) Conductance (UA) calculation
        private void heatExchangerConductanceUACalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create a new Form for Heat Exchangers Conductance (UA) calculation
            HX_Conductance = new HeatExchangerUA();
            HX_Conductance.MdiParent = this;
            HX_Conductance.Show();

            //Refrigerant Category
            if (HX_Conductance.comboBox1.Text == "PureFluid")
            {
                category = RefrigerantCategory.PureFluid;
            }
             if (HX_Conductance.comboBox1.Text == "PredefinedMixture")
            {
                category = RefrigerantCategory.PredefinedMixture;
            }
             if (HX_Conductance.comboBox1.Text == "NewMixture")
            {
                category = RefrigerantCategory.NewMixture;         
            }
             if (HX_Conductance.comboBox1.Text == "PseudoPureFluid")
            {
                category = RefrigerantCategory.PseudoPureFluid;
            }


            //Refrigerant State
             if (HX_Conductance.comboBox3.Text == "DEF")
             {
                 referencestate = ReferenceState.DEF;
             }
             if (HX_Conductance.comboBox3.Text == "ASH")
             {
                 referencestate = ReferenceState.ASH;
             }
             if (HX_Conductance.comboBox3.Text == "IIR")
             {
                 referencestate = ReferenceState.IIR;
             }
             if (HX_Conductance.comboBox3.Text == "NBP")
             {
                 referencestate = ReferenceState.NBP;
             }

             CoreHX.core1(HX_Conductance.comboBox2.Text, category);
             CoreHX.working_fluid.Category = category;
             CoreHX.working_fluid.reference = referencestate;

             HX_Conductance.HeatExchangerUA1(CoreHX); 
        }

        // Auto_Optimal_Design Menu Option
        public void autooptimaldesignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create a new Form for the RC Opimizing the Design-Point
            //RC_AutoOptimalwindow = new RC_Auto_Optimal();
            //RC_AutoOptimalwindow.MdiParent = this;
            //RC_AutoOptimalwindow.Show();
        }

        //SNL_Compressor dialog show
        public void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //SNL_Radial_Turbine dialog show (with a ONE Stage Recompressor)
        public void sandiaLaboratoryTurbineSizingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SNL_Turbine = new snl_radial_turbine();
            SNL_Turbine.MdiParent = this;
            SNL_Turbine.Show();
        }

        //Radial_Turbine dialog show
        public void radialTurbineSizingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadialTurbine = new Radial_Turbine();
            RadialTurbine.MdiParent = this;
            RadialTurbine.Show();
        }

        //SNL_Compressor dialog show (with a TWO Stages Recompressor)
        public void compressorSizingAndRecompressorWithTwoStagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SNL_Compressor = new snl_compressor_tsr();
            SNL_Compressor.MdiParent = this;
            SNL_Compressor.Show();
        }

        //TurboMachine Outlet Conditions
        public void turboMachinesOutletDesignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurboMachine_Outlet = new TurboMachineOutlet();
            TurboMachine_Outlet.MdiParent = this;
            TurboMachine_Outlet.Show();
        }

        //Isoentropic Efficiency calculation 
        public void isoentropicPolitropicEfficienciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Isoentropic_effc = new IsoentropicEfficiency();
            Isoentropic_effc.MdiParent = this;
            Isoentropic_effc.Show();
        }

        //REFPROP properties interface
        public void rEFPROPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REFPROP_properties = new REFPROP_Interface();
            REFPROP_properties.MdiParent = this;
            REFPROP_properties.Show();
        }

        //RefProp Path Configuration
        public void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuration_window = new Configuration_Form(this);
            Configuration_window.MdiParent = this;
            Configuration_window.Show();
        }

        public void designPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCRC_design_dialog = new PCRC();
            PCRC_design_dialog.MdiParent = this;
            PCRC_design_dialog.Show();
        }

        public void designPointToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RCMCI_design_dialog = new RCMCI();
            RCMCI_design_dialog.MdiParent = this;
            RCMCI_design_dialog.Show();
        }

        public void designPointToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RC_without_ReHeating = new RC_without_ReHeating();
            RC_without_ReHeating.MdiParent = this;
            RC_without_ReHeating.Show();
        }

        //PCRC without ReHeating at Design-Point
        public void designPointToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PCRC_without_ReHeating_Dialog = new PCRC_without_ReHeating();
            PCRC_without_ReHeating_Dialog.MdiParent = this;
            PCRC_without_ReHeating_Dialog.Show();
        }

        //RCMCI without ReHeating at Design-Point
        public void designPointToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            RCMCI_without_ReHeating_Dialog = new RCMCI_without_ReHeating();
            RCMCI_without_ReHeating_Dialog.MdiParent = this;
            RCMCI_without_ReHeating_Dialog.Show();
        }

        public void sensingAnalysisToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        public void MainWindow_Load(object sender, EventArgs e)
        {
            this.aboutToolStripMenuItem_Click(this, e);

            //Configurations_Summary_dialog = new Configurations_Summary(this);
            //Configurations_Summary_dialog.MdiParent = this;
            //Configurations_Summary_dialog.Show();

            Wizard_dialog = new WizardOne(this);
            Wizard_dialog.MdiParent = this;
            Wizard_dialog.Show();
        }

        //PTC Solar Field Design
        public void parabolicCollectorDetailDesignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PTC_Solar_Field_dialog = new PTC_Solar_Field();
            PTC_Solar_Field_dialog.MdiParent = this;
            PTC_Solar_Field_dialog.Show();

            //Refrigerant Category
            if (PTC_Solar_Field_dialog.comboBox1.Text == "PureFluid")
            {
                category = RefrigerantCategory.PureFluid;
            }
            if (PTC_Solar_Field_dialog.comboBox1.Text == "PredefinedMixture")
            {
                category = RefrigerantCategory.PredefinedMixture;
            }
            if (PTC_Solar_Field_dialog.comboBox1.Text == "NewMixture")
            {
                category = RefrigerantCategory.NewMixture;
            }
            if (PTC_Solar_Field_dialog.comboBox1.Text == "PseudoPureFluid")
            {
                category = RefrigerantCategory.PseudoPureFluid;
            }

            //Refrigerant State
            if (PTC_Solar_Field_dialog.comboBox3.Text == "DEF")
            {
                referencestate = ReferenceState.DEF;
            }
            if (PTC_Solar_Field_dialog.comboBox3.Text == "ASH")
            {
                referencestate = ReferenceState.ASH;
            }
            if (PTC_Solar_Field_dialog.comboBox3.Text == "IIR")
            {
                referencestate = ReferenceState.IIR;
            }
            if (PTC_Solar_Field_dialog.comboBox3.Text == "NBP")
            {
                referencestate = ReferenceState.NBP;
            }

            CoreHX.core1(PTC_Solar_Field_dialog.comboBox2.Text, category);
            CoreHX.working_fluid.Category = category;
            CoreHX.working_fluid.reference = referencestate;

            PTC_Solar_Field_dialog.PTC_Solar_Field_uno(CoreHX);
        }

        //About window
        public void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_dialog = new About(this);
            About_dialog.ShowDialog();
        }

        //Wizard
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Wizard_dialog = new WizardOne(this);
            Wizard_dialog.MdiParent = this;
            Wizard_dialog.Show();
        }

        //REFPROP_Mixtures_Dialogue
        private void rEFPROPMixtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REFPROP_Interface_Mixture_dialogue = new REFPROP_Interface_Mixture();
            REFPROP_Interface_Mixture_dialogue.MdiParent = this;
            REFPROP_Interface_Mixture_dialogue.Show();
        }

        //TOPGEN_V2_Radial_Turbine_Design
        private void tOPGENV2rRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Radial_Turbine_Design_dialogue = new Radial_Turbine_Design();
            Radial_Turbine_Design_dialogue.MdiParent = this;
            Radial_Turbine_Design_dialogue.Show();
        }

        //TOPGEN_V3
        private void tOPGENV3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TOPGEN_V3_dialogue = new TOPGEN_V3();
            TOPGEN_V3_dialogue.MdiParent = this;
            TOPGEN_V3_dialogue.Show();
        }

        private void pTCSolarFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PTC_SF_Calculation PTC_SF_Calculation_window = new PTC_SF_Calculation();
            PTC_SF_Calculation_window.Show();
        }

        private void lFSolarFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LF_SF_Calculation LF_SF_Calculation_window = new LF_SF_Calculation();
            LF_SF_Calculation_window.Show();
        }

        private void dualLoopSolarFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dual_Loop_SF_Calculation Dual_Loop_SF_Calculation_window = new Dual_Loop_SF_Calculation();
            Dual_Loop_SF_Calculation_window.Show();
        }

        //Wizard Configurations 1-6
        private void configurations16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wizard_dialog = new WizardOne(this);
            Wizard_dialog.MdiParent = this;
            Wizard_dialog.Show();
        }

        private void adobePDFViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdobePDFViewer_dialog = new AdobePDFViewer();
            AdobePDFViewer_dialog.MdiParent = this;
            AdobePDFViewer_dialog.Show();

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();

            if (dlg.FileName != "")
            {
                AdobePDFViewer_dialog.axAcroPDF1.src = dlg.FileName;
            }
        }

        private void chartsExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartsExample_dialog = new ChartsExample();
            ChartsExample_dialog.MdiParent = this;
            ChartsExample_dialog.Show();
        }

        private void ReceiverForristalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receiver_Forristall_dialog = new Receiver_Forristall(this);
            Receiver_Forristall_dialog.MdiParent = this;
            Receiver_Forristall_dialog.Show();
        }

        private void tesisDeFranciscoCrespiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdobePDFViewer_dialog = new AdobePDFViewer();
            AdobePDFViewer_dialog.MdiParent = this;
            AdobePDFViewer_dialog.axAcroPDF1.src = "C:\\SCSP\\PhD-Crespi-Final-1.pdf";
            AdobePDFViewer_dialog.Show();
        }

        private void configurationsXXXXToolStripMenuItem14_Click(object sender, EventArgs e)
        {

        }

        private void configurationsXXXXToolStripMenuItem15_Click(object sender, EventArgs e)
        {

        }

        private void configurationsXXXXToolStripMenuItem16_Click(object sender, EventArgs e)
        {

        }

        private void configurationsXXXXToolStripMenuItem17_Click(object sender, EventArgs e)
        {

        }

        private void configurationsXXXXToolStripMenuItem18_Click(object sender, EventArgs e)
        {

        }

       

        private void adobePDFViewerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdobePDFViewer_dialog = new AdobePDFViewer();
            AdobePDFViewer_dialog.MdiParent = this;
            AdobePDFViewer_dialog.Show();

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();

            if (dlg.FileName != "")
            {
                AdobePDFViewer_dialog.axAcroPDF1.src = dlg.FileName;
            }
        }

        private void chartsExampleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChartsExample_dialog = new ChartsExample();
            ChartsExample_dialog.MdiParent = this;
            ChartsExample_dialog.Show();
        }

        private void tesisFrancescoCrespiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdobePDFViewer_dialog = new AdobePDFViewer();
            AdobePDFViewer_dialog.MdiParent = this;
            AdobePDFViewer_dialog.axAcroPDF1.src = "C:\\SCSP\\References\\PhD-Crespi-Final-1.pdf";
            AdobePDFViewer_dialog.Show();
        }

        private void tesisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
