using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Program
    {
        static void Main(string[] args)
        {

            Person Dave = new Person("Dave", "123 Happy Ave");

            Person Sarah = new Student("Sarah", "124 Happy Road", "Maths", 1805, 2000.99);

            Person Jack = new Staff("Jack", "907 Mt. Moon", "Moon College", 10000000.99);



            Console.WriteLine(Dave.ToString());

            Console.WriteLine(Sarah.ToString());

            Console.WriteLine(Jack.ToString());



            Console.ReadKey(true);

        }
    }
}
