using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class StudentList
    {

        List<Student> ListOfStudents = new List<Student>();


        public void AddToList()
        {
            char answer;
            answer = Validator.GetAnyCaseChar("Please type 'S' to add a 'S'tudent, or 'A' to add an 'A'rchived student...", new char[]{'a', 's'}, new char[]{ 'A', 'S' });

            if (answer == 'a')
            {
                ListOfStudents.Add(NewArchivedStudent());
            }
            else if(answer == 's')
            {
                ListOfStudents.Add(NewStudent());
            }
        }



        public void ReturnList()
        {
            //sorted with Linq
            //ListOfStudents.Sort((p, q) => p.LastName.CompareTo(q.LastName));

            //sorted with default comparer - which should be IComparable
            ListOfStudents.Sort();

            foreach(object student in ListOfStudents)
            {
                Console.WriteLine(student.ToString());
            }

        }





        private Student NewStudent()
        {
            Console.WriteLine("\n--- adding STUDENT ---\n");
            string name = Validator.GetString("Please enter a first name in Title Case", @"^[A-Z][a-z]+$");
            string lastName = Validator.GetString("Please enter a last name in Title Case", @"^[A-Z][a-z]+$");
            string address = Validator.GetString("Please enter an address in Title Case, space, and then a 2-3 letter abbreviation followed by '.'\n" +
                                            "EX: '123 Stonehoof Dr.'   or    '2134 Moon Ave.'\n", @"^[0-9]+(\s[A-Z][a-z]+)+\s[A-Z][a-z]{1,2}[.]$");
            string program = Validator.GetString("Please enter the program name in Title Case", @"^([A-Z][a-z]+\s*)+$");
            int year = Validator.GetNumber("Please enter a valid year (1900 - 2018)", 1900, 2018);
            int fee = Validator.GetNumber("Please enter a valid fee(100 - 1000000)", 100, 1000000);
        
            Student newOne = new Student(name, address, lastName, program, year, fee);

            return newOne;
        }



        private ArchivedStudent NewArchivedStudent()
        {
            Console.WriteLine("\n--- adding ARCHIVED STUDENT ---\n");
            string name = Validator.GetString("Please enter a first name in Title Case", @"^[A-Z][a-z]+$");
            string lastName = Validator.GetString("Please enter a last name in Title Case", @"^[A-Z][a-z]+$");
            string address = Validator.GetString("Please enter an address in Title Case, space, and then a 2-3 letter abbreviation followed by '.'\n" +
                                            "EX: '123 Stonehoof Dr.'   or    '2134 Moon Ave.'\n", @"^[0-9]+(\s[A-Z][a-z]+)+\s[A-Z][a-z]{1,2}[.]$");
            string program = Validator.GetString("Please enter the program name in Title Case", @"^([A-Z][a-z]+\s*)+$");
            int year = Validator.GetNumber("Please enter a valid year (1900 - 2018)", 1900, 2018);
            int fee = Validator.GetNumber("Please enter a valid fee(100 - 1000000)", 100, 1000000);
            int finalScore = Validator.GetNumber("PLease enter a valid final score (0 - 100)", 0, 100);

            ArchivedStudent newOne = new ArchivedStudent(name, address, lastName, program, year, fee, finalScore);

            return newOne;
        }


    }
}
