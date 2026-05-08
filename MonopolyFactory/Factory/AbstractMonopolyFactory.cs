namespace MonopolyFactory.Factory
{
    abstract class AbstractMonopolyFactory
    {
        public abstract AbstractBoard CreateBoard(AbstractDeck deck1, AbstractDeck deck2);       
        public abstract AbstractDeck CreateGameDeck1();
        public abstract AbstractDeck CreateGameDeck2();
    }
}
