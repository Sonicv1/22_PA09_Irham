using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_Irham_PA09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {

            try
            {
                double AmountEntered;
                double convertedvalue;

                if ((btn_USD.Checked == false) || (btn_JPYen.Checked = false))
                {
                    txtBx_Value.Text = "Select atleast one type of currency to convert";
                }
                if (btn_JPYen.Checked == true)
                {
                    AmountEntered = double.Parse(txtBx_Amount.Text);
                    convertedvalue = AmountEntered * 0.81;

                    txtBx_Value.Text = convertedvalue.ToString();
                }
                else if (btn_USD.Checked == true)
                {
                    AmountEntered = double.Parse(txtBx_Amount.Text);
                    convertedvalue = AmountEntered * 0.74;

                    txtBx_Value.Text = convertedvalue.ToString();
                }
            }
            catch (Exception)
            {
                txtBx_Value.Text = "Please enter a valid amount";
            }
        
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBx_Amount.Text = "";
            txtBx_Value.Text = "";
        }

        private void txtBx_Amount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
