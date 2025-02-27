using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Customer : Person
    {
        public Customer(string firstName, string lastName) 
            : base(firstName, lastName)
        {
        }

        public string Contract { get; set; }
    }
}
