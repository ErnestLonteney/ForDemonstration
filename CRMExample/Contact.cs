using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace CRMExample
{
    internal class Contact
    {
        private readonly Status status;

        public Guid Id { get; }

        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public ContactInfo[] Info { get; set; } = [];
        public Address Address { get; set; }

        public byte[]? Photo { get; set; } 

        public string Description { get; set; }

        public Account? Account { get; set; }


        public Contact(string firstName, string secondName, Status status)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;  
            LastName = secondName;
            this.status = status;
        }

        public string GetMyInfo()
        {
            string info = @$"Name {FirstName} {LastName}
Info - {Description}";

            info += '\n';

            switch (status)
            {
                case Status.VIP:
                    info += "VIP";
                break;
                case Status.Politic:
                    info += $"Middle Name - {MiddleName}";
                    break;
            }

            info += "\n";

            if (Account is not null)
                info += $"Company = {Account.Name}";


            return info;
        }
    }
}