namespace Bits
{
    internal class Program
    {
        static void Main()
        {
            byte a, n;
            int c = 0;
            string sign;

            Console.WriteLine("Input number");
            string answer = Console.ReadLine();

            if (byte.TryParse(answer, out a))
            {
                Console.WriteLine("Input operation (*, /)");
                sign = Console.ReadLine();
                Console.WriteLine("Input second opperand (for 2 - 1, 4 - 2, 8 - 3, 16 - 4)");
                answer = Console.ReadLine();    

                if (byte.TryParse(answer, out n))
                {
                    c = (sign) switch
                    { 
                        "/" => a >> n,
                        "*" => a << n,
                        _ => 0
                    };
                }

                Console.WriteLine($"Result = {c}");
            }

            Console.WriteLine("Wrong input");
        }
    }
}
