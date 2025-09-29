namespace Matrix
{
    internal class Program
    {
        static string GenerateString()
        {
            var random = new Random();
            var length = random.Next(8, 15);
            string result = string.Empty;

            for (int i = 0; i < length; i++)
            { 
                char randomChar = (char)random.Next(48, 90);
                result += randomChar;
            }

            return result;
        }

        static void PrintMatrix(object indentant)
        {
            while (true)
            {
                string randomString = GenerateString();
                lock (new object())
                {
                    for (int j = 0; j < randomString.Length; j++)
                    {
                        Thread.Sleep(20);
                        Console.ForegroundColor = (j == randomString.Length - 2) ? ConsoleColor.Green : (j == randomString.Length - 1) ? ConsoleColor.White : ConsoleColor.DarkGreen;
                        Console.WriteLine(new string(' ', (int)indentant * 2) + randomString[j]);
                    }

                    var spaceCount = new Random().Next(1, 4);
                    for (int x = 0; x < spaceCount; x++)
                        Console.WriteLine();
                    Thread.Sleep(500);
                }       
            }
        }

        static void Main()
        {
            for (int i = 0; i < 100; i++)
            {
                new Thread(PrintMatrix).Start(i);
            }
        }
    }
}
