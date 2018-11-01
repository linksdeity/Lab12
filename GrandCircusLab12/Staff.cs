using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Staff : Person
    {
        protected string School;
        protected double Pay;

        public Staff (string name, string address, string lastName, string school, double pay) : base (name, address, lastName)
        {
            School = school;
            Pay = pay;
        }

        public override string ToString()
        {
            string toString = "";
            toString += ("\nName: " + Name + " " + LastName + "\nAddress: " + Address + "\nSchool: " + School + "\nPay: " + Pay);
            return toString;
        }

    }
}
