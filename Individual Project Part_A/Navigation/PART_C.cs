using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_A
{
    class PART_C
    {
        public static void Navigation()
        {
            string c = "C";
            string e = "E";
            string userInput = null;

            while (userInput != e)
            {
                Console.WriteLine("\nChoose Action: \n(C) Input Student, \n(E) to EXIT");
                userInput = Console.ReadLine();
                if (userInput == c)
                {
                    ListPrinter.PrintListINPUTStudents();
                }
                else if (userInput == e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("EXIT");
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
