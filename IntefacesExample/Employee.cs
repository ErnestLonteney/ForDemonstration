using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntefacesExample
{
    abstract class Employee : Person
    {
        public string TitleOfPosition { get; set; }
        public double Salary { get; set; }

        public abstract double CalculatePremia();

        public void SendReport(string text)
        {
            RegisterInSystem(text);
            Console.WriteLine($"Report sent: {text}");
        }
    }
}
