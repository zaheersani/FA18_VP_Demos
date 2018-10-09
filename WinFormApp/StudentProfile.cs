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
            Student s1 = new Student()
            {
                FirstName = "Talha",
                LastName = "Iqbal",
                RegistrationNo = new RegNo()
                {
                    Session = Session.Fall,
                    Year = 12,
                    Program = "BCS",
                    RollNo = "006"
                }
            };
            List<Student> sList = new List<Student>();
            sList.Add(s1);
            this.dataGridView1.DataSource = sList.ToList();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Student sObj = new Student()
            //{
            //    Name = this.txtName.Text
            //};
            //MessageBox.Show("Student Name: " + sObj.Name);
        }
    }
}
