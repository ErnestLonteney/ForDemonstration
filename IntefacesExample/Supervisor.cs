using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntefacesExample
{
    internal class Supervisor : IContactInfo
    {
        public string LicenseCode { get; set; }

        public void MakeCheck()
        {
            Console.WriteLine("Making check...");   
        }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public void PrintContactInfo()
        {
            Console.WriteLine($"Enail {Email}");
        }

        public void SayHello()
        {
            throw new NotImplementedException();
        }
    }
}
