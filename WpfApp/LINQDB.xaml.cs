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

        }
    }
}
