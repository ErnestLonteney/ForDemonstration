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

            decimal result = 0;

            try
            {
                float rate = float.Parse(rateInput);
                decimal sum = decimal.Parse(sumInput);

                result = sum / (decimal)rate;
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
            }
            catch (DivideByZeroException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something wrong");
            }
            finally // Exception or not, this block will always execute
            {
                Console.WriteLine("Execution completed.");
            }

           

            Console.WriteLine($"Sum in HRN = {result}");
        }
    }
}
