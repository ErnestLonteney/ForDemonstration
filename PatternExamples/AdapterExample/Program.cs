namespace AdapterExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose operation");
            Console.WriteLine("1-Calculate factorial");
            Console.WriteLine("2-Calculate square equation");

            string answer = Console.ReadLine() ?? string.Empty;

            switch (answer)
            {
                case "1":
                    var factorialCalculator = new FactorialCalculator();
                    Console.WriteLine(MathProcessor.Process(factorialCalculator, 5));
                    break;
                case "2":
                    var squareEquationCalculator = new SquareEquationCalculatorAdapter();
                    Console.WriteLine(MathProcessor.Process(squareEquationCalculator, new double[] { 1, -5, 6 }));
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
