namespace ExceptionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input rate");
            string rateInput = Console.ReadLine();

            Console.WriteLine("Input sum");
            string sumInput = Console.ReadLine();

            double result = 0;

            try
            {
                double rate = double.Parse(rateInput);
                double sum = double.Parse(sumInput);
                if (rate == 0)
                    throw new Exception("Divide by zero attept");

                result = sum / rate;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something wrong");
            }


            //finally // Exception or not, this block will always execute
            //{
            //    Console.WriteLine("Execution completed.");
            //}

            Console.WriteLine($"Sum in HRN = {result}");
        }
    }
}
