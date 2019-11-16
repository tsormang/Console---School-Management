using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class UserInputStudentData
    {
        public static void UserInput()
        {
            string e = "E";
            string i = "I";
            string userInput = null;

            List<Student> students = ListProvider.CreateListsStudents();

            while (userInput != e)
            {
                Console.WriteLine("\nChoose Action: \n(I) INPUT DATA, \n(E) BACK ");
                userInput = Console.ReadLine();
                if (userInput == i)
                {
                    string tempName = "Anonimos";
                    string tempSurname = "Anonimopoulos";
                    string tempSubject = "Unspecified";
                    DateTime tempDate = DateTime.Now;
                    int tempFees = 2500;

                    // Input Set Up__________________________________________________
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please Input Student Data");
                    Console.ForegroundColor = ConsoleColor.White;

                    // Input NAME_____________________________________________________
                    string tempName0;
                    Console.Write("Name:            ");
                    tempName0 = Console.ReadLine();
                    if (tempName0 == null)
                    {
                        tempName = "Anonimos";
                    }
                    tempName = tempName0;

                    // Input SURNAME__________________________________________________
                    string tempSurname0;
                    Console.Write("SurName:         ");
                    tempSurname0 = Console.ReadLine();
                    if (tempSurname0 == null)
                    {
                        tempSurname = "Anonimopoulos";
                    }
                    tempSurname = tempSurname0;

                    // Input SUBJECT__________________________________________________
                    string tempSubject0;
                    Console.Write("Subject:         ");
                    tempSubject0 = Console.ReadLine();
                    if (tempSubject0 == null)
                    {
                        tempSubject = "Unspecified";
                    }
                    tempSubject = tempSubject0;

                    // Input START DATE_______________________________________________
                    try
                    {
                        Console.WriteLine("Starting Date (DD/MM/YYYY): ");
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

                    // Input TUITION FEES_____________________________________________
                    try
                    {
                        Console.Write("Tuition Fees:    ");
                        tempFees = Int32.Parse(Console.ReadLine());
                        if (tempFees <= 0)
                        {
                            tempFees = 2500;
                        }
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fees must be a Number, Please Input a Number");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Student temp = new Student(tempName, tempSurname, tempSubject, tempDate, tempFees);
                    students.Add(temp);

                    foreach (var item in students)
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
