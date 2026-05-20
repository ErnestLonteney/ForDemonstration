using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeExample
{
    internal class SpaceCar : SportCar
    {
        public void HyperAccelerate()
        {
            Console.WriteLine("Space car is hyper accelerating!");
        }   

        public SpaceCar(string mark, string model) : base(mark, model)
        {
        }
    }
}
