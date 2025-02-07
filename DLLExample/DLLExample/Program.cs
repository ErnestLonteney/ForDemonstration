namespace DLLExample
{
    using CalculatorDll;

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator myCal = new Calculator();
            var res = myCal.Add(45, 56);


            Console.WriteLine($"Result = {res}");

            Console.ReadLine(); 
        }
    }
}
