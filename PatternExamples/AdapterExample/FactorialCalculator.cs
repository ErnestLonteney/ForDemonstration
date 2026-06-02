using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterExample
{
    public class FactorialCalculator : ICalculator
    {
        public string Name => "Factorial Calculator";

        public string Calculate(object input)
        {
            if (input is int n)
            {
                return Factorial(n).ToString();
            }

            throw new ArgumentException("Input must be an integer");
        }

        private int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
    }
}
