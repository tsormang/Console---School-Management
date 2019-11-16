using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class ListPrinter
    {
        public static void PrintListCourses()
        {
            // Output COURSE List________________________________________________________________________
            List<Course> listcourse = new List<Course>();
            listcourse = ListProvider.CreateListCourses();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine($" {"TITLE",-15} | {"STREAM",-15} | {"TYPE",-10} | {"START DATE",-12} | {"END DATE"}");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in listcourse)
            {
                item.Output();
            }
            //-------------------------------------------------------------------------------------------
        }

        public static void PrintListAssignments()
        {
            // Output ASSIGNEMENTS List__________________________________________________________________
            List<Assignment> listAss = new List<Assignment>();
            listAss = ListProvider.CreateListAssignments();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine($" {"TITLE",-10} |{"DESCRIPTION",-30} | {"SUBMISSION",-12} | {"ORAL",-6} | {"TOTAL"}");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in listAss)
            {
                item.Output();
            }
            //-------------------------------------------------------------------------------------------

        }

        public static void PrintListTrainers()
        {
            // Output TRAINERS List______________________________________________________________________
            List<Trainer> trainers = new List<Trainer>();
            trainers = ListProvider.CreateListsTrainers();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine($" {"TRAINERS NAME",-15} {" ",-15} | {"SUBJECT"}");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in trainers)
            {
                item.Output();
            }
            //-------------------------------------------------------------------------------------------
        }

        public static void PrintListStudents()
        {
            // Output STUDENTS List______________________________________________________________________
            List<Student> students = new List<Student>();
            students = ListProvider.CreateListsStudents();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine($" {"STUDENTS NAME",-15} {" ", -15} | {"SUBJECT",-10} | {"START DATE",-12} | {"TUITION FEES"} ");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in students)
            {
                item.Output();
            }
            //-------------------------------------------------------------------------------------------
        }
        
    }
}
