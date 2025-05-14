namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grns = Converter.ConvertDollarsToHrn(500);

            Console.WriteLine($"Sum in hrn {grns}");


            Converter.EuroRate = 47;
            Converter.DallarRate = 42.5;


            var grns2 = Converter.ConvertDollarsToHrn(500);
            var dollars = Converter.ConvertHrnToDollars(10_000);

            Console.WriteLine($"Dollars={dollars}");

            Console.WriteLine($"Sum in hrn {grns2}");

            Converter.EuroRate = 46;
            Converter.DallarRate = 49;

           var hrn3 = Converter.ConvertEuroToHrn(1000);
           Console.WriteLine($"Hrn = {hrn3}");
        }
    }
}
