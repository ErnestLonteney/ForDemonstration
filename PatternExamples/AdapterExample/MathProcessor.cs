namespace AdapterExample
{
    static class MathProcessor
    {
        public static string Process(ICalculator calculator, object args)
        {
            var result = calculator.Calculate(args);    
            return $"Processed by {calculator.Name}: {result}";
        }   
    }
}
