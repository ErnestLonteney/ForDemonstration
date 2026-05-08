namespace MonopolyFactory.Factory
{
    abstract class AbstractBoard(AbstractDeck chanceDeck, AbstractDeck communityChestDeck)
    {
        public AbstractDeck Chances { get; } = chanceDeck;
        public AbstractDeck CommunityChest { get; } = communityChestDeck;

        protected string[] fields = new string[36];

        public string? this[int index]
        {
            get
            {
                if (index >= 0 && index < 40)
                {
                    return fields[index];
                }

                return null;
            }
        }
    }
}
