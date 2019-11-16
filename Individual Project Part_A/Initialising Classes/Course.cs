using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace School_Management
{
    class Course
    {
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public Course()
        {

        }
        public Course(string title, string stream, string type, DateTime start, DateTime end)
        {
            Title = title;
            Stream = stream;
            Type = type;
            startDate = start;
            endDate = end;
        }

        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($" {Title, -15} | {Stream, -15} | {Type,-10} | {startDate.ToString("dd/MM/yyyy"),-12} | {endDate.ToString("dd/MM/yyyy")}");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
  

}
