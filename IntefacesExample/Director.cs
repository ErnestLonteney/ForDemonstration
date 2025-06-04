using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntefacesExample
{
    internal class Director : Employee
    {      

        public string Department { get; set; }

        public override double CalculatePremia()
        {
            return Salary;
        }

        public override void RegisterInSystem(string data = null)
        {
            Console.WriteLine("Register into CRM");
        }

        public override void Introduce()
        {
            base.Introduce(); // не обов'язково, але дозволяє викликати метод базового класу
            Console.WriteLine($"I am director of {Department} department");
        }
    }
}
