using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        public enum Genders { male, female }

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Genders gender;
        
        public Person(string name, DateTime birthdate, Genders gender )
        {
            this.Name = name;
            this.BirthDate = birthdate;
            this.gender = gender;
        }


        public override string ToString()
        {
            return this.Name + " " + this.BirthDate + " " + this.gender;
        }

        static void Main(string[] args)
        {
            Person abel = new Person("Ábel Váradi", new DateTime(1984,03,28), Genders.male);
            Console.WriteLine(abel);
        }
    }
}
