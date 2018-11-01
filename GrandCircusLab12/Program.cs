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

            Console.WriteLine("Welcome to the student list!");

            StudentList newList = new StudentList();


            while (true)

            {
                Console.WriteLine("Would you like to add some students to the list?");

                bool answer = Validator.GetAnyCaseChar("Enter 'y' for 'y'es, anything else to quit!", 'y', 'Y');

                if (!answer)
                {
                    break;
                }

                Console.WriteLine("\nHow many students would you like to add?");

                int numAnswer = Validator.GetNumber("Please enter a number 1 - 10 (max at a time)", 1, 10);

                for (int i = 1; i <= numAnswer; i++)
                {
                    newList.AddToList();
                }

                Console.Clear();

                Console.WriteLine("Here are the students on the list, sorted by last name...\n");

                newList.ReturnList();

                Console.WriteLine("\nWould you like to continue adding students to the list?");


                bool answerAgain = Validator.GetAnyCaseChar("Enter 'y' for 'y'es, anything else to quit!", 'y', 'Y');

                if (answerAgain)
                {
                    Console.Clear();
                }
                else
                {
                    break;
                }

            }



            Console.WriteLine("GODBYE!!");
            Console.ReadKey(true);

        }
    }
}
