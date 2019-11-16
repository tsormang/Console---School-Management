using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class UserInputAssignmentData
    {
        public static void UserInput()
        {
            string e = "E";
            string i = "I";
            string userInput = null;

            List<Assignment> assigns = ListProvider.CreateListAssignments();

            while (userInput != e)
            {
                Console.WriteLine("\nChoose Action: \n(I) INPUT DATA, \n(E) BACK ");
                userInput = Console.ReadLine();
                if (userInput == i)
                {
                    string tempTitle = "Anonimos";
                    string tempDescription = "Anonimopoulos";
                    DateTime tempDate = DateTime.Now;
                    double tempOmark = 5;
                    double tempmark = 5;

                    // Input Set Up__________________________________________________
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please Input Assignment Data");
                    Console.ForegroundColor = ConsoleColor.White;

                    // Input NAME_____________________________________________________
                    string tempTitle0;
                    Console.Write("Title:            ");
                    tempTitle0 = Console.ReadLine();
                    if (tempTitle0 == null)
                    {
                        tempTitle = "Agnosto";
                    }
                    tempTitle = tempTitle0;

                    // Input SURNAME__________________________________________________
                    string tempDescriptione0;
                    Console.Write("Description:         ");
                    tempDescriptione0 = Console.ReadLine();
                    if (tempDescriptione0 == null)
                    {
                        tempDescription = "Agnoto kai auto";
                    }
                    tempDescription = tempDescriptione0;

                    // Input  DATE_______________________________________________
                    try
                    {
                        Console.WriteLine("Subscription Date (DD/MM/YYYY): ");
                        string Check = Console.ReadLine();
                        DateTime DateCheck = DateTime.ParseExact(Check, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        tempDate = DateCheck;
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your Given Date has Bad Format, Please input: (DD/MM/YYYY)");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    // Input Oral Mark_____________________________________________
                    try
                    {
                        Console.Write("Oral Mark:    ");
                        tempOmark = double.Parse(Console.ReadLine());
                        if (tempOmark <= 0)
                        {
                            tempOmark = 0;
                        }
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Mark must be a Number, Please Input a Number");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    // Input Total Mark_____________________________________________
                    try
                    {
                        Console.Write("Total Mark:    ");
                        tempmark = double.Parse(Console.ReadLine());
                        if (tempmark <= 0)
                        {
                            tempmark = 0;
                        }
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Mark must be a Number, Please Input a Number");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Assignment temp = new Assignment(tempTitle, tempDescription, tempDate, tempOmark, tempmark);
                    assigns.Add(temp);

                    foreach (var item in assigns)
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
