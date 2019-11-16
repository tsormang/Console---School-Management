using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project_Part_A
{
    class Participants
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public Participants()
        {
            Name = "John";
            LastName = "Smith";
            Subject = "Any";
        }
        public Participants(string nam, string surnam, string subject)
        {
            Name = nam;
            LastName = surnam;
            Subject = subject;
        }

        public virtual void Output()
        {
            Console.WriteLine("+----------+----------+----------+----------+----------+");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"                            {Name} {LastName}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Subject ---+----------+----------+----------+----------+");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"                            {Subject}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("+----------+----------+----------+----------+----------+");
        }
    }
}
