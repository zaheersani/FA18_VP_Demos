using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ConsoleApp;

namespace WinFormApp
{
    public partial class StudentProfile : Form
    {
        public StudentProfile()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Student sObj = new Student()
            {
                Name = this.txtName.Text
            };
            MessageBox.Show("Student Name: " + sObj.Name);
        }
    }
}
