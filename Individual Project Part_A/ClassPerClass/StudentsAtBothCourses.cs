using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class StudentsAtBothCourses
    {
        public static void CourseCheck()
        {

            List<Student> students = ListProvider.CreateListsStudents();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine($"STUDENTS IN MORE THAN ONE COURSES");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < students.Count; i++)
            {
                for (int j = i + 1; j < students.Count; j++)
                {
                    if (students[i].Name == students[j].Name && students[i].Subject != students[j].Subject)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" {students[i].Name,-10} {students[i].LastName, -15} | 1) {students[i].Subject, -8} | 2) {students[j].Subject,-8}");
                        Console.WriteLine("-----------------------------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

            }

        }


    }
}
