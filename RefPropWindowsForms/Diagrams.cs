﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RefPropWindowsForms
{
    public partial class Diagrams : Form
    {
        public Double Brayton_cycle_type_variable;

        public Recompression_Brayton_Power_Cycle Punterociclo_2;
        public RC_without_ReHeating Punterociclo_4;

        public PCRC Punterociclo_6;
        public PCRC_without_ReHeating Punterociclo_8;
        public RCMCI Punterociclo_10;
        public RCMCI_without_ReHeating Punterociclo_12;

        public Diagrams()
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

        //Temperature-Entrophy Diagram
        public void button2_Click(object sender, EventArgs e)
        {
            if (Brayton_cycle_type_variable == 1)
            {
                
            }

            else if (Brayton_cycle_type_variable == 2)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:Temperatures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp26), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp210), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp211), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp212), 1, MidpointRounding.AwayFromZero);

                //DataGridView1:Entrophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.entr21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.entr22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.entr23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.entr24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.entr25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.entr26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.entr27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.entr28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.entr29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.entr210), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.entr211), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.entr212), 2, MidpointRounding.AwayFromZero);

                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr21 - 0.1), 1, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr212 + 0.1), 1, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 0.125;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp21 - 25), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp212 + 25), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Entrophy (kJ/kg K)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Temperature (K)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr21), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr22), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr23), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr24), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp210);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr25), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr26), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr211), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp211);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr212), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp212);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr27), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr28), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr29), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp29);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr21), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp21);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr29), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp29);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr21), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr22), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr23), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr24), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr25), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr26), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr27), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr28), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr29), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp210);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr211), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp211);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.entr212), 2, MidpointRounding.AwayFromZero), Punterociclo_2.temp212);

                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";
                chart1.Series["Main_Flow"].Points[4].Label = "10";
                chart1.Series["Main_Flow"].Points[5].Label = "5";
                chart1.Series["Main_Flow"].Points[6].Label = "6";
                chart1.Series["Main_Flow"].Points[7].Label = "11";
                chart1.Series["Main_Flow"].Points[8].Label = "12";
                chart1.Series["Main_Flow"].Points[9].Label = "7";
                chart1.Series["Main_Flow"].Points[10].Label = "8";
                chart1.Series["Main_Flow"].Points[11].Label = "9";
            }

            else if (Brayton_cycle_type_variable == 3)
            {
               
            }

            else if (Brayton_cycle_type_variable == 4)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:Temperatures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp26), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp210), 1, MidpointRounding.AwayFromZero);
           
                //DataGridView1:Entrophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.entr21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.entr22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.entr23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.entr24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.entr25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.entr26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.entr27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.entr28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.entr29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.entr210), 2, MidpointRounding.AwayFromZero);

                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr21 - 0.1), 1, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr27 + 0.1), 1, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 0.125;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp21 - 25), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp26 + 25), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Entrophy (kJ/kg K)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Temperature (K)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr21), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr22), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr23), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr24), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp210);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr25), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr26), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr27), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr28), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr29), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp29);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr21), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp21);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr29), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp29);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr21), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr22), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr23), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr24), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr25), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr26), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr27), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr28), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr29), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_4.temp210);

                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";
                chart1.Series["Main_Flow"].Points[4].Label = "10";
                chart1.Series["Main_Flow"].Points[5].Label = "5";
                chart1.Series["Main_Flow"].Points[6].Label = "6";
                chart1.Series["Main_Flow"].Points[7].Label = "7";
                chart1.Series["Main_Flow"].Points[8].Label = "8";
                chart1.Series["Main_Flow"].Points[9].Label = "9";
            }

            else if (Brayton_cycle_type_variable == 5)
            {
               
            }

            else if (Brayton_cycle_type_variable == 6)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:Temperatures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp26), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp211), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp212), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp210), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[12].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp213), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[13].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp214), 1, MidpointRounding.AwayFromZero);

                //DataGridView1:Entrophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.entr21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.entr22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.entr23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.entr24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.entr25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.entr26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.entr27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.entr211), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.entr212), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.entr28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.entr29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.entr210), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[12].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.entr213), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[13].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.entr214), 2, MidpointRounding.AwayFromZero);

                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr21 - 0.1), 1, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr27 + 0.1), 1, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 0.125;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp21 - 25), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp26 + 25), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Entrophy (kJ/kg K)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Temperature (K)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr21), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr22), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr23), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr24), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp210);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr25), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr26), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr211), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp211);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr212), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp212);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr27), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr28), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr29), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp29);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr213), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp213);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr214), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp214);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr21), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp21);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr214), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp214);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr21), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr22), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr23), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr24), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp210);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr25), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr26), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr211), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp211);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr212), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp212);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr27), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr28), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr29), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr213), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp213);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.entr214), 2, MidpointRounding.AwayFromZero), Punterociclo_6.temp214);

                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";
                chart1.Series["Main_Flow"].Points[4].Label = "10";
                chart1.Series["Main_Flow"].Points[5].Label = "5";
                chart1.Series["Main_Flow"].Points[6].Label = "6";
                chart1.Series["Main_Flow"].Points[7].Label = "11";
                chart1.Series["Main_Flow"].Points[8].Label = "12";
                chart1.Series["Main_Flow"].Points[9].Label = "7";
                chart1.Series["Main_Flow"].Points[10].Label = "8";
                chart1.Series["Main_Flow"].Points[11].Label = "9";
                chart1.Series["Main_Flow"].Points[12].Label = "13";
                chart1.Series["Main_Flow"].Points[13].Label = "14";
            }

            else if (Brayton_cycle_type_variable == 7)
            {
               
            }

            else if (Brayton_cycle_type_variable == 8)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:Temperatures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp26), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp210), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp213), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp214), 1, MidpointRounding.AwayFromZero);

                //DataGridView1:Entrophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.entr21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.entr22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.entr23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.entr24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.entr25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.entr26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.entr27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.entr28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.entr29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.entr210), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.entr213), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.entr214), 2, MidpointRounding.AwayFromZero);

                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr21 - 0.1), 1, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr27 + 0.1), 1, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 0.125;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp21 - 25), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp26 + 25), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Entrophy (kJ/kg K)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Temperature (K)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr21), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr22), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr23), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr24), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp210);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr25), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr26), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr27), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr28), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr29), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp29);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr213), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp213);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr214), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp214);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr21), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp21);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr214), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp29);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr21), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr22), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr23), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr24), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp210);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr25), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr26), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr27), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr28), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr29), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr213), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp213);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.entr214), 2, MidpointRounding.AwayFromZero), Punterociclo_8.temp214);

                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";
                chart1.Series["Main_Flow"].Points[4].Label = "10";
                chart1.Series["Main_Flow"].Points[5].Label = "5";
                chart1.Series["Main_Flow"].Points[6].Label = "6";
                chart1.Series["Main_Flow"].Points[7].Label = "7";
                chart1.Series["Main_Flow"].Points[8].Label = "8";
                chart1.Series["Main_Flow"].Points[9].Label = "9";
                chart1.Series["Main_Flow"].Points[10].Label = "11";
                chart1.Series["Main_Flow"].Points[11].Label = "12";
            }

            else if (Brayton_cycle_type_variable == 9)
            {
                
            }

            else if (Brayton_cycle_type_variable == 10)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:Temperatures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp214), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp26), 1, MidpointRounding.AwayFromZero);                
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp210), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp211), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp212), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[12].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[13].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp213), 1, MidpointRounding.AwayFromZero);

                //DataGridView1:Entrophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.entr214), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.entr22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.entr23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.entr24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.entr25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.entr26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.entr27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.entr28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.entr29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.entr210), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.entr211), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.entr212), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[12].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.entr21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[13].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.entr213), 2, MidpointRounding.AwayFromZero);

                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr22 - 0.1), 1, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr27 + 0.1), 1, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 0.125;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp213 - 100), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp212 + 100), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Entrophy (kJ/kg K)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Temperature (K)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr214), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp214);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr22), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr23), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr24), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp210);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr25), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr26), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr211), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp211);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr212), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp212);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr27), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr28), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr29), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp29);        
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr21), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr213), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp213);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr214), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp214);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr29), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp29);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr21), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr22), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr23), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr24), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr25), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr26), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr27), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr28), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr29), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp210);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr211), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp211);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr212), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp212);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr213), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp213);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.entr214), 2, MidpointRounding.AwayFromZero), Punterociclo_10.temp214);

                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";
                chart1.Series["Main_Flow"].Points[4].Label = "10";
                chart1.Series["Main_Flow"].Points[5].Label = "5";
                chart1.Series["Main_Flow"].Points[6].Label = "6";
                chart1.Series["Main_Flow"].Points[7].Label = "11";
                chart1.Series["Main_Flow"].Points[8].Label = "12";
                chart1.Series["Main_Flow"].Points[9].Label = "7";
                chart1.Series["Main_Flow"].Points[10].Label = "8";
                chart1.Series["Main_Flow"].Points[11].Label = "9";
                chart1.Series["Main_Flow"].Points[12].Label = "13";
                chart1.Series["Main_Flow"].Points[13].Label = "14";

                //chart1.Series["Recomp_Flow"].Points[1].Label = "10";
            }

            else if (Brayton_cycle_type_variable == 11)
            {
                
            }

            else if (Brayton_cycle_type_variable == 12)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:Temperatures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp212), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp26), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp210), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp211), 1, MidpointRounding.AwayFromZero);

                //DataGridView1:Entrophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.entr212), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.entr22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.entr23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.entr24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.entr25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.entr26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.entr27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.entr28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.entr29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.entr210), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.entr21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.entr211), 2, MidpointRounding.AwayFromZero);

                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr22 - 0.1), 1, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr27 + 0.1), 1, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 0.125;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp21 - 25), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp26 + 25), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Entrophy (kJ/kg K)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Temperature (K)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr212), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp212);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr22), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr23), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr24), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp210);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr25), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr26), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr27), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr28), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr29), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp29);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr21), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr211), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp211);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr212), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp212);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr29), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp29);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr21), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr22), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr23), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr24), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr25), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr26), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr27), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr28), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr29), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr210), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp210);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr211), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp211);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr212), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp212);

                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";
                chart1.Series["Main_Flow"].Points[4].Label = "10";
                chart1.Series["Main_Flow"].Points[5].Label = "5";
                chart1.Series["Main_Flow"].Points[6].Label = "6";
                chart1.Series["Main_Flow"].Points[7].Label = "7";
                chart1.Series["Main_Flow"].Points[8].Label = "8";
                chart1.Series["Main_Flow"].Points[9].Label = "9";
                chart1.Series["Main_Flow"].Points[10].Label = "11";
                chart1.Series["Main_Flow"].Points[11].Label = "12";

                //chart1.Series["Recomp_Flow"].Points[1].Label = "10";
            }
        }

        //Pressuer-Entalphy Diagram
        public void button3_Click(object sender, EventArgs e)
        {
            if (Brayton_cycle_type_variable == 1)
            {
                
            }

            else if (Brayton_cycle_type_variable == 2)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:entheratures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres26), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres210), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres211), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres212), 1, MidpointRounding.AwayFromZero);

                //DataGridView1:enthophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.enth21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.enth22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.enth23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.enth24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.enth25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.enth26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.enth27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.enth28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.enth29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.enth210), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.enth211), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.enth212), 2, MidpointRounding.AwayFromZero);

                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth21 - 50), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth212 + 50), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 1000;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_2.pres21 - 1000), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_2.pres22 + 3000), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Enthalpy (kJ/kg)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Pressure (kPa)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth21), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth22), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth23), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth24), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth25), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth26), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth211), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres211);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth212), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres212);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth27), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth28), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth29), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres29);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth21), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres21);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth29), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres29);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth210), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth21), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth22), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth23), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth24), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth25), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth26), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth27), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth28), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth29), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth210), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres210);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth211), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres211);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.enth212), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres212);

                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";

                chart1.Series["Main_Flow"].Points[4].Label = "5";
                chart1.Series["Main_Flow"].Points[5].Label = "6";
                chart1.Series["Main_Flow"].Points[6].Label = "11";
                chart1.Series["Main_Flow"].Points[7].Label = "12";
                chart1.Series["Main_Flow"].Points[8].Label = "7";
                chart1.Series["Main_Flow"].Points[9].Label = "8";
                chart1.Series["Main_Flow"].Points[10].Label = "9";

                chart1.Series["Recomp_Flow"].Points[1].Label = "10";
            }

            else if (Brayton_cycle_type_variable == 3)
            {
                
            }

            else if (Brayton_cycle_type_variable == 4)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:entheratures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres26), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres210), 1, MidpointRounding.AwayFromZero);
               
                //DataGridView1:enthophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.enth21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.enth22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.enth23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.enth24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.enth25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.enth26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.enth27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.enth28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.enth29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.enth210), 2, MidpointRounding.AwayFromZero);
               
                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth21 - 50), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth26 + 50), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 1000;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_4.pres21 - 1000), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_4.pres22 + 3000), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Enthalpy (kJ/kg)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Pressure (kPa)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth21), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth22), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth23), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth24), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth25), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth26), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth27), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth28), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth29), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres29);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth21), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres21);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth29), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres29);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth210), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth21), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth22), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth23), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth24), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth25), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth26), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth27), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth28), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth29), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.enth210), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres210);
              
                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";

                chart1.Series["Main_Flow"].Points[4].Label = "5";
                chart1.Series["Main_Flow"].Points[5].Label = "6";
                chart1.Series["Main_Flow"].Points[6].Label = "7";
                chart1.Series["Main_Flow"].Points[7].Label = "8";
                chart1.Series["Main_Flow"].Points[8].Label = "9";

                chart1.Series["Recomp_Flow"].Points[1].Label = "10";
            }

            else if (Brayton_cycle_type_variable == 5)
            {
               
            }

            else if (Brayton_cycle_type_variable == 6)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:Temperatures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres26), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres211), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres212), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres210), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[12].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres213), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[13].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres214), 1, MidpointRounding.AwayFromZero);

                //DataGridView1:Entrophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.enth21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.enth22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.enth23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.enth24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.enth25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.enth26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.enth27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.enth211), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.enth212), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.enth28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.enth29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.enth210), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[12].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.enth213), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[13].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.enth214), 2, MidpointRounding.AwayFromZero);

                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth21 - 50), 1, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth26 + 50), 1, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 1000;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_6.pres213 - 3000), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_6.pres26 + 3000), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Enthalpy (kJ/kg)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Pressure (kPa)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth21), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth22), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth23), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth24), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth210), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres210);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth25), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth26), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth211), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres211);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth212), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres212);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth27), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth28), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth29), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres29);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth213), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres213);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth214), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres214);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth21), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres21);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth214), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres214);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth210), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth21), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth22), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth23), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth24), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth210), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres210);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth25), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth26), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth211), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres211);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth212), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres212);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth27), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth28), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth29), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth213), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres213);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.enth214), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres214);

                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";
                chart1.Series["Main_Flow"].Points[4].Label = "10";
                chart1.Series["Main_Flow"].Points[5].Label = "5";
                chart1.Series["Main_Flow"].Points[6].Label = "6";
                chart1.Series["Main_Flow"].Points[7].Label = "11";
                chart1.Series["Main_Flow"].Points[8].Label = "12";
                chart1.Series["Main_Flow"].Points[9].Label = "7";
                chart1.Series["Main_Flow"].Points[10].Label = "8";
                chart1.Series["Main_Flow"].Points[11].Label = "9";
                chart1.Series["Main_Flow"].Points[12].Label = "13";
                chart1.Series["Main_Flow"].Points[13].Label = "14";
            }

            else if (Brayton_cycle_type_variable == 7)
            {
                
            }

            else if (Brayton_cycle_type_variable == 8)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:Temperatures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres26), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres210), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres213), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres214), 1, MidpointRounding.AwayFromZero);

                //DataGridView1:Entrophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.enth21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.enth22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.enth23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.enth24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.enth25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.enth26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.enth27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.enth28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.enth29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.enth210), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.enth213), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.enth214), 2, MidpointRounding.AwayFromZero);

                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth21 - 50), 1, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth26 + 50), 1, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 1000;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_8.pres213 - 3000), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_8.pres26 + 3000), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Enthalpy (kJ/kg)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Pressure (kPa)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth21), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth22), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth23), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth24), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth210), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres210);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth25), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth26), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth27), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth28), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth29), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres29);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth213), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres213);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth214), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres214);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth21), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres21);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth214), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres214);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth210), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth21), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth22), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth23), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth24), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth210), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres210);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth25), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth26), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth27), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth28), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth29), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth213), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres213);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.enth214), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres214);

                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";
                chart1.Series["Main_Flow"].Points[4].Label = "10";
                chart1.Series["Main_Flow"].Points[5].Label = "5";
                chart1.Series["Main_Flow"].Points[6].Label = "6";
                chart1.Series["Main_Flow"].Points[7].Label = "7";
                chart1.Series["Main_Flow"].Points[8].Label = "8";
                chart1.Series["Main_Flow"].Points[9].Label = "9";
                chart1.Series["Main_Flow"].Points[10].Label = "11";
                chart1.Series["Main_Flow"].Points[11].Label = "12";
            }

            else if (Brayton_cycle_type_variable == 9)
            {
                
            }

            else if (Brayton_cycle_type_variable == 10)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:Temperatures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres214), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres26), 1, MidpointRounding.AwayFromZero);                
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres210), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres211), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres212), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[12].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[13].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres213), 1, MidpointRounding.AwayFromZero);

                //DataGridView1:Entrophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.enth214), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.enth22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.enth23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.enth24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.enth25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.enth26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.enth27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.enth28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.enth29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.enth210), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.enth211), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.enth212), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[12].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.enth21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[13].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.enth213), 2, MidpointRounding.AwayFromZero);

                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth22 - 50), 1, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth212 + 50), 1, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 1000;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_10.pres21 - 1000), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_10.pres22 + 3000), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Enthalpy (kJ/kg)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Pressure (kPa)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth214), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres214);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth22), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth23), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth24), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth210), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres210);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth25), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth26), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth211), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres211);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth212), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres212);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth27), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth28), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth29), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres29);        
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth21), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth213), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres213);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth214), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres214);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth29), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres29);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth210), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth21), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth22), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth23), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth24), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth25), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth26), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth27), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth28), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth29), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth210), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres210);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth211), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres211);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth212), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres212);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth213), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres213);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.enth214), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres214);

                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";
                chart1.Series["Main_Flow"].Points[4].Label = "10";
                chart1.Series["Main_Flow"].Points[5].Label = "5";
                chart1.Series["Main_Flow"].Points[6].Label = "6";
                chart1.Series["Main_Flow"].Points[7].Label = "11";
                chart1.Series["Main_Flow"].Points[8].Label = "12";
                chart1.Series["Main_Flow"].Points[9].Label = "7";
                chart1.Series["Main_Flow"].Points[10].Label = "8";
                chart1.Series["Main_Flow"].Points[11].Label = "9";
                chart1.Series["Main_Flow"].Points[12].Label = "13";
                chart1.Series["Main_Flow"].Points[13].Label = "14";

                //chart1.Series["Recomp_Flow"].Points[1].Label = "10";
            }

            else if (Brayton_cycle_type_variable == 11)
            {
                
            }

            else if (Brayton_cycle_type_variable == 12)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:Temperatures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres212), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres26), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres210), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres211), 1, MidpointRounding.AwayFromZero);

                //DataGridView1:Entrophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.enth212), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.enth22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.enth23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.enth24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.enth25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.enth26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.enth27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.enth28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.enth29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.enth210), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.enth21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.enth211), 2, MidpointRounding.AwayFromZero);

                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth22 - 50), 1, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth26 + 50), 1, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 1000;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_12.pres21 - 1000), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_12.pres26 + 3000), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Enthalpy (kJ/kg)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Pressure (kPa)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth212), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres212);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth22), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth23), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth24), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth25), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth26), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth27), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth28), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth29), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres29);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth21), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth211), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres211);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth212), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres212);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth29), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres29);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth210), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth21), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth22), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth23), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth24), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth25), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth26), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth27), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth28), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth29), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth210), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres210);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.enth211), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres211);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr212), 2, MidpointRounding.AwayFromZero), Punterociclo_12.temp212);

                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";
                chart1.Series["Main_Flow"].Points[4].Label = "5";
                chart1.Series["Main_Flow"].Points[5].Label = "6";
                chart1.Series["Main_Flow"].Points[6].Label = "7";
                chart1.Series["Main_Flow"].Points[7].Label = "8";
                chart1.Series["Main_Flow"].Points[8].Label = "9";
                chart1.Series["Main_Flow"].Points[9].Label = "11";
                chart1.Series["Main_Flow"].Points[10].Label = "12";

                chart1.Series["Recomp_Flow"].Points[1].Label = "10";
            }
        }

        //Pressure-Temperature Diagram
        public void button4_Click(object sender, EventArgs e)
        {
            if (Brayton_cycle_type_variable == 1)
            {

            }

            else if (Brayton_cycle_type_variable == 2)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:Temperatures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres26), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres210), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres211), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.pres212), 1, MidpointRounding.AwayFromZero);

                //DataGridView1:tempophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp210), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp211), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_2.temp212), 2, MidpointRounding.AwayFromZero);

                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp21 - 25), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp212 + 25), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 1000;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_2.pres21 - 1000), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_2.pres22 + 3000), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Temperature (K)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Pressure (kPa)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp21), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp22), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp23), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp24), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp25), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp26), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp211), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres211);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp212), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres212);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp27), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp28), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp29), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres29);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp21), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres21);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp29), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres29);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp210), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp21), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp22), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp23), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp24), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp25), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp26), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp27), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp28), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp29), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp210), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres210);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp211), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres211);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_2.temp212), 2, MidpointRounding.AwayFromZero), Punterociclo_2.pres212);

                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";

                chart1.Series["Main_Flow"].Points[4].Label = "5";
                chart1.Series["Main_Flow"].Points[5].Label = "6";
                chart1.Series["Main_Flow"].Points[6].Label = "11";
                chart1.Series["Main_Flow"].Points[7].Label = "12";
                chart1.Series["Main_Flow"].Points[8].Label = "7";
                chart1.Series["Main_Flow"].Points[9].Label = "8";
                chart1.Series["Main_Flow"].Points[10].Label = "9";

                chart1.Series["Recomp_Flow"].Points[1].Label = "10";          
            }

            else if (Brayton_cycle_type_variable == 3)
            {
               
            }

            else if (Brayton_cycle_type_variable == 4)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:Temperatures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres26), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.pres210), 1, MidpointRounding.AwayFromZero);
              
                //DataGridView1:tempophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_4.temp210), 2, MidpointRounding.AwayFromZero);
            
                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp21 - 25), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp26 + 25), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 1000;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_4.pres21 - 1000), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_4.pres22 + 3000), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Temperature (K)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Pressure (kPa)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp21), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp22), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp23), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp24), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp25), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp26), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp27), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp28), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp29), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres29);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp21), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres21);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp29), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres29);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp210), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp21), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp22), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp23), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp24), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp25), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp26), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp27), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp28), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp29), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_4.temp210), 2, MidpointRounding.AwayFromZero), Punterociclo_4.pres210);
          
                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";

                chart1.Series["Main_Flow"].Points[4].Label = "5";
                chart1.Series["Main_Flow"].Points[5].Label = "6";
                chart1.Series["Main_Flow"].Points[6].Label = "7";
                chart1.Series["Main_Flow"].Points[7].Label = "8";
                chart1.Series["Main_Flow"].Points[8].Label = "9";

                chart1.Series["Recomp_Flow"].Points[1].Label = "10";
            }

            else if (Brayton_cycle_type_variable == 5)
            {
                
            }

            else if (Brayton_cycle_type_variable == 6)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:Temperatures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres26), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres211), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres212), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres210), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[12].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres213), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[13].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.pres214), 1, MidpointRounding.AwayFromZero);

                //DataGridView1:Entrophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp211), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp212), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp210), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[12].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp213), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[13].Value = decimal.Round(Convert.ToDecimal(Punterociclo_6.temp214), 2, MidpointRounding.AwayFromZero);

                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp21 - 50), 1, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp26 + 50), 1, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 1000;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_6.pres213 - 3000), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_6.pres26 + 3000), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Temperature (K)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Pressure (kPa)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp21), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp22), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp23), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp24), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp210), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres210);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp25), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp26), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp211), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres211);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp212), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres212);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp27), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp28), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp29), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres29);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp213), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres213);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp214), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres214);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp21), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres21);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp214), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres214);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp210), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp21), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp22), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp23), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp24), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp210), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres210);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp25), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp26), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp211), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres211);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp212), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres212);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp27), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp28), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp29), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp213), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres213);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_6.temp214), 2, MidpointRounding.AwayFromZero), Punterociclo_6.pres214);

                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";
                chart1.Series["Main_Flow"].Points[4].Label = "10";
                chart1.Series["Main_Flow"].Points[5].Label = "5";
                chart1.Series["Main_Flow"].Points[6].Label = "6";
                chart1.Series["Main_Flow"].Points[7].Label = "11";
                chart1.Series["Main_Flow"].Points[8].Label = "12";
                chart1.Series["Main_Flow"].Points[9].Label = "7";
                chart1.Series["Main_Flow"].Points[10].Label = "8";
                chart1.Series["Main_Flow"].Points[11].Label = "9";
                chart1.Series["Main_Flow"].Points[12].Label = "13";
                chart1.Series["Main_Flow"].Points[13].Label = "14";
            }

            else if (Brayton_cycle_type_variable == 7)
            {
               
            }

            else if (Brayton_cycle_type_variable == 8)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:Temperatures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres26), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres210), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres213), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.pres214), 1, MidpointRounding.AwayFromZero);

                //DataGridView1:Entrophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp210), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp213), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_8.temp214), 2, MidpointRounding.AwayFromZero);

                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp21 - 50), 1, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp26 + 50), 1, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 1000;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_8.pres213 - 3000), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_8.pres26 + 3000), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Temperature (K)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Pressure (kPa)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp21), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp22), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp23), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp24), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp210), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres210);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp25), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp26), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp27), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp28), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp29), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres29);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp213), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres213);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp214), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres214);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp21), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres21);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp214), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres214);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp210), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp21), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp22), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp23), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp24), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp210), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres210);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp25), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp26), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp27), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp28), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp29), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp213), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres213);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_8.temp214), 2, MidpointRounding.AwayFromZero), Punterociclo_8.pres214);

                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";
                chart1.Series["Main_Flow"].Points[4].Label = "10";
                chart1.Series["Main_Flow"].Points[5].Label = "5";
                chart1.Series["Main_Flow"].Points[6].Label = "6";
                chart1.Series["Main_Flow"].Points[7].Label = "7";
                chart1.Series["Main_Flow"].Points[8].Label = "8";
                chart1.Series["Main_Flow"].Points[9].Label = "9";
                chart1.Series["Main_Flow"].Points[10].Label = "11";
                chart1.Series["Main_Flow"].Points[11].Label = "12";
            }

            else if (Brayton_cycle_type_variable == 9)
            {
               
            }

            else if (Brayton_cycle_type_variable == 10)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:Temperatures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres214), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres26), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres210), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres211), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres212), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[12].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[13].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.pres213), 1, MidpointRounding.AwayFromZero);

                //DataGridView1:Entrophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp214), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp210), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp211), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp212), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[12].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[13].Value = decimal.Round(Convert.ToDecimal(Punterociclo_10.temp213), 2, MidpointRounding.AwayFromZero);

                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp22 - 50), 1, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp212 + 50), 1, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 1000;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_10.pres21 - 1000), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_10.pres22 + 3000), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Temperature (K)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Pressure (kPa)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp214), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres214);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp22), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp23), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp24), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp210), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres210);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp25), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp26), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp211), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres211);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp212), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres212);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp27), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp28), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp29), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres29);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp21), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp213), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres213);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp214), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres214);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp29), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres29);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp210), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp21), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp22), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp23), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp24), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp25), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp26), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp27), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp28), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp29), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp210), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres210);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp211), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres211);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp212), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres212);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp213), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres213);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_10.temp214), 2, MidpointRounding.AwayFromZero), Punterociclo_10.pres214);

                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";
                chart1.Series["Main_Flow"].Points[4].Label = "10";
                chart1.Series["Main_Flow"].Points[5].Label = "5";
                chart1.Series["Main_Flow"].Points[6].Label = "6";
                chart1.Series["Main_Flow"].Points[7].Label = "11";
                chart1.Series["Main_Flow"].Points[8].Label = "12";
                chart1.Series["Main_Flow"].Points[9].Label = "7";
                chart1.Series["Main_Flow"].Points[10].Label = "8";
                chart1.Series["Main_Flow"].Points[11].Label = "9";
                chart1.Series["Main_Flow"].Points[12].Label = "13";
                chart1.Series["Main_Flow"].Points[13].Label = "14";

                //chart1.Series["Recomp_Flow"].Points[1].Label = "10";
            }

            else if (Brayton_cycle_type_variable == 11)
            {
                
            }

            else if (Brayton_cycle_type_variable == 12)
            {
                chart1.Series.Clear();
                chart1.Series.Add("Main_Flow");
                chart1.Series.Add("Recomp_Flow");
                chart1.Series.Add("Points_Values");

                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();

                //DataGridView2:Temperatures (K)
                dataGridView2.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres212), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres22), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres23), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres24), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres25), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres26), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres27), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres28), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres29), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres210), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres21), 1, MidpointRounding.AwayFromZero);
                dataGridView2.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.pres211), 1, MidpointRounding.AwayFromZero);

                //DataGridView1:Entrophies (kJ/Kg K)
                dataGridView1.Rows[0].Cells[0].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp212), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[1].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp22), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[2].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp23), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[3].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp24), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[4].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp25), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[5].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp26), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[6].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp27), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[7].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp28), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[8].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp29), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[9].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp210), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[10].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp21), 2, MidpointRounding.AwayFromZero);
                dataGridView1.Rows[0].Cells[11].Value = decimal.Round(Convert.ToDecimal(Punterociclo_12.temp211), 2, MidpointRounding.AwayFromZero);

                // Set series chart type
                chart1.Series["Main_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Main_Flow"].BorderWidth = 2;

                chart1.Series["Recomp_Flow"].ChartType = SeriesChartType.Line;
                chart1.Series["Recomp_Flow"].BorderWidth = 2;

                chart1.Series["Points_Values"].ChartType = SeriesChartType.Point;
                chart1.Series["Points_Values"].MarkerSize = 8;
                chart1.Series["Points_Values"].MarkerStyle = MarkerStyle.Diamond;

                chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp21 - 25), 1, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisX.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp26 + 25), 1, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 50;
                chart1.ChartAreas["ChartArea1"].AxisX.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Interval = 1000;
                chart1.ChartAreas["ChartArea1"].AxisY.RoundAxisValues();

                chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_12.pres21 - 1000), 0, MidpointRounding.AwayFromZero));
                chart1.ChartAreas["ChartArea1"].AxisY.Maximum = Convert.ToDouble(decimal.Round(Convert.ToDecimal(Punterociclo_12.pres26 + 3000), 0, MidpointRounding.AwayFromZero));

                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Temperature (K)";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Pressure (kPa)";

                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp212), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres212);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp22), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres22);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp23), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres23);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp24), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres24);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp25), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres25);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp26), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres26);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp27), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres27);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp28), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres28);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp29), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres29);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp21), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres21);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp211), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres211);
                chart1.Series["Main_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp212), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres212);

                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp29), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres29);
                chart1.Series["Recomp_Flow"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp210), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres210);

                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp21), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres21);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp22), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres22);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp23), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres23);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp24), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres24);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp25), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres25);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp26), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres26);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp27), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres27);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp28), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres28);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp29), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres29);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp210), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres210);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.temp211), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres211);
                chart1.Series["Points_Values"].Points.AddXY(decimal.Round(Convert.ToDecimal(Punterociclo_12.entr212), 2, MidpointRounding.AwayFromZero), Punterociclo_12.pres212);

                chart1.Series["Main_Flow"].Points[0].Label = "1";
                chart1.Series["Main_Flow"].Points[1].Label = "2";
                chart1.Series["Main_Flow"].Points[2].Label = "3";
                chart1.Series["Main_Flow"].Points[3].Label = "4";
                chart1.Series["Main_Flow"].Points[4].Label = "5";
                chart1.Series["Main_Flow"].Points[5].Label = "6";
                chart1.Series["Main_Flow"].Points[6].Label = "7";
                chart1.Series["Main_Flow"].Points[7].Label = "8";
                chart1.Series["Main_Flow"].Points[8].Label = "9";
                chart1.Series["Main_Flow"].Points[9].Label = "11";
                chart1.Series["Main_Flow"].Points[10].Label = "12";

                chart1.Series["Recomp_Flow"].Points[1].Label = "10";
            }
        }
    }
}
