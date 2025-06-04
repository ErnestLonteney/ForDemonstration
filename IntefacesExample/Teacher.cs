using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntefacesExample
{
    class Teacher : Employee
    {     
        public string[] Subjects { get; set; }

        public override double CalculatePremia()
        {
             return Salary / 10; 
        }

        public override void RegisterInSystem(string data = null)
        {
            Console.WriteLine("Register in teacher system");
        }

        public override void Introduce()
        {
            base.Introduce(); // не обов'язково, але дозволяє викликати метод базового класу

            Console.WriteLine("I teach following subjects");
            for (int i = 0; i < Subjects.Length; i++)
            {
                Console.WriteLine(Subjects[i]);
            }
        }
    }
}
