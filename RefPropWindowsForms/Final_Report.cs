﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RefPropWindowsForms
{
    public partial class Final_Report : Form
    {
        //Storing PTC_SF_Design dialog results in the Brayton dialog for Final Reporting or Cost Estimation
        public Double Brayton_cycle_type_variable;

        public Recompression_Brayton_Power_Cycle Punterociclo_2;
        public RC_without_ReHeating Punterociclo_4;      
        public PCRC Punterociclo_6;
        public PCRC_without_ReHeating Punterociclo_8;
        public RCMCI Punterociclo_10;
        public RCMCI_without_ReHeating Punterociclo_12;

        public Final_Report()
        {
            InitializeComponent();
        }

        // RC_Design_WithReHeating: Brayton_cycle_type_variable = 2
        public void Ciclo_RC_Design_withReHeating(Recompression_Brayton_Power_Cycle Punterociclo2, Double Brayton_cycle_type)
        {
            Brayton_cycle_type_variable = Brayton_cycle_type;
            Punterociclo_2 = Punterociclo2;
        }

        // RC_Design_WithoutReHeating: Brayton_cycle_type_variable = 4
        public void Ciclo_RC_Design_withoutReHeating(RC_without_ReHeating Punterociclo4, Double Brayton_cycle_type)
        {
            Brayton_cycle_type_variable = Brayton_cycle_type;
            Punterociclo_4 = Punterociclo4;
        }

        // PCRC_Design_WithReHeating: Brayton_cycle_type_variable = 6
        public void Ciclo_PCRC_Design_withReHeating(PCRC Punterociclo6, Double Brayton_cycle_type)
        {
            Brayton_cycle_type_variable = Brayton_cycle_type;
            Punterociclo_6 = Punterociclo6;
        }

        // PCRC_Design_WithoutReHeating: Brayton_cycle_type_variable = 8
        public void Ciclo_PCRC_Design_withoutReHeating(PCRC_without_ReHeating Punterociclo8, Double Brayton_cycle_type)
        {
            Brayton_cycle_type_variable = Brayton_cycle_type;
            Punterociclo_8 = Punterociclo8;
        }

        // PCRC_Design_WithReHeating: Brayton_cycle_type_variable = 10
        public void Ciclo_RCMCI_Design_withReHeating(RCMCI Punterociclo10, Double Brayton_cycle_type)
        {
            Brayton_cycle_type_variable = Brayton_cycle_type;
            Punterociclo_10 = Punterociclo10;
        }

        // PCRC_Design_WithoutReHeating: Brayton_cycle_type_variable = 12
        public void Ciclo_RCMCI_Design_withoutReHeating(RCMCI_without_ReHeating Punterociclo12, Double Brayton_cycle_type)
        {
            Brayton_cycle_type_variable = Brayton_cycle_type;
            Punterociclo_12 = Punterociclo12;
        }

        //OK Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Power Cycle Results
        private void button2_Click(object sender, EventArgs e)
        {
            if (Brayton_cycle_type_variable == 1)
            {
                
            }

            else if (Brayton_cycle_type_variable == 2)
            {
                textBox1.Clear();

                //Power Generated in Turbomachines
                Double Main_Turbine_Power = 0;
                Double ReHeating_Turbine_Power = 0;
                Double Compressor1_Power = 0;
                Double Compressor2_Power = 0;
                Double Total_Turbomachines_Power = 0;
                Double Total_Auxiliaries = 0;
                Main_Turbine_Power = Punterociclo_2.specific_work_main_turbine * Punterociclo_2.massflow2;
                ReHeating_Turbine_Power = Punterociclo_2.specific_work_reheating_turbine * Punterociclo_2.massflow2;
                Compressor1_Power = Punterociclo_2.specific_work_compressor1 * Punterociclo_2.massflow2 * (1 - Punterociclo_2.recomp_frac2);
                Compressor2_Power = Punterociclo_2.specific_work_compressor2 * Punterociclo_2.massflow2 * Punterociclo_2.recomp_frac2;
                Total_Turbomachines_Power = Main_Turbine_Power + ReHeating_Turbine_Power + Compressor1_Power + Compressor2_Power;
                Total_Auxiliaries = Punterociclo_2.ACHE_fans + Punterociclo_2.Main_SF_Pump_Electrical_Consumption + Punterociclo_2.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_2.Generator_Power_Output * (Punterociclo_2.Miscellanous_Auxiliaries / 100));

                textBox1.Text = "THERMOSOLAR POWER PLANT WITH LINE-FOCUSING SOLAR COLLECTORS AND A s-CO2 BRAYTON POWER CYCLE" +
                Environment.NewLine + "Main Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.PHX_Q2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReHeating Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.RHX_Q2))) +
                Environment.NewLine + "Pre-Cooler (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.PC_Q2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Total Heat Input (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.PHX_Q2 + Punterociclo_2.RHX_Q2), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main Turbine (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.specific_work_main_turbine * Punterociclo_2.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReHeating Turbine (kW) : " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.specific_work_reheating_turbine * Punterociclo_2.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Main Compressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.specific_work_compressor1 * Punterociclo_2.massflow2 * (1 - Punterociclo_2.recomp_frac2)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReCompressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.specific_work_compressor2 * Punterociclo_2.massflow2 * Punterociclo_2.recomp_frac2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total TurboMachines Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Gross Output Power (kWe): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Gross Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_2.Generator_Power_Output) / (Punterociclo_2.PHX_Q2 + Punterociclo_2.RHX_Q2)) * 100), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReHeating SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.ReHeating_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "UHS Water Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Miscellanous_Auxiliaries (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Power_Output * (Punterociclo_2.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ACHE Fans Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.ACHE_fans), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total_Auxiliaries Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Net Power Output (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_2.Rating_Point_Efficiency / 100) * Punterociclo_2.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_2.Rating_Point_Efficiency / 100) * Punterociclo_2.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries) / (Punterociclo_2.PHX_Q2 + Punterociclo_2.RHX_Q2)) * 100), 4, MidpointRounding.AwayFromZero));
            }

            else if (Brayton_cycle_type_variable == 3)
            {

            }

            else if (Brayton_cycle_type_variable == 4)
            {
                textBox1.Clear();

                //Power Generated in Turbomachines
                Double Main_Turbine_Power = 0;
                Double Compressor1_Power = 0;
                Double Compressor2_Power = 0;
                Double Total_Turbomachines_Power = 0;
                Double Total_Auxiliaries = 0;
                Main_Turbine_Power = Punterociclo_4.specific_work_main_turbine * Punterociclo_4.massflow2;
                Compressor1_Power = Punterociclo_4.specific_work_compressor1 * Punterociclo_4.massflow2 * (1 - Punterociclo_4.recomp_frac2);
                Compressor2_Power = Punterociclo_4.specific_work_compressor2 * Punterociclo_4.massflow2 * Punterociclo_4.recomp_frac2;
                Total_Turbomachines_Power = Main_Turbine_Power + Compressor1_Power + Compressor2_Power;
                Total_Auxiliaries = Punterociclo_4.ACHE_fans + Punterociclo_4.Main_SF_Pump_Electrical_Consumption + Punterociclo_4.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_4.Generator_Power_Output * (Punterociclo_4.Miscellanous_Auxiliaries / 100));

                textBox1.Text = "THERMOSOLAR POWER PLANT WITH LINE-FOCUSING SOLAR COLLECTORS AND A s-CO2 BRAYTON POWER CYCLE" +
                Environment.NewLine + "Main Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.PHX_Q2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Pre-Cooler (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.PC_Q2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Total Heat Input (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.PHX_Q2), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main Turbine (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.specific_work_main_turbine * Punterociclo_4.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Main Compressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.specific_work_compressor1 * Punterociclo_4.massflow2 * (1 - Punterociclo_4.recomp_frac2)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReCompressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.specific_work_compressor2 * Punterociclo_4.massflow2 * Punterociclo_4.recomp_frac2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total TurboMachines Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Gross Output Power (kWe): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Gross Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_4.Generator_Power_Output) / (Punterociclo_4.PHX_Q2)) * 100), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "UHS Water Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Miscellanous_Auxiliaries (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Power_Output * (Punterociclo_4.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ACHE Fans Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.ACHE_fans), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total_Auxiliaries Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Net Power Output (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_4.Rating_Point_Efficiency / 100) * Punterociclo_4.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_4.Rating_Point_Efficiency / 100) * Punterociclo_4.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries) / (Punterociclo_4.PHX_Q2)) * 100), 4, MidpointRounding.AwayFromZero));
            }

            else if (Brayton_cycle_type_variable == 15)
            {

            }

            else if (Brayton_cycle_type_variable == 5)
            {
                
            }

            else if (Brayton_cycle_type_variable == 6)
            {
                textBox1.Clear();

                //Power Generated in Turbomachines
                Double Main_Turbine_Power = 0;
                Double ReHeating_Turbine_Power = 0;
                Double Compressor1_Power = 0;
                Double Compressor2_Power = 0;
                Double Compressor3_Power = 0;
                Double Total_Turbomachines_Power = 0;
                Double Total_Auxiliaries = 0;
                Main_Turbine_Power = Punterociclo_6.specific_work_main_turbine * Punterociclo_6.massflow2;
                ReHeating_Turbine_Power = Punterociclo_6.specific_work_reheating_turbine * Punterociclo_6.massflow2;
                Compressor1_Power = Punterociclo_6.specific_work_compressor1 * Punterociclo_6.massflow2 * (1 - Punterociclo_6.recomp_frac2);
                Compressor2_Power = Punterociclo_6.specific_work_compressor2 * Punterociclo_6.massflow2 * (Punterociclo_6.recomp_frac2);
                Compressor3_Power = Punterociclo_6.specific_work_compressor3 * Punterociclo_6.massflow2;
                Total_Turbomachines_Power = Main_Turbine_Power + ReHeating_Turbine_Power + Compressor1_Power + Compressor2_Power + Compressor3_Power;
                Total_Auxiliaries = Punterociclo_6.ACHE_fans + Punterociclo_6.Main_SF_Pump_Electrical_Consumption + Punterociclo_6.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_6.Generator_Power_Output * (Punterociclo_6.Miscellanous_Auxiliaries / 100));

                textBox1.Text = "THERMOSOLAR POWER PLANT WITH LINE-FOCUSING SOLAR COLLECTORS AND A s-CO2 BRAYTON POWER CYCLE" +
                Environment.NewLine + "Main Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.PHX1), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Reheating Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.RHX1), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Pre-Cooler1 (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.PC1), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Pre-Cooler2 (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.COOLER1), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Total Heat Input (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.PHX1 + Punterociclo_6.RHX1), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main Turbine (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.specific_work_main_turbine * Punterociclo_6.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReHeating Turbine (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.specific_work_reheating_turbine * Punterociclo_6.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Main Compressor1 (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.specific_work_compressor1 * Punterociclo_6.massflow2 * (1 - Punterociclo_6.recomp_frac2)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "PreCompressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.specific_work_compressor3 * Punterociclo_6.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReCompressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.specific_work_compressor2 * Punterociclo_6.massflow2 * Punterociclo_6.recomp_frac2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total TurboMachines Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Gross Output Power (kWe): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Gross Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_6.Generator_Power_Output) / (Punterociclo_6.PHX1 + Punterociclo_6.RHX1)) * 100), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                 Environment.NewLine + "Reheating SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.ReHeating_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "UHS Water Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Miscellanous_Auxiliaries (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Power_Output * (Punterociclo_6.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ACHE Fans Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.ACHE_fans), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total_Auxiliaries Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Net Power Output (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_6.Rating_Point_Efficiency / 100) * Punterociclo_6.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_6.Rating_Point_Efficiency / 100) * Punterociclo_6.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries) / (Punterociclo_6.PHX1 + Punterociclo_6.RHX1)) * 100), 4, MidpointRounding.AwayFromZero));
            }

            else if (Brayton_cycle_type_variable == 7)
            {
                
            }

            else if (Brayton_cycle_type_variable == 8)
            {
                textBox1.Clear();

                //Power Generated in Turbomachines
                Double Main_Turbine_Power = 0;
                Double Compressor1_Power = 0;
                Double Compressor2_Power = 0;
                Double Compressor3_Power = 0;
                Double Total_Turbomachines_Power = 0;
                Double Total_Auxiliaries = 0;
                Main_Turbine_Power = Punterociclo_8.specific_work_main_turbine * Punterociclo_8.massflow2;
                Compressor1_Power = Punterociclo_8.specific_work_compressor1 * Punterociclo_8.massflow2 * (1 - Punterociclo_8.recomp_frac2);
                Compressor2_Power = Punterociclo_8.specific_work_compressor2 * Punterociclo_8.massflow2 * (Punterociclo_8.recomp_frac2);
                Compressor3_Power = Punterociclo_8.specific_work_compressor3 * Punterociclo_8.massflow2;
                Total_Turbomachines_Power = Main_Turbine_Power + Compressor1_Power + Compressor2_Power + Compressor3_Power;
                Total_Auxiliaries = Punterociclo_8.ACHE_fans + Punterociclo_8.Main_SF_Pump_Electrical_Consumption + Punterociclo_8.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_8.Generator_Power_Output * (Punterociclo_8.Miscellanous_Auxiliaries / 100));

                textBox1.Text = "THERMOSOLAR POWER PLANT WITH LINE-FOCUSING SOLAR COLLECTORS AND A s-CO2 BRAYTON POWER CYCLE" +
                Environment.NewLine + "Main Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.PHX1), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Pre-Cooler1 (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.PC11), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Pre-Cooler2 (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.PC21), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Total Heat Input (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.PHX1), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main Turbine (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.specific_work_main_turbine * Punterociclo_8.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Main Compressor1 (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.specific_work_compressor1 * Punterociclo_8.massflow2 * (1 - Punterociclo_8.recomp_frac2)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "PreCompressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.specific_work_compressor3 * Punterociclo_8.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReCompressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.specific_work_compressor2 * Punterociclo_8.massflow2 * Punterociclo_8.recomp_frac2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total TurboMachines Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Gross Output Power (kWe): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Gross Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_8.Generator_Power_Output) / (Punterociclo_8.PHX1)) * 100), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "UHS Water Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Miscellanous_Auxiliaries (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Power_Output * (Punterociclo_8.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ACHE Fans Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.ACHE_fans), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total_Auxiliaries Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Net Power Output (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_8.Rating_Point_Efficiency / 100) * Punterociclo_8.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_8.Rating_Point_Efficiency / 100) * Punterociclo_8.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries) / (Punterociclo_8.PHX1)) * 100), 4, MidpointRounding.AwayFromZero));
            }

            else if (Brayton_cycle_type_variable == 9)
            {
               
            }

            else if (Brayton_cycle_type_variable == 10)
            {
                textBox1.Clear();

                //Power Generated in Turbomachines
                Double Main_Turbine_Power = 0;
                Double ReHeating_Turbine_Power = 0;
                Double Compressor1_Power = 0;
                Double Compressor2_Power = 0;
                Double Compressor3_Power = 0;
                Double Total_Turbomachines_Power = 0;
                Double Total_Auxiliaries = 0;
                Main_Turbine_Power = Punterociclo_10.specific_work_main_turbine * Punterociclo_10.massflow2;
                ReHeating_Turbine_Power = Punterociclo_10.specific_work_reheating_turbine * Punterociclo_10.massflow2;
                Compressor1_Power = Punterociclo_10.specific_work_compressor1 * Punterociclo_10.massflow2 * (1 - Punterociclo_10.recomp_frac2);
                Compressor2_Power = Punterociclo_10.specific_work_compressor3 * Punterociclo_10.massflow2 * (1 - Punterociclo_10.recomp_frac2);
                Compressor3_Power = Punterociclo_10.specific_work_compressor2 * Punterociclo_10.massflow2 * Punterociclo_10.recomp_frac2;
                Total_Turbomachines_Power = Main_Turbine_Power + ReHeating_Turbine_Power + Compressor1_Power + Compressor2_Power + Compressor3_Power;
                Total_Auxiliaries = Punterociclo_10.ACHE_fans + Punterociclo_10.Main_SF_Pump_Electrical_Consumption + Punterociclo_10.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_10.Generator_Power_Output * (Punterociclo_10.Miscellanous_Auxiliaries / 100));

                textBox1.Text = "THERMOSOLAR POWER PLANT WITH LINE-FOCUSING SOLAR COLLECTORS AND A s-CO2 BRAYTON POWER CYCLE" +
                Environment.NewLine + "Main Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.PHX1), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Reheating Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.RHX1), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Pre-Cooler1 (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.PC11), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Pre-Cooler2 (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.PC21), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Total Heat Input (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.PHX1 + Punterociclo_10.RHX1), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main Turbine (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.specific_work_main_turbine * Punterociclo_10.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReHeating Turbine (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.specific_work_reheating_turbine * Punterociclo_10.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Main Compressor1 (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.specific_work_compressor1 * Punterociclo_10.massflow2 * (1 - Punterociclo_10.recomp_frac2)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Main Compressor2 (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.specific_work_compressor3 * Punterociclo_10.massflow2 * (1 - Punterociclo_10.recomp_frac2)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReCompressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.specific_work_compressor2 * Punterociclo_10.massflow2 * Punterociclo_10.recomp_frac2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total TurboMachines Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Gross Output Power (kWe): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Gross Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_10.Generator_Power_Output) / (Punterociclo_10.PHX1 + Punterociclo_10.RHX1)) * 100), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                 Environment.NewLine + "Reheating SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.ReHeating_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "UHS Water Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Miscellanous_Auxiliaries (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Power_Output * (Punterociclo_10.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ACHE Fans Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.ACHE_fans), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total_Auxiliaries Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Net Power Output (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_10.Rating_Point_Efficiency / 100) * Punterociclo_10.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_10.Rating_Point_Efficiency / 100) * Punterociclo_10.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries) / (Punterociclo_10.PHX1 + Punterociclo_10.RHX1)) * 100), 4, MidpointRounding.AwayFromZero));
            }

            else if (Brayton_cycle_type_variable == 11)
            {

            }

            else if (Brayton_cycle_type_variable == 12)
            {
                textBox1.Clear();

                //Power Generated in Turbomachines
                Double Main_Turbine_Power = 0;
                Double Compressor1_Power = 0;
                Double Compressor2_Power = 0;
                Double Compressor3_Power = 0;
                Double Total_Turbomachines_Power = 0;
                Double Total_Auxiliaries = 0;
                Main_Turbine_Power = Punterociclo_12.specific_work_main_turbine * Punterociclo_12.massflow2;
                Compressor1_Power = Punterociclo_12.specific_work_compressor1 * Punterociclo_12.massflow2 * (1 - Punterociclo_12.recomp_frac2);
                Compressor2_Power = Punterociclo_12.specific_work_compressor3 * Punterociclo_12.massflow2 * (1 - Punterociclo_12.recomp_frac2);
                Compressor3_Power = Punterociclo_12.specific_work_compressor2 * Punterociclo_12.massflow2 * Punterociclo_12.recomp_frac2;
                Total_Turbomachines_Power = Main_Turbine_Power + Compressor1_Power + Compressor2_Power + Compressor3_Power;
                Total_Auxiliaries = Punterociclo_12.ACHE_fans + Punterociclo_12.Main_SF_Pump_Electrical_Consumption + Punterociclo_12.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_12.Generator_Power_Output * (Punterociclo_12.Miscellanous_Auxiliaries / 100));

                textBox1.Text = "THERMOSOLAR POWER PLANT WITH LINE-FOCUSING SOLAR COLLECTORS AND A s-CO2 BRAYTON POWER CYCLE" +
                Environment.NewLine + "Main Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.PHX), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Pre-Cooler1 (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.PC11), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Pre-Cooler2 (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.PC21), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Total Heat Input (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.PHX), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main Turbine (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.specific_work_main_turbine * Punterociclo_12.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Main Compressor1 (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.specific_work_compressor1 * Punterociclo_12.massflow2 * (1 - Punterociclo_12.recomp_frac2)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Main Compressor2 (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.specific_work_compressor3 * Punterociclo_12.massflow2 * (1 - Punterociclo_12.recomp_frac2)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReCompressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.specific_work_compressor2 * Punterociclo_12.massflow2 * Punterociclo_12.recomp_frac2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total TurboMachines Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Gross Output Power (kWe): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Gross Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_12.Generator_Power_Output) / (Punterociclo_12.PHX)) * 100), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "UHS Water Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Miscellanous_Auxiliaries (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Power_Output * (Punterociclo_12.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ACHE Fans Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.ACHE_fans), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total_Auxiliaries Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Net Power Output (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_12.Rating_Point_Efficiency / 100) * Punterociclo_12.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_12.Rating_Point_Efficiency / 100) * Punterociclo_12.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries) / (Punterociclo_12.PHX)) * 100), 4, MidpointRounding.AwayFromZero));
            }
        }

        //Low Temperatura Recuperator (LTR) and High Temperature Recuperator (HTR) Results Report
        private void button5_Click(object sender, EventArgs e)
        {
            if (Brayton_cycle_type_variable == 1)
            {
               
            }

            else if (Brayton_cycle_type_variable == 2)
            {
                textBox1.Clear();

                textBox1.Text = "LOW TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_2.LTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_2.LTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_2.LTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_2.LTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_2.LTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_2.LTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_2.LTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_2.LTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_2.LTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_2.LTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_2.LTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_2.LTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_2.LTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_2.LTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_2.LTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_2.LTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_2.LTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_2.LTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_2.LTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_2.LTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_2.LTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_2.LTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_2.LTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_2.LTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "HIGH TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_2.HTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_2.HTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_2.HTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_2.HTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_2.HTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_2.HTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_2.HTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_2.HTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_2.HTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_2.HTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_2.HTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_2.HTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_2.HTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_2.HTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_2.HTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_2.HTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_2.HTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_2.HTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_2.HTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_2.HTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_2.HTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_2.HTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_2.HTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_2.HTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "PRECOOLER HEAT EXCHANGER Detail Design:" +
                Environment.NewLine + "PC_Q_dot:" + Convert.ToString(Punterociclo_2.PC_Q2) +
                Environment.NewLine + "" + Environment.NewLine;
            }

            else if (Brayton_cycle_type_variable == 3)
            {

            }

            else if (Brayton_cycle_type_variable == 4)
            {
                textBox1.Clear();

                textBox1.Text = "LOW TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_4.LTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_4.LTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_4.LTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_4.LTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_4.LTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_4.LTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_4.LTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_4.LTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_4.LTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_4.LTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_4.LTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_4.LTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_4.LTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_4.LTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_4.LTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_4.LTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_4.LTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_4.LTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_4.LTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_4.LTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_4.LTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_4.LTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_4.LTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_4.LTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "HIGH TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_4.HTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_4.HTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_4.HTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_4.HTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_4.HTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_4.HTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_4.HTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_4.HTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_4.HTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_4.HTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_4.HTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_4.HTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_4.HTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_4.HTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_4.HTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_4.HTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_4.HTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_4.HTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_4.HTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_4.HTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_4.HTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_4.HTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_4.HTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_4.HTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "PRECOOLER HEAT EXCHANGER Detail Design:" +
                Environment.NewLine + "PC_Q_dot:" + Convert.ToString(Punterociclo_4.PC_Q2) +
                Environment.NewLine + "" + Environment.NewLine;
            }

            else if (Brayton_cycle_type_variable == 15)
            {

            }


            else if (Brayton_cycle_type_variable == 5)
            {
               
            }

            else if (Brayton_cycle_type_variable == 6)
            {
                textBox1.Clear();

                textBox1.Text = "LOW TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_6.LTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_6.LTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_6.LTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_6.LTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_6.LTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_6.LTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_6.LTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_6.LTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_6.LTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_6.LTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_6.LTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_6.LTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_6.LTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_6.LTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_6.LTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_6.LTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_6.LTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_6.LTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_6.LTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_6.LTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_6.LTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_6.LTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_6.LTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_6.LTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "HIGH TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_6.HTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_6.HTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_6.HTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_6.HTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_6.HTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_6.HTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_6.HTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_6.HTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_6.HTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_6.HTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_6.HTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_6.HTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_6.HTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_6.HTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_6.HTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_6.HTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_6.HTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_6.HTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_6.HTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_6.HTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_6.HTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_6.HTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_6.HTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_6.HTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "PRECOOLER HEAT EXCHANGER Detail Design:" +
                Environment.NewLine + "PC1_Q_dot:" + Convert.ToString(Punterociclo_6.PC1) +
                Environment.NewLine + "PC2_Q_dot:" + Convert.ToString(Punterociclo_6.COOLER1) +
                Environment.NewLine + "" + Environment.NewLine;
            }

            else if (Brayton_cycle_type_variable == 7)
            {
               
            }

            else if (Brayton_cycle_type_variable == 8)
            {
                textBox1.Clear();

                textBox1.Text = "LOW TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_8.LTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_8.LTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_8.LTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_8.LTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_8.LTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_8.LTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_8.LTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_8.LTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_8.LTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_8.LTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_8.LTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_8.LTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_8.LTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_8.LTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_8.LTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_8.LTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_8.LTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_8.LTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_8.LTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_8.LTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_8.LTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_8.LTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_8.LTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_8.LTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "HIGH TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_8.HTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_8.HTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_8.HTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_8.HTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_8.HTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_8.HTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_8.HTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_8.HTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_8.HTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_8.HTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_8.HTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_8.HTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_8.HTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_8.HTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_8.HTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_8.HTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_8.HTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_8.HTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_8.HTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_8.HTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_8.HTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_8.HTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_8.HTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_8.HTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "PRECOOLER HEAT EXCHANGER Detail Design:" +
                Environment.NewLine + "PC1_Q_dot:" + Convert.ToString(Punterociclo_8.PC11) +
                Environment.NewLine + "PC2_Q_dot:" + Convert.ToString(Punterociclo_8.PC21) +
                Environment.NewLine + "" + Environment.NewLine;
            }

            else if (Brayton_cycle_type_variable == 9)
            {
                
            }

            else if (Brayton_cycle_type_variable == 10)
            {
                textBox1.Clear();

                textBox1.Text = "LOW TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_10.LTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_10.LTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_10.LTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_10.LTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_10.LTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_10.LTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_10.LTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_10.LTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_10.LTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_10.LTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_10.LTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_10.LTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_10.LTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_10.LTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_10.LTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_10.LTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_10.LTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_10.LTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_10.LTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_10.LTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_10.LTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_10.LTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_10.LTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_10.LTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "HIGH TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_10.HTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_10.HTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_10.HTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_10.HTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_10.HTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_10.HTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_10.HTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_10.HTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_10.HTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_10.HTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_10.HTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_10.HTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_10.HTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_10.HTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_10.HTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_10.HTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_10.HTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_10.HTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_10.HTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_10.HTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_10.HTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_10.HTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_10.HTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_10.HTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "PRECOOLER HEAT EXCHANGER Detail Design:" +
                Environment.NewLine + "PC1_Q_dot:" + Convert.ToString(Punterociclo_10.PC11) +
                 Environment.NewLine + "PC2_Q_dot:" + Convert.ToString(Punterociclo_10.PC21) +
                Environment.NewLine + "" + Environment.NewLine;
            }

            else if (Brayton_cycle_type_variable == 11)
            {
               
            }

            else if (Brayton_cycle_type_variable == 12)
            {
                textBox1.Clear();

                textBox1.Text = "LOW TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_12.LTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_12.LTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_12.LTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_12.LTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_12.LTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_12.LTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_12.LTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_12.LTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_12.LTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_12.LTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_12.LTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_12.LTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_12.LTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_12.LTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_12.LTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_12.LTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_12.LTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_12.LTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_12.LTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_12.LTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_12.LTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_12.LTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_12.LTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_12.LTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "HIGH TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_12.HTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_12.HTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_12.HTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_12.HTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_12.HTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_12.HTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_12.HTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_12.HTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_12.HTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_12.HTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_12.HTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_12.HTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_12.HTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_12.HTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_12.HTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_12.HTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_12.HTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_12.HTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_12.HTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_12.HTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_12.HTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_12.HTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_12.HTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_12.HTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "PRECOOLER HEAT EXCHANGER Detail Design:" +
                Environment.NewLine + "PC1_Q_dot:" + Convert.ToString(Punterociclo_12.PC11) +
                Environment.NewLine + "PC2_Q_dot:" + Convert.ToString(Punterociclo_12.PC21) +
                Environment.NewLine + "" + Environment.NewLine;
            }
        }

        //Compressors Results
        private void button3_Click(object sender, EventArgs e)
        {
            if (Brayton_cycle_type_variable == 1)
            {

            
            }

            else if (Brayton_cycle_type_variable == 2)
            {

                textBox1.Clear();

                textBox1.Text = "MAIN COMPRESSOR:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_2.Main_Compressor_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_2.Main_Compressor_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_2.Main_Compressor_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_2.Main_Compressor_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_2.Main_Compressor_Flow) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_2.Main_Compressor_Diameter) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_2.Main_Compressor_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_2.Main_Compressor_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_2.Main_Compressor_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_2.Main_Compressor_Surge) +

                    Environment.NewLine + Environment.NewLine + "RECOMPRESSOR:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_2.ReCompressor_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_2.ReCompressor_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_2.ReCompressor_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_2.ReCompressor_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_2.ReCompressor_Flow) +
                    Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_2.ReCompressor_Diameter1) +
                    Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_2.ReCompressor_Diameter2) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_2.ReCompressor_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_2.ReCompressor_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_2.ReCompressor_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_2.ReCompressor_Surge);
            }

            else if (Brayton_cycle_type_variable == 3)
            {

            }

            else if (Brayton_cycle_type_variable == 4)
            {

                textBox1.Clear();

                textBox1.Text = "MAIN COMPRESSOR:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_4.Main_Compressor_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_4.Main_Compressor_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_4.Main_Compressor_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_4.Main_Compressor_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_4.Main_Compressor_Flow) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_4.Main_Compressor_Diameter) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_4.Main_Compressor_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_4.Main_Compressor_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_4.Main_Compressor_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_4.Main_Compressor_Surge) +

                    Environment.NewLine + Environment.NewLine + "RECOMPRESSOR:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_4.ReCompressor_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_4.ReCompressor_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_4.ReCompressor_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_4.ReCompressor_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_4.ReCompressor_Flow) +
                    Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_4.ReCompressor_Diameter1) +
                    Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_4.ReCompressor_Diameter2) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_4.ReCompressor_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_4.ReCompressor_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_4.ReCompressor_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_4.ReCompressor_Surge);
            }

            else if (Brayton_cycle_type_variable == 15)
            {

            }

            else if (Brayton_cycle_type_variable == 5)
            {
               
            }

            else if (Brayton_cycle_type_variable == 6)
            {

                textBox1.Clear();

                textBox1.Text = "PRE-COMPRESSOR:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Flow) +
                    Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Diameter1) +
                    Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Diameter2) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Surge) +

                    Environment.NewLine + Environment.NewLine + "MAIN COMPRESSOR:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_6.Main_Compressor_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_6.Main_Compressor_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_6.Main_Compressor_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_6.Main_Compressor_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_6.Main_Compressor_Flow) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_6.Main_Compressor_Diameter) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_6.Main_Compressor_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_6.Main_Compressor_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_6.Main_Compressor_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_6.Main_Compressor_Surge) +

                    Environment.NewLine + Environment.NewLine + "RECOMPRESSOR:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_6.ReCompressor_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_6.ReCompressor_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_6.ReCompressor_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_6.ReCompressor_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_6.ReCompressor_Flow) +
                    Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_6.ReCompressor_Diameter1) +
                    Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_6.ReCompressor_Diameter2) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_6.ReCompressor_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_6.ReCompressor_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_6.ReCompressor_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_6.ReCompressor_Surge);
            }

            else if (Brayton_cycle_type_variable == 7)
            {

            }

            else if (Brayton_cycle_type_variable == 8)
            {

                textBox1.Clear();

                textBox1.Text = "PRE-COMPRESSOR:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Flow) +
                    Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Diameter1) +
                    Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Diameter2) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Surge) +

                    Environment.NewLine + Environment.NewLine + "MAIN COMPRESSOR:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_8.Main_Compressor_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_8.Main_Compressor_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_8.Main_Compressor_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_8.Main_Compressor_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_8.Main_Compressor_Flow) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_8.Main_Compressor_Diameter) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_8.Main_Compressor_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_8.Main_Compressor_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_8.Main_Compressor_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_8.Main_Compressor_Surge) +

                    Environment.NewLine + Environment.NewLine + "RECOMPRESSOR:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_8.ReCompressor_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_8.ReCompressor_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_8.ReCompressor_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_8.ReCompressor_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_8.ReCompressor_Flow) +
                    Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_8.ReCompressor_Diameter1) +
                    Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_8.ReCompressor_Diameter2) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_8.ReCompressor_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_8.ReCompressor_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_8.ReCompressor_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_8.ReCompressor_Surge);
            }

            else if (Brayton_cycle_type_variable == 9)
            {

            }

            else if (Brayton_cycle_type_variable == 10)
            {

                textBox1.Clear();

                textBox1.Text = "MAIN COMPRESSOR1:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Flow) +
                    Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Diameter1) +
                    Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Diameter2) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_10.Main_Compressor1_Surge) +

                    Environment.NewLine + Environment.NewLine + "MAIN COMPRESSOR2:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_10.Main_Compressor_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_10.Main_Compressor_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_10.Main_Compressor_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_10.Main_Compressor_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_10.Main_Compressor_Flow) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_10.Main_Compressor_Diameter) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_10.Main_Compressor_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_10.Main_Compressor_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_10.Main_Compressor_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_10.Main_Compressor_Surge) +

                    Environment.NewLine + Environment.NewLine + "RECOMPRESSOR:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_10.ReCompressor_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_10.ReCompressor_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_10.ReCompressor_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_10.ReCompressor_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_10.ReCompressor_Flow) +
                    Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_10.ReCompressor_Diameter1) +
                    Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_10.ReCompressor_Diameter2) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_10.ReCompressor_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_10.ReCompressor_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_10.ReCompressor_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_10.ReCompressor_Surge);
            }

            else if (Brayton_cycle_type_variable == 11)
            {

               
            }

            else if (Brayton_cycle_type_variable == 12)
            {

                textBox1.Clear();

                textBox1.Text = "MAIN COMPRESSOR1:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Flow) +
                    Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Diameter1) +
                    Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Diameter2) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_12.Main_Compressor1_Surge) +

                    Environment.NewLine + Environment.NewLine + "MAIN COMPRESSOR2:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_12.Main_Compressor_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_12.Main_Compressor_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_12.Main_Compressor_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_12.Main_Compressor_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_12.Main_Compressor_Flow) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_12.Main_Compressor_Diameter) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_12.Main_Compressor_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_12.Main_Compressor_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_12.Main_Compressor_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_12.Main_Compressor_Surge) +

                    Environment.NewLine + Environment.NewLine + "RECOMPRESSOR:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_12.ReCompressor_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_12.ReCompressor_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_12.ReCompressor_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_12.ReCompressor_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_12.ReCompressor_Flow) +
                    Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_12.ReCompressor_Diameter1) +
                    Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_12.ReCompressor_Diameter2) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_12.ReCompressor_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_12.ReCompressor_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_12.ReCompressor_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_12.ReCompressor_Surge);
            }
        }

        //Turbines Results
        private void button4_Click(object sender, EventArgs e)
        {
            if (Brayton_cycle_type_variable == 1)
            {
               
            }

            else if (Brayton_cycle_type_variable == 2)
            {
                textBox1.Clear();

                textBox1.Text = "MAIN_TURBINE:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_2.Main_Turbine_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_2.Main_Turbine_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_2.Main_Turbine_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_2.Main_Turbine_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_2.Main_Turbine_Flow) +
                    Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_2.Main_Turbine_Rotary_Velocity) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_2.Main_Turbine_Diameter) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_2.Main_Turbine_Efficiency) +
                    Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_2.Main_Turbine_Anozzle) +
                    Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_2.Main_Turbine_nu) +
                    Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_2.Main_Turbine_w_Tip_Ratio) +

                    Environment.NewLine + Environment.NewLine + "REHEATING_TURBINE:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Flow) +
                    Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Rotary_Velocity) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Diameter) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Efficiency) +
                    Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Anozzle) +
                    Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_nu) +
                    Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_w_Tip_Ratio);
            }

            else if (Brayton_cycle_type_variable == 3)
            {

            }

            else if (Brayton_cycle_type_variable == 4)
            {
                textBox1.Clear();

                textBox1.Text = "MAIN_TURBINE:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_4.Main_Turbine_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_4.Main_Turbine_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_4.Main_Turbine_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_4.Main_Turbine_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_4.Main_Turbine_Flow) +
                    Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_4.Main_Turbine_Rotary_Velocity) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_4.Main_Turbine_Diameter) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_4.Main_Turbine_Efficiency) +
                    Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_4.Main_Turbine_Anozzle) +
                    Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_4.Main_Turbine_nu) +
                    Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_4.Main_Turbine_w_Tip_Ratio);
            }

            else if (Brayton_cycle_type_variable == 15)
            {

            }

            else if (Brayton_cycle_type_variable == 5)
            {
                
            }

            else if (Brayton_cycle_type_variable == 6)
            {
                textBox1.Clear();

                textBox1.Text = "MAIN_TURBINE:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_6.Main_Turbine_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_6.Main_Turbine_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_6.Main_Turbine_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_6.Main_Turbine_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_6.Main_Turbine_Flow) +
                    Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_6.Main_Turbine_Rotary_Velocity) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_6.Main_Turbine_Diameter) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_6.Main_Turbine_Efficiency) +
                    Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_6.Main_Turbine_Anozzle) +
                    Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_6.Main_Turbine_nu) +
                    Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_6.Main_Turbine_w_Tip_Ratio) +

                    Environment.NewLine + Environment.NewLine + "REHEATING_TURBINE:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Flow) +
                    Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Rotary_Velocity) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Diameter) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Efficiency) +
                    Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Anozzle) +
                    Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_nu) +
                    Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_w_Tip_Ratio);
            }

            else if (Brayton_cycle_type_variable == 7)
            {
               
            }

            else if (Brayton_cycle_type_variable == 8)
            {
                textBox1.Clear();

                textBox1.Text = "MAIN_TURBINE:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_8.Main_Turbine_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_8.Main_Turbine_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_8.Main_Turbine_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_8.Main_Turbine_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_8.Main_Turbine_Flow) +
                    Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_8.Main_Turbine_Rotary_Velocity) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_8.Main_Turbine_Diameter) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_8.Main_Turbine_Efficiency) +
                    Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_8.Main_Turbine_Anozzle) +
                    Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_8.Main_Turbine_nu) +
                    Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_8.Main_Turbine_w_Tip_Ratio);
            }

            else if (Brayton_cycle_type_variable == 9)
            {
               
            }

            else if (Brayton_cycle_type_variable == 10)
            {
                textBox1.Clear();

                textBox1.Text = "MAIN_TURBINE:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_10.Main_Turbine_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_10.Main_Turbine_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_10.Main_Turbine_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_10.Main_Turbine_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_10.Main_Turbine_Flow) +
                    Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_10.Main_Turbine_Rotary_Velocity) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_10.Main_Turbine_Diameter) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_10.Main_Turbine_Efficiency) +
                    Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_10.Main_Turbine_Anozzle) +
                    Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_10.Main_Turbine_nu) +
                    Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_10.Main_Turbine_w_Tip_Ratio) +

                    Environment.NewLine + Environment.NewLine + "REHEATING_TURBINE:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Flow) +
                    Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Rotary_Velocity) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Diameter) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Efficiency) +
                    Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Anozzle) +
                    Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_nu) +
                    Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_w_Tip_Ratio);
            }

            else if (Brayton_cycle_type_variable == 11)
            {
              
            }

            else if (Brayton_cycle_type_variable == 12)
            {
                textBox1.Clear();

                textBox1.Text = "MAIN_TURBINE:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_12.Main_Turbine_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_12.Main_Turbine_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_12.Main_Turbine_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_12.Main_Turbine_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_12.Main_Turbine_Flow) +
                    Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_12.Main_Turbine_Rotary_Velocity) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_12.Main_Turbine_Diameter) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_12.Main_Turbine_Efficiency) +
                    Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_12.Main_Turbine_Anozzle) +
                    Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_12.Main_Turbine_nu) +
                    Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_12.Main_Turbine_w_Tip_Ratio);
            }
        }

        //Export Report To Excel
        private void button8_Click(object sender, EventArgs e)
        {

        }

        //Export Report To Word
        private void button9_Click(object sender, EventArgs e)
        {

        }

        //Solar Field resuls
        private void button6_Click(object sender, EventArgs e)
        {
            if (Brayton_cycle_type_variable == 1)
            {

               
            }

            else if (Brayton_cycle_type_variable == 2)
            {
                if (Punterociclo_2.Collector_Type_Main_SF == "Parabolic")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_2.PTC_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.PTC_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.PTC_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.PTC_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_2.PTC_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_2.PTC_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_2.PTC_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_2.PTC_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_2.PTC_Main_calculated_Row_length);
                }

                else if (Punterociclo_2.Collector_Type_Main_SF == "Fresnel")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_2.LF_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.LF_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.LF_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.LF_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_2.LF_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_2.LF_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_2.LF_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_2.LF_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_2.LF_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_2.LF_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_2.LF_Main_calculated_Row_length);
                }

                if (Punterociclo_2.Collector_Type_ReHeating_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHETAING_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_calculated_Row_length));
                }

                else if (Punterociclo_2.Collector_Type_ReHeating_SF == "Fresnel")
                {
                   textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHETAING_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_2.LF_ReHeating_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.LF_ReHeating_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.LF_ReHeating_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.LF_ReHeating_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_2.LF_ReHeating_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_2.LF_ReHeating_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_2.LF_ReHeating_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_2.LF_ReHeating_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_2.LF_ReHeating_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_2.LF_ReHeating_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_2.LF_ReHeating_calculated_Row_length));
                }
            }

            else if (Brayton_cycle_type_variable == 3)
            {

            }

            else if (Brayton_cycle_type_variable == 4)
            {
                if (Punterociclo_4.Collector_Type_Main_SF == "Parabolic")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_4.PTC_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_4.PTC_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_4.PTC_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_4.PTC_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_4.PTC_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_4.PTC_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_4.PTC_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_4.PTC_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_4.PTC_Main_calculated_Row_length);
                }

                else if (Punterociclo_4.Collector_Type_Main_SF == "Fresnel")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_4.LF_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_4.LF_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_4.LF_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_4.LF_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_4.LF_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_4.LF_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_4.LF_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_4.LF_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_4.LF_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_4.LF_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_4.LF_Main_calculated_Row_length);
                }
            }

            else if (Brayton_cycle_type_variable == 15)
            {
   
            }

            else if (Brayton_cycle_type_variable == 5)
            {

                
            }

            else if (Brayton_cycle_type_variable == 6)
            {

                if (Punterociclo_6.Collector_Type_Main_SF == "Parabolic")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_6.PTC_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.PTC_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.PTC_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.PTC_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_6.PTC_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_6.PTC_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_6.PTC_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_6.PTC_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_6.PTC_Main_calculated_Row_length);
                }

                else if (Punterociclo_6.Collector_Type_Main_SF == "Fresnel")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_6.LF_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.LF_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.LF_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.LF_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_6.LF_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_6.LF_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_6.LF_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_6.LF_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_6.LF_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_6.LF_Main_calculated_Row_length);
                }

                if (Punterociclo_6.Collector_Type_ReHeating_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHETAING_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_calculated_Row_length));
                }

                else if (Punterociclo_6.Collector_Type_ReHeating_SF == "Fresnel")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHETAING_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_6.LF_ReHeating_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.LF_ReHeating_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.LF_ReHeating_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.LF_ReHeating_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_6.LF_ReHeating_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_6.LF_ReHeating_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_6.LF_ReHeating_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_6.LF_ReHeating_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_6.LF_ReHeating_calculated_Row_length));
                }
            }

            else if (Brayton_cycle_type_variable == 7)
            {
                
            }

            else if (Brayton_cycle_type_variable == 8)
            {
                if (Punterociclo_8.Collector_Type_Main_SF == "Parabolic")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_8.PTC_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_8.PTC_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_8.PTC_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_8.PTC_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_8.PTC_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_8.PTC_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_8.PTC_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_8.PTC_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_8.PTC_Main_calculated_Row_length);
                }

                else if (Punterociclo_8.Collector_Type_Main_SF == "Fresnel")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_8.LF_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_8.LF_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_8.LF_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_8.LF_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_8.LF_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_8.LF_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_8.LF_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_8.LF_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_8.LF_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_8.LF_Main_calculated_Row_length);
                }
            }

            else if (Brayton_cycle_type_variable == 9)
            {

               
            }

            else if (Brayton_cycle_type_variable == 10)
            {

                if (Punterociclo_10.Collector_Type_Main_SF == "Parabolic")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_10.PTC_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.PTC_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.PTC_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.PTC_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_10.PTC_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_10.PTC_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_10.PTC_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_10.PTC_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_10.PTC_Main_calculated_Row_length);
                }

                else if (Punterociclo_10.Collector_Type_Main_SF == "Fresnel")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_10.LF_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.LF_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.LF_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.LF_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_10.LF_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_10.LF_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_10.LF_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_10.LF_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_10.LF_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_10.LF_Main_calculated_Row_length);
                }

                if (Punterociclo_10.Collector_Type_ReHeating_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHETAING_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_calculated_Row_length));
                }

                else if (Punterociclo_10.Collector_Type_ReHeating_SF == "Fresnel")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHETAING_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_10.LF_ReHeating_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.LF_ReHeating_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.LF_ReHeating_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.LF_ReHeating_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_10.LF_ReHeating_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_10.LF_ReHeating_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_10.LF_ReHeating_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_10.LF_ReHeating_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_10.LF_ReHeating_calculated_Row_length));
                }
            }

            else if (Brayton_cycle_type_variable == 11)
            {

            }

            else if (Brayton_cycle_type_variable == 12)
            {

                if (Punterociclo_12.Collector_Type_Main_SF == "Parabolic")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_12.PTC_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_12.PTC_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_12.PTC_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_12.PTC_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_12.PTC_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_12.PTC_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_12.PTC_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_12.PTC_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_12.PTC_Main_calculated_Row_length);
                }

                else if (Punterociclo_12.Collector_Type_Main_SF == "Fresnel")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_12.LF_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_12.LF_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_12.LF_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_12.LF_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_12.LF_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_12.LF_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_12.LF_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_12.LF_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_12.LF_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_12.LF_Main_calculated_Row_length);
                }
            }
        }

        //Solar Field Pumps results
        private void button11_Click(object sender, EventArgs e)
        {
            if (Brayton_cycle_type_variable == 1)
            {


            }

            else if (Brayton_cycle_type_variable == 2)
            {
                if (Punterociclo_2.Collector_Type_Main_SF == "Parabolic")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD_PUMP:" +
                        Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_Calculated_Power) +
                        Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_isoentropic_eff) +
                        Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_Hydraulic_Power) +
                        Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_Mechanical_eff) +
                        Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_Shaft_Work) +
                        Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_Motor_eff) +
                        Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_Motor_Elec_Consump) +
                        Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_Motor_NamePlate_Design) +
                        Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_Motor_NamePlate);

                }

                else if (Punterociclo_2.Collector_Type_Main_SF == "Fresnel")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_2.LF_Main_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_2.LF_Main_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_2.LF_Main_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_2.LF_Main_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_2.LF_Main_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_2.LF_Main_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_2.LF_Main_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_2.LF_Main_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_2.LF_Main_SF_Pump_Motor_NamePlate);

                }

                if (Punterociclo_2.Collector_Type_ReHeating_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHEATING_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_Motor_NamePlate));
                }

                else if (Punterociclo_2.Collector_Type_ReHeating_SF == "Fresnel")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHEATING_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_2.LF_ReHeating_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_2.LF_ReHeating_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_2.LF_ReHeating_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_2.LF_ReHeating_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_2.LF_ReHeating_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_2.LF_ReHeating_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_2.LF_ReHeating_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_2.LF_ReHeating_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_2.LF_ReHeating_SF_Pump_Motor_NamePlate));
                }
            }

            else if (Brayton_cycle_type_variable == 3)
            {
  
            }

            else if (Brayton_cycle_type_variable == 4)
            {
                if (Punterociclo_4.Collector_Type_Main_SF == "Parabolic")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD_PUMP:" +
                        Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_Calculated_Power) +
                        Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_isoentropic_eff) +
                        Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_Hydraulic_Power) +
                        Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_Mechanical_eff) +
                        Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_Shaft_Work) +
                        Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_Motor_eff) +
                        Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_Motor_Elec_Consump) +
                        Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_Motor_NamePlate_Design) +
                        Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_Motor_NamePlate);

                }

                else if (Punterociclo_4.Collector_Type_Main_SF == "Fresnel")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_4.LF_Main_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_4.LF_Main_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_4.LF_Main_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_4.LF_Main_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_4.LF_Main_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_4.LF_Main_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_4.LF_Main_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_4.LF_Main_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_4.LF_Main_SF_Pump_Motor_NamePlate);

                }
            }

            else if (Brayton_cycle_type_variable == 5)
            {
                
            }

            else if (Brayton_cycle_type_variable == 6)
            {
                if (Punterociclo_6.Collector_Type_Main_SF == "Parabolic")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD_PUMP:" +
                        Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_Calculated_Power) +
                        Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_isoentropic_eff) +
                        Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_Hydraulic_Power) +
                        Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_Mechanical_eff) +
                        Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_Shaft_Work) +
                        Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_Motor_eff) +
                        Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_Motor_Elec_Consump) +
                        Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_Motor_NamePlate_Design) +
                        Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_Motor_NamePlate);

                }

                else if (Punterociclo_6.Collector_Type_Main_SF == "Fresnel")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_Motor_NamePlate);

                }

                if (Punterociclo_6.Collector_Type_ReHeating_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHEATING_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_Motor_NamePlate));
                }

                else if (Punterociclo_6.Collector_Type_ReHeating_SF == "Fresnel")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHEATING_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_Motor_NamePlate));
                }
            }

            else if (Brayton_cycle_type_variable == 7)
            {
                
            }

            else if (Brayton_cycle_type_variable == 8)
            {
                if (Punterociclo_8.Collector_Type_Main_SF == "Parabolic")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD_PUMP:" +
                        Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_Calculated_Power) +
                        Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_isoentropic_eff) +
                        Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_Hydraulic_Power) +
                        Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_Mechanical_eff) +
                        Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_Shaft_Work) +
                        Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_Motor_eff) +
                        Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_Motor_Elec_Consump) +
                        Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_Motor_NamePlate_Design) +
                        Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_Motor_NamePlate);

                }

                else if (Punterociclo_8.Collector_Type_Main_SF == "Fresnel")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_Motor_NamePlate);

                }
            }

            else if (Brayton_cycle_type_variable == 9)
            {
               
            }

            else if (Brayton_cycle_type_variable == 10)
            {
                if (Punterociclo_10.Collector_Type_Main_SF == "Parabolic")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD_PUMP:" +
                        Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_Calculated_Power) +
                        Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_isoentropic_eff) +
                        Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_Hydraulic_Power) +
                        Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_Mechanical_eff) +
                        Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_Shaft_Work) +
                        Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_Motor_eff) +
                        Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_Motor_Elec_Consump) +
                        Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_Motor_NamePlate_Design) +
                        Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_Motor_NamePlate);

                }

                else if (Punterociclo_10.Collector_Type_Main_SF == "Fresnel")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_Motor_NamePlate);

                }

                if (Punterociclo_10.Collector_Type_ReHeating_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHEATING_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_Motor_NamePlate));
                }

                else if (Punterociclo_10.Collector_Type_ReHeating_SF == "Fresnel")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHEATING_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_Motor_NamePlate));
                }
            }

            else if (Brayton_cycle_type_variable == 11)
            {
                
            }

            else if (Brayton_cycle_type_variable == 12)
            {
                if (Punterociclo_12.Collector_Type_Main_SF == "Parabolic")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD_PUMP:" +
                        Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_Calculated_Power) +
                        Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_isoentropic_eff) +
                        Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_Hydraulic_Power) +
                        Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_Mechanical_eff) +
                        Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_Shaft_Work) +
                        Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_Motor_eff) +
                        Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_Motor_Elec_Consump) +
                        Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_Motor_NamePlate_Design) +
                        Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_Motor_NamePlate);

                }

                else if (Punterociclo_12.Collector_Type_Main_SF == "Fresnel")
                {

                    textBox1.Clear();

                    textBox1.Text = "MAIN_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_Motor_NamePlate);
                }
            }
        }

        //Solar Field Heat Exchangers (PHX and RHX)
        private void button10_Click(object sender, EventArgs e)
        {
            if (Brayton_cycle_type_variable == 1)
            {

               
            }

            else if (Brayton_cycle_type_variable == 2)
            {

                textBox1.Clear();

                textBox1.Text = "PRIMARY HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_2.PHX_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_2.PHX_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_2.PHX_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_2.PHX_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_2.PHX_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_2.PHX_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_2.PHX_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_2.PHX_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_2.PHX_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_2.PHX_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_2.PHX_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_2.PHX_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_2.PHX_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_2.PHX_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_2.PHX_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_2.PHX_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_2.PHX_Q_per_module) +

                Environment.NewLine + Environment.NewLine + "REHEATING HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_2.RHX_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_2.RHX_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_2.RHX_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_2.RHX_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_2.RHX_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_2.RHX_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_2.RHX_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_2.RHX_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_2.RHX_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_2.RHX_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_2.RHX_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_2.RHX_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_2.RHX_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_2.RHX_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_2.RHX_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_2.RHX_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_2.RHX_Q_per_module);
            }

            else if (Brayton_cycle_type_variable == 3)
            {

            }

            else if (Brayton_cycle_type_variable == 4)
            {

                textBox1.Clear();

                textBox1.Text = "PRIMARY HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_4.PHX_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_4.PHX_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_4.PHX_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_4.PHX_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_4.PHX_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_4.PHX_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_4.PHX_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_4.PHX_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_4.PHX_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_4.PHX_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_4.PHX_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_4.PHX_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_4.PHX_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_4.PHX_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_4.PHX_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_4.PHX_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_4.PHX_Q_per_module);
            }

            else if (Brayton_cycle_type_variable == 5)
            {

            }

            else if (Brayton_cycle_type_variable == 6)
            {

                textBox1.Clear();

                textBox1.Text = "PRIMARY HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_6.PHX_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_6.PHX_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_6.PHX_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_6.PHX_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_6.PHX_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_6.PHX_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_6.PHX_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_6.PHX_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_6.PHX_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_6.PHX_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_6.PHX_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_6.PHX_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_6.PHX_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_6.PHX_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_6.PHX_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_6.PHX_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_6.PHX_Q_per_module) +

                Environment.NewLine + Environment.NewLine + "REHEATING HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_6.RHX_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_6.RHX_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_6.RHX_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_6.RHX_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_6.RHX_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_6.RHX_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_6.RHX_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_6.RHX_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_6.RHX_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_6.RHX_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_6.RHX_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_6.RHX_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_6.RHX_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_6.RHX_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_6.RHX_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_6.RHX_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_6.RHX_Q_per_module);
            }

            else if (Brayton_cycle_type_variable == 7)
            {
               
            }

            else if (Brayton_cycle_type_variable == 8)
            {
                textBox1.Clear();

                textBox1.Text = "PRIMARY HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_8.PHX_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_8.PHX_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_8.PHX_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_8.PHX_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_8.PHX_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_8.PHX_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_8.PHX_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_8.PHX_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_8.PHX_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_8.PHX_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_8.PHX_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_8.PHX_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_8.PHX_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_8.PHX_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_8.PHX_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_8.PHX_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_8.PHX_Q_per_module);
            }

            else if (Brayton_cycle_type_variable == 9)
            {

               
            }

            else if (Brayton_cycle_type_variable == 10)
            {

                textBox1.Clear();

                textBox1.Text = "PRIMARY HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_10.PHX_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_10.PHX_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_10.PHX_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_10.PHX_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_10.PHX_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_10.PHX_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_10.PHX_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_10.PHX_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_10.PHX_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_10.PHX_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_10.PHX_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_10.PHX_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_10.PHX_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_10.PHX_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_10.PHX_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_10.PHX_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_10.PHX_Q_per_module) +

                Environment.NewLine + Environment.NewLine + "REHEATING HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_10.RHX_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_10.RHX_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_10.RHX_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_10.RHX_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_10.RHX_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_10.RHX_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_10.RHX_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_10.RHX_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_10.RHX_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_10.RHX_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_10.RHX_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_10.RHX_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_10.RHX_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_10.RHX_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_10.RHX_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_10.RHX_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_10.RHX_Q_per_module);
            }

            else if (Brayton_cycle_type_variable == 11)
            {

               
            }

            else if (Brayton_cycle_type_variable == 12)
            {

                textBox1.Clear();

                textBox1.Text = "PRIMARY HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_12.PHX_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_12.PHX_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_12.PHX_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_12.PHX_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_12.PHX_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_12.PHX_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_12.PHX_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_12.PHX_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_12.PHX_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_12.PHX_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_12.PHX_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_12.PHX_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_12.PHX_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_12.PHX_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_12.PHX_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_12.PHX_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_12.PHX_Q_per_module);
            }
        }

        //All Equipments Results Report
        private void button7_Click(object sender, EventArgs e)
        {
            if (Brayton_cycle_type_variable == 1)
            {
                   
            }

            else if (Brayton_cycle_type_variable == 2)
            {
                    textBox1.Clear();
                    //Power Generated in Turbomachines
                    Double Main_Turbine_Power = 0;
                    Double ReHeating_Turbine_Power = 0;
                    Double Compressor1_Power = 0;
                    Double Compressor2_Power = 0;
                    Double Total_Turbomachines_Power = 0;
                    Double Total_Auxiliaries = 0;
                
                    Main_Turbine_Power = Punterociclo_2.specific_work_main_turbine * Punterociclo_2.massflow2;
                    ReHeating_Turbine_Power = Punterociclo_2.specific_work_reheating_turbine * Punterociclo_2.massflow2;
                    Compressor1_Power = Punterociclo_2.specific_work_compressor1 * Punterociclo_2.massflow2 * (1 - Punterociclo_2.recomp_frac2);
                    Compressor2_Power = Punterociclo_2.specific_work_compressor2 * Punterociclo_2.massflow2 * Punterociclo_2.recomp_frac2;
                    Total_Turbomachines_Power = Main_Turbine_Power + ReHeating_Turbine_Power + Compressor1_Power + Compressor2_Power;
                    Total_Auxiliaries = Punterociclo_2.ACHE_fans + Punterociclo_2.Main_SF_Pump_Electrical_Consumption + Punterociclo_2.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_2.Generator_Power_Output * (Punterociclo_2.Miscellanous_Auxiliaries / 100));

                    textBox1.Text = "THERMOSOLAR POWER PLANT WITH LINE-FOCUSING SOLAR COLLECTORS AND A s-CO2 BRAYTON POWER CYCLE" +
                    Environment.NewLine + "Main Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.PHX_Q2), 4, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "ReHeating Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.RHX_Q2))) +
                    Environment.NewLine + "Pre-Cooler (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.PC_Q2), 4, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Net Total Heat Input (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.PHX_Q2 + Punterociclo_2.RHX_Q2), 4, MidpointRounding.AwayFromZero)) +

                    Environment.NewLine + Environment.NewLine + "Main Turbine (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.specific_work_main_turbine * Punterociclo_2.massflow2), 4, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "ReHeating Turbine (kW) : " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.specific_work_reheating_turbine * Punterociclo_2.massflow2), 4, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Main Compressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.specific_work_compressor1 * Punterociclo_2.massflow2 * (1 - Punterociclo_2.recomp_frac2)), 4, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "ReCompressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.specific_work_compressor2 * Punterociclo_2.massflow2 * Punterociclo_2.recomp_frac2), 4, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Total TurboMachines Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)) +

                    Environment.NewLine + Environment.NewLine + "Gross Output Power (kWe): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Gross Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_2.Generator_Power_Output) / (Punterociclo_2.PHX_Q2 + Punterociclo_2.RHX_Q2)) * 100), 4, MidpointRounding.AwayFromZero)) +

                    Environment.NewLine + Environment.NewLine + "Main SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "ReHeating SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.ReHeating_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "UHS Water Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Miscellanous_Auxiliaries (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Power_Output * (Punterociclo_2.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "ACHE Fans Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.ACHE_fans), 4, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Total_Auxiliaries Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +

                    Environment.NewLine + Environment.NewLine + "Net Power Output (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_2.Rating_Point_Efficiency / 100) * Punterociclo_2.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Net Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_2.Rating_Point_Efficiency / 100) * Punterociclo_2.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries) / (Punterociclo_2.PHX_Q2 + Punterociclo_2.RHX_Q2)) * 100), 4, MidpointRounding.AwayFromZero)) +

                    Environment.NewLine + Environment.NewLine + "MAIN_SOLAR_FIELD:" +
                    Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_2.PTC_Main_Solar_Impinging_flowpath) +
                    Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.PTC_Main_Solar_Energy_Absorbed_flowpath) +
                    Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.PTC_Main_Energy_Loss_flowpath) +
                    Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.PTC_Main_Net_Absorbed_flowpath) +
                    Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_2.PTC_Main_Net_Absorbed_SF) +
                    Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_2.PTC_Main_Collector_Efficiency) +
                    Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Effective_Apperture_Area) +
                    Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pressure_drop) +
                    Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_2.PTC_Main_calculated_mass_flux) +
                    Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_2.PTC_Main_calculated_Number_Rows) +
                    Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_2.PTC_Main_calculated_Row_length) +

                    Environment.NewLine + Environment.NewLine + "REHETAING_SOLAR_FIELD:" +
                    Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_Solar_Impinging_flowpath) +
                    Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_Solar_Energy_Absorbed_flowpath) +
                    Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_Energy_Loss_flowpath) +
                    Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_Net_Absorbed_flowpath) +
                    Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_Net_Absorbed_SF) +
                    Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_Collector_Efficiency) +
                    Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Effective_Apperture_Area) +
                    Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pressure_drop) +
                    Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_calculated_mass_flux) +
                    Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_calculated_Number_Rows) +
                    Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_2.PTC_ReHeating_calculated_Row_length) +

                    Environment.NewLine + Environment.NewLine + "MAIN_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_2.PTC_Main_SF_Pump_Motor_NamePlate) +

                    Environment.NewLine + Environment.NewLine + "REHEATING_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_2.PTC_ReHeating_SF_Pump_Motor_NamePlate) +

                    Environment.NewLine + Environment.NewLine + "PRIMARY HEAT EXCHANGER:" +
                    Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_2.PHX_cold_Pin) +
                    Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_2.PHX_cold_Tin) +
                    Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_2.PHX_hot_Pin) +
                    Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_2.PHX_hot_Tin) +
                    Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_2.PHX_cold_Pout) +
                    Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_2.PHX_hot_Pout) +
                    Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_2.PHX_mdot_c) +
                    Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_2.PHX_mdot_h) +
                    Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_2.PHX_Qdot) +
                    Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_2.PHX_Num_HXs) +
                    Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_2.PHX_UA) +
                    Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_2.PHX_NTU) +
                    Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_2.PHX_CR) +
                    Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_2.PHX_Effectiveness) +
                    Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_2.PHX_min_DT) +
                    Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_2.PHX_number_modules) +
                    Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_2.PHX_Q_per_module) +

                    Environment.NewLine + Environment.NewLine + "REHEATING HEAT EXCHANGER:" +
                    Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_2.RHX_cold_Pin) +
                    Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_2.RHX_cold_Tin) +
                    Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_2.RHX_hot_Pin) +
                    Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_2.RHX_hot_Tin) +
                    Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_2.RHX_cold_Pout) +
                    Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_2.RHX_hot_Pout) +
                    Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_2.RHX_mdot_c) +
                    Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_2.RHX_mdot_h) +
                    Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_2.RHX_Qdot) +
                    Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_2.RHX_Num_HXs) +
                    Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_2.RHX_UA) +
                    Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_2.RHX_NTU) +
                    Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_2.RHX_CR) +
                    Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_2.RHX_Effectiveness) +
                    Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_2.RHX_min_DT) +
                    Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_2.RHX_number_modules) +
                    Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_2.RHX_Q_per_module) +

                    Environment.NewLine + Environment.NewLine + "MAIN COMPRESSOR:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_2.Main_Compressor_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_2.Main_Compressor_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_2.Main_Compressor_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_2.Main_Compressor_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_2.Main_Compressor_Flow) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_2.Main_Compressor_Diameter) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_2.Main_Compressor_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_2.Main_Compressor_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_2.Main_Compressor_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_2.Main_Compressor_Surge) +

                    Environment.NewLine + Environment.NewLine + "RECOMPRESSOR:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_2.ReCompressor_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_2.ReCompressor_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_2.ReCompressor_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_2.ReCompressor_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_2.ReCompressor_Flow) +
                    Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_2.ReCompressor_Diameter1) +
                    Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_2.ReCompressor_Diameter2) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_2.ReCompressor_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_2.ReCompressor_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_2.ReCompressor_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_2.ReCompressor_Surge) +

                    Environment.NewLine + Environment.NewLine + "MAIN_TURBINE:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_2.Main_Turbine_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_2.Main_Turbine_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_2.Main_Turbine_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_2.Main_Turbine_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_2.Main_Turbine_Flow) +
                    Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_2.Main_Turbine_Rotary_Velocity) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_2.Main_Turbine_Diameter) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_2.Main_Turbine_Efficiency) +
                    Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_2.Main_Turbine_Anozzle) +
                    Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_2.Main_Turbine_nu) +
                    Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_2.Main_Turbine_w_Tip_Ratio) +

                    Environment.NewLine + Environment.NewLine + "REHEATING_TURBINE:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Flow) +
                    Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Rotary_Velocity) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Diameter) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Efficiency) +
                    Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_Anozzle) +
                    Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_nu) +
                    Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_2.ReHeating_Turbine_w_Tip_Ratio) +

                    Environment.NewLine + Environment.NewLine + "LOW TEMPERATURE HEAT EXCHANGER:" +
                    Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_2.LTR_cold_Pin) +
                    Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_2.LTR_cold_Tin) +
                    Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_2.LTR_hot_Pin) +
                    Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_2.LTR_hot_Tin) +
                    Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_2.LTR_cold_Pout) +
                    Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_2.LTR_hot_Pout) +
                    Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_2.LTR_mdot_c) +
                    Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_2.LTR_mdot_h) +
                    Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_2.LTR_Qdot) +
                    Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_2.LTR_Num_HXs) +
                    Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_2.LTR_UA) +
                    Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_2.LTR_NTU) +
                    Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_2.LTR_CR) +
                    Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_2.LTR_Effectiveness) +
                    Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_2.LTR_min_DT) +
                    Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_2.LTR_number_modules) +
                    Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_2.LTR_Q_per_module) +
                    Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_2.LTR_mdot_c_module) +
                    Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_2.LTR_mdot_h_module) +
                    Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_2.LTR_UA_module) +
                    Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_2.LTR_NTU_module) +
                    Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_2.LTR_CR_module) +
                    Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_2.LTR_Effectiveness_module) +
                    Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_2.LTR_min_DT_module) +

                    Environment.NewLine + Environment.NewLine + "HIGH TEMPERATURE HEAT EXCHANGER:" +
                    Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_2.HTR_cold_Pin) +
                    Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_2.HTR_cold_Tin) +
                    Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_2.HTR_hot_Pin) +
                    Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_2.HTR_hot_Tin) +
                    Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_2.HTR_cold_Pout) +
                    Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_2.HTR_hot_Pout) +
                    Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_2.HTR_mdot_c) +
                    Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_2.HTR_mdot_h) +
                    Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_2.HTR_Qdot) +
                    Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_2.HTR_Num_HXs) +
                    Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_2.HTR_UA) +
                    Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_2.HTR_NTU) +
                    Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_2.HTR_CR) +
                    Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_2.HTR_Effectiveness) +
                    Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_2.HTR_min_DT) +
                    Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_2.HTR_number_modules) +
                    Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_2.HTR_Q_per_module) +
                    Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_2.HTR_mdot_c_module) +
                    Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_2.HTR_mdot_h_module) +
                    Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_2.HTR_UA_module) +
                    Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_2.HTR_NTU_module) +
                    Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_2.HTR_CR_module) +
                    Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_2.HTR_Effectiveness_module) +
                    Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_2.HTR_min_DT_module) +

                    Environment.NewLine + Environment.NewLine + "PRECOOLER HEAT EXCHANGER Detail Design:" +
                    Environment.NewLine + "PC_Q_dot:" + Convert.ToString(Punterociclo_2.PC_Q2) +

                    Environment.NewLine + Environment.NewLine + "GENERATOR:" +
                    Environment.NewLine + "Generator nameplate power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Name_Plate_Power), 2, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Nameplate / Design point load = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Rating_Design_Point_Load), 2, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Generator Power Output (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Power_Output), 2, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Shaft Power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Generator total loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Total_Loss), 2, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Electrical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Electrical_Loss), 2, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Mechanical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Mechanical_Loss), 2, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Generator Efficiency (%) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Rating_Point_Efficiency), 4, MidpointRounding.AwayFromZero));
            }

            else if (Brayton_cycle_type_variable == 3)
            {
               
            }

            else if (Brayton_cycle_type_variable == 4)
            {
                textBox1.Clear();
                //Power Generated in Turbomachines
                Double Main_Turbine_Power = 0;
                Double Compressor1_Power = 0;
                Double Compressor2_Power = 0;
                Double Total_Turbomachines_Power = 0;
                Double Total_Auxiliaries = 0;

                Main_Turbine_Power = Punterociclo_4.specific_work_main_turbine * Punterociclo_4.massflow2;
                Compressor1_Power = Punterociclo_4.specific_work_compressor1 * Punterociclo_4.massflow2 * (1 - Punterociclo_4.recomp_frac2);
                Compressor2_Power = Punterociclo_4.specific_work_compressor2 * Punterociclo_4.massflow2 * Punterociclo_4.recomp_frac2;
                Total_Turbomachines_Power = Main_Turbine_Power + Compressor1_Power + Compressor2_Power;
                Total_Auxiliaries = Punterociclo_4.ACHE_fans + Punterociclo_4.Main_SF_Pump_Electrical_Consumption + Punterociclo_4.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_4.Generator_Power_Output * (Punterociclo_4.Miscellanous_Auxiliaries / 100));

                textBox1.Text = "THERMOSOLAR POWER PLANT WITH LINE-FOCUSING SOLAR COLLECTORS AND A s-CO2 BRAYTON POWER CYCLE" +
                Environment.NewLine + "Main Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.PHX_Q2), 4, MidpointRounding.AwayFromZero)) +   
                Environment.NewLine + "Pre-Cooler (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.PC_Q2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Total Heat Input (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.PHX_Q2), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main Turbine (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.specific_work_main_turbine * Punterociclo_4.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Main Compressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.specific_work_compressor1 * Punterociclo_4.massflow2 * (1 - Punterociclo_4.recomp_frac2)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReCompressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.specific_work_compressor2 * Punterociclo_4.massflow2 * Punterociclo_4.recomp_frac2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total TurboMachines Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Gross Output Power (kWe): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Gross Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_4.Generator_Power_Output) / (Punterociclo_4.PHX_Q2)) * 100), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "UHS Water Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Miscellanous_Auxiliaries (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Power_Output * (Punterociclo_4.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ACHE Fans Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.ACHE_fans), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total_Auxiliaries Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Net Power Output (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_4.Rating_Point_Efficiency / 100) * Punterociclo_4.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_4.Rating_Point_Efficiency / 100) * Punterociclo_4.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries) / (Punterociclo_4.PHX_Q2)) * 100), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "MAIN_SOLAR_FIELD:" +
                Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_4.PTC_Main_Solar_Impinging_flowpath) +
                Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_4.PTC_Main_Solar_Energy_Absorbed_flowpath) +
                Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_4.PTC_Main_Energy_Loss_flowpath) +
                Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_4.PTC_Main_Net_Absorbed_flowpath) +
                Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_4.PTC_Main_Net_Absorbed_SF) +
                Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_4.PTC_Main_Collector_Efficiency) +
                Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Effective_Apperture_Area) +
                Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pressure_drop) +
                Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_4.PTC_Main_calculated_mass_flux) +
                Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_4.PTC_Main_calculated_Number_Rows) +
                Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_4.PTC_Main_calculated_Row_length) +

                Environment.NewLine + Environment.NewLine + "MAIN_SOLAR_FIELD_PUMP:" +
                Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_Calculated_Power) +
                Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_isoentropic_eff) +
                Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_Hydraulic_Power) +
                Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_Mechanical_eff) +
                Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_Shaft_Work) +
                Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_Motor_eff) +
                Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_Motor_Elec_Consump) +
                Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_Motor_NamePlate_Design) +
                Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_4.PTC_Main_SF_Pump_Motor_NamePlate) +

                Environment.NewLine + Environment.NewLine + "PRIMARY HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_4.PHX_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_4.PHX_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_4.PHX_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_4.PHX_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_4.PHX_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_4.PHX_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_4.PHX_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_4.PHX_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_4.PHX_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_4.PHX_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_4.PHX_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_4.PHX_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_4.PHX_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_4.PHX_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_4.PHX_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_4.PHX_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_4.PHX_Q_per_module) +

                Environment.NewLine + Environment.NewLine + "MAIN COMPRESSOR:" +
                Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_4.Main_Compressor_Pin) +
                Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_4.Main_Compressor_Tin) +
                Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_4.Main_Compressor_Tout) +
                Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_4.Main_Compressor_Pout) +
                Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_4.Main_Compressor_Flow) +
                Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_4.Main_Compressor_Diameter) +
                Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_4.Main_Compressor_Rotation_Velocity) +
                Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_4.Main_Compressor_Efficiency) +
                Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_4.Main_Compressor_Phi) +
                Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_4.Main_Compressor_Surge) +

                Environment.NewLine + Environment.NewLine + "RECOMPRESSOR:" +
                Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_4.ReCompressor_Pin) +
                Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_4.ReCompressor_Tin) +
                Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_4.ReCompressor_Tout) +
                Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_4.ReCompressor_Pout) +
                Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_4.ReCompressor_Flow) +
                Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_4.ReCompressor_Diameter1) +
                Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_4.ReCompressor_Diameter2) +
                Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_4.ReCompressor_Rotation_Velocity) +
                Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_4.ReCompressor_Efficiency) +
                Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_4.ReCompressor_Phi) +
                Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_4.ReCompressor_Surge) +

                Environment.NewLine + Environment.NewLine + "MAIN_TURBINE:" +
                Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_4.Main_Turbine_Pin) +
                Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_4.Main_Turbine_Tin) +
                Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_4.Main_Turbine_Tout) +
                Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_4.Main_Turbine_Pout) +
                Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_4.Main_Turbine_Flow) +
                Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_4.Main_Turbine_Rotary_Velocity) +
                Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_4.Main_Turbine_Diameter) +
                Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_4.Main_Turbine_Efficiency) +
                Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_4.Main_Turbine_Anozzle) +
                Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_4.Main_Turbine_nu) +
                Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_4.Main_Turbine_w_Tip_Ratio) +

                Environment.NewLine + Environment.NewLine + "LOW TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_4.LTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_4.LTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_4.LTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_4.LTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_4.LTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_4.LTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_4.LTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_4.LTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_4.LTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_4.LTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_4.LTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_4.LTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_4.LTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_4.LTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_4.LTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_4.LTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_4.LTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_4.LTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_4.LTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_4.LTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_4.LTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_4.LTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_4.LTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_4.LTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "HIGH TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_4.HTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_4.HTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_4.HTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_4.HTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_4.HTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_4.HTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_4.HTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_4.HTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_4.HTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_4.HTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_4.HTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_4.HTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_4.HTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_4.HTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_4.HTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_4.HTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_4.HTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_4.HTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_4.HTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_4.HTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_4.HTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_4.HTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_4.HTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_4.HTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "PRECOOLER HEAT EXCHANGER Detail Design:" +
                Environment.NewLine + "PC_Q_dot:" + Convert.ToString(Punterociclo_4.PC_Q2) +

                Environment.NewLine + Environment.NewLine + "GENERATOR:" +
                Environment.NewLine + "Generator nameplate power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Name_Plate_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Nameplate / Design point load = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Rating_Design_Point_Load), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Power Output (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Power_Output), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Shaft Power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator total loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Total_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Electrical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Electrical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Mechanical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Mechanical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Efficiency (%) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Rating_Point_Efficiency), 4, MidpointRounding.AwayFromZero));
            }

            else if (Brayton_cycle_type_variable == 5)
            {

            }

            else if (Brayton_cycle_type_variable == 6)
            {
                textBox1.Clear();

                //Power Generated in Turbomachines
                Double Main_Turbine_Power = 0;
                Double ReHeating_Turbine_Power = 0;
                Double Compressor1_Power = 0;
                Double Compressor2_Power = 0;
                Double Compressor3_Power = 0;
                Double Total_Turbomachines_Power = 0;
                Double Total_Auxiliaries = 0;
                Main_Turbine_Power = Punterociclo_6.specific_work_main_turbine * Punterociclo_6.massflow2;
                ReHeating_Turbine_Power = Punterociclo_6.specific_work_reheating_turbine * Punterociclo_6.massflow2;
                Compressor1_Power = Punterociclo_6.specific_work_compressor1 * Punterociclo_6.massflow2 * (1 - Punterociclo_6.recomp_frac2);
                Compressor2_Power = Punterociclo_6.specific_work_compressor2 * Punterociclo_6.massflow2 * (Punterociclo_6.recomp_frac2);
                Compressor3_Power = Punterociclo_6.specific_work_compressor3 * Punterociclo_6.massflow2;
                Total_Turbomachines_Power = Main_Turbine_Power + ReHeating_Turbine_Power + Compressor1_Power + Compressor2_Power + Compressor3_Power;
                Total_Auxiliaries = Punterociclo_6.ACHE_fans + Punterociclo_6.Main_SF_Pump_Electrical_Consumption + Punterociclo_6.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_6.Generator_Power_Output * (Punterociclo_6.Miscellanous_Auxiliaries / 100));

                textBox1.Text = "THERMOSOLAR POWER PLANT WITH LINE-FOCUSING SOLAR COLLECTORS AND A s-CO2 BRAYTON POWER CYCLE" +
                Environment.NewLine + "Main Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.PHX1), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Reheating Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.RHX1), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Pre-Cooler1 (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.PC1), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Pre-Cooler2 (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.COOLER1), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Total Heat Input (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.PHX1 + Punterociclo_6.RHX1), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main Turbine (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.specific_work_main_turbine * Punterociclo_6.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReHeating Turbine (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.specific_work_reheating_turbine * Punterociclo_6.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Main Compressor1 (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.specific_work_compressor1 * Punterociclo_6.massflow2 * (1 - Punterociclo_6.recomp_frac2)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "PreCompressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.specific_work_compressor3 * Punterociclo_6.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReCompressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.specific_work_compressor2 * Punterociclo_6.massflow2 * Punterociclo_6.recomp_frac2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total TurboMachines Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Gross Output Power (kWe): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Gross Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_6.Generator_Power_Output) / (Punterociclo_6.PHX1 + Punterociclo_6.RHX1)) * 100), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                 Environment.NewLine + "Reheating SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.ReHeating_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "UHS Water Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Miscellanous_Auxiliaries (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Power_Output * (Punterociclo_6.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ACHE Fans Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.ACHE_fans), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total_Auxiliaries Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Net Power Output (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_6.Rating_Point_Efficiency / 100) * Punterociclo_6.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_6.Rating_Point_Efficiency / 100) * Punterociclo_6.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries) / (Punterociclo_6.PHX1 + Punterociclo_6.RHX1)) * 100), 4, MidpointRounding.AwayFromZero));

                if (Punterociclo_6.Collector_Type_Main_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_6.PTC_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.PTC_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.PTC_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.PTC_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_6.PTC_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_6.PTC_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_6.PTC_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_6.PTC_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_6.PTC_Main_calculated_Row_length));
                }

                else if (Punterociclo_6.Collector_Type_Main_SF == "Fresnel")
                {
                    textBox1.AppendText(Environment.NewLine +Environment.NewLine +"MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_6.LF_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.LF_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.LF_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.LF_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_6.LF_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_6.LF_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_6.LF_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_6.LF_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_6.LF_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_6.LF_Main_calculated_Row_length));
                }

                if (Punterociclo_6.Collector_Type_ReHeating_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHETAING_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_6.PTC_ReHeating_calculated_Row_length));
                }

                else if (Punterociclo_6.Collector_Type_ReHeating_SF == "Fresnel")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHETAING_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_6.LF_ReHeating_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.LF_ReHeating_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.LF_ReHeating_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_6.LF_ReHeating_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_6.LF_ReHeating_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_6.LF_ReHeating_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_6.LF_ReHeating_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_6.LF_ReHeating_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_6.LF_ReHeating_calculated_Row_length));
                }

                if (Punterociclo_6.Collector_Type_Main_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MAIN_SOLAR_FIELD_PUMP:" +
                        Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_Calculated_Power) +
                        Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_isoentropic_eff) +
                        Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_Hydraulic_Power) +
                        Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_Mechanical_eff) +
                        Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_Shaft_Work) +
                        Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_Motor_eff) +
                        Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_Motor_Elec_Consump) +
                        Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_Motor_NamePlate_Design) +
                        Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_6.PTC_Main_SF_Pump_Motor_NamePlate));

                }

                else if (Punterociclo_6.Collector_Type_Main_SF == "Fresnel")
                {
                    textBox1.AppendText(Environment.NewLine +Environment.NewLine + "MAIN_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_6.LF_Main_SF_Pump_Motor_NamePlate));

                }

                if (Punterociclo_6.Collector_Type_ReHeating_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHEATING_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_6.PTC_ReHeating_SF_Pump_Motor_NamePlate));
                }

                else if (Punterociclo_6.Collector_Type_ReHeating_SF == "Fresnel")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHEATING_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_6.LF_ReHeating_SF_Pump_Motor_NamePlate));
                }

                textBox1.AppendText( Environment.NewLine + Environment.NewLine + "PRIMARY HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_6.PHX_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_6.PHX_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_6.PHX_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_6.PHX_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_6.PHX_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_6.PHX_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_6.PHX_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_6.PHX_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_6.PHX_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_6.PHX_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_6.PHX_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_6.PHX_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_6.PHX_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_6.PHX_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_6.PHX_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_6.PHX_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_6.PHX_Q_per_module) +

                Environment.NewLine + Environment.NewLine + "REHEATING HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_6.RHX_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_6.RHX_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_6.RHX_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_6.RHX_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_6.RHX_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_6.RHX_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_6.RHX_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_6.RHX_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_6.RHX_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_6.RHX_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_6.RHX_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_6.RHX_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_6.RHX_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_6.RHX_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_6.RHX_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_6.RHX_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_6.RHX_Q_per_module));

                textBox1.AppendText(Environment.NewLine + Environment.NewLine + "PRE-COMPRESSOR:" +
                Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Pin) +
                Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Tin) +
                Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Tout) +
                Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Pout) +
                Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Flow) +
                Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Diameter1) +
                Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Diameter2) +
                Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Rotation_Velocity) +
                Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Efficiency) +
                Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Phi) +
                Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_6.Pre_Compressor1_Surge) +
                
                Environment.NewLine + Environment.NewLine + "MAIN COMPRESSOR:" +
                Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_6.Main_Compressor_Pin) +
                Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_6.Main_Compressor_Tin) +
                Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_6.Main_Compressor_Tout) +
                Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_6.Main_Compressor_Pout) +
                Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_6.Main_Compressor_Flow) +
                Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_6.Main_Compressor_Diameter) +
                Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_6.Main_Compressor_Rotation_Velocity) +
                Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_6.Main_Compressor_Efficiency) +
                Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_6.Main_Compressor_Phi) +
                Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_6.Main_Compressor_Surge) +

                Environment.NewLine + Environment.NewLine + "RECOMPRESSOR:" +
                Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_6.ReCompressor_Pin) +
                Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_6.ReCompressor_Tin) +
                Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_6.ReCompressor_Tout) +
                Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_6.ReCompressor_Pout) +
                Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_6.ReCompressor_Flow) +
                Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_6.ReCompressor_Diameter1) +
                Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_6.ReCompressor_Diameter2) +
                Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_6.ReCompressor_Rotation_Velocity) +
                Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_6.ReCompressor_Efficiency) +
                Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_6.ReCompressor_Phi) +
                Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_6.ReCompressor_Surge));

                textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MAIN_TURBINE:" +
                Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_6.Main_Turbine_Pin) +
                Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_6.Main_Turbine_Tin) +
                Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_6.Main_Turbine_Tout) +
                Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_6.Main_Turbine_Pout) +
                Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_6.Main_Turbine_Flow) +
                Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_6.Main_Turbine_Rotary_Velocity) +
                Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_6.Main_Turbine_Diameter) +
                Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_6.Main_Turbine_Efficiency) +
                Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_6.Main_Turbine_Anozzle) +
                Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_6.Main_Turbine_nu) +
                Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_6.Main_Turbine_w_Tip_Ratio));

                textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHEATING_TURBINE:" +
                Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Pin) +
                Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Tin) +
                Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Tout) +
                Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Pout) +
                Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Flow) +
                Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Rotary_Velocity) +
                Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Diameter) +
                Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Efficiency) +
                Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_Anozzle) +
                Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_nu) +
                Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_6.ReHeating_Turbine_w_Tip_Ratio));

                textBox1.AppendText(Environment.NewLine + Environment.NewLine +"LOW TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_6.LTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_6.LTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_6.LTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_6.LTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_6.LTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_6.LTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_6.LTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_6.LTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_6.LTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_6.LTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_6.LTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_6.LTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_6.LTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_6.LTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_6.LTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_6.LTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_6.LTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_6.LTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_6.LTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_6.LTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_6.LTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_6.LTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_6.LTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_6.LTR_min_DT_module) +
 
                Environment.NewLine + Environment.NewLine + "HIGH TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_6.HTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_6.HTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_6.HTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_6.HTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_6.HTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_6.HTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_6.HTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_6.HTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_6.HTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_6.HTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_6.HTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_6.HTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_6.HTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_6.HTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_6.HTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_6.HTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_6.HTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_6.HTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_6.HTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_6.HTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_6.HTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_6.HTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_6.HTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_6.HTR_min_DT_module) +
                 
                Environment.NewLine + Environment.NewLine + "PRECOOLER HEAT EXCHANGER Detail Design:" +
                Environment.NewLine + "PC1_Q_dot:" + Convert.ToString(Punterociclo_6.PC1) +
                Environment.NewLine + "PC2_Q_dot:" + Convert.ToString(Punterociclo_6.COOLER1) +
                Environment.NewLine + "" + Environment.NewLine);
            }

            else if (Brayton_cycle_type_variable == 7)
            {

             
        }

            else if (Brayton_cycle_type_variable == 8)
            {
                textBox1.Clear();

                //Power Generated in Turbomachines
                Double Main_Turbine_Power = 0;
                Double Compressor1_Power = 0;
                Double Compressor2_Power = 0;
                Double Compressor3_Power = 0;
                Double Total_Turbomachines_Power = 0;
                Double Total_Auxiliaries = 0;
                Main_Turbine_Power = Punterociclo_8.specific_work_main_turbine * Punterociclo_8.massflow2;
                Compressor1_Power = Punterociclo_8.specific_work_compressor1 * Punterociclo_8.massflow2 * (1 - Punterociclo_8.recomp_frac2);
                Compressor2_Power = Punterociclo_8.specific_work_compressor2 * Punterociclo_8.massflow2 * (Punterociclo_8.recomp_frac2);
                Compressor3_Power = Punterociclo_8.specific_work_compressor3 * Punterociclo_8.massflow2;
                Total_Turbomachines_Power = Main_Turbine_Power + Compressor1_Power + Compressor2_Power + Compressor3_Power;
                Total_Auxiliaries = Punterociclo_8.ACHE_fans + Punterociclo_8.Main_SF_Pump_Electrical_Consumption + Punterociclo_8.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_8.Generator_Power_Output * (Punterociclo_8.Miscellanous_Auxiliaries / 100));

                textBox1.Text = "THERMOSOLAR POWER PLANT WITH LINE-FOCUSING SOLAR COLLECTORS AND A s-CO2 BRAYTON POWER CYCLE" +
                Environment.NewLine + "Main Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.PHX1), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Pre-Cooler1 (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.PC11), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Pre-Cooler2 (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.PC21), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Total Heat Input (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.PHX1), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main Turbine (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.specific_work_main_turbine * Punterociclo_8.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Main Compressor1 (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.specific_work_compressor1 * Punterociclo_8.massflow2 * (1 - Punterociclo_8.recomp_frac2)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "PreCompressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.specific_work_compressor3 * Punterociclo_8.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReCompressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.specific_work_compressor2 * Punterociclo_8.massflow2 * Punterociclo_8.recomp_frac2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total TurboMachines Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Gross Output Power (kWe): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Gross Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_8.Generator_Power_Output) / (Punterociclo_8.PHX1)) * 100), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "UHS Water Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Miscellanous_Auxiliaries (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Power_Output * (Punterociclo_8.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ACHE Fans Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.ACHE_fans), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total_Auxiliaries Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Net Power Output (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_8.Rating_Point_Efficiency / 100) * Punterociclo_8.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_8.Rating_Point_Efficiency / 100) * Punterociclo_8.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries) / (Punterociclo_8.PHX1)) * 100), 4, MidpointRounding.AwayFromZero));

                if (Punterociclo_8.Collector_Type_Main_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine +Environment.NewLine +"MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_8.PTC_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_8.PTC_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_8.PTC_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_8.PTC_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_8.PTC_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_8.PTC_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_8.PTC_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_8.PTC_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_8.PTC_Main_calculated_Row_length));
                }

                else if (Punterociclo_8.Collector_Type_Main_SF == "Fresnel")
                {
                    textBox1.AppendText(Environment.NewLine +Environment.NewLine +"MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_8.LF_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_8.LF_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_8.LF_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_8.LF_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_8.LF_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_8.LF_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_8.LF_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_8.LF_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_8.LF_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_8.LF_Main_calculated_Row_length));
                }

                if (Punterociclo_8.Collector_Type_Main_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MAIN_SOLAR_FIELD_PUMP:" +
                        Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_Calculated_Power) +
                        Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_isoentropic_eff) +
                        Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_Hydraulic_Power) +
                        Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_Mechanical_eff) +
                        Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_Shaft_Work) +
                        Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_Motor_eff) +
                        Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_Motor_Elec_Consump) +
                        Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_Motor_NamePlate_Design) +
                        Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_8.PTC_Main_SF_Pump_Motor_NamePlate));
                }

                else if (Punterociclo_8.Collector_Type_Main_SF == "Fresnel")
                {
                    textBox1.AppendText(Environment.NewLine +Environment.NewLine +"MAIN_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_8.LF_Main_SF_Pump_Motor_NamePlate));
                }

                    textBox1.AppendText(Environment.NewLine +Environment.NewLine +"PRIMARY HEAT EXCHANGER:" +
                    Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_8.PHX_cold_Pin) +
                    Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_8.PHX_cold_Tin) +
                    Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_8.PHX_hot_Pin) +
                    Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_8.PHX_hot_Tin) +
                    Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_8.PHX_cold_Pout) +
                    Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_8.PHX_hot_Pout) +
                    Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_8.PHX_mdot_c) +
                    Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_8.PHX_mdot_h) +
                    Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_8.PHX_Qdot) +
                    Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_8.PHX_Num_HXs) +
                    Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_8.PHX_UA) +
                    Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_8.PHX_NTU) +
                    Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_8.PHX_CR) +
                    Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_8.PHX_Effectiveness) +
                    Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_8.PHX_min_DT) +
                    Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_8.PHX_number_modules) +
                    Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_8.PHX_Q_per_module));

                    textBox1.AppendText(Environment.NewLine +Environment.NewLine +"PRE-COMPRESSOR:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Flow) +
                    Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Diameter1) +
                    Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Diameter2) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_8.Pre_Compressor1_Surge) +

                    Environment.NewLine + Environment.NewLine + "MAIN COMPRESSOR:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_8.Main_Compressor_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_8.Main_Compressor_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_8.Main_Compressor_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_8.Main_Compressor_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_8.Main_Compressor_Flow) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_8.Main_Compressor_Diameter) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_8.Main_Compressor_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_8.Main_Compressor_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_8.Main_Compressor_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_8.Main_Compressor_Surge) +

                    Environment.NewLine + Environment.NewLine + "RECOMPRESSOR:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_8.ReCompressor_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_8.ReCompressor_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_8.ReCompressor_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_8.ReCompressor_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_8.ReCompressor_Flow) +
                    Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_8.ReCompressor_Diameter1) +
                    Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_8.ReCompressor_Diameter2) +
                    Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_8.ReCompressor_Rotation_Velocity) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_8.ReCompressor_Efficiency) +
                    Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_8.ReCompressor_Phi) +
                    Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_8.ReCompressor_Surge));

                    textBox1.AppendText(Environment.NewLine +Environment.NewLine +"MAIN_TURBINE:" +
                    Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_8.Main_Turbine_Pin) +
                    Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_8.Main_Turbine_Tin) +
                    Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_8.Main_Turbine_Tout) +
                    Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_8.Main_Turbine_Pout) +
                    Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_8.Main_Turbine_Flow) +
                    Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_8.Main_Turbine_Rotary_Velocity) +
                    Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_8.Main_Turbine_Diameter) +
                    Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_8.Main_Turbine_Efficiency) +
                    Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_8.Main_Turbine_Anozzle) +
                    Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_8.Main_Turbine_nu) +
                    Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_8.Main_Turbine_w_Tip_Ratio));

                    textBox1.AppendText(Environment.NewLine +Environment.NewLine +"LOW TEMPERATURE HEAT EXCHANGER:" +
                    Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_8.LTR_cold_Pin) +
                    Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_8.LTR_cold_Tin) +
                    Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_8.LTR_hot_Pin) +
                    Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_8.LTR_hot_Tin) +
                    Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_8.LTR_cold_Pout) +
                    Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_8.LTR_hot_Pout) +
                    Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_8.LTR_mdot_c) +
                    Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_8.LTR_mdot_h) +
                    Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_8.LTR_Qdot) +
                    Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_8.LTR_Num_HXs) +
                    Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_8.LTR_UA) +
                    Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_8.LTR_NTU) +
                    Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_8.LTR_CR) +
                    Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_8.LTR_Effectiveness) +
                    Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_8.LTR_min_DT) +
                    Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_8.LTR_number_modules) +
                    Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_8.LTR_Q_per_module) +
                    Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_8.LTR_mdot_c_module) +
                    Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_8.LTR_mdot_h_module) +
                    Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_8.LTR_UA_module) +
                    Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_8.LTR_NTU_module) +
                    Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_8.LTR_CR_module) +
                    Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_8.LTR_Effectiveness_module) +
                    Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_8.LTR_min_DT_module) +

                    Environment.NewLine + Environment.NewLine + "HIGH TEMPERATURE HEAT EXCHANGER:" +
                    Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_8.HTR_cold_Pin) +
                    Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_8.HTR_cold_Tin) +
                    Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_8.HTR_hot_Pin) +
                    Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_8.HTR_hot_Tin) +
                    Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_8.HTR_cold_Pout) +
                    Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_8.HTR_hot_Pout) +
                    Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_8.HTR_mdot_c) +
                    Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_8.HTR_mdot_h) +
                    Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_8.HTR_Qdot) +
                    Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_8.HTR_Num_HXs) +
                    Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_8.HTR_UA) +
                    Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_8.HTR_NTU) +
                    Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_8.HTR_CR) +
                    Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_8.HTR_Effectiveness) +
                    Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_8.HTR_min_DT) +
                    Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_8.HTR_number_modules) +
                    Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_8.HTR_Q_per_module) +
                    Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_8.HTR_mdot_c_module) +
                    Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_8.HTR_mdot_h_module) +
                    Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_8.HTR_UA_module) +
                    Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_8.HTR_NTU_module) +
                    Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_8.HTR_CR_module) +
                    Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_8.HTR_Effectiveness_module) +
                    Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_8.HTR_min_DT_module) +

                    Environment.NewLine + Environment.NewLine + "PRECOOLER HEAT EXCHANGER Detail Design:" +
                    Environment.NewLine + "PC1_Q_dot:" + Convert.ToString(Punterociclo_8.PC11) +
                    Environment.NewLine + "PC2_Q_dot:" + Convert.ToString(Punterociclo_8.PC21));

                    textBox1.AppendText(Environment.NewLine +Environment.NewLine +"GENERATOR:" +
                    Environment.NewLine + "Generator nameplate power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Name_Plate_Power), 2, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Nameplate / Design point load = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Rating_Design_Point_Load), 2, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Generator Power Output (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Power_Output), 2, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Shaft Power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Generator total loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Total_Loss), 2, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Electrical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Electrical_Loss), 2, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Mechanical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Mechanical_Loss), 2, MidpointRounding.AwayFromZero)) +
                    Environment.NewLine + "Generator Efficiency (%) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Rating_Point_Efficiency), 4, MidpointRounding.AwayFromZero)));
            }

            else if (Brayton_cycle_type_variable == 9)
            {
               
            }

            else if (Brayton_cycle_type_variable == 10)
            {
                textBox1.Clear();

                //Power Generated in Turbomachines
                Double Main_Turbine_Power = 0;
                Double ReHeating_Turbine_Power = 0;
                Double Compressor1_Power = 0;
                Double Compressor2_Power = 0;
                Double Compressor3_Power = 0;
                Double Total_Turbomachines_Power = 0;
                Double Total_Auxiliaries = 0;
                Main_Turbine_Power = Punterociclo_10.specific_work_main_turbine * Punterociclo_10.massflow2;
                ReHeating_Turbine_Power = Punterociclo_10.specific_work_reheating_turbine * Punterociclo_10.massflow2;
                Compressor1_Power = Punterociclo_10.specific_work_compressor1 * Punterociclo_10.massflow2 * (1 - Punterociclo_10.recomp_frac2);
                Compressor2_Power = Punterociclo_10.specific_work_compressor3 * Punterociclo_10.massflow2 * (1 - Punterociclo_10.recomp_frac2);
                Compressor3_Power = Punterociclo_10.specific_work_compressor2 * Punterociclo_10.massflow2 * Punterociclo_10.recomp_frac2;
                Total_Turbomachines_Power = Main_Turbine_Power + ReHeating_Turbine_Power + Compressor1_Power + Compressor2_Power + Compressor3_Power;
                Total_Auxiliaries = Punterociclo_10.ACHE_fans + Punterociclo_10.Main_SF_Pump_Electrical_Consumption + Punterociclo_10.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_10.Generator_Power_Output * (Punterociclo_10.Miscellanous_Auxiliaries / 100));

                textBox1.Text = "THERMOSOLAR POWER PLANT WITH LINE-FOCUSING SOLAR COLLECTORS AND A s-CO2 BRAYTON POWER CYCLE" +
                Environment.NewLine + "Main Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.PHX1), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Reheating Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.RHX1), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Pre-Cooler1 (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.PC11), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Pre-Cooler2 (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.PC21), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Total Heat Input (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.PHX1 + Punterociclo_10.RHX1), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main Turbine (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.specific_work_main_turbine * Punterociclo_10.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReHeating Turbine (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.specific_work_reheating_turbine * Punterociclo_10.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Main Compressor1 (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.specific_work_compressor1 * Punterociclo_10.massflow2 * (1 - Punterociclo_10.recomp_frac2)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Main Compressor2 (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.specific_work_compressor3 * Punterociclo_10.massflow2 * (1 - Punterociclo_10.recomp_frac2)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReCompressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.specific_work_compressor2 * Punterociclo_10.massflow2 * Punterociclo_10.recomp_frac2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total TurboMachines Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Gross Output Power (kWe): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Gross Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_10.Generator_Power_Output) / (Punterociclo_10.PHX1 + Punterociclo_10.RHX1)) * 100), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                 Environment.NewLine + "Reheating SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.ReHeating_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "UHS Water Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Miscellanous_Auxiliaries (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Power_Output * (Punterociclo_10.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ACHE Fans Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.ACHE_fans), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total_Auxiliaries Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Net Power Output (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_10.Rating_Point_Efficiency / 100) * Punterociclo_10.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_10.Rating_Point_Efficiency / 100) * Punterociclo_10.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries) / (Punterociclo_10.PHX1 + Punterociclo_10.RHX1)) * 100), 4, MidpointRounding.AwayFromZero));

                if (Punterociclo_10.Collector_Type_Main_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_10.PTC_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.PTC_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.PTC_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.PTC_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_10.PTC_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_10.PTC_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_10.PTC_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_10.PTC_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_10.PTC_Main_calculated_Row_length));
                }

                else if (Punterociclo_10.Collector_Type_Main_SF == "Fresnel")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MAIN_SOLAR_FIELD:" +
                         Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_10.LF_Main_Solar_Impinging_flowpath) +
                         Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.LF_Main_Solar_Energy_Absorbed_flowpath) +
                         Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.LF_Main_Energy_Loss_flowpath) +
                         Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.LF_Main_Net_Absorbed_flowpath) +
                         Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_10.LF_Main_Net_Absorbed_SF) +
                         Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_10.LF_Main_Collector_Efficiency) +
                         Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_10.LF_Main_SF_Effective_Apperture_Area) +
                         Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pressure_drop) +
                         Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_10.LF_Main_calculated_mass_flux) +
                         Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_10.LF_Main_calculated_Number_Rows) +
                         Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_10.LF_Main_calculated_Row_length));
                }

                if (Punterociclo_10.Collector_Type_ReHeating_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHETAING_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_10.PTC_ReHeating_calculated_Row_length));
                }

                else if (Punterociclo_10.Collector_Type_ReHeating_SF == "Fresnel")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHETAING_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_10.LF_ReHeating_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.LF_ReHeating_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.LF_ReHeating_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_10.LF_ReHeating_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_10.LF_ReHeating_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_10.LF_ReHeating_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_10.LF_ReHeating_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_10.LF_ReHeating_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_10.LF_ReHeating_calculated_Row_length));
                }

                if (Punterociclo_10.Collector_Type_Main_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MAIN_SOLAR_FIELD_PUMP:" +
                         Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_Calculated_Power) +
                         Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_isoentropic_eff) +
                         Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_Hydraulic_Power) +
                         Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_Mechanical_eff) +
                         Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_Shaft_Work) +
                         Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_Motor_eff) +
                         Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_Motor_Elec_Consump) +
                         Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_Motor_NamePlate_Design) +
                         Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_10.PTC_Main_SF_Pump_Motor_NamePlate));
                }

                else if (Punterociclo_10.Collector_Type_Main_SF == "Fresnel")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MAIN_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_10.LF_Main_SF_Pump_Motor_NamePlate));

                }

                if (Punterociclo_10.Collector_Type_ReHeating_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHEATING_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_10.PTC_ReHeating_SF_Pump_Motor_NamePlate));
                }

                else if (Punterociclo_10.Collector_Type_ReHeating_SF == "Fresnel")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "REHEATING_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_10.LF_ReHeating_SF_Pump_Motor_NamePlate));
                }

                textBox1.AppendText(Environment.NewLine + Environment.NewLine + "PRIMARY HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_10.PHX_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_10.PHX_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_10.PHX_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_10.PHX_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_10.PHX_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_10.PHX_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_10.PHX_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_10.PHX_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_10.PHX_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_10.PHX_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_10.PHX_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_10.PHX_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_10.PHX_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_10.PHX_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_10.PHX_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_10.PHX_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_10.PHX_Q_per_module) +

                Environment.NewLine + Environment.NewLine + "REHEATING HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_10.RHX_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_10.RHX_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_10.RHX_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_10.RHX_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_10.RHX_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_10.RHX_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_10.RHX_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_10.RHX_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_10.RHX_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_10.RHX_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_10.RHX_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_10.RHX_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_10.RHX_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_10.RHX_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_10.RHX_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_10.RHX_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_10.RHX_Q_per_module));

                textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MAIN COMPRESSOR1:" +
                Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Pin) +
                Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Tin) +
                Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Tout) +
                Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Pout) +
                Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Flow) +
                Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Diameter1) +
                Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Diameter2) +
                Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Rotation_Velocity) +
                Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Efficiency) +
                Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_10.Main_Compressor1_Phi) +
                Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_10.Main_Compressor1_Surge) +

                Environment.NewLine + Environment.NewLine + "MAIN COMPRESSOR2:" +
                Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_10.Main_Compressor_Pin) +
                Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_10.Main_Compressor_Tin) +
                Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_10.Main_Compressor_Tout) +
                Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_10.Main_Compressor_Pout) +
                Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_10.Main_Compressor_Flow) +
                Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_10.Main_Compressor_Diameter) +
                Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_10.Main_Compressor_Rotation_Velocity) +
                Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_10.Main_Compressor_Efficiency) +
                Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_10.Main_Compressor_Phi) +
                Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_10.Main_Compressor_Surge) +

                Environment.NewLine + Environment.NewLine + "RECOMPRESSOR:" +
                Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_10.ReCompressor_Pin) +
                Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_10.ReCompressor_Tin) +
                Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_10.ReCompressor_Tout) +
                Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_10.ReCompressor_Pout) +
                Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_10.ReCompressor_Flow) +
                Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_10.ReCompressor_Diameter1) +
                Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_10.ReCompressor_Diameter2) +
                Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_10.ReCompressor_Rotation_Velocity) +
                Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_10.ReCompressor_Efficiency) +
                Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_10.ReCompressor_Phi) +
                Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_10.ReCompressor_Surge));

                textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MAIN_TURBINE:" +
                Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_10.Main_Turbine_Pin) +
                Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_10.Main_Turbine_Tin) +
                Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_10.Main_Turbine_Tout) +
                Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_10.Main_Turbine_Pout) +
                Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_10.Main_Turbine_Flow) +
                Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_10.Main_Turbine_Rotary_Velocity) +
                Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_10.Main_Turbine_Diameter) +
                Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_10.Main_Turbine_Efficiency) +
                Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_10.Main_Turbine_Anozzle) +
                Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_10.Main_Turbine_nu) +
                Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_10.Main_Turbine_w_Tip_Ratio) +

                Environment.NewLine + Environment.NewLine + "REHEATING_TURBINE:" +
                Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Pin) +
                Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Tin) +
                Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Tout) +
                Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Pout) +
                Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Flow) +
                Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Rotary_Velocity) +
                Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Diameter) +
                Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Efficiency) +
                Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_Anozzle) +
                Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_nu) +
                Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_10.ReHeating_Turbine_w_Tip_Ratio));

                textBox1.AppendText(Environment.NewLine + Environment.NewLine + "LOW TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_10.LTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_10.LTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_10.LTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_10.LTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_10.LTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_10.LTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_10.LTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_10.LTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_10.LTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_10.LTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_10.LTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_10.LTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_10.LTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_10.LTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_10.LTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_10.LTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_10.LTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_10.LTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_10.LTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_10.LTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_10.LTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_10.LTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_10.LTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_10.LTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "HIGH TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_10.HTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_10.HTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_10.HTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_10.HTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_10.HTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_10.HTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_10.HTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_10.HTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_10.HTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_10.HTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_10.HTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_10.HTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_10.HTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_10.HTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_10.HTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_10.HTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_10.HTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_10.HTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_10.HTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_10.HTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_10.HTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_10.HTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_10.HTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_10.HTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "PRECOOLER HEAT EXCHANGER Detail Design:" +
                Environment.NewLine + "PC1_Q_dot:" + Convert.ToString(Punterociclo_10.PC11) +
                Environment.NewLine + "PC2_Q_dot:" + Convert.ToString(Punterociclo_10.PC21));

                textBox1.AppendText(Environment.NewLine + Environment.NewLine + "GENERATOR:" +
                Environment.NewLine + "Generator nameplate power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Name_Plate_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Nameplate / Design point load = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Rating_Design_Point_Load), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Power Output (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Power_Output), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Shaft Power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator total loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Total_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Electrical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Electrical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Mechanical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Mechanical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Efficiency (%) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Rating_Point_Efficiency), 4, MidpointRounding.AwayFromZero)));
            }

            else if (Brayton_cycle_type_variable == 11)
            {
               
            }

            else if (Brayton_cycle_type_variable == 12)
            {
                textBox1.Clear();

                //Power Generated in Turbomachines
                Double Main_Turbine_Power = 0;
                Double Compressor1_Power = 0;
                Double Compressor2_Power = 0;
                Double Compressor3_Power = 0;
                Double Total_Turbomachines_Power = 0;
                Double Total_Auxiliaries = 0;
                Main_Turbine_Power = Punterociclo_12.specific_work_main_turbine * Punterociclo_12.massflow2;
                Compressor1_Power = Punterociclo_12.specific_work_compressor1 * Punterociclo_12.massflow2 * (1 - Punterociclo_12.recomp_frac2);
                Compressor2_Power = Punterociclo_12.specific_work_compressor3 * Punterociclo_12.massflow2 * (1 - Punterociclo_12.recomp_frac2);
                Compressor3_Power = Punterociclo_12.specific_work_compressor2 * Punterociclo_12.massflow2 * Punterociclo_12.recomp_frac2;
                Total_Turbomachines_Power = Main_Turbine_Power + Compressor1_Power + Compressor2_Power + Compressor3_Power;
                Total_Auxiliaries = Punterociclo_12.ACHE_fans + Punterociclo_12.Main_SF_Pump_Electrical_Consumption + Punterociclo_12.ReHeating_SF_Pump_Electrical_Consumption + (Punterociclo_12.Generator_Power_Output * (Punterociclo_12.Miscellanous_Auxiliaries / 100));

                textBox1.Text = "THERMOSOLAR POWER PLANT WITH LINE-FOCUSING SOLAR COLLECTORS AND A s-CO2 BRAYTON POWER CYCLE" +
                Environment.NewLine + "Main Solar Field (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.PHX), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Pre-Cooler1 (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.PC11), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Pre-Cooler2 (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.PC21), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Total Heat Input (kWth): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.PHX), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main Turbine (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.specific_work_main_turbine * Punterociclo_12.massflow2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Main Compressor1 (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.specific_work_compressor1 * Punterociclo_12.massflow2 * (1 - Punterociclo_12.recomp_frac2)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Main Compressor2 (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.specific_work_compressor3 * Punterociclo_12.massflow2 * (1 - Punterociclo_12.recomp_frac2)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ReCompressor (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.specific_work_compressor2 * Punterociclo_12.massflow2 * Punterociclo_12.recomp_frac2), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total TurboMachines Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Turbomachines_Power), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Gross Output Power (kWe): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Power_Output), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Gross Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal(((Punterociclo_12.Generator_Power_Output) / (Punterociclo_12.PHX)) * 100), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Main SF Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Main_SF_Pump_Electrical_Consumption), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "UHS Water Pump Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.UHS_Water_Pump), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Miscellanous_Auxiliaries (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Power_Output * (Punterociclo_12.Miscellanous_Auxiliaries / 100)), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "ACHE Fans Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.ACHE_fans), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Total_Auxiliaries Power (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal(Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +

                Environment.NewLine + Environment.NewLine + "Net Power Output (kW): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((Punterociclo_12.Rating_Point_Efficiency / 100) * Punterociclo_12.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries), 4, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Net Efficiency (%): " + Convert.ToString(decimal.Round(Convert.ToDecimal((((((Punterociclo_12.Rating_Point_Efficiency / 100) * Punterociclo_12.Gear_Efficiency) * Total_Turbomachines_Power) - Total_Auxiliaries) / (Punterociclo_12.PHX)) * 100), 4, MidpointRounding.AwayFromZero));

                if (Punterociclo_12.Collector_Type_Main_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_12.PTC_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_12.PTC_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_12.PTC_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_12.PTC_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_12.PTC_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_12.PTC_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_12.PTC_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_12.PTC_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_12.PTC_Main_calculated_Row_length));
                }

                else if (Punterociclo_12.Collector_Type_Main_SF == "Fresnel")
                {

                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MAIN_SOLAR_FIELD:" +
                        Environment.NewLine + "Solar Energy impinging active aperture in each flow path (kW): " + Convert.ToString(Punterociclo_12.LF_Main_Solar_Impinging_flowpath) +
                        Environment.NewLine + "Solar Energy absorbed by receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_12.LF_Main_Solar_Energy_Absorbed_flowpath) +
                        Environment.NewLine + "Energy loss from receiver in each operating flow path (kW): " + Convert.ToString(Punterociclo_12.LF_Main_Energy_Loss_flowpath) +
                        Environment.NewLine + "Net heat absorbed by fluid in each operating flow path (kW): " + Convert.ToString(Punterociclo_12.LF_Main_Net_Absorbed_flowpath) +
                        Environment.NewLine + "Net heat absorbed by field (kW): " + Convert.ToString(Punterociclo_12.LF_Main_Net_Absorbed_SF) +
                        Environment.NewLine + "Collector efficiency (Fluid heating in receiver / Energy impinging focused active collector) (%): " + Convert.ToString(Punterociclo_12.LF_Main_Collector_Efficiency) +
                        Environment.NewLine + "Solar Field Effective Aperture Area (m2): " + Convert.ToString(Punterociclo_12.LF_Main_SF_Effective_Apperture_Area) +
                        Environment.NewLine + "Calculated Pressure Drop (bar): " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pressure_drop) +
                        Environment.NewLine + "Calculated massflux in receiver tubes (kg/m2 s): " + Convert.ToString(Punterociclo_12.LF_Main_calculated_mass_flux) +
                        Environment.NewLine + "Calculated Number of Rows: " + Convert.ToString(Punterociclo_12.LF_Main_calculated_Number_Rows) +
                        Environment.NewLine + "Calculated Row Length (m): " + Convert.ToString(Punterociclo_12.LF_Main_calculated_Row_length));
                }

                if (Punterociclo_12.Collector_Type_Main_SF == "Parabolic")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MAIN_SOLAR_FIELD_PUMP:" +
                        Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_Calculated_Power) +
                        Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_isoentropic_eff) +
                        Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_Hydraulic_Power) +
                        Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_Mechanical_eff) +
                        Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_Shaft_Work) +
                        Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_Motor_eff) +
                        Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_Motor_Elec_Consump) +
                        Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_Motor_NamePlate_Design) +
                        Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_12.PTC_Main_SF_Pump_Motor_NamePlate));
                }

                else if (Punterociclo_12.Collector_Type_Main_SF == "Fresnel")
                {
                    textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MAIN_SOLAR_FIELD_PUMP:" +
                    Environment.NewLine + "Calculated Power: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_Calculated_Power) +
                    Environment.NewLine + "Pump Isoentropic Efficiency: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_isoentropic_eff) +
                    Environment.NewLine + "Hydraulic Pumping Power: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_Hydraulic_Power) +
                    Environment.NewLine + "Pump Mechanical Efficiency: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_Mechanical_eff) +
                    Environment.NewLine + "Pump Shaft Work: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_Shaft_Work) +
                    Environment.NewLine + "Motor Efficiency: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_Motor_eff) +
                    Environment.NewLine + "Electrical Consumption: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_Motor_Elec_Consump) +
                    Environment.NewLine + "Name Plate / Design Point Load: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_Motor_NamePlate_Design) +
                    Environment.NewLine + "Motor Name Plate Power: " + Convert.ToString(Punterociclo_12.LF_Main_SF_Pump_Motor_NamePlate));
                }

                textBox1.AppendText(Environment.NewLine + Environment.NewLine + "PRIMARY HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_12.PHX_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_12.PHX_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_12.PHX_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_12.PHX_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_12.PHX_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_12.PHX_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_12.PHX_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_12.PHX_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_12.PHX_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_12.PHX_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_12.PHX_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_12.PHX_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_12.PHX_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_12.PHX_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_12.PHX_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_12.PHX_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_12.PHX_Q_per_module));

                textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MAIN COMPRESSOR1:" +
                Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Pin) +
                Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Tin) +
                Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Tout) +
                Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Pout) +
                Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Flow) +
                Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Diameter1) +
                Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Diameter2) +
                Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Rotation_Velocity) +
                Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Efficiency) +
                Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_12.Main_Compressor1_Phi) +
                Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_12.Main_Compressor1_Surge) +

                Environment.NewLine + Environment.NewLine + "MAIN COMPRESSOR2:" +
                Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_12.Main_Compressor_Pin) +
                Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_12.Main_Compressor_Tin) +
                Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_12.Main_Compressor_Tout) +
                Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_12.Main_Compressor_Pout) +
                Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_12.Main_Compressor_Flow) +
                Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_12.Main_Compressor_Diameter) +
                Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_12.Main_Compressor_Rotation_Velocity) +
                Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_12.Main_Compressor_Efficiency) +
                Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_12.Main_Compressor_Phi) +
                Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_12.Main_Compressor_Surge) +

                Environment.NewLine + Environment.NewLine + "RECOMPRESSOR:" +
                Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_12.ReCompressor_Pin) +
                Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_12.ReCompressor_Tin) +
                Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_12.ReCompressor_Tout) +
                Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_12.ReCompressor_Pout) +
                Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_12.ReCompressor_Flow) +
                Environment.NewLine + "Diameter1 (m): " + Convert.ToString(Punterociclo_12.ReCompressor_Diameter1) +
                Environment.NewLine + "Diameter2 (m): " + Convert.ToString(Punterociclo_12.ReCompressor_Diameter2) +
                Environment.NewLine + "Rotary Speed (rpm): " + Convert.ToString(Punterociclo_12.ReCompressor_Rotation_Velocity) +
                Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_12.ReCompressor_Efficiency) +
                Environment.NewLine + "Flow Factor (Phi): " + Convert.ToString(Punterociclo_12.ReCompressor_Phi) +
                Environment.NewLine + "Surge: " + Convert.ToString(Punterociclo_12.ReCompressor_Surge));

                textBox1.AppendText(Environment.NewLine + Environment.NewLine + "MAIN_TURBINE:" +
                Environment.NewLine + "Inlet Pressure Pin (kPa): " + Convert.ToString(Punterociclo_12.Main_Turbine_Pin) +
                Environment.NewLine + "Inlet Pressure Tin (K): " + Convert.ToString(Punterociclo_12.Main_Turbine_Tin) +
                Environment.NewLine + "Outlet Pressure Pout (kPa): " + Convert.ToString(Punterociclo_12.Main_Turbine_Tout) +
                Environment.NewLine + "Outlet Temperature Tout (K): " + Convert.ToString(Punterociclo_12.Main_Turbine_Pout) +
                Environment.NewLine + "Mass Flow (kg/s): " + Convert.ToString(Punterociclo_12.Main_Turbine_Flow) +
                Environment.NewLine + "Rotary Velocity (rpm): " + Convert.ToString(Punterociclo_12.Main_Turbine_Rotary_Velocity) +
                Environment.NewLine + "Diameter (m): " + Convert.ToString(Punterociclo_12.Main_Turbine_Diameter) +
                Environment.NewLine + "Efficiency (%): " + Convert.ToString(Punterociclo_12.Main_Turbine_Efficiency) +
                Environment.NewLine + "Nozzle Area (m2): " + Convert.ToString(Punterociclo_12.Main_Turbine_Anozzle) +
                Environment.NewLine + "Tip Velocity/Spouting Velocity Nu: " + Convert.ToString(Punterociclo_12.Main_Turbine_nu) +
                Environment.NewLine + "W_Tip_Ratio: " + Convert.ToString(Punterociclo_12.Main_Turbine_w_Tip_Ratio));

                textBox1.AppendText(Environment.NewLine + Environment.NewLine + "LOW TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_12.LTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_12.LTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_12.LTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_12.LTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_12.LTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_12.LTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_12.LTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_12.LTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_12.LTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_12.LTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_12.LTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_12.LTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_12.LTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_12.LTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_12.LTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_12.LTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_12.LTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_12.LTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_12.LTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_12.LTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_12.LTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_12.LTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_12.LTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_12.LTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "HIGH TEMPERATURE HEAT EXCHANGER:" +
                Environment.NewLine + "Cold side inlet Pressure (bar): " + Convert.ToString(Punterociclo_12.HTR_cold_Pin) +
                Environment.NewLine + "Cold side inlet Temperature (K): " + Convert.ToString(Punterociclo_12.HTR_cold_Tin) +
                Environment.NewLine + "Hot side inlet Pressure (bar): " + Convert.ToString(Punterociclo_12.HTR_hot_Pin) +
                Environment.NewLine + "Hot side inlet Temperature (K): " + Convert.ToString(Punterociclo_12.HTR_hot_Tin) +
                Environment.NewLine + "Cold side outlet Pressure (bar): " + Convert.ToString(Punterociclo_12.HTR_cold_Pout) +
                Environment.NewLine + "Hot side outlet Pressure (bar): " + Convert.ToString(Punterociclo_12.HTR_hot_Pout) +
                Environment.NewLine + "Cold side mass flow (kg/s): " + Convert.ToString(Punterociclo_12.HTR_mdot_c) +
                Environment.NewLine + "Hot side mass flow (kg/s): " + Convert.ToString(Punterociclo_12.HTR_mdot_h) +
                Environment.NewLine + "Heat Exchanged (kWth): " + Convert.ToString(Punterociclo_12.HTR_Qdot) +
                Environment.NewLine + "Number of Sub-Heat Exchanger (Uds.): " + Convert.ToString(Punterociclo_12.HTR_Num_HXs) +
                Environment.NewLine + "Conductance (kW/K): " + Convert.ToString(Punterociclo_12.HTR_UA) +
                Environment.NewLine + "Number of Thermal Units: " + Convert.ToString(Punterociclo_12.HTR_NTU) +
                Environment.NewLine + "Capacity Ratio: " + Convert.ToString(Punterociclo_12.HTR_CR) +
                Environment.NewLine + "Effectiveness: " + Convert.ToString(Punterociclo_12.HTR_Effectiveness) +
                Environment.NewLine + "Pinch-Point Temperature (K): " + Convert.ToString(Punterociclo_12.HTR_min_DT) +
                Environment.NewLine + "Number of Modules in paralell: " + Convert.ToString(Punterociclo_12.HTR_number_modules) +
                Environment.NewLine + "Heat Exchanged per module (kWth): " + Convert.ToString(Punterociclo_12.HTR_Q_per_module) +
                Environment.NewLine + "Cold side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_12.HTR_mdot_c_module) +
                Environment.NewLine + "Hot side mass flow per module (kg/s): " + Convert.ToString(Punterociclo_12.HTR_mdot_h_module) +
                Environment.NewLine + "Conductance per module (kW/K): " + Convert.ToString(Punterociclo_12.HTR_UA_module) +
                Environment.NewLine + "Number of Thermal Units per module: " + Convert.ToString(Punterociclo_12.HTR_NTU_module) +
                Environment.NewLine + "Capacity Ratio per module: " + Convert.ToString(Punterociclo_12.HTR_CR_module) +
                Environment.NewLine + "Effectiveness per module: " + Convert.ToString(Punterociclo_12.HTR_Effectiveness_module) +
                Environment.NewLine + "Pinch-Point Tempertuature per module (K): " + Convert.ToString(Punterociclo_12.HTR_min_DT_module) +

                Environment.NewLine + Environment.NewLine + "PRECOOLER HEAT EXCHANGER Detail Design:" +
                Environment.NewLine + "PC1_Q_dot:" + Convert.ToString(Punterociclo_12.PC11) +
                Environment.NewLine + "PC2_Q_dot:" + Convert.ToString(Punterociclo_12.PC21));

                textBox1.AppendText(Environment.NewLine + Environment.NewLine + "GENERATOR:" +
                Environment.NewLine + "Generator nameplate power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Name_Plate_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Nameplate / Design point load = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Rating_Design_Point_Load), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Power Output (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Power_Output), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Shaft Power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator total loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Total_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Electrical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Electrical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Mechanical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Mechanical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Efficiency (%) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Rating_Point_Efficiency), 4, MidpointRounding.AwayFromZero)));
            }
        }

        //Generator Results
        private void button12_Click(object sender, EventArgs e)
        {
            if (Brayton_cycle_type_variable == 1)
            {
                
            }

            else if (Brayton_cycle_type_variable == 2)
            {
                textBox1.Clear();

                textBox1.Text = "THERMOSOLAR POWER PLANT WITH LINE-FOCUSING SOLAR COLLECTORS AND A s-CO2 BRAYTON POWER CYCLE" +
                Environment.NewLine + "Generator nameplate power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Name_Plate_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Nameplate / Design point load = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Rating_Design_Point_Load), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Power Output (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Power_Output), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Shaft Power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator total loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Total_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Electrical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Electrical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Mechanical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Generator_Mechanical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Efficiency (%) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_2.Rating_Point_Efficiency), 4, MidpointRounding.AwayFromZero));
            }

            else if (Brayton_cycle_type_variable == 3)
            {
               
            }

            else if (Brayton_cycle_type_variable == 4)
            {
                textBox1.Clear();

                textBox1.Text = "THERMOSOLAR POWER PLANT WITH LINE-FOCUSING SOLAR COLLECTORS AND A s-CO2 BRAYTON POWER CYCLE" +
                Environment.NewLine + "Generator nameplate power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Name_Plate_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Nameplate / Design point load = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Rating_Design_Point_Load), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Power Output (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Power_Output), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Shaft Power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator total loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Total_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Electrical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Electrical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Mechanical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Generator_Mechanical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Efficiency (%) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_4.Rating_Point_Efficiency), 4, MidpointRounding.AwayFromZero));
            }

            else if (Brayton_cycle_type_variable == 5)
            {
               
            }

            else if (Brayton_cycle_type_variable == 6)
            {
                textBox1.Clear();

                textBox1.Text = "GENERATOR:" +
                Environment.NewLine + "Generator nameplate power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Name_Plate_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Nameplate / Design point load = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Rating_Design_Point_Load), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Power Output (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Power_Output), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Shaft Power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator total loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Total_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Electrical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Electrical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Mechanical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Generator_Mechanical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Efficiency (%) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_6.Rating_Point_Efficiency), 4, MidpointRounding.AwayFromZero));
            }

            else if (Brayton_cycle_type_variable == 7)
            {
                
            }

            else if (Brayton_cycle_type_variable == 8)
            {
                textBox1.Clear();

                textBox1.Text = "GENERATOR:" +
                Environment.NewLine + "Generator nameplate power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Name_Plate_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Nameplate / Design point load = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Rating_Design_Point_Load), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Power Output (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Power_Output), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Shaft Power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator total loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Total_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Electrical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Electrical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Mechanical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Generator_Mechanical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Efficiency (%) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_8.Rating_Point_Efficiency), 4, MidpointRounding.AwayFromZero));
            }

            else if (Brayton_cycle_type_variable == 9)
            {
               
            }

            else if (Brayton_cycle_type_variable == 10)
            {
                textBox1.Clear();

                textBox1.Text = "GENERATOR:" +
                Environment.NewLine + "Generator nameplate power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Name_Plate_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Nameplate / Design point load = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Rating_Design_Point_Load), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Power Output (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Power_Output), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Shaft Power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator total loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Total_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Electrical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Electrical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Mechanical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Generator_Mechanical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Efficiency (%) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_10.Rating_Point_Efficiency), 4, MidpointRounding.AwayFromZero));
            }

            else if (Brayton_cycle_type_variable == 11)
            {
                
            }

            else if (Brayton_cycle_type_variable == 12)
            {
                textBox1.Clear();

                textBox1.Text = "GENERATOR:" +
                Environment.NewLine + "Generator nameplate power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Name_Plate_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Nameplate / Design point load = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Rating_Design_Point_Load), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Power Output (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Power_Output), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Shaft Power (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Shaft_Power), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator total loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Total_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Electrical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Electrical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Mechanical loss (kW) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Generator_Mechanical_Loss), 2, MidpointRounding.AwayFromZero)) +
                Environment.NewLine + "Generator Efficiency (%) = " + Convert.ToString(decimal.Round(Convert.ToDecimal(Punterociclo_12.Rating_Point_Efficiency), 4, MidpointRounding.AwayFromZero));
            }
        }        
    }
}
