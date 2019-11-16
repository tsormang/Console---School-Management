using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class ListProvider
    {
        public static List<Course> CreateListCourses()
        {
            // Create COURSE Objects and List_______________________________________________________
            Course CB61A = new Course("CB6",     "Full Time",    "C#",      new DateTime(2019, 1, 1), new DateTime(2019, 3, 31));
            Course CB61B = new Course("CB6",     "Part Time",    "C#",      new DateTime(2019, 1, 1), new DateTime(2019, 3, 31));
            Course CB62A = new Course("CB6",     "Full Time",    "Java",    new DateTime(2019, 1, 1), new DateTime(2019, 3, 31));
            Course CB62B = new Course("CB6",     "Part Time",    "Java",    new DateTime(2019, 1, 1), new DateTime(2019, 3, 31));

            List<Course> courses = new List<Course>();
            courses.Add(CB61A);
            courses.Add(CB61B);
            courses.Add(CB62A);
            courses.Add(CB62B);

            return courses;
            //--------------------------------------------------------------------------------------
        }
        public static List<Assignment> CreateListAssignments()
        {
            // Create ASSIGNMENT Objects and List___________________________________________________
            Assignment CA1 = new Assignment("C#",   "Introduction to C#",       new DateTime(2019, 1, 14),   0,    0);
            Assignment CA2 = new Assignment("C#",   "Conditional Statements",   new DateTime(2019, 1, 28),   0,    0);
            Assignment CA3 = new Assignment("C#",   "Loops, Arrays",            new DateTime(2019, 2, 04),   0,    0);
            Assignment CA4 = new Assignment("C#",   "Methods",                  new DateTime(2019, 2, 18),   0,    0);
            Assignment CA5 = new Assignment("C#",   "Defining Classes",         new DateTime(2019, 3, 11),   0,    0);
            Assignment CA6 = new Assignment("C#",   "Algorithm Complexity",     new DateTime(2019, 3, 25),   0,    0);
                                                                                               
            Assignment JA1 = new Assignment("Java", "Introduction to Java",     new DateTime(2019, 1, 14),   0,    0);
            Assignment JA2 = new Assignment("Java", "Conditional Statements",   new DateTime(2019, 1, 28),   0,    0);
            Assignment JA3 = new Assignment("Java", "Loops, Arrays",            new DateTime(2019, 2, 04),   0,    0);
            Assignment JA4 = new Assignment("Java", "Numerals,Methods",         new DateTime(2019, 2, 18),   0,    0);
            Assignment JA5 = new Assignment("Java", "Defining Classes",         new DateTime(2019, 3, 11),   0,    0);
            Assignment JA6 = new Assignment("Java", "Lambda, LINQ",             new DateTime(2019, 3, 25),   0,    0);

            List<Assignment> assignments = new List<Assignment>();
            assignments.Add(CA1);
            assignments.Add(CA2);
            assignments.Add(CA3);
            assignments.Add(CA4);
            assignments.Add(CA5);
            assignments.Add(CA6);
            assignments.Add(JA1);
            assignments.Add(JA2);
            assignments.Add(JA3);
            assignments.Add(JA4);
            assignments.Add(JA5);
            assignments.Add(JA6);

            return assignments;
            //--------------------------------------------------------------------------------------
        }
        public static List<Trainer> CreateListsTrainers()
        {
            // Create TRAINERS Objects and List_________________________________________________
            Trainer TRC01 = new Trainer("Hector",      "Gatsos",       "C#");
            Trainer TRC02 = new Trainer("Yiorgos",     "Mpihis",       "C#");
            Trainer TRC03 = new Trainer("Giannis",     "Tsorman",      "C#");
            Trainer TRC04 = new Trainer("Nikolas",     "Koyama",       "C#");
            Trainer TRC05 = new Trainer("Maria",       "Papanikoli",   "C#");
            Trainer TRC06 = new Trainer("Ifigeneia",   "Fotopoulou",   "C#");
            Trainer TRJ01 = new Trainer("Mpampis",     "Sougias",      "Java");
            Trainer TRJ02 = new Trainer("Afroditi",    "Xepapa",       "Java");
            Trainer TRJ03 = new Trainer("Maria",       "Papanikoli",   "Java");
            Trainer TRJ04 = new Trainer("Ifigeneia",   "Fotopoulou",   "Java");
            Trainer TRJ05 = new Trainer("Hector",      "Gatsos",       "Java");
            Trainer TRJ06 = new Trainer("Yiorgos",     "Mpihis",       "Java");

            List<Trainer> trainers = new List<Trainer>();
            trainers.Add(TRC01);
            trainers.Add(TRC02);
            trainers.Add(TRC03);
            trainers.Add(TRC04);
            trainers.Add(TRC05);
            trainers.Add(TRC06);
            trainers.Add(TRJ01);
            trainers.Add(TRJ02);
            trainers.Add(TRJ03);
            trainers.Add(TRJ04);
            trainers.Add(TRJ05);
            trainers.Add(TRJ06);

            return trainers;
            //--------------------------------------------------------------------------------------
        }
        public static List<Student> CreateListsStudents()
        {
            // Create STUDENTS Objects and List_________________________________________________
            Student ST001 = new Student("Zorz", "Varhis", "C#",             new DateTime(2019, 1, 1), 2500);
            Student ST002 = new Student("Jack", "Knife", "C#",              new DateTime(2019, 1, 1), 2500);
            Student ST003 = new Student("Matthew", "Vaughum", "C#",         new DateTime(2019, 1, 1), 1500);
            Student ST004 = new Student("Jason", "Smithens", "C#",          new DateTime(2019, 1, 1), 2500);
            Student ST005 = new Student("Jennifer", "Babes", "C#",          new DateTime(2019, 1, 1), 500);
            Student ST006 = new Student("John", "Hahnis", "C#",             new DateTime(2019, 1, 1), 500);
            Student ST007 = new Student("Melissa", "Honey", "C#",           new DateTime(2019, 1, 1), 1500);
            Student ST008 = new Student("Nicole", "Vandi", "C#",            new DateTime(2019, 1, 1), 2500);
            Student ST009 = new Student("Amy", "Summer", "C#",              new DateTime(2019, 1, 1), 2500);
            Student ST010 = new Student("Christopher", "Valls", "C#",       new DateTime(2019, 1, 1), 2000);
            Student ST011 = new Student("Michael", "Summy", "Java",         new DateTime(2019, 1, 1), 2500);
            Student ST012 = new Student("Elizabeth", "Queen", "Java",       new DateTime(2019, 1, 1), 1500);
            Student ST013 = new Student("Manolis", "Sefopoulos", "Java",    new DateTime(2019, 1, 1), 1500);
            Student ST014 = new Student("Lakis", "Bardis", "Java",          new DateTime(2019, 1, 1), 2500);
            Student ST015 = new Student("Ioanna", "Giannakarou", "Java",    new DateTime(2019, 1, 1), 1500);
            Student ST016 = new Student("Nikoleta", "Dekemvri", "Java",     new DateTime(2019, 1, 1), 500);
            Student ST017 = new Student("George", "Micklis", "Java",        new DateTime(2019, 1, 1), 500);
            Student ST018 = new Student("Mairy", "Popins", "Java",          new DateTime(2019, 1, 1), 2500);
            Student ST019 = new Student("Mimis", "Fotopoulos", "Java",      new DateTime(2019, 1, 1), 500);
            Student ST020 = new Student("Dimitris", "Rossos", "Java",       new DateTime(2019, 1, 1), 2500);
            Student ST021 = new Student("Mairy", "Popins", "C#",            new DateTime(2019, 1, 1), 2500);
            Student ST022 = new Student("Mimis", "Fotopoulos", "C#",        new DateTime(2019, 1, 1), 500);
            Student ST023 = new Student("Dimitris", "Rossos", "C#",         new DateTime(2019, 1, 1), 2500);

            List<Student> students = new List<Student>();
            students.Add(ST001);
            students.Add(ST002);
            students.Add(ST003);
            students.Add(ST004);
            students.Add(ST005);
            students.Add(ST006);
            students.Add(ST007);
            students.Add(ST008);
            students.Add(ST009);
            students.Add(ST010);
            students.Add(ST011);
            students.Add(ST012);
            students.Add(ST013);
            students.Add(ST014);
            students.Add(ST015);
            students.Add(ST016);
            students.Add(ST017);
            students.Add(ST018);
            students.Add(ST019);
            students.Add(ST020);
            students.Add(ST021);
            students.Add(ST022);
            students.Add(ST023);

            return students;
            //--------------------------------------------------------------------------------------
        }
        

    }
}
