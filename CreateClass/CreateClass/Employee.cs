using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        public int Salary { get; set; }
        public string Profession { get; set; }
        public Room Room { get; set; }

        public Employee(string name, DateTime birthdate, Genders gender ,int salary, string profession) : base(name, birthdate, gender)
        {
            this.Salary = salary;
            this.Profession = profession;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.Salary + " " + this.Profession + " " + this.Room.Number;
        }

        /*public object Clone()
        {
            return this.MemberwiseClone();
        }
        */

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }
    }
}
