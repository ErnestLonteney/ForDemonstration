using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Person : IAdditionalFunctionallity
    {
        public string Name { get; set; }

        public void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        public void Run()
        {
            Console.WriteLine("Run");
        }

        public void Sleep()
        {
            Console.WriteLine("I`m slipping...");
        }


        public string Work()
        {
            return "I`m working...";
        }

        public int Salary { get; set; }
    }
}
