namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hrn = CurrencyConverter.ConvertDollarsToHrn(500);

            Console.WriteLine($"Sum in hrn {hrn}");

            Convert.ToDecimal(hrn.ToString()); 

            CurrencyConverter.EuroRate = 47;
            CurrencyConverter.DallarRate = 42.5;         

            var dollars = CurrencyConverter.ConvertHrnToDollars(10_000);
            Console.WriteLine($"Dollars={dollars}");

            CurrencyConverter.EuroRate = 46;
            CurrencyConverter.DallarRate = 49;

           var hrn3 = CurrencyConverter.ConvertEuroToHrn(1000);
           Console.WriteLine($"Hrn = {hrn3}");
        }
    }
}
