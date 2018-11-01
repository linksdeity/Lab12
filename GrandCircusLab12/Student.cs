using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Student : Person, IComparable<Student>
    {

        protected string Program;
        protected int Year;
        protected double Fee;

        public Student(string name, string address, string lastName, string program, int year, double fee) : base(name, address, lastName)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public override string ToString()
        {
            string toString = "";
            toString += ("\nName: " + Name + " " + LastName + "\nAddress: " + Address + "\nProgram: " + Program + "\nYear: " + Year + "\nFee: " + Fee);
            return toString;
        }

        public int CompareTo(Student other)
        {
            if (this.LastName == other.LastName)
            {
                return this.Name.CompareTo(other.Name);
            }
            else
            {
                return this.LastName.CompareTo(other.LastName);
            }
        }

    }
}
