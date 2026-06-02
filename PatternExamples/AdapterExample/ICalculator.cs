using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterExample
{
    internal interface ICalculator
    {
        public string Calculate(object input);

        public string Name { get; }      
    }
}
