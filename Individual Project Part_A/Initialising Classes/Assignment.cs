using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class Assignment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime subDateTime { get; set; }
        public double OralMark { get; set; }
        public double TotalMark { get; set; }

        public Assignment()
        {

        }
        public Assignment(string title, string description, DateTime subscription, double oral, double total)
        {
            Title = title;
            Description = description;
            subDateTime = subscription;
            OralMark = oral;
            TotalMark = total;
        }

        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($" {Title,-10} |{Description, -30} | {subDateTime.ToString("dd/MM/yyyy"),-12} | {OralMark,-6} | {TotalMark}");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }

        


    }
}
