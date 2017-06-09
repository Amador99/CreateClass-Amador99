using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person
    {
        public int Salary { get; set; }
        public string Profession { get; set; }
        public Room HotelRoom { get; set; }

        public Employee(string name, DateTime birthdate, Genders gender ,int salary, string profession) : base(name, birthdate, gender)
        {
            this.Salary = salary;
            this.Profession = profession;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.Salary + " " + this.Profession + " " + this.HotelRoom.RoomNumber;
        }
    }
}
