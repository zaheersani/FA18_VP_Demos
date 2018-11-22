using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for LINQDB.xaml
    /// </summary>
    public partial class LINQDB : Window
    {
        public LINQDB()
        {
            InitializeComponent();
            DataClassesHospitalDBDataContext dc = new DataClassesHospitalDBDataContext();
            //IEnumerable<user> r = from u in dc.users
            //                      //where u.username.StartsWith("a")
            //                      select u;

            var r = from u in dc.users
                    select new
                    {
                        UserID = u.Id,
                        u.Name,
                        UserName = u.username,
                        u.pwd,
                        u.email
                    };
            foreach (var item in r)
            {
                Console.WriteLine(item.UserName);
            }
            this.gridUsers.ItemsSource = r;

            // Display Data of an entire table as it is in grid
            //this.gridUsers.ItemsSource = dc.users;

            // Display Doctors record on grid
            // Display only Name and Specialization of the doctor
            var docRes = from d in dc.Doctors
                         select new
                         {
                             d.Name,
                             d.Specialization
                         };
            this.gridDoctors.ItemsSource = docRes;
        }

        /// <summary>
        /// Insert a new doctor into the database.
        /// Take user input from text fields input.
        /// Note: Changes into databse will not appear if database file always copies into output directory.
        /// Select Database file -> Properties -> Copy to Output Directory = Copy if newer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddDoctor_Click(object sender, RoutedEventArgs e)
        {
            Doctor d = new Doctor()
            {
                Name = this.txtName.Text,
                Specialization = this.txtSpec.Text
            };

            DataClassesHospitalDBDataContext dc = new DataClassesHospitalDBDataContext();
            dc.Doctors.InsertOnSubmit(d);
            dc.SubmitChanges();

            this.gridDoctors.ItemsSource = dc.Doctors;
        }

        /// <summary>
        /// Select an object from database and modify it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            // Create DataContext object
            DataClassesHospitalDBDataContext dc = new DataClassesHospitalDBDataContext();

            // Find a single record from database using LINQ using SingleOrDefault method
            // SingleOrDefault will return a single Doctor object (if found) or Null when object was not found
            Doctor docResult = (from d in dc.Doctors
                                where d.Id == 1
                                select d).SingleOrDefault();

            // Modify Doctor object if an object/record found
            if (docResult != null)
            {
                // Modify Object
                // LINQ tracks the object changes
                docResult.Name = "Dr. Updated Doc";
                // Save changes into database
                dc.SubmitChanges();
                // Update Grid to view changes
                this.gridDoctors.ItemsSource = dc.Doctors;
                MessageBox.Show("Doctor Name updated!");
            }
            else
            {
                MessageBox.Show("Doctor Does Not Exist!");
            }

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            DataClassesHospitalDBDataContext dc = new DataClassesHospitalDBDataContext();

            // Select a single object from database 
            Doctor docResult = (from d in dc.Doctors
                                where d.Id == 1
                                select d).SingleOrDefault();

            // Delete if object exists in database
            if (docResult != null)
            {
                // Remove object from Doctors collection
                dc.Doctors.DeleteOnSubmit(docResult);
                // Save changes into database
                dc.SubmitChanges();
                // Update grid to view changes
                this.gridDoctors.ItemsSource = dc.Doctors;
                MessageBox.Show("Doctor " + docResult.Name + " Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Doctor Does Not Exist!");
            }

        }
    }
}
