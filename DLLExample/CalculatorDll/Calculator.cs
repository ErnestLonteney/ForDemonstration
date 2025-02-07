namespace CalculatorDll
{
    public class Calculator
    {
        private ResultCollection results;

        public Calculator()
        {
           results = new ResultCollection();    
        }

        public double Add(double a, double b)
        {
            var res = a + b;
            results.Add(res);   

            return res;
        }

        public double sub(double a, double b)
        {
            var res = a - b;
            results.Add(res);

            return res;
        }
    }
}
