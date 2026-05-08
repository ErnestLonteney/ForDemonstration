namespace MonopolyFactory.Factory
{
    abstract class AbstractDeck(IEnumerable<AbstractCard> cards)
    {
        protected Queue<AbstractCard> cards { get; set; } = new Queue<AbstractCard>(cards);

        public AbstractCard DrawCard()
        {
            var card = cards.Dequeue();            
            cards.Enqueue(card);

            return card;
        }
    }
}
