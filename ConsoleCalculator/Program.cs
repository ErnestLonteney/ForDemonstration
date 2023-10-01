namespace CalculatorGeneric
{
    internal class Program
    {      
        static void Main()
        {
            Calculator.DivideByZero += (sender, e) => 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Attempt divide by zero");
                Console.ResetColor();
            };

            double result = Calculator.Add(45, 47);
            double? result2 = Calculator.Divide(47, 0);

            Console.WriteLine(result);
        }
    }
}