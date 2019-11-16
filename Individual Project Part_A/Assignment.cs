using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_A
{
    class Assignment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string subDateTime { get; set; }
        public float OralMark { get; set; }
        public float TotalMark { get; set; }

        public Assignment(string title, string description, string subscription, float oral, float total)
        {
            Title = title;
            Description = description;
            subDateTime = subscription;
            OralMark = oral;
            TotalMark = total;
        }

        public void Output()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"ASSIGNMENT                  {Title}");
            Console.WriteLine("INFO ------------------------------------------------------");
            Console.WriteLine($"Description:                {Description}");
            Console.WriteLine($"Subscriptions till:         {subDateTime}");
            Console.WriteLine($"Oral Mark:                  {OralMark}");
            Console.WriteLine($"Total Mark:                 {TotalMark}");
            Console.WriteLine("-----------------------------------------------------------");
        }


    }
}
