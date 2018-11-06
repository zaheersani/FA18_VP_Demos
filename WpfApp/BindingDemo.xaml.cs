using System.Windows;

using ConsoleApp;
using System.Collections.Generic;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for BindingDemo.xaml
    /// </summary>
    public partial class BindingDemo : Window
    {
        Student s1 = new Student()
        {
            FirstName = "Talha",
            LastName = "Iqbal",
            Department = "Computer Science",
            RegistrationNo = new RegNo()
            {
                Session = Session.Fall,
                Year = 12,
                Program = "BCS",
                RollNo = "006"
            }
        };
        Student s2 = new Student()
        {
            FirstName = "Ahmed",
            LastName = "Ali",
            Department = "Computer Science",
            RegistrationNo = new RegNo()
            {
                Session = Session.Fall,
                Year = 11,
                Program = "BSE",
                RollNo = "123"
            }
        };
        List<Student> sList = new List<Student>();
        public BindingDemo()
        {
            InitializeComponent();
            sList.Add(s1);
            sList.Add(s2);
            this.DataContext = s1;
            this.listboxStudents.ItemsSource = sList;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(s1.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Add item into list from text fields
            Student s1 = new Student()
            {
                FirstName = this.txtNameForListBox.Text,
                LastName = "Iqbal",
                Department = "Computer Science",
                RegistrationNo = new RegNo()
                {
                    Session = Session.Fall,
                    Year = 12,
                    Program = "BCS",
                    RollNo = "006"
                }
            };
            // Add this Student object into Students list
            sList.Add(s1);
            // Refresh Items of ListBox to update UI
            this.listboxStudents.Items.Refresh();
        }

        private void listboxStudents_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            MessageBox.Show(((Student)this.listboxStudents.SelectedItem).ToString());
        }
    }
}
