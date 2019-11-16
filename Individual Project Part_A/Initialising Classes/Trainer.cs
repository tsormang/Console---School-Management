using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    class Trainer
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public Trainer(string nam, string surnam, string subject)
        {
            Name = nam;
            LastName = surnam;
            Subject = subject;
        }

        public void Output()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($" {Name,-15} {LastName,-15} | {Subject}");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}
