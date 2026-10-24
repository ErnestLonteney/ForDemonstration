using System;
using System.Collections.Generic;
using System.Text;

namespace InheritionAndPolymorphism
{
    internal class Manager : Employee
    {
        public string? Department { get; set; }

        public Manager(string firstName, string lastName, string title, decimal salary, string inn, string department) : base(firstName, lastName, title, inn, salary)
        {
            Department = department;
        }

        public override void IntroduceMyself()
        {
            Console.WriteLine($"Hello I am a manager. I manage department {Department}");
        }

        public void HireEmployee(Employee employee)
        {
            Console.WriteLine($"Hiring {employee.FirstName} {employee.LastName} for the position of {employee.Title} my inn is {inn}");
        }

        public override void SendReport(string myWork)
        {
            base.SendReport(myWork);
            Console.WriteLine($"Reported by {FirstName} {LastName}  manger of {Department}");
        }
    }
}
