using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterExample
{
    class SquareEquationCalculator 
    {
        private double GetDiscriminant(double a, double b, double c) =>  Math.Pow(b, 2) - 4 * a * c;

        public (double root1, double root2) GetRoots(double a, double b, double c)
        {
            var discriminant = GetDiscriminant(a, b, c);
            if (discriminant < 0)
            {
                throw new ArgumentException("No real roots");
            }

            var sqrtDiscriminant = Math.Sqrt(discriminant);
            var root1 = (-b + sqrtDiscriminant) / (2 * a);
            var root2 = (-b - sqrtDiscriminant) / (2 * a);

            return (root1, root2);
        }
    }
}
