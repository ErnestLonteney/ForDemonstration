using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntefacesExample
{
    abstract class Person : IContactInfo
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public abstract void RegisterInSystem(string someData = null);

        public virtual void Introduce()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Phone: {Phone}, Email: {Email}");
        }

        public void PrintContactInfo()
        {
            Console.WriteLine($"Phohe = {Phone} Email = {Email} Address = {Address}");
        }

        public void SayHello()
        {
            throw new NotImplementedException();
        }
    }
}
