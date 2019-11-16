using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class UserInputCourseData
    {
        public static void UserInput()
        {
            string e = "E";
            string i = "I";
            string userInput = null;

            List<Course> courses = ListProvider.CreateListCourses();

            while (userInput != e)
            {
                Console.WriteLine("\nChoose Action: \n(I) INPUT DATA, \n(E) BACK ");
                userInput = Console.ReadLine();
                if (userInput == i)
                {
                    string tempTitle = "Unspecified";
                    string tempStream = "Unspecified";
                    string tempType = "Unspecified";
                    DateTime tempSDate = new DateTime(2019, 1, 1);
                    DateTime tempEDate = new DateTime(2019, 3, 31);


                    // Input Set Up__________________________________________________
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please Input Course Data");
                    Console.ForegroundColor = ConsoleColor.White;

                    // Input NAME_____________________________________________________
                    string tempTitle0;
                    Console.Write("Title:            ");
                    tempTitle0 = Console.ReadLine();
                    if (tempTitle0 == null)
                    {
                        tempTitle = "Unspecified";
                    }
                    tempTitle = tempTitle0;

                    // Input SURNAME__________________________________________________
                    string tempStream0;
                    Console.Write("Stream:         ");
                    tempStream0 = Console.ReadLine();
                    if (tempStream0 == null)
                    {
                        tempStream = "Unspecified";
                    }
                    tempStream = tempStream0;

                    // Input SUBJECT__________________________________________________
                    string tempType0;
                    Console.Write("Type:         ");
                    tempType0 = Console.ReadLine();
                    if (tempType0 == null)
                    {
                        tempType = "Unspecified";
                    }
                    tempType = tempType0;

                    // Input START DATE_______________________________________________
                    try
                    {
                        Console.WriteLine("Starting Date (DD/MM/YYYY): ");
                        string Check = Console.ReadLine();
                        DateTime DateCheck = DateTime.ParseExact(Check, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        tempSDate = DateCheck;
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your Given Date has Bad Format, Please input: (DD/MM/YYYY)");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    // Input END DATE_______________________________________________
                    try
                    {
                        Console.WriteLine("End Date (DD/MM/YYYY): ");
                        string Check = Console.ReadLine();
                        DateTime DateCheck = DateTime.ParseExact(Check, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        tempEDate = DateCheck;
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your Given Date has Bad Format, Please input: (DD/MM/YYYY)");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Course temp = new Course(tempTitle, tempStream, tempType, tempSDate, tempEDate);
                    courses.Add(temp);

                    foreach (var item in courses)
                    {
                        item.Output();
                    }

                }
                else if (userInput == e)                                    // Step Back Command
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("BACK");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else                                                        // In the Case of false Data Input
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Unindentified Input, Please Choose Again");
                    Console.ForegroundColor = ConsoleColor.White;
                }


            }


        }

    }
}
