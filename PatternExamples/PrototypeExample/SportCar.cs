using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeExample
{
    internal class SportCar : Car
    {
        public int Nitro { get; }

        public SportCar(string mark, string model) : base(mark, model)
        {
            Nitro = 100;
        }

        public override void Start()
        {
            Console.WriteLine("Sport car started.");
        }

        public override void Stop()
        {
            Console.WriteLine("Sport car stopped.");
        }

        public override void Accelerate(int delta)
        {
            Console.WriteLine($"Sport car accelerated by {delta} mph.");
        }
    }
}
