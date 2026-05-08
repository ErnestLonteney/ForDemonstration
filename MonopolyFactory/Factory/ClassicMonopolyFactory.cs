namespace MonopolyFactory.Factory
{
    class ClassicMonopolyFactory : AbstractMonopolyFactory
    {
        public override AbstractBoard CreateBoard(AbstractDeck deck1, AbstractDeck deck2)
        {
            return new ClassicBoard(deck1, deck2);
        }

        public override AbstractDeck CreateGameDeck1()
        {
            var cards = new AbstractCard[]
            {
                new ClassicCard("Advance to Go (Collect $200)"),
                new ClassicCard("Bank error in your favor – Collect $200"),
                new ClassicCard("Doctor's fees – Pay $50"),
                new ClassicCard("Get Out of Jail Free – This card may be kept until needed, or traded/sold"),
                new ClassicCard("Go to Jail – Go directly to Jail – Do not pass Go, do not collect $200"),
                new ClassicCard("It is your birthday Collect $10 from each player"),
                new ClassicCard("Grand Opera Night – Collect $50 from every player for opening night seats"),
                new ClassicCard("Holiday Fund matures - Receive $100"),
                new ClassicCard("Income tax refund – Collect $20"),
                new ClassicCard("Life insurance matures – Collect $100"),
                new ClassicCard("Pay hospital fees of $100"),
                new ClassicCard("Pay school fees of $150"),
                new ClassicCard("Receive $25 consultancy fee"),
                new ClassicCard("You are assessed for street repairs: Pay $40 per house and $115 per hotel you own")
            };

            cards.Shuffle();

            return new ClassicGameDeck(cards);
        }

        public override AbstractDeck CreateGameDeck2()
        {
            var cards = new AbstractCard[]
            {
                new ClassicCard("Advance to Illinois Ave. If you pass Go, collect $200"),
                new ClassicCard("Advance to St. Charles Place. If you pass Go, collect $200"),
                new ClassicCard("Advance token to nearest Utility. If unowned, you may buy it from the Bank. If owned, throw dice and pay owner a total ten times the amount thrown."),
                new ClassicCard("Advance token to the nearest Railroad and pay owner twice the rental to which they are otherwise entitled. If Railroad is unowned, you may buy it from the Bank."),
                new ClassicCard("Bank pays you dividend of $50"),
                new ClassicCard("Get Out of Jail Free – This card may be kept until needed, or traded/sold"),
                new ClassicCard("Go Back 3 Spaces"),
                new ClassicCard("Go to Jail – Go directly to Jail – Do not pass Go, do not collect $200"),
                new ClassicCard("Make general repairs on all your property: For each house pay $25, For each hotel pay $100"),
                new ClassicCard("Pay poor tax of $15"),
                new ClassicCard("Take a trip to Reading Railroad. If you pass Go, collect $200"),
                new ClassicCard("Take a walk on the Boardwalk. Advance token to Boardwalk"),
                new ClassicCard("You have been elected Chairman of the Board – Pay each player $50"),
                new ClassicCard("Your building loan matures – Collect $150"),
                new ClassicCard("You have won a crossword competition - Collect $100"),
                new ClassicCard("You inherit $100")
            };

            cards.Shuffle();

            return new ClassicGameDeck(cards);  
        }
    }
}
