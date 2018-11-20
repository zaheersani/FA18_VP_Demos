using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Create Employee class with Name, Department inline properties of type string and a List of type 
 * Task (Task is of type Structure with Code, Priority and Description properties). 
 * Employee class also contains an indexer which returns a Task object. 
 * It takes Task Code as int, searches in Task list using Find method of List and returns Task object. 
 * You are required to write C# code for Employee class only.
 *
*/

namespace ConsoleApp
{
    class Employee2
    {
        public string Name { get; set; }
        public string Department { get; set; }
        List<Tasks> tList = new List<Tasks>();

        public Tasks this[int index]
        {
            get
            {
                return this.tList.Find(t => t.Code == index);
            }
        }
    }

    struct Tasks
    {
        public int Code { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }
    }

}
