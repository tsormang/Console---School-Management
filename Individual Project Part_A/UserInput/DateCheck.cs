using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class DateCheck
    {
        //public string GivenDate;
        List<Assignment> Assignments = ListProvider.CreateListAssignments();
        List<Student> Students = ListProvider.CreateListsStudents();

        public static void DateCheckAss()
        {
            string GivenDate = "01/01/2019";
            List<Assignment> Assignments = ListProvider.CreateListAssignments();

            // USER DATE___________________________________________________________________________________________________________________________
            try
            {
                Console.WriteLine("Input Date in this Format (DD/MM/YYYY): ");
                GivenDate = Console.ReadLine();
                DateTime DateCheck = DateTime.ParseExact(GivenDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your Given Date has Bad Format, Please input: (DD/MM/YYYY)");
                Console.ForegroundColor = ConsoleColor.White;
            }
            DateTime DateConv = DateTime.ParseExact(GivenDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            // ASSIGNMENTS DUE DATES_______________________________________________________________________________________________________________


            DateTime temDate = new DateTime(2019, 1, 1);
            string tempD = temDate.ToString("dd/MM/yyyy");
            DateTime temDate0 = DateTime.ParseExact(tempD, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            DateTime temDate1 = DateTime.ParseExact(Assignments[0].subDateTime.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime temDate2 = DateTime.ParseExact(Assignments[1].subDateTime.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime temDate3 = DateTime.ParseExact(Assignments[2].subDateTime.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime temDate4 = DateTime.ParseExact(Assignments[3].subDateTime.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime temDate5 = DateTime.ParseExact(Assignments[4].subDateTime.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime temDate6 = DateTime.ParseExact(Assignments[5].subDateTime.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (DateConv <= temDate0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your Given Date is Out of the Course Dates");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (DateConv >= temDate0 && DateConv <= temDate1)
            {
                GivenDate = Assignments[0].subDateTime.ToString("dd/MM/yyyy");
                AssPerStudent.Submissions(GivenDate);
            }
            else if (DateConv >= temDate1 && DateConv <= temDate2)
            {
                GivenDate = Assignments[1].subDateTime.ToString("dd/MM/yyyy");
                AssPerStudent.Submissions(GivenDate);
            }
            else if (DateConv >= temDate2 && DateConv <= temDate3)
            {
                GivenDate = Assignments[2].subDateTime.ToString("dd/MM/yyyy");
                AssPerStudent.Submissions(GivenDate);
            }
            else if (DateConv >= temDate3 && DateConv <= temDate4)
            {
                GivenDate = Assignments[3].subDateTime.ToString("dd/MM/yyyy");
                AssPerStudent.Submissions(GivenDate);
            }
            else if (DateConv >= temDate4 && DateConv <= temDate5)
            {
                GivenDate = Assignments[4].subDateTime.ToString("dd/MM/yyyy");
                AssPerStudent.Submissions(GivenDate);
            }
            else if (DateConv >= temDate5 && DateConv <= temDate6)
            {
                GivenDate = Assignments[5].subDateTime.ToString("dd/MM/yyyy");
                AssPerStudent.Submissions(GivenDate);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your Given Date is Out of the Assignments Submission Dates");
                Console.ForegroundColor = ConsoleColor.White;
            }
            

        }



    }
}
