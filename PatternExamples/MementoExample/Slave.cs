using System;
using System.Collections.Generic;
using System.Text;

namespace MementoExample
{
    internal class Slave
    {
        public required string Name { get; init; }

        public StorageBack StorageBack { get; set; } = new();



        public void Fight()
        {
            Console.WriteLine($"Slave {Name} is fighting");
        }
    }
}
