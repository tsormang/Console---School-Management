using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Individual_Project_Part_A
{
    class Course
    {
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }

        public Course(string title, string stream, string type, string start, string end)
        {
            Title = title;
            Stream = stream;
            Type = type;
            startDate = start;
            endDate = end;
        }

        public void Output()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"COURSE                      {Title}");
            Console.WriteLine("INFO ------------------------------------------------------");
            Console.WriteLine($"Stream:                     {Stream}");
            Console.WriteLine($"Type:                       {Type}");
            Console.WriteLine($"Starts at:                  {startDate}");
            Console.WriteLine($"Ends at:                    {endDate}");
            Console.WriteLine("-----------------------------------------------------------");
        }





    }



}
