using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class StudPerCourse
    {
        List<Course> Mathima = ListProvider.CreateListCourses();
        List<Student> Students = ListProvider.CreateListsStudents();

        public StudPerCourse(List<Course> mathima, List<Student> mathites)
        {
            Students = mathites;
            Mathima = mathima;
        }

        public static List<StudPerCourse> CreateListsStudentsPerCourse() // CREATE LIST, STUDENTS per COURSE______________________________________
        {
            List<Student> Mathites = ListProvider.CreateListsStudents();
            List<Course> Mathima = ListProvider.CreateListCourses();

            StudPerCourse SPC001 = new StudPerCourse(Mathima, Mathites);

            List<StudPerCourse> studentspermathima = new List<StudPerCourse>();
            studentspermathima.Add(SPC001);

            return studentspermathima;
        }

        public static void PrintListsStudentsPerCourse() // PRINT STUDENTS per COURSE______________________________________
        {
            List<StudPerCourse> SpC = new List<StudPerCourse>();
            SpC = StudPerCourse.CreateListsStudentsPerCourse();


            foreach (var item in SpC[0].Mathima)
            {
                item.Output();

                foreach (var ass in SpC[0].Students)
                {
                    if (ass.Subject == item.Type)
                    {
                        ass.Output();
                    }
                }
            }
        }

    }
}
