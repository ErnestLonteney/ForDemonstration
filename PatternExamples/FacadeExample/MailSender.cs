using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeExample
{
    internal class MailSender
    {
        public void SendMailRegardingOrder(string text, Order order)
        {
            // Simulate sending an email
            Console.WriteLine($"Sending email to: {order.Email}");
            Console.WriteLine($"Subject: Order Confirmation");
            Console.WriteLine($"Body: {text}");
        }
        
    }
}
