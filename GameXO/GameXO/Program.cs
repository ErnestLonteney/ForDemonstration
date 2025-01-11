namespace GameXO
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("For start the game pres any key");
            Console.ReadKey();

            GameXO game = new GameXO();

            char current = 'X';
            do
            {
                Console.WriteLine("Turn " + current);
                Console.WriteLine("Input number of the line");
                bool lineNumberParseResult = byte.TryParse(Console.ReadLine(), out byte lineNumber);
                Console.WriteLine("Input number of the column");
                bool columnNumberParseResult = byte.TryParse(Console.ReadLine(), out byte columnNumber);

                if (!(lineNumberParseResult && columnNumberParseResult))
                {
                    Console.WriteLine("Wrong input");
                    continue;
                }

                game[lineNumber - 1, columnNumber - 1] = current;
                current = (current == 'X') ? 'O' : 'X';
            }
            while (!game.IsFinished);

            Console.WriteLine("You are win the game!");
        }
    }
}
