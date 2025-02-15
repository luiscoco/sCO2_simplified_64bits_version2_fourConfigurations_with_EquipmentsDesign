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
    public partial class PTC_SF_PHX_Data_Input : Form
    { 
        public int tipo_sensing_dialogue;
        public string Solar_Field_Type;

        public PTC_SF_PHX_Data_Input()
        {
            InitializeComponent();
        }

        //OK Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (Solar_Field_Type == "Main_SF")
            {

            }

            else if (Solar_Field_Type == "ReHeating_SF")
            {

            }
                      
            this.Dispose();
        }
    }
}
