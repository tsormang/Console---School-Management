using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{

    class AssPerStudent
    {
        List<Assignment> Assignments = ListProvider.CreateListAssignments();
        List<Student> Students = ListProvider.CreateListsStudents();

        public AssPerStudent(List<Student> students, List<Assignment> assignments)
        {
            Assignments = assignments;
            Students = students;
        }

        public static List<AssPerStudent> CreateListsAssPerStudents() // CREATE LIST, ASSIGNMENTS per STUDENTS_____________________________________
        {
            List<Assignment> Assignments = ListProvider.CreateListAssignments();
            List<Student> Students = ListProvider.CreateListsStudents();

            
            AssPerStudent APS001 = new AssPerStudent(Students, Assignments);

            List<AssPerStudent> asignemntsperstudent = new List<AssPerStudent>();
            asignemntsperstudent.Add(APS001);

            return asignemntsperstudent;
        }

        public static void PrintListsAssPerStudents() // PRINT ASSIGNMENTS per STUDENTS______________________________________
        {
            List<AssPerStudent> ApS = new List<AssPerStudent>();
            ApS = AssPerStudent.CreateListsAssPerStudents();

            
            foreach (var item in ApS[0].Students)
            {
                item.Output();

                foreach (var ass in ApS[0].Assignments)
                {
                    if (ass.Title == item.Subject)
                    {
                        ass.Output();
                    }
                }
            }
        }

        public static void Submissions(string date) // ASSIGNMENTS per STUDENTS PRINT (DATE CHECK)______________________________________
        {
            List<Assignment> Assignments = ListProvider.CreateListAssignments();
            List<AssPerStudent> ApS = new List<AssPerStudent>();
            ApS = AssPerStudent.CreateListsAssPerStudents();

            foreach (var item in ApS[0].Students)
            {
                item.Output();

                foreach (var ass in ApS[0].Assignments)
                {
                    if (ass.Title == item.Subject && ass.subDateTime.ToString("dd/MM/yyyy") == date)
                    {
                        ass.Output();
                    }
                }
            }
        }

    }
}
