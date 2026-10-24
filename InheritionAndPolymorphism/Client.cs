using System;
using System.Collections.Generic;
using System.Text;

namespace InheritionAndPolymorphism
{
    internal class Client : Person
    {
        public required string IBAN { get; set; }

        public override void IntroduceMyself()
        {
            Console.WriteLine($"Hello, I am {FirstName} {LastName} and my IBAN is {IBAN}");
        }


        public Client(string firstName, string lastName, string iban) : 
            base(firstName, lastName)
        {
            IBAN = iban;
        }
    }
}
