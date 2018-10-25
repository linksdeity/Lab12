using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Student : Person
    {

        protected string Program;
        protected int Year;
        protected double Fee;

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public override string ToString()
        {
            string toString = "";
            toString += ("\nName: " + Name + "\nAddress: " + Address + "\nProgram: " + Program + "\nYear: " + Year + "\nFee: " + Fee);
            return toString;
        }

    }
}
