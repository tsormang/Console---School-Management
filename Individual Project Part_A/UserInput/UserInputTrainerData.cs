using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class UserInputTrainerData
    {
        public static void UserInput()
        {
            string e = "E";
            string i = "I";
            string userInput = null;

            List<Trainer> trainers = ListProvider.CreateListsTrainers();

            while (userInput != e)
            {
                Console.WriteLine("\nChoose Action: \n(I) INPUT DATA, \n(E) BACK ");
                userInput = Console.ReadLine();
                if (userInput == i)
                {
                    string tempName = "Anonimos";
                    string tempSurname = "Anonimopoulos";
                    string tempSubject = "Unspecified";

                    // Input Set Up__________________________________________________
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please Input Trainer Data");
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



                    Trainer temp = new Trainer(tempName, tempSurname, tempSubject);
                    trainers.Add(temp);

                    foreach (var item in trainers)
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
