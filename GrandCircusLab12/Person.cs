using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    abstract class Person
    {
        public string LastName { get; set; }

        public string Name;
        public string Address;

        public Person(string name, string address, string lastName)
        {
            Name = name;
            Address = address;
            LastName = lastName;
        }

        public override string ToString()
        {
            string toString = "";
            toString += ("\nName: " + Name + " " + LastName + "\nAddress: " + Address);
            return toString;
        }



    }
}
