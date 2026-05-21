namespace EventExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var monopoly = new Monopoly();

            monopoly.OnPassGo += () =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("GO");
                Console.ResetColor();
            };

            monopoly.OnGoToJail += () =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("GO to jail!");
                Console.ResetColor();
            };

            while (!monopoly.IsEndOfGame)
            {
                Console.WriteLine("Rolling dice... ");
                Console.ReadKey();
                monopoly.RollDice();
                Console.WriteLine($"You rolled a {monopoly.DiceValue}");
                Console.WriteLine($"You are on {monopoly.CurretField}");
                string currentField = monopoly.ProcessResult();
               
                Console.WriteLine(currentField);
            }
        }
    }
}
