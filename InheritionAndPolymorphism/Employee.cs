using System;
using System.Collections.Generic;
using System.Text;

namespace InheritionAndPolymorphism
{
    internal class Employee(string firstName, string lastName, string title, string inn, decimal salary) : Person(firstName, lastName)
    {
        protected string inn = inn;

        public string Title { get; set; } = title;

        public decimal Salary { get; set; } = salary;

        public override void IntroduceMyself()
        {
            Console.WriteLine($"Hello, I am {Title}");
        }

        public virtual void SendReport(string myWork)
        {
            PrintFullName();
            Console.WriteLine($"Sending report for {myWork}");
        }

        private void PrintFullName()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}");
        }


    }
}
