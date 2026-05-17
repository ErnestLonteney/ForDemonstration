using MonopolyFactory.Factory;

namespace MonopolyFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var monopolyFactory = new ClassicMonopolyFactory();
            var game = new Game(monopolyFactory);  

            game.Start();
        }
    }
}
