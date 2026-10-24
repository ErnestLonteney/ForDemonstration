using System;
using System.Collections.Generic;
using System.Text;

namespace InheritionAndPolymorphism
{
    internal class VIPClient(string firstName, string lastName, string iban, string vipCode) 
                 : Client(firstName, lastName, iban)
    {
        public string VIPCode { get; set; } = vipCode;

        public double Discount { get; set; }

        public override void IntroduceMyself()
        {
            Console.WriteLine($"Hello, I am {FirstName} {LastName} and my IBAN is {IBAN}. My VIP code is {VIPCode}");
        }
    }
}
