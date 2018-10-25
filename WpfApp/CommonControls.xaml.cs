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
using System.Windows.Navigation;
using System.Windows.Shapes;

using ConsoleApp;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.StudentGrid.Visibility = Visibility.Visible;
            this.Buttons.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.StudentGrid.Visibility = Visibility.Hidden;
            this.Buttons.Visibility = Visibility.Visible;
            //if (MessageBoxResult.Yes == 
            //    MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButton.YesNoCancel, MessageBoxImage.Information, MessageBoxResult.Cancel))
            //{
            //    MessageBox.Show("Deleting all files");
            //}
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            RegNo r = new RegNo()
            {
                Program = "BCS",
                RollNo = this.txtRegNo.Text,
                Session = Session.Spring,
                Year = 11
            };
            this.list.Items.Add(new Student()
            {
                FirstName = this.txtName.Text,
                RegistrationNo = r
            });
        }
    }
}
