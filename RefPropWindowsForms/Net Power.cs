using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RefPropWindowsForms
{
    public partial class Net_Power : Form
    {
        //Storing PTC_SF_Design dialog results in the Brayton dialog for Final Reporting or Cost Estimation
        public Double Brayton_cycle_type_variable;
        public String SF_Type_variable;

        public Recompression_Brayton_Power_Cycle Punterociclo_2;
        public RC_without_ReHeating Punterociclo_4;

        public PCRC Punterociclo_6;
        public PCRC_without_ReHeating Punterociclo_8;
        public RCMCI Punterociclo_10;
        public RCMCI_without_ReHeating Punterociclo_12;

        public Double specific_work_main_turbine = 0;
        public Double specific_work_reheating_turbine = 0;
        public Double specific_work_reheating1_turbine = 0;
        public Double specific_work_reheating2_turbine = 0;

        public Double specific_work_compressor1 = 0;
        public Double specific_work_compressor2 = 0;
        public Double specific_work_compressor3 = 0;

        public Net_Power()
        {
            InitializeComponent();
        }

        // RC_Design_WithReHeating: Brayton_cycle_type_variable = 2
        public void RC_Design_withReHeating(Recompression_Brayton_Power_Cycle Punterociclo2, Double Brayton_cycle_type)
        {
            Brayton_cycle_type_variable = Brayton_cycle_type;
            Punterociclo_2 = Punterociclo2;
        }       

        // RC_Design_WithoutReHeating: Brayton_cycle_type_variable = 4
        public void RC_Design_withoutReHeating(RC_without_ReHeating Punterociclo4, Double Brayton_cycle_type)
        {
            Brayton_cycle_type_variable = Brayton_cycle_type;
            Punterociclo_4 = Punterociclo4;
        }

        // PCRC_Design_WithReHeating: Brayton_cycle_type_variable = 6
        public void PCRC_Design_withReHeating(PCRC Punterociclo6, Double Brayton_cycle_type)
        {
            Brayton_cycle_type_variable = Brayton_cycle_type;
            Punterociclo_6 = Punterociclo6;
        }

        // PCRC_Design_WithoutReHeating: Brayton_cycle_type_variable = 8
        public void PCRC_Design_withoutReHeating(PCRC_without_ReHeating Punterociclo8, Double Brayton_cycle_type)
        {
            Brayton_cycle_type_variable = Brayton_cycle_type;
            Punterociclo_8 = Punterociclo8;
        }

        // PCRC_Design_WithReHeating: Brayton_cycle_type_variable = 10
        public void RCMCI_Design_withReHeating(RCMCI Punterociclo10, Double Brayton_cycle_type)
        {
            Brayton_cycle_type_variable = Brayton_cycle_type;
            Punterociclo_10 = Punterociclo10;
        }

        // PCRC_Design_WithoutReHeating: Brayton_cycle_type_variable = 12
        public void RCMCI_Design_withoutReHeating(RCMCI_without_ReHeating Punterociclo12, Double Brayton_cycle_type)
        {
            Brayton_cycle_type_variable = Brayton_cycle_type;
            Punterociclo_12 = Punterociclo12;
        }

        //OK Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Calculate Power production and Energy Efficiency
        public void button2_Click(object sender, EventArgs e)
        {
            //Storing Generator Dialogue results in the Power cycle dialogue.
            if (this.Brayton_cycle_type_variable == 1)
            {

               
            }

            else if (this.Brayton_cycle_type_variable == 2)
            {
                //Generator_Total_Loss, Generator_Electrical_Loss, Generator_Mechanical_Loss
                textBox9.Text = "Generator nameplate power = " + decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Name_Plate_Power), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Nameplate / Design point load = " + decimal.Round(Convert.ToDecimal(Punterociclo_2.Rating_Design_Point_Load), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Power Output = " + decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Power_Output), 2, MidpointRounding.AwayFromZero) + " Shaft Power = " + decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Power Output = " + decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Power_Output), 2, MidpointRounding.AwayFromZero) + "=" + decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero) + " * " + decimal.Round(Convert.ToDecimal((Punterociclo_2.Rating_Point_Efficiency / 100)), 4, MidpointRounding.AwayFromZero) + " * " + decimal.Round(Convert.ToDecimal(Punterociclo_2.Gear_Efficiency), 4, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator total loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Total_Loss), 2, MidpointRounding.AwayFromZero) + " Electrical loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Electrical_Loss), 2, MidpointRounding.AwayFromZero) + " Mechanical loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Mechanical_Loss), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Efficiency = " + decimal.Round(Convert.ToDecimal(Punterociclo_2.Rating_Point_Efficiency), 4, MidpointRounding.AwayFromZero);

                dataGridView1.Rows.Clear();
                dataGridView3.Rows.Clear();
                dataGridView2.Rows.Clear();
                dataGridView4.Rows.Clear();

                string[] row = new string[] { Convert.ToString("Main Solar Field: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.PHX_Q2), 4, MidpointRounding.AwayFromZero)),"kWth" };
                dataGridView4.Rows.Add(row);

                string[] row1 = new string[] { Convert.ToString("ReHeating Solar Field: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.RHX_Q2), 4, MidpointRounding.AwayFromZero)),"kWth" };
                dataGridView4.Rows.Add(row1);

                string[] row2 = new string[] { Convert.ToString("Pre-Cooler: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.PC_Q2), 4, MidpointRounding.AwayFromZero)),"kWth" };
                dataGridView4.Rows.Add(row2);

                string[] row3 = new string[] { Convert.ToString("Net Total Heat Input: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.PHX_Q2 + Punterociclo_2.RHX_Q2), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView2.Rows.Add(row3);

                string[] row4 = new string[] { Convert.ToString("Gross Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView2.Rows.Add(row4);

                string[] row5 = new string[] { Convert.ToString("Gross Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_2.Generator_Power_Output) / (Punterociclo_2.PHX_Q2 + Punterociclo_2.RHX_Q2)) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView2.Rows.Add(row5);

                //Power Generated in Turbomachines
                Double Main_Turbine_Power = 0;
                Double ReHeating_Turbine_Power = 0;
                Double Compressor1_Power = 0;
                Double Compressor2_Power = 0;
                Double Total_Turbomachines_Power = 0;

                //Turbines Power
                string[] row6 = new string[] { Convert.ToString("Main Turbine : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_main_turbine*Punterociclo_2.massflow2), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row6);
                Main_Turbine_Power = specific_work_main_turbine * Punterociclo_2.massflow2;

                string[] row7 = new string[] { Convert.ToString("ReHeating Turbine : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_reheating_turbine * Punterociclo_2.massflow2), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row7);
                ReHeating_Turbine_Power = specific_work_reheating_turbine * Punterociclo_2.massflow2;

                //Compressors Power
                string[] row8 = new string[] { Convert.ToString("Main Compressor : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_compressor1 * Punterociclo_2.massflow2 * (1-Punterociclo_2.recomp_frac2)), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row8);
                Compressor1_Power = specific_work_compressor1 * Punterociclo_2.massflow2 * (1 - Punterociclo_2.recomp_frac2);

                string[] row9 = new string[] { Convert.ToString("ReCompressor : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_compressor2 * Punterociclo_2.massflow2 * Punterociclo_2.recomp_frac2), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row9);
                Compressor2_Power = specific_work_compressor2 * Punterociclo_2.massflow2 * Punterociclo_2.recomp_frac2;

                Total_Turbomachines_Power = Main_Turbine_Power + ReHeating_Turbine_Power + Compressor1_Power + Compressor2_Power;

                string[] row10 = new string[] { Convert.ToString("Total TurboMachines Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row10);

                string[] row11 = new string[] { Convert.ToString("Generator Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_2.Rating_Point_Efficiency / 100) * Punterociclo_2.Gear_Efficiency) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView1.Rows.Add(row11);

                string[] row12 = new string[] { Convert.ToString("Generator Output Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_2.Rating_Point_Efficiency / 100) * Punterociclo_2.Gear_Efficiency) * Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row12);

                //Solar Field Pumps Electrical Consumption
                string[] row13 = new string[] { Convert.ToString("Main SF Pump Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row13);

                textBox15.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Main_SF_Pump_Electrical_Consumption), 2, MidpointRounding.AwayFromZero));

                string[] row14 = new string[] { Convert.ToString("ReHeating SF Pump Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.ReHeating_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row14);

                textBox14.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.ReHeating_SF_Pump_Electrical_Consumption), 2, MidpointRounding.AwayFromZero));

                Punterociclo_2.UHS_Water_Pump = Convert.ToDouble(textBox11.Text);
                string[] row15 = new string[] { Convert.ToString("UHS Water Pump Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row15);

                Punterociclo_2.Miscellanous_Auxiliaries = Convert.ToDouble(textBox13.Text);
                textBox3.Text = Convert.ToString(Punterociclo_2.Generator_Power_Output * (Punterociclo_2.Miscellanous_Auxiliaries / 100));
                string[] row16 = new string[] { Convert.ToString("Miscellanous_Auxiliaries : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Power_Output * (Punterociclo_2.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row16);

                textBox14.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.ReHeating_SF_Pump_Electrical_Consumption), 2, MidpointRounding.AwayFromZero));

                Punterociclo_2.ACHE_fans = Convert.ToDouble(textBox2.Text);

                Punterociclo_2.Miscellanous_Auxiliaries = Convert.ToDouble(textBox13.Text);
                string[] row17 = new string[] { Convert.ToString("ACHE Fans Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.ACHE_fans), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row17);

                Punterociclo_2.Total_Auxiliaries = Punterociclo_2.ACHE_fans + Punterociclo_2.Main_SF_Pump_Electrical_Consumption + Punterociclo_2.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_2.Generator_Power_Output * (Punterociclo_2.Miscellanous_Auxiliaries / 100));
                textBox1.Text = Convert.ToString(Punterociclo_2.Total_Auxiliaries);

                string[] row18 = new string[] { Convert.ToString("Total_Auxiliaries Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row18);

                string[] row20 = new string[] { Convert.ToString("Net Power Output : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_2.Rating_Point_Efficiency / 100) * Punterociclo_2.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_2.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView2.Rows.Add(row20);

                string[] row19 = new string[] { Convert.ToString("Net Power Output : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_2.Rating_Point_Efficiency / 100) * Punterociclo_2.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_2.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row19);

                string[] row21 = new string[] { Convert.ToString("Net Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_2.Rating_Point_Efficiency / 100) * Punterociclo_2.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_2.Total_Auxiliaries) / (Punterociclo_2.PHX_Q2 + Punterociclo_2.RHX_Q2)) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView2.Rows.Add(row21);
            }

            else if (this.Brayton_cycle_type_variable == 3)
            {
                
            }

            else if (this.Brayton_cycle_type_variable == 4)
            {
                //Generator_Total_Loss, Generator_Electrical_Loss, Generator_Mechanical_Loss
                textBox9.Text = "Generator nameplate power = " + decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Name_Plate_Power), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Nameplate / Design point load = " + decimal.Round(Convert.ToDecimal(Punterociclo_4.Rating_Design_Point_Load), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Power Output = " + decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Power_Output), 2, MidpointRounding.AwayFromZero) + " Shaft Power = " + decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Power Output = " + decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Power_Output), 2, MidpointRounding.AwayFromZero) + "=" + decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero) + " * " + decimal.Round(Convert.ToDecimal((Punterociclo_4.Rating_Point_Efficiency / 100)), 4, MidpointRounding.AwayFromZero) + " * " + decimal.Round(Convert.ToDecimal(Punterociclo_4.Gear_Efficiency), 4, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator total loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Total_Loss), 2, MidpointRounding.AwayFromZero) + " Electrical loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Electrical_Loss), 2, MidpointRounding.AwayFromZero) + " Mechanical loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Mechanical_Loss), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Efficiency = " + decimal.Round(Convert.ToDecimal(Punterociclo_4.Rating_Point_Efficiency), 4, MidpointRounding.AwayFromZero);

                dataGridView1.Rows.Clear();
                dataGridView3.Rows.Clear();
                dataGridView2.Rows.Clear();
                dataGridView4.Rows.Clear();

                string[] row = new string[] { Convert.ToString("Main Solar Field: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.PHX_Q2), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView4.Rows.Add(row);

                string[] row2 = new string[] { Convert.ToString("Pre-Cooler: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.PC_Q2), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView4.Rows.Add(row2);

                string[] row3 = new string[] { Convert.ToString("Net Total Heat Input: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.PHX_Q2), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView2.Rows.Add(row3);

                string[] row4 = new string[] { Convert.ToString("Gross Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView2.Rows.Add(row4);

                string[] row5 = new string[] { Convert.ToString("Gross Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_4.Generator_Power_Output) / (Punterociclo_4.PHX_Q2)) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView2.Rows.Add(row5);

                //Power Generated in Turbomachines
                Double Main_Turbine_Power = 0;
                Double Compressor1_Power = 0;
                Double Compressor2_Power = 0;
                Double Total_Turbomachines_Power = 0;

                //Turbines Power
                string[] row6 = new string[] { Convert.ToString("Main Turbine : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_main_turbine * Punterociclo_4.massflow2), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row6);
                Main_Turbine_Power = specific_work_main_turbine * Punterociclo_4.massflow2;

                //Compressors Power
                string[] row8 = new string[] { Convert.ToString("Main Compressor : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_compressor1 * Punterociclo_4.massflow2 * (1 - Punterociclo_4.recomp_frac2)), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row8);
                Compressor1_Power = specific_work_compressor1 * Punterociclo_4.massflow2 * (1 - Punterociclo_4.recomp_frac2);

                string[] row9 = new string[] { Convert.ToString("ReCompressor : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_compressor2 * Punterociclo_4.massflow2 * Punterociclo_4.recomp_frac2), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row9);
                Compressor2_Power = specific_work_compressor2 * Punterociclo_4.massflow2 * Punterociclo_4.recomp_frac2;

                Total_Turbomachines_Power = Main_Turbine_Power + Compressor1_Power + Compressor2_Power;

                string[] row10 = new string[] { Convert.ToString("Total TurboMachines Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row10);

                string[] row11 = new string[] { Convert.ToString("Generator Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_4.Rating_Point_Efficiency / 100) * Punterociclo_4.Gear_Efficiency) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView1.Rows.Add(row11);

                string[] row12 = new string[] { Convert.ToString("Generator Output Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_4.Rating_Point_Efficiency / 100) * Punterociclo_4.Gear_Efficiency) * Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row12);

                //Solar Field Pumps Electrical Consumption
                string[] row13 = new string[] { Convert.ToString("Main SF Pump Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row13);

                textBox15.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Main_SF_Pump_Electrical_Consumption), 2, MidpointRounding.AwayFromZero));

                Punterociclo_4.UHS_Water_Pump = Convert.ToDouble(textBox11.Text);
                string[] row15 = new string[] { Convert.ToString("UHS Water Pump Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row15);

                Punterociclo_4.Miscellanous_Auxiliaries = Convert.ToDouble(textBox13.Text);
                textBox3.Text = Convert.ToString(Punterociclo_4.Generator_Power_Output * (Punterociclo_4.Miscellanous_Auxiliaries / 100));
                string[] row16 = new string[] { Convert.ToString("Miscellanous_Auxiliaries : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Power_Output * (Punterociclo_4.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row16);

                textBox14.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.ReHeating_SF_Pump_Electrical_Consumption), 2, MidpointRounding.AwayFromZero));

                Punterociclo_4.ACHE_fans = Convert.ToDouble(textBox2.Text);

                Punterociclo_4.Miscellanous_Auxiliaries = Convert.ToDouble(textBox13.Text);
                string[] row17 = new string[] { Convert.ToString("ACHE Fans Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.ACHE_fans), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row17);

                Punterociclo_4.Total_Auxiliaries = Punterociclo_4.ACHE_fans + Punterociclo_4.Main_SF_Pump_Electrical_Consumption + Punterociclo_4.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_4.Generator_Power_Output * (Punterociclo_4.Miscellanous_Auxiliaries / 100));
                textBox1.Text = Convert.ToString(Punterociclo_4.Total_Auxiliaries);

                string[] row18 = new string[] { Convert.ToString("Total_Auxiliaries Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row18);

                string[] row20 = new string[] { Convert.ToString("Net Power Output : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_4.Rating_Point_Efficiency / 100) * Punterociclo_4.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_4.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView2.Rows.Add(row20);

                string[] row19 = new string[] { Convert.ToString("Net Power Output : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_4.Rating_Point_Efficiency / 100) * Punterociclo_4.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_4.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row19);

                string[] row21 = new string[] { Convert.ToString("Net Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_4.Rating_Point_Efficiency / 100) * Punterociclo_4.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_4.Total_Auxiliaries) / (Punterociclo_4.PHX_Q2)) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView2.Rows.Add(row21);
            }

            else if (this.Brayton_cycle_type_variable == 15)
            {
                
            }

            else if (this.Brayton_cycle_type_variable == 5)
            {

            }

            else if (this.Brayton_cycle_type_variable == 6)
            {
                //Generator_Total_Loss, Generator_Electrical_Loss, Generator_Mechanical_Loss
                textBox9.Text = "Generator nameplate power = " + decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Name_Plate_Power), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Nameplate / Design point load = " + decimal.Round(Convert.ToDecimal(Punterociclo_6.Rating_Design_Point_Load), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Power Output = " + decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Power_Output), 2, MidpointRounding.AwayFromZero) + " Shaft Power = " + decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Power Output = " + decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Power_Output), 2, MidpointRounding.AwayFromZero) + "=" + decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero) + " * " + decimal.Round(Convert.ToDecimal((Punterociclo_6.Rating_Point_Efficiency / 100)), 4, MidpointRounding.AwayFromZero) + " * " + decimal.Round(Convert.ToDecimal(Punterociclo_6.Gear_Efficiency), 4, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator total loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Total_Loss), 2, MidpointRounding.AwayFromZero) + " Electrical loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Electrical_Loss), 2, MidpointRounding.AwayFromZero) + " Mechanical loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Mechanical_Loss), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Efficiency = " + decimal.Round(Convert.ToDecimal(Punterociclo_6.Rating_Point_Efficiency), 4, MidpointRounding.AwayFromZero);

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                dataGridView3.Rows.Clear();
                dataGridView4.Rows.Clear();

                string[] row = new string[] { Convert.ToString("Main Solar Field: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.PHX1), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView4.Rows.Add(row);

                string[] row1 = new string[] { Convert.ToString("ReHeating Solar Field: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.RHX1), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView4.Rows.Add(row1);

                string[] row2 = new string[] { Convert.ToString("Pre-Cooler1: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.PC1), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView4.Rows.Add(row2);

                string[] row21 = new string[] { Convert.ToString("Pre-Cooler2: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.COOLER1), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView4.Rows.Add(row21);

                string[] row3 = new string[] { Convert.ToString("Net Total Heat Input: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.PHX1 + Punterociclo_6.RHX1), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView2.Rows.Add(row3);

                string[] row4 = new string[] { Convert.ToString("Gross Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView2.Rows.Add(row4);

                string[] row5 = new string[] { Convert.ToString("Gross Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_6.Generator_Power_Output) / (Punterociclo_6.PHX1 + Punterociclo_6.RHX1)) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView2.Rows.Add(row5);

                //Power Generated in Turbomachines
                Double Main_Turbine_Power = 0;
                Double ReHeating_Turbine_Power = 0;
                Double Compressor1_Power = 0;
                Double Compressor2_Power = 0;
                Double Compressor3_Power = 0;
                Double Total_Turbomachines_Power = 0;

                //Turbines Power
                string[] row6 = new string[] { Convert.ToString("Main Turbine : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_main_turbine * Punterociclo_6.massflow2), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row6);
                Main_Turbine_Power = specific_work_main_turbine * Punterociclo_6.massflow2;

                string[] row7 = new string[] { Convert.ToString("ReHeating Turbine : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_reheating_turbine * Punterociclo_6.massflow2), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row7);
                ReHeating_Turbine_Power = specific_work_reheating_turbine * Punterociclo_6.massflow2;

                //Compressors Power
                string[] row8 = new string[] { Convert.ToString("Main Compressor : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_compressor1 * Punterociclo_6.massflow2 * (1 - Punterociclo_6.recomp_frac2)), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row8);
                Compressor1_Power = specific_work_compressor1 * Punterociclo_6.massflow2 * (1 - Punterociclo_6.recomp_frac2);

                string[] row9 = new string[] { Convert.ToString("ReCompressor : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_compressor2 * Punterociclo_6.massflow2 * Punterociclo_6.recomp_frac2), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row9);
                Compressor2_Power = specific_work_compressor2 * Punterociclo_6.massflow2 * Punterociclo_6.recomp_frac2;

                string[] row91 = new string[] { Convert.ToString("PreCompressor : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_compressor3 * Punterociclo_6.massflow2), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row91);
                Compressor3_Power = specific_work_compressor3 * Punterociclo_6.massflow2;

                Total_Turbomachines_Power = Main_Turbine_Power + ReHeating_Turbine_Power + Compressor1_Power + Compressor2_Power + Compressor3_Power;

                string[] row10 = new string[] { Convert.ToString("Total TurboMachines Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row10);

                string[] row11 = new string[] { Convert.ToString("Generator Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_6.Rating_Point_Efficiency / 100) * Punterociclo_6.Gear_Efficiency) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView1.Rows.Add(row11);

                string[] row12 = new string[] { Convert.ToString("Generator Output Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_6.Rating_Point_Efficiency / 100) * Punterociclo_6.Gear_Efficiency) * Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row12);

                //Solar Field Pumps Electrical Consumption
                string[] row13 = new string[] { Convert.ToString("Main SF Pump Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row13);

                textBox15.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Main_SF_Pump_Electrical_Consumption), 2, MidpointRounding.AwayFromZero));

                string[] row14 = new string[] { Convert.ToString("ReHeating SF Pump Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.ReHeating_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row14);

                textBox14.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.ReHeating_SF_Pump_Electrical_Consumption), 2, MidpointRounding.AwayFromZero));

                Punterociclo_6.UHS_Water_Pump = Convert.ToDouble(textBox11.Text);
                string[] row15 = new string[] { Convert.ToString("UHS Water Pump Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row15);

                Punterociclo_6.Miscellanous_Auxiliaries = Convert.ToDouble(textBox13.Text);
                textBox3.Text = Convert.ToString(Punterociclo_6.Generator_Power_Output * (Punterociclo_6.Miscellanous_Auxiliaries / 100));
                string[] row16 = new string[] { Convert.ToString("Miscellanous_Auxiliaries : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Power_Output * (Punterociclo_6.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row16);

                textBox14.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.ReHeating_SF_Pump_Electrical_Consumption), 2, MidpointRounding.AwayFromZero));

                Punterociclo_6.ACHE_fans = Convert.ToDouble(textBox2.Text);

                Punterociclo_6.Miscellanous_Auxiliaries = Convert.ToDouble(textBox13.Text);
                string[] row17 = new string[] { Convert.ToString("ACHE Fans Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.ACHE_fans), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row17);

                Punterociclo_6.Total_Auxiliaries = Punterociclo_6.ACHE_fans + Punterociclo_6.Main_SF_Pump_Electrical_Consumption + Punterociclo_6.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_6.Generator_Power_Output * (Punterociclo_6.Miscellanous_Auxiliaries / 100));
                textBox1.Text = Convert.ToString(Punterociclo_6.Total_Auxiliaries);

                string[] row18 = new string[] { Convert.ToString("Total_Auxiliaries Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row18);

                string[] row20 = new string[] { Convert.ToString("Net Power Output : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_6.Rating_Point_Efficiency / 100) * Punterociclo_6.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_6.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView2.Rows.Add(row20);

                string[] row19 = new string[] { Convert.ToString("Net Power Output : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_6.Rating_Point_Efficiency / 100) * Punterociclo_6.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_6.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row19);

                string[] row25 = new string[] { Convert.ToString("Net Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_6.Rating_Point_Efficiency / 100) * Punterociclo_6.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_6.Total_Auxiliaries) / (Punterociclo_6.PHX1 + Punterociclo_6.RHX1)) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView2.Rows.Add(row25);
            }

            else if (this.Brayton_cycle_type_variable == 7)
            {
                
            }

            else if (this.Brayton_cycle_type_variable == 8)
            {
                //Generator_Total_Loss, Generator_Electrical_Loss, Generator_Mechanical_Loss
                textBox9.Text = "Generator nameplate power = " + decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Name_Plate_Power), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Nameplate / Design point load = " + decimal.Round(Convert.ToDecimal(Punterociclo_8.Rating_Design_Point_Load), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Power Output = " + decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Power_Output), 2, MidpointRounding.AwayFromZero) + " Shaft Power = " + decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Power Output = " + decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Power_Output), 2, MidpointRounding.AwayFromZero) + "=" + decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero) + " * " + decimal.Round(Convert.ToDecimal((Punterociclo_8.Rating_Point_Efficiency / 100)), 4, MidpointRounding.AwayFromZero) + " * " + decimal.Round(Convert.ToDecimal(Punterociclo_8.Gear_Efficiency), 4, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator total loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Total_Loss), 2, MidpointRounding.AwayFromZero) + " Electrical loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Electrical_Loss), 2, MidpointRounding.AwayFromZero) + " Mechanical loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Mechanical_Loss), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Efficiency = " + decimal.Round(Convert.ToDecimal(Punterociclo_8.Rating_Point_Efficiency), 4, MidpointRounding.AwayFromZero);

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                dataGridView3.Rows.Clear();
                dataGridView4.Rows.Clear();

                string[] row = new string[] { Convert.ToString("Main Solar Field: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.PHX1), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView4.Rows.Add(row);

                string[] row2 = new string[] { Convert.ToString("Pre-Cooler1: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.PC11), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView4.Rows.Add(row2);

                string[] row21 = new string[] { Convert.ToString("Pre-Cooler2: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.PC21), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView4.Rows.Add(row21);

                string[] row3 = new string[] { Convert.ToString("Net Total Heat Input: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.PHX1), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView2.Rows.Add(row3);

                string[] row4 = new string[] { Convert.ToString("Gross Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView2.Rows.Add(row4);

                string[] row5 = new string[] { Convert.ToString("Gross Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_8.Generator_Power_Output) / (Punterociclo_8.PHX1)) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView2.Rows.Add(row5);

                //Power Generated in Turbomachines
                Double Main_Turbine_Power = 0;
                Double Compressor1_Power = 0;
                Double Compressor2_Power = 0;
                Double Compressor3_Power = 0;
                Double Total_Turbomachines_Power = 0;

                //Turbines Power
                string[] row6 = new string[] { Convert.ToString("Main Turbine : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_main_turbine * Punterociclo_8.massflow2), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row6);
                Main_Turbine_Power = specific_work_main_turbine * Punterociclo_8.massflow2;

                //Compressors Power
                string[] row8 = new string[] { Convert.ToString("Main Compressor : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_compressor1 * Punterociclo_8.massflow2 * (1 - Punterociclo_8.recomp_frac2)), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row8);
                Compressor1_Power = specific_work_compressor1 * Punterociclo_8.massflow2 * (1 - Punterociclo_8.recomp_frac2);

                string[] row9 = new string[] { Convert.ToString("ReCompressor : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_compressor2 * Punterociclo_8.massflow2 * Punterociclo_8.recomp_frac2), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row9);
                Compressor2_Power = specific_work_compressor2 * Punterociclo_8.massflow2 * Punterociclo_8.recomp_frac2;

                string[] row91 = new string[] { Convert.ToString("PreCompressor : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_compressor3 * Punterociclo_8.massflow2), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row91);
                Compressor3_Power = specific_work_compressor3 * Punterociclo_8.massflow2;

                Total_Turbomachines_Power = Main_Turbine_Power + Compressor1_Power + Compressor2_Power + Compressor3_Power;

                string[] row10 = new string[] { Convert.ToString("Total TurboMachines Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row10);

                string[] row11 = new string[] { Convert.ToString("Generator Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_8.Rating_Point_Efficiency / 100) * Punterociclo_8.Gear_Efficiency) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView1.Rows.Add(row11);

                string[] row12 = new string[] { Convert.ToString("Generator Output Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_8.Rating_Point_Efficiency / 100) * Punterociclo_8.Gear_Efficiency) * Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row12);

                //Solar Field Pumps Electrical Consumption
                string[] row13 = new string[] { Convert.ToString("Main SF Pump Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row13);

                textBox15.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Main_SF_Pump_Electrical_Consumption), 2, MidpointRounding.AwayFromZero));

                Punterociclo_8.UHS_Water_Pump = Convert.ToDouble(textBox11.Text);
                string[] row15 = new string[] { Convert.ToString("UHS Water Pump Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row15);

                Punterociclo_8.Miscellanous_Auxiliaries = Convert.ToDouble(textBox13.Text);
                textBox3.Text = Convert.ToString(Punterociclo_8.Generator_Power_Output * (Punterociclo_8.Miscellanous_Auxiliaries / 100));
                string[] row16 = new string[] { Convert.ToString("Miscellanous_Auxiliaries : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Power_Output * (Punterociclo_8.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row16);

                textBox14.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.ReHeating_SF_Pump_Electrical_Consumption), 2, MidpointRounding.AwayFromZero));

                Punterociclo_8.ACHE_fans = Convert.ToDouble(textBox2.Text);

                Punterociclo_8.Miscellanous_Auxiliaries = Convert.ToDouble(textBox13.Text);
                string[] row17 = new string[] { Convert.ToString("ACHE Fans Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.ACHE_fans), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row17);

                Punterociclo_8.Total_Auxiliaries = Punterociclo_8.ACHE_fans + Punterociclo_8.Main_SF_Pump_Electrical_Consumption + Punterociclo_8.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_8.Generator_Power_Output * (Punterociclo_8.Miscellanous_Auxiliaries / 100));
                textBox1.Text = Convert.ToString(Punterociclo_8.Total_Auxiliaries);

                string[] row18 = new string[] { Convert.ToString("Total_Auxiliaries Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row18);

                string[] row20 = new string[] { Convert.ToString("Net Power Output : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_8.Rating_Point_Efficiency / 100) * Punterociclo_8.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_8.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView2.Rows.Add(row20);

                string[] row19 = new string[] { Convert.ToString("Net Power Output : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_8.Rating_Point_Efficiency / 100) * Punterociclo_8.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_8.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row19);

                string[] row25 = new string[] { Convert.ToString("Net Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_8.Rating_Point_Efficiency / 100) * Punterociclo_8.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_8.Total_Auxiliaries) / (Punterociclo_8.PHX1)) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView2.Rows.Add(row25);            
            }

            else if (this.Brayton_cycle_type_variable == 9)
            {
                
            }

            else if (this.Brayton_cycle_type_variable == 10)
            {
                //Generator_Total_Loss, Generator_Electrical_Loss, Generator_Mechanical_Loss
                textBox9.Text = "Generator nameplate power = " + decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Name_Plate_Power), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Nameplate / Design point load = " + decimal.Round(Convert.ToDecimal(Punterociclo_10.Rating_Design_Point_Load), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Power Output = " + decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Power_Output), 2, MidpointRounding.AwayFromZero) + " Shaft Power = " + decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Power Output = " + decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Power_Output), 2, MidpointRounding.AwayFromZero) + "=" + decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero) + " * " + decimal.Round(Convert.ToDecimal((Punterociclo_10.Rating_Point_Efficiency / 100)), 4, MidpointRounding.AwayFromZero) + " * " + decimal.Round(Convert.ToDecimal(Punterociclo_10.Gear_Efficiency), 4, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator total loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Total_Loss), 2, MidpointRounding.AwayFromZero) + " Electrical loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Electrical_Loss), 2, MidpointRounding.AwayFromZero) + " Mechanical loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Mechanical_Loss), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Efficiency = " + decimal.Round(Convert.ToDecimal(Punterociclo_10.Rating_Point_Efficiency), 4, MidpointRounding.AwayFromZero);
                
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                dataGridView3.Rows.Clear();
                dataGridView4.Rows.Clear();

                string[] row = new string[] { Convert.ToString("Main Solar Field: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.PHX1), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView4.Rows.Add(row);

                string[] row1 = new string[] { Convert.ToString("ReHeating Solar Field: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.RHX1), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView4.Rows.Add(row1);

                string[] row2 = new string[] { Convert.ToString("Pre-Cooler1: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.PC11), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView4.Rows.Add(row2);

                string[] row21 = new string[] { Convert.ToString("Pre-Cooler2: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.PC21), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView4.Rows.Add(row21);

                string[] row3 = new string[] { Convert.ToString("Net Total Heat Input: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.PHX1 + Punterociclo_10.RHX1), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView2.Rows.Add(row3);

                string[] row4 = new string[] { Convert.ToString("Gross Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView2.Rows.Add(row4);

                string[] row5 = new string[] { Convert.ToString("Gross Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_10.Generator_Power_Output) / (Punterociclo_10.PHX1 + Punterociclo_10.RHX1)) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView2.Rows.Add(row5);

                //Power Generated in Turbomachines
                Double Main_Turbine_Power = 0;
                Double ReHeating_Turbine_Power = 0;
                Double Compressor1_Power = 0;
                Double Compressor2_Power = 0;
                Double Compressor3_Power = 0;
                Double Total_Turbomachines_Power = 0;

                //Turbines Power
                string[] row6 = new string[] { Convert.ToString("Main Turbine : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_main_turbine * Punterociclo_10.massflow2), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row6);
                Main_Turbine_Power = specific_work_main_turbine * Punterociclo_10.massflow2;

                string[] row7 = new string[] { Convert.ToString("ReHeating Turbine : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_reheating_turbine * Punterociclo_10.massflow2), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row7);
                ReHeating_Turbine_Power = specific_work_reheating_turbine * Punterociclo_10.massflow2;

                //Compressors Power
                string[] row8 = new string[] { Convert.ToString("Main Compressor : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_compressor1 * Punterociclo_10.massflow2 * (1 - Punterociclo_10.recomp_frac2)), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row8);
                Compressor1_Power = specific_work_compressor1 * Punterociclo_10.massflow2 * (1 - Punterociclo_10.recomp_frac2);

                string[] row9 = new string[] { Convert.ToString("ReCompressor : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_compressor2 * Punterociclo_10.massflow2 * Punterociclo_10.recomp_frac2), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row9);
                Compressor2_Power = specific_work_compressor2 * Punterociclo_10.massflow2 * Punterociclo_10.recomp_frac2;

                string[] row91 = new string[] { Convert.ToString("Compressor 2 : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_compressor3 * Punterociclo_10.massflow2 * (1 - Punterociclo_10.recomp_frac2)), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row91);
                Compressor3_Power = specific_work_compressor3 * Punterociclo_10.massflow2 * (1 - Punterociclo_10.recomp_frac2);

                Total_Turbomachines_Power = Main_Turbine_Power + ReHeating_Turbine_Power + Compressor1_Power + Compressor2_Power + Compressor3_Power;

                string[] row10 = new string[] { Convert.ToString("Total TurboMachines Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row10);

                string[] row11 = new string[] { Convert.ToString("Generator Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_10.Rating_Point_Efficiency / 100) * Punterociclo_10.Gear_Efficiency) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView1.Rows.Add(row11);

                string[] row12 = new string[] { Convert.ToString("Generator Output Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_10.Rating_Point_Efficiency / 100) * Punterociclo_10.Gear_Efficiency) * Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row12);

                //Solar Field Pumps Electrical Consumption
                string[] row13 = new string[] { Convert.ToString("Main SF Pump Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row13);

                textBox15.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Main_SF_Pump_Electrical_Consumption), 2, MidpointRounding.AwayFromZero));

                string[] row14 = new string[] { Convert.ToString("ReHeating SF Pump Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.ReHeating_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row14);

                textBox14.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.ReHeating_SF_Pump_Electrical_Consumption), 2, MidpointRounding.AwayFromZero));

                Punterociclo_10.UHS_Water_Pump = Convert.ToDouble(textBox11.Text);
                string[] row15 = new string[] { Convert.ToString("UHS Water Pump Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row15);

                Punterociclo_10.Miscellanous_Auxiliaries = Convert.ToDouble(textBox13.Text);
                textBox3.Text = Convert.ToString(Punterociclo_10.Generator_Power_Output * (Punterociclo_10.Miscellanous_Auxiliaries / 100));
                string[] row16 = new string[] { Convert.ToString("Miscellanous_Auxiliaries : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Power_Output * (Punterociclo_10.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row16);

                textBox14.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.ReHeating_SF_Pump_Electrical_Consumption), 2, MidpointRounding.AwayFromZero));

                Punterociclo_10.ACHE_fans = Convert.ToDouble(textBox2.Text);

                Punterociclo_10.Miscellanous_Auxiliaries = Convert.ToDouble(textBox13.Text);
                string[] row17 = new string[] { Convert.ToString("ACHE Fans Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.ACHE_fans), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row17);

                Punterociclo_10.Total_Auxiliaries = Punterociclo_10.ACHE_fans + Punterociclo_10.Main_SF_Pump_Electrical_Consumption + Punterociclo_10.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_10.Generator_Power_Output * (Punterociclo_10.Miscellanous_Auxiliaries / 100));
                textBox1.Text = Convert.ToString(Punterociclo_10.Total_Auxiliaries);

                string[] row18 = new string[] { Convert.ToString("Total_Auxiliaries Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row18);

                string[] row20 = new string[] { Convert.ToString("Net Power Output : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_10.Rating_Point_Efficiency / 100) * Punterociclo_10.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_10.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView2.Rows.Add(row20);

                string[] row19 = new string[] { Convert.ToString("Net Power Output : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_10.Rating_Point_Efficiency / 100) * Punterociclo_10.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_10.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row19);

                string[] row25 = new string[] { Convert.ToString("Net Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_10.Rating_Point_Efficiency / 100) * Punterociclo_10.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_10.Total_Auxiliaries) / (Punterociclo_10.PHX1 + Punterociclo_10.RHX1)) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView2.Rows.Add(row25);
            }

            else if (this.Brayton_cycle_type_variable == 11)
            {
               
            }

            else if (this.Brayton_cycle_type_variable == 12)
            {
                //Generator_Total_Loss, Generator_Electrical_Loss, Generator_Mechanical_Loss
                textBox9.Text = "Generator nameplate power = " + decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Name_Plate_Power), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Nameplate / Design point load = " + decimal.Round(Convert.ToDecimal(Punterociclo_12.Rating_Design_Point_Load), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Power Output = " + decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Power_Output), 2, MidpointRounding.AwayFromZero) + " Shaft Power = " + decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Power Output = " + decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Power_Output), 2, MidpointRounding.AwayFromZero) + "=" + decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero) + " * " + decimal.Round(Convert.ToDecimal((Punterociclo_12.Rating_Point_Efficiency / 100)), 4, MidpointRounding.AwayFromZero) + " * " + decimal.Round(Convert.ToDecimal(Punterociclo_12.Gear_Efficiency), 4, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator total loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Total_Loss), 2, MidpointRounding.AwayFromZero) + " Electrical loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Electrical_Loss), 2, MidpointRounding.AwayFromZero) + " Mechanical loss = " + decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Mechanical_Loss), 2, MidpointRounding.AwayFromZero) +
                                  Environment.NewLine + "Generator Efficiency = " + decimal.Round(Convert.ToDecimal(Punterociclo_12.Rating_Point_Efficiency), 4, MidpointRounding.AwayFromZero);

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                dataGridView3.Rows.Clear();
                dataGridView4.Rows.Clear();

                string[] row = new string[] { Convert.ToString("Main Solar Field: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.PHX), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView4.Rows.Add(row);

                string[] row2 = new string[] { Convert.ToString("Pre-Cooler1: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.PC11), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView4.Rows.Add(row2);

                string[] row21 = new string[] { Convert.ToString("Pre-Cooler2: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.PC21), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView4.Rows.Add(row21);

                string[] row3 = new string[] { Convert.ToString("Net Total Heat Input: "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.PHX), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView2.Rows.Add(row3);

                string[] row4 = new string[] { Convert.ToString("Gross Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)), "kWth" };
                dataGridView2.Rows.Add(row4);

                string[] row5 = new string[] { Convert.ToString("Gross Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_12.Generator_Power_Output) / (Punterociclo_12.PHX)) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView2.Rows.Add(row5);

                //Power Generated in Turbomachines
                Double Main_Turbine_Power = 0;
                Double Compressor1_Power = 0;
                Double Compressor2_Power = 0;
                Double Compressor3_Power = 0;
                Double Total_Turbomachines_Power = 0;

                //Turbines Power
                string[] row6 = new string[] { Convert.ToString("Main Turbine : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_main_turbine * Punterociclo_12.massflow2), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row6);
                Main_Turbine_Power = specific_work_main_turbine * Punterociclo_12.massflow2;

                //Compressors Power
                string[] row8 = new string[] { Convert.ToString("Main Compressor : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_compressor1 * Punterociclo_12.massflow2 * (1 - Punterociclo_12.recomp_frac2)), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row8);
                Compressor1_Power = specific_work_compressor1 * Punterociclo_12.massflow2 * (1 - Punterociclo_12.recomp_frac2);

                string[] row9 = new string[] { Convert.ToString("ReCompressor : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_compressor2 * Punterociclo_12.massflow2 * Punterociclo_12.recomp_frac2), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row9);
                Compressor2_Power = specific_work_compressor2 * Punterociclo_12.massflow2 * Punterociclo_12.recomp_frac2;

                string[] row91 = new string[] { Convert.ToString("Compressor 2 : "), Convert.ToString(decimal.Round(Convert.ToDecimal(specific_work_compressor3 * Punterociclo_12.massflow2 * (1 - Punterociclo_12.recomp_frac2)), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row91);
                Compressor3_Power = specific_work_compressor3 * Punterociclo_12.massflow2 * (1 - Punterociclo_12.recomp_frac2);

                Total_Turbomachines_Power = Main_Turbine_Power + Compressor1_Power + Compressor2_Power + Compressor3_Power;

                string[] row10 = new string[] { Convert.ToString("Total TurboMachines Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row10);

                string[] row11 = new string[] { Convert.ToString("Generator Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_12.Rating_Point_Efficiency / 100) * Punterociclo_12.Gear_Efficiency) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView1.Rows.Add(row11);

                string[] row12 = new string[] { Convert.ToString("Generator Output Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_12.Rating_Point_Efficiency / 100) * Punterociclo_12.Gear_Efficiency) * Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row12);

                //Solar Field Pumps Electrical Consumption
                string[] row13 = new string[] { Convert.ToString("Main SF Pump Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row13);

                textBox15.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Main_SF_Pump_Electrical_Consumption), 2, MidpointRounding.AwayFromZero));

                Punterociclo_12.UHS_Water_Pump = Convert.ToDouble(textBox11.Text);
                string[] row15 = new string[] { Convert.ToString("UHS Water Pump Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row15);

                Punterociclo_12.Miscellanous_Auxiliaries = Convert.ToDouble(textBox13.Text);
                textBox3.Text = Convert.ToString(Punterociclo_12.Generator_Power_Output * (Punterociclo_12.Miscellanous_Auxiliaries / 100));
                string[] row16 = new string[] { Convert.ToString("Miscellanous_Auxiliaries : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Power_Output * (Punterociclo_12.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row16);

                textBox14.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.ReHeating_SF_Pump_Electrical_Consumption), 2, MidpointRounding.AwayFromZero));

                Punterociclo_12.ACHE_fans = Convert.ToDouble(textBox2.Text);

                Punterociclo_12.Miscellanous_Auxiliaries = Convert.ToDouble(textBox13.Text);
                string[] row17 = new string[] { Convert.ToString("ACHE Fans Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.ACHE_fans), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row17);

                Punterociclo_12.Total_Auxiliaries = Punterociclo_12.ACHE_fans + Punterociclo_12.Main_SF_Pump_Electrical_Consumption + Punterociclo_12.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_12.Generator_Power_Output * (Punterociclo_12.Miscellanous_Auxiliaries / 100));
                textBox1.Text = Convert.ToString(Punterociclo_12.Total_Auxiliaries);

                string[] row18 = new string[] { Convert.ToString("Total_Auxiliaries Power : "), Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView3.Rows.Add(row18);

                string[] row20 = new string[] { Convert.ToString("Net Power Output : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_12.Rating_Point_Efficiency / 100) * Punterociclo_12.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_12.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView2.Rows.Add(row20);

                string[] row19 = new string[] { Convert.ToString("Net Power Output : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_12.Rating_Point_Efficiency / 100) * Punterociclo_12.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_12.Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)), "kW" };
                dataGridView1.Rows.Add(row19);

                string[] row25 = new string[] { Convert.ToString("Net Efficiency : "), Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_12.Rating_Point_Efficiency / 100) * Punterociclo_12.Gear_Efficiency) * Total_Turbomachines_Power) - Punterociclo_12.Total_Auxiliaries) / (Punterociclo_12.PHX)) * 100), 4, MidpointRounding.AwayFromZero)), "%" };
                dataGridView2.Rows.Add(row25);
            }
        }
    }
}
