using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace FacadeExample
{
    internal class StorageManager
    {
        public bool IsAvialiable(string productName, int quantity)
        {
            return true;
        }

        public void Reserve(string productName, int quantity)
        {
            // Simulate reserving the product
            Console.WriteLine($"Reserving {quantity} of {productName}");
        }
        
        public void CancelReservation(string productName, int quantity)
        {
            // Simulate canceling the reservation
            Console.WriteLine($"Canceling reservation of {quantity} of {productName}");
        }   
    }
}
