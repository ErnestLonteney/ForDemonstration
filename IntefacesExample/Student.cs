using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntefacesExample
{
    internal class Student : Person
    {      
        public Teacher GroupLeader { get; set; }

        public int Rating { get; set; }

        public string GroupName { get; set; }

        public override void RegisterInSystem(string data = null)
        {
            Console.WriteLine("Registered in google class");
        }
    }
}
