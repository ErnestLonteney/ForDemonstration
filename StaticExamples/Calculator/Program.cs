namespace ConsoleApp47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator.Pi = 3.456159f;

            int sum = Calculator.Add(5, 3);
            Console.WriteLine($"5 + 3 = {sum}");

            int difference = Calculator.Subtract(5, 3);
            Console.WriteLine($"5 - 3 = {difference}");

            int product = Calculator.Multiply(5, 3);
            Console.WriteLine($"5 * 3 = {product}");

            double quotient = Calculator.Divide(5, 3);
            Console.WriteLine($"5 / 3 = {quotient}");

            var res = Calculator.GetCircleArea(18);
            Console.WriteLine(res);

            Calculator.Add(5, 3);

           var res2 = Calculator.GetCircleArea(18);
            Console.WriteLine(res2);

         //   calculator.DisplayOperationCount();
           // calculator2.DisplayOperationCount();
        }
    }
}
