using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class AssPerCourse
    {
        List<Assignment> Assignments = ListProvider.CreateListAssignments();
        List<Course> Mathima = ListProvider.CreateListCourses();

        public AssPerCourse(List<Course> mathima, List<Assignment> assignments)
        {
            Assignments = assignments;
            Mathima = mathima;
        }

        public static List<AssPerCourse> CreateListsAssPerCourse() // CREATE LIST, ASSIGNMENTS per COURSE______________________________________
        {
            List<Assignment> Assignments = ListProvider.CreateListAssignments();
            List<Course> Mathima = ListProvider.CreateListCourses();

            AssPerCourse APC001 = new AssPerCourse(Mathima, Assignments);

            List<AssPerCourse> asignemntspermathima = new List<AssPerCourse>();
            asignemntspermathima.Add(APC001);

            return asignemntspermathima;
        }

        public static void PrintListsAssPerCourse() // PRINT ASSIGNMENTS per COURSE______________________________________
        {
            List<AssPerCourse> ApC = new List<AssPerCourse>();
            ApC = AssPerCourse.CreateListsAssPerCourse();


            foreach (var item in ApC[0].Mathima)
            {
                item.Output();

                foreach (var ass in ApC[0].Assignments)
                {
                    if (ass.Title == item.Type)
                    {
                        ass.Output();
                    }
                }
            }
        }
    }
}
