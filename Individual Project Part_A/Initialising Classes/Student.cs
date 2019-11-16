using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public DateTime startDate { get; set; }
        public int TuitionFees { get; set; }

        public Student(string nam, string surnam, string subject, DateTime start, int fees)
        {
            Name = nam;
            LastName = surnam;
            Subject = subject;
            startDate = start;
            TuitionFees = fees;
        }

        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {Name,-15} {LastName,-15} | {Subject,-10} | {startDate.ToString("dd/MM/yyyy"),-10} | {TuitionFees} euro");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}
