using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class ArchivedStudent : Student, IComparable<Student>
    {
        public int FinalScore { get; }


        public ArchivedStudent(string name, string address, string lastName, string program, int year, double fee, int finalScore) : base(name, address, lastName, program, year, fee)
        {

            FinalScore = finalScore;

        }


        public override string ToString()
        {
            string toString = "";
            toString += ("\nName: " + Name + " " + LastName + "\nAddress: " + Address + "\nProgram: " + Program + "\nYear: " + Year + "\nFee: " + Fee + "\nFinal Score: " + FinalScore);
            return toString;
        }




    }       
}
