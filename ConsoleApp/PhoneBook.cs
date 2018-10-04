using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    enum ContactFilter { Name, Number, Email, Address }
    class PhoneBook
    {
        private List<Contact> cList;

        public PhoneBook()
        {
            this.cList = new List<Contact>();
        }
        public void AddContact(Contact contactObj)
        {
            this.cList.Add(contactObj);
        }
        public List<Contact> GetAllContacts
        {
            get
            {
                return this.cList;
            }
        }

        public string this[int index] 
        {
            get
            {
                return this.cList[index].Name;
            }
            set
            {
                //TODO: Fix it
                //this.cList[index].Name = value;
            }
        }

        public Contact this[string name]
        {
            get
            {
                foreach (Contact item in this.cList)
                {
                    if (item.Name.ToLower().Contains(name.ToLower()))
                        return item;
                }
                return new Contact();
            }
        }
        public List<Contact> this[string number, ContactFilter filter]
        {
            get
            {
                //TODO: Search by Number
                //TODO: Search by Email
                //Use ContactFilter enum to make a decision
                if (filter == ContactFilter.Number)
                {
                    return this.cList.FindAll(x => x.Number.StartsWith(number));
                }
                return new List<Contact>();
            }
        }
    }

    public struct Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return this.Name + ", " + this.Number;
        }
    }

}
