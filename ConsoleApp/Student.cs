using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public interface IPerson<T>
    {
        bool isEqual(T obj);
    }

    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Age { get; set; }
        public string Address { get; set; }

        public Person()
        {
            this.FirstName = this.LastName = "Dummy Name";
        }

        public Person(string FirstName, string LastName, DateTime Age, string Address)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Address = Address;
        }

        /// <summary>
        /// This should provide me string representation of the object
        /// </summary>
        /// <returns>String representation of the object</returns>
        public abstract string ConvertToString();

    }

    public class Student : Person, IPerson<Student>
    {
        public string RegNo { get; set; }
        public string Department { get; set; }

        public Student() : base()
        {
            this.RegNo = this.Department = "Not Initialized";
        }

        public Student(string FirstName, string LastName, DateTime Age, string Address, string RegNo, string Department)
            : base(FirstName,LastName,Age,Address)
        {
            this.RegNo = RegNo;
            this.Department = Department;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + "\n" + this.RegNo;
        }

        public bool isEqual(Student sObj)
        {
            if(this.RegNo == sObj.RegNo)
                return true;
            return false;
        }

        public override string ConvertToString()
        {
            return this.ToString();
        }
    }

    public class Employee : Person, IPerson<Employee>
    {
        public string Department { get; set; }
        public string Designation { get; set; }

        public bool isEqual(Employee emp)
        {
            if (this.Department == emp.Department)
                return true;
            return false;
        }

        public override string ConvertToString()
        {
            return this.FirstName + " " + this.Designation;
        }
    }

    public class Parent
    {
        //TODO: Parent Class!
        //Complete the implementation of Parent class
        //Make it derived class and implement interface
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
