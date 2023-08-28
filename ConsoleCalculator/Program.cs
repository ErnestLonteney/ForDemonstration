namespace CalculatorGeneric
{
    internal class Program
    {
        static void DivideByZero(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Attempt divide by zero");
            Console.ForegroundColor= ConsoleColor.White;
        }

        static void Main()
        {
            Calculator.DivideByZero += new EventHandler(DivideByZero);

            double result = Calculator.Add(45, 47);
            double? result2 = Calculator.Divide(47, 0);

            Console.WriteLine(result);
        }
    }
}