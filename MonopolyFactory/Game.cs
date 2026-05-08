using MonopolyFactory.Factory;

namespace MonopolyFactory
{
    internal class Game
    {
        private AbstractBoard _board;
        private int currentPosition = 0;
        private bool endOfGame = false;


        public Game(AbstractMonopolyFactory monopolyFactory)
        {
            var deck1 = monopolyFactory.CreateGameDeck1();
            var deck2 = monopolyFactory.CreateGameDeck2();

            _board = monopolyFactory.CreateBoard(deck1, deck2);  
        }

        public void Start()
        {
            Console.WriteLine("Game Started");

            while (!endOfGame)
            {
                Console.WriteLine("Roll dices");
                Console.ReadKey();

                var dice1 = new Random().Next(1, 7);
                var dice2 = new Random().Next(1, 7);
                var result = dice1 + dice2;
                currentPosition += result;

                string currentField = _board[currentPosition] ?? "Unknown Field";

                switch (currentField)
                {
                    case "Chance": 
                        Console.WriteLine("You landed on Chance. Drawing a card...");
                        var chanceCard = _board.Chances.DrawCard();
                        Console.WriteLine($"Card Instruction: {chanceCard.Instruction}");
                        break;
                    case "Community Chest":
                        Console.WriteLine("You landed on Community Chest. Drawing a card...");
                        var communityChestCard = _board.CommunityChest.DrawCard();
                        Console.WriteLine($"Card Instruction: {communityChestCard.Instruction}");
                        break;
                      default:
                        Console.WriteLine($"You landed on {currentField}");
                        break;
                }

                if (currentPosition >= 39)
                {
                    endOfGame = true;
                    Console.WriteLine("Game Ended");
                }
            }
        }

    }
}
