using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {      
        public int Id 
        {
            get;           
        }  

        public string FirstName { get; } // private string firstName null

        public string LastName { get;  } // private string lastName; null

        public string PhoneNumber { get; set; } // private string phoneNumber; null

        public string Email { get; set; }


        public Person(string firstName, string lastName)
        {
            Id = 1000 * 10 / DateTime.Now.Second;
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, string phone)
            :this(firstName, lastName)
        {            
            PhoneNumber = phone;
        }        
    }
}
