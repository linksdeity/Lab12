using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Person
    {

        protected string Name;
        protected string Address;

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            string toString = "";
            toString += ("\nName: " + Name + "\nAddress: " + Address);
            return toString;
        }



    }
}
