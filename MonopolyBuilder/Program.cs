using MonopolyFactory.Builder;
using MonopolyFactory.Factory;

namespace MonopolyFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var monopolyBuilder = new MonopolyClassicBoardBuilder();
            var game = new Game(monopolyBuilder);  

            game.Start();
        }
    }
}
