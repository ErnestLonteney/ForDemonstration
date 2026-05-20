using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeExample
{
    public abstract class Car
    {
        public int VIN { get; }

        public string Mark { get; set; }

        public string Model { get; set; }


        protected Car(string mark, string model)
        {
            Mark = mark;
            Model = model;
            VIN = new Random().Next(100000, 999999);
        }


        public abstract void Start();

        public abstract void Stop();

        public abstract void Accelerate(int delta);


    }
}
