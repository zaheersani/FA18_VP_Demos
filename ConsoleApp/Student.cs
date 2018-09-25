using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Student
    {
        private string name;
        private string regno;
        private int age;

        /// <summary>
        /// Inline Property without declaring any variable
        /// </summary>
        public string Address { get; set; }

        public Student()
        {
            this.name = this.regno = "";
            this.age = 0;
        }

        public Student(string Name, string RegNo, int Age)
        {
            this.name = Name;
            this.regno = RegNo;
            this.age = Age;
            this.Address = "Some Fixed Address";
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != null)
                {
                    if(value.Length > 0)
                        this.name = value;
                }
            }
        }
    }
}
