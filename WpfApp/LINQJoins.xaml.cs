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
    /// Interaction logic for LINQJoins.xaml
    /// </summary>
    public partial class LINQJoins : Window
    {
        public LINQJoins()
        {
            InitializeComponent();
            DataClassesHospitalDBDataContext dc = new DataClassesHospitalDBDataContext();

            // Show data from Doctors Entity
            this.gridDoctors.ItemsSource = dc.Doctors;

            // Show data from Patients Entity
            this.gridPatients.ItemsSource = dc.Patients;

            // Show data from Appointments Entity
            this.gridAppointment.ItemsSource = dc.Appointments;

            // Show data of Appointments using Navigation Style Joins
            var result = from a in dc.Appointments
                    select new
                    {
                        AppID = a.Id,
                        // Navigate from Appointment Entity to Doctor Entity and Retrive Doctor ID
                        DoctorID = a.Doctor.Id,
                        // Navigate from Appointment Entity to Doctor Entity and Retrive Doctor Name
                        Doctor = a.Doctor.Name,
                        a.Doctor.Specialization,
                        PatientID = a.Patient.Id,
                        Patient = a.Patient.Name,
                        PatientPhone = a.Patient.Contact,
                        a.AppointmentDate,
                        a.AppointmentTime
                    };

            this.gridAppointmentJoins.ItemsSource = result;
        }
    }
}
