using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class FormCalc : Form
    {
        /*
         * TODO: Create Subtract, Division and Multiplication Buttons
         * Create Event Handlers for each button and Add functionality
        */
        public FormCalc()
        {
            InitializeComponent();
            this.txtVal1.Text = "10";
            this.txtVal2.Text = "20";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            //string str = "123A"
            //int res;
            //if (int.TryParse(str, out res))
            //    Console.WriteLine("Parsed Val: " + res);
            //else
            //    Console.WriteLine("Couldn't Parsed Val: " + str);

            int v1, v2;
            if (int.TryParse(this.txtVal1.Text, out v1)
                && int.TryParse(this.txtVal2.Text, out v2))
            {
                this.lblResult.Text = (v1 + v2).ToString();
            }
            else
            {
                MessageBox.Show("Input Values are not a Number");
            }
        }

        private void txtVal1_Leave(object sender, EventArgs e)
        {
            int v1;
            if (!int.TryParse(this.txtVal1.Text, out v1))
            {
                this.txtVal1.Focus();
                this.txtVal1.BackColor = Color.Red;
            }
            else
            {
                this.txtVal1.BackColor = Color.White;
            }
        }
    }
}

