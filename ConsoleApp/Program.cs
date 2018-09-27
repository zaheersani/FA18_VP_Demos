using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
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
                RegNo = "SP15-BCS-098"
            };
            Student s3 = new Student()
            {
                FirstName = "Abc",
                LastName = "xyz",
                RegNo = "SP15-BCS-098"
            };
            Student s2 = new Student();

            Person p = s1;
            p = new Employee()
            {
                FirstName = "Zaheer",
                Designation = "Lecturer"
            };

            Console.WriteLine(p.ConvertToString());

            Console.WriteLine(s1.isEqual(s2));
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
