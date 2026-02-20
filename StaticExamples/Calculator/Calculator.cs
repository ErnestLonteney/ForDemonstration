using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp47
{
    static class Calculator
    {
        static Calculator()
        {
            Pi = 3.14f;
        }

        public static float Pi { get; set; }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (double)a / b;
        }

        public static double GetCircleArea(float radius)
        {
            return Pi * radius * radius;
        }
    }
}
