namespace FlightwihgtPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckBoard board = new CheckBoard();
            board.Restart();

            board.Display();

            board.MoveFigure(1, 5, 3, 5);

            board.Display();
        }
    }
}
