using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class Project
    {
        static void Main(string[] args)
        {
            string one = "1";
            string two = "2";
            string three = "3";
            string e = "E";
            string userInput = null;
            string a = "A";
            string c = "C";
            string m = "M";
            string t = "T";
            string s = "S";

            while (userInput != e)
            {
                // CHOOSE ONE OF THE 3 MAJOR PATHS
                Console.WriteLine("\nChoose Action: \n(1) INPUT MODE, \n(2) READ LISTS MODE, \n(3) DATE INPUT SEARCH, \n(E) EXIT ");
                userInput = Console.ReadLine();

                // PART A >>> USER INPUT DATA PART >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                
                if (userInput == one)    
                {
                    while (userInput != e)
                    {
                        Console.WriteLine("\nChoose Action: \n(C) COURSE INPUT, \n(S) STUDENT INPUT, \n(T) TRAINER INPUT, \n(A) ASSIGNMENT INPUT, \n(E) EXIT ");
                        userInput = Console.ReadLine();
                        //
                        if (userInput == c)
                        {
                            UserInputCourseData.UserInput();
                        }
                        else if (userInput == s)
                        {
                            UserInputStudentData.UserInput();
                        }
                        else if (userInput == t)
                        {
                            UserInputTrainerData.UserInput();
                        }
                        else if (userInput == a)
                        {
                            UserInputAssignmentData.UserInput();
                        }
                        else if (userInput == e) // Step Back Command____________________________________________________________________________
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("EXIT");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else // In the Case of false Data Input__________________________________________________________________________________
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Unindentified Input, Please Choose Again");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }

                }

                // PART B >>> READ PREMADE LISTS  PART >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


                else if (userInput == two) 
                {
                    while (userInput != e)  
                    {
                        Console.WriteLine("\nChoose Action: \n(1) Lists, \n(S) Student per Course, \n(T) Trainers per Course, \n(A) Assignments per Course, \n(C) Assignements per Student, \n(M) Students in more Courses, \n(E) EXIT");
                        userInput = Console.ReadLine();

                        if (userInput == one)
                        {
                            PART_A.Navigation(); // Simple Initial Lists Display_______________________________________________________________
                        }
                        else if (userInput == s)
                        {
                            StudPerCourse.PrintListsStudentsPerCourse();
                        }
                        else if (userInput == t)
                        {
                            TrainPerCourse.PrintListsTrainersPerCourse();
                        }
                        else if (userInput == a)
                        {
                            AssPerCourse.PrintListsAssPerCourse();
                        }
                        else if (userInput == c)
                        {
                            AssPerStudent.PrintListsAssPerStudents();    
                        }
                        else if (userInput == m)
                        {
                            StudentsAtBothCourses.CourseCheck(); // Students that have more than one Courses___________________________________
                        }
                        else if (userInput == e) // Step Back Command__________________________________________________________________________      
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("EXIT");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else // In the Case of false Data Input________________________________________________________________________________                                     
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Unindentified Input, Please Choose Again");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }

                // PART C >>> USER INPUT DATE AND CHECK PART >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


                else if (userInput == three)    
                {
                    DateCheck.DateCheckAss();
                }
                else if (userInput == e) // Coplete Exit________________________________________________________________________
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("EXIT");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else  // In the Case of false Data Input________________________________________________________________________
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Unindentified Input, Please Choose Again");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }








        }
     


    }


}
