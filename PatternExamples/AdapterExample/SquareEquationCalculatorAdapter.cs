using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterExample
{
    public class SquareEquationCalculatorAdapter : ICalculator
    {
        private readonly SquareEquationCalculator _squareEquationCalculator;
        
        public SquareEquationCalculatorAdapter()
        {
            _squareEquationCalculator = new SquareEquationCalculator();
        }
    
        public string Name => "Square Equation Calculator";

        public string Calculate(object input)
        {
            double[] args = input as double[];

            var result = _squareEquationCalculator.GetRoots(args[0], args[1], args[2]);
            return $"Roots: {result.root1}, {result.root2}";
        }
    }
}
