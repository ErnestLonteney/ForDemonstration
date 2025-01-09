using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Factory
    {
        private Volume[] volumes;

        private int i = 0;

        public Factory()
        {
            volumes = new Volume[10];   
        }

        public Volume GetVolume(double value)
        {
            var newVolume = new Volume(value);
            volumes[i++] = newVolume;   

            return newVolume;
        }

        class Volume
        {
            public Volume(double value)
            {
                Value = value;
            }

            public double Value { get; }
        }

    }
}
