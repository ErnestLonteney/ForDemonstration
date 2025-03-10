using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Emploee : Person
    {
        public string Position { get; set; } // null

        public double Sallary { get; set; } // 0

        public Emploee(string firstName, string lastName, double sallary)
            : base(firstName, lastName) // new Person("Jeffry", "Rihter")
        {
            Sallary = sallary;
        }

        public Emploee(string firstName, string lastName, double sallary, string position)
            :this(firstName, lastName, sallary)
        {
            Position = position;     
        }

        public override string GetInfo()
        {
           string info = base.GetInfo();

           info += @$"Possition {Position}
Sallary {Sallary}";

            return info;
        }

    }
}
