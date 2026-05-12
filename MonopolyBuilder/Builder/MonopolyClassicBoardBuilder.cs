using MonopolyFactory.Factory;

namespace MonopolyFactory.Builder
{
    internal class MonopolyClassicBoardBuilder : MonopolyBoardBuilder
    {
        public override AbstractBoard BuildBoard(AbstractDeck deck1, AbstractDeck deck2)
        {
            return new ClassicBoard(deck1, deck2);  
        }

        public override AbstractDeck CreateDeck1()
        {
            ClassicCard[] cardsDef = [ new ClassicCard("1"), new ClassicCard("2"), new ClassicCard("3") ];

            return new ClassicGameDeck(cardsDef);
        }   

        public override AbstractDeck CreateDeck2()
        {
            ClassicCard[] cardsDef = [new ClassicCard("9"), new ClassicCard("10"), new ClassicCard("11")];

            return new ClassicGameDeck(cardsDef);
        }
    }
}
