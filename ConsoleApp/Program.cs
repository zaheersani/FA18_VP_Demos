using System.Collections.Generic;
using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            (new Activity()).WhatToDoToday(DayOfWeek.Sunday);
            Console.ReadKey();
            return;

            Box b1 = new Box()
            {
                Breadth = 50, Height = 50, Length = 50
            };

            Box b2 = new Box()
            {
                Breadth = 50,
                Height = 50,
                Length = 50
            };

            if (b1 == b2)
                Console.WriteLine("Both Boxes are indentical");
            else
                Console.WriteLine("Both Boxes are NOT indentical");
            Console.ReadKey();
            return;

            Contact c1 = new Contact()
            {
                Name = "Ahmed Ali", Number = "03334243242"
            };
            Contact c2 = new Contact()
            {
                Name = "Muhammad Ahmed Khan",
                Number = "0334890808"
            };
            PhoneBook phBookObj = new PhoneBook();
            phBookObj.AddContact(c1);
            phBookObj.AddContact(c2);
            phBookObj.AddContact(new Contact() 
            { 
                Name = "Ali Hasnain", Number = "030032432424"
            });
            foreach (Contact item in phBookObj.GetAllContacts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Accessing through indexes!");
            Console.WriteLine(phBookObj["ALI"]);
            
            Console.WriteLine("Number Search indexes!");
            List<Contact> cList = phBookObj["033", ContactFilter.Number];
            foreach (Contact item in cList)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
            return;

            Program p = new Program();
            p.ClassesTest();
            Console.ReadKey();
            return;

            Console.WriteLine("My First C# Program!");
            Console.WriteLine("No. of Arguments: " + args.Length);

            if (args.Length > 0)
            {
                if (args[0] == "BCS6A" && args[1] == "SP15")
                    Console.WriteLine("You have unlocked this class!");
            }
            Console.ReadKey();
        }

        public void ClassesTest()
        {
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
            
            Console.WriteLine(s1);

            Student s3 = new Student()
            {
                FirstName = "Abc",
                LastName = "xyz",
                RegistrationNo = new RegNo()
                {
                    Session = Session.Spring,
                    Year = 12,
                    Program = "BSE",
                    RollNo = "006"
                }
            };

            Student s2 = new Student();

            Person p = s1;
            p = new Employee()
            {
                FirstName = "Zaheer",
                Designation = "Lecturer"
            };

            Console.WriteLine(p.ConvertToString());

            //Console.WriteLine(s1.isEqual(s2));
            return;
            
            Console.WriteLine(s1.ToString());
            Console.WriteLine(s2.ToString());
            //Student s1 = new Student("Saira","SP16-BCS-008",21);
            //Student s2 = new Student("Talha", "SP16-BCS-012", 21);
            //s1.Address = "Some address";
            //Console.WriteLine("Name of student1: " + s1.Name);
            //Console.WriteLine("Address " + s1.Address);

            //s1.Name = Console.ReadLine();
            //Console.WriteLine("Name of student1 after Modification: " + s1.Name);
        }

    }
}
