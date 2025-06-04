using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IntefacesExample
{
    static class MessageSender
    {
        public static void SendMessage(string message, string reciplient, IContactInfo contactInfo)
        {          
            Console.WriteLine($"Sending message to {reciplient}: {contactInfo.Address}");
            Console.WriteLine($"Letter has been sent to you on number {contactInfo.Phone}" );
        }

        public static void SendEmail(string message, string reciplient, IContactInfo contactInfo)
        {
            Console.WriteLine($"Sending message to {reciplient} : {contactInfo.Email}");
        }
    }
}
