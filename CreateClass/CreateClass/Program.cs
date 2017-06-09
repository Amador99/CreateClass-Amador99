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
            Person abel = new Person("Ábel Váradi", new DateTime(1984,03,28), Genders.male);
            Console.WriteLine(abel);
        }
    }
}
