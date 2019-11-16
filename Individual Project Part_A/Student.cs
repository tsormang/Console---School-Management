using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_A
{
    class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public string startDate { get; set; }
        public int TuitionFees { get; set; }
        public List<Assignment> Assignments { get; set; }



        public Student(string nam, string surnam, string subject, string start, int fees, List<Assignment> assignments)
        {
            Name = nam;
            LastName = surnam;
            Subject = subject;
            startDate = start;
            TuitionFees = fees;
            Assignments = new List<Assignment>(assignments);
        }

        public void Output()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"STUDENT                     {Name} {LastName}");
            Console.WriteLine("Subject ---------------------------------------------------");
            Console.WriteLine($"                            {Subject}");
            Console.WriteLine($"Starts at:                  {startDate}");
            Console.WriteLine($"Tuition Fees:               {TuitionFees} euro");
            Console.WriteLine("-----------------------------------------------------------");
        }


    }
}
