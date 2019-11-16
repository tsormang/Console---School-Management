using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class PART_A
    {
        public static void Navigation()
        {

            string s = "S";
            string t = "T";
            string a = "A";
            string c = "C";
            string e = "E";
            string userInput = null;


            while (userInput != e)
            {
                Console.WriteLine("\nChoose Lists: \n(S) Student List, \n(T) Trainers List, \n(A) Assignments, \n(C) Courses, \n(E) BACK");
                userInput = Console.ReadLine();

                if (userInput == s)
                {
                    ListPrinter.PrintListStudents();
                }
                else if (userInput == t)
                {
                    ListPrinter.PrintListTrainers();
                }
                else if (userInput == a)
                {
                    ListPrinter.PrintListAssignments();
                }
                else if (userInput == c)
                {
                    ListPrinter.PrintListCourses();
                }
                else if (userInput == e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("BACK");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Unindentified Input, Please Choose Again");
                    Console.ForegroundColor = ConsoleColor.White;
                }


            }

        
        }



    }
}
