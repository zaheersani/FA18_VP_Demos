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
    public partial class CommonControls : Form
    {
        public CommonControls()
        {
            InitializeComponent();
            
            //MessageBox.Show(this.grpGender.Controls.Count.ToString());
            //foreach (RadioButton radio in this.grpGender.Controls)
            //{
            //    MessageBox.Show(radio.Text + " is Checked? " + radio.Checked);
            //}
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (this.openFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(this.openFD.FileName);
                //MessageBox.Show(this.openFD.FileName);
            }
        }
    }
}
