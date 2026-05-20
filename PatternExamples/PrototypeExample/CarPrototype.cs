using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeExample
{
    public class CarPrototype
    {
        public string CarType { get; set; }

        public int VIN { get; set; }

        public string Mark { get; set; }

        public string Model { get; set; }

        public CarPrototype Clone()
        {
            return new CarPrototype()
            {
                CarType = CarType,
                VIN = VIN,
                Mark = Mark,
                Model = Model
            };
        }

    }
}
