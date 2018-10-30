using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;

using ConsoleApp;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for LINQBasics.xaml
    /// </summary>
    public partial class LINQBasics : Window
    {
        public LINQBasics()
        {
            InitializeComponent();
            //this.LINQIntExample();
            //this.LINQStringExample();
            this.LINQUserDefined();

        }
        public void LINQUserDefined()
        {
            List<Student> sList = new List<Student>()
            {
                new Student() 
                { 
                    FirstName = "Talha", RegistrationNo = new RegNo { Session = Session.Fall, Program="BCS",Year=10,RollNo="098"}
                },
                new Student() 
                { 
                    FirstName = "Ahmed", RegistrationNo = new RegNo { Session = Session.Spring, Program="BSE",Year=10,RollNo="100"}
                },
                new Student() 
                { 
                    FirstName = "Zafar", RegistrationNo = new RegNo { Session = Session.Fall, Program="BCS",Year=11,RollNo="008"}
                }
            };

            IEnumerable<Student> rs = from s in sList
                                      where s.RegistrationNo.Session == Session.Fall
                                      orderby s.FirstName descending
                                      select s;

            foreach (var item in rs)
            {
                Console.WriteLine(item);
            }

        }
        public void LINQStringExample()
        {
            List<string> words = new List<string>()
            {
                "visual", "studio", "samoosay", "tea" , "spring", "nashta", "paratha",
                "coke", "5 min break"
            };
            IEnumerable<string> r = from w in words
                                    where w.Contains("samoos") || w.StartsWith("tea")
                                    || w.StartsWith("vis")
                                    orderby w
                                    select w;
            foreach (var item in r)
            {
                Console.WriteLine(item);
            }
        }
        public void LINQIntExample()
        {
            int[] nums = new int[] { 2, 3, 3, 2, 34, 2, 67, 8, 9, 99, 90, 22, 33, 445, 5, 312 };
            IEnumerable<int> res = from n in nums
                                   where n > 10 && n < 1000 && n % 2 == 0
                                   orderby n descending
                                   select n;
            foreach (int item in res)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Max Val:" + res.Max());
            Console.WriteLine("Min Val:" + res.Min());
            Console.WriteLine("Avg Val:" + res.Average());
        }
    }
}

