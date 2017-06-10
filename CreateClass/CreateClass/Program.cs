using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

     
namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Abel = new Employee("Ábel Váradi", new DateTime(1984,03,28), Genders.male, 120000, "developer");
            Abel.Room = new Room(111);
            Employee Abel2 = (Employee)Abel.Clone();
            Abel2.Room.Number = 112;
            Console.WriteLine(Abel);
            Console.WriteLine(Abel2);
        }
    }
}
