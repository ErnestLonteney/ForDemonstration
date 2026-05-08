using MonopolyFactory.Factory;

namespace MonopolyFactory
{
    internal class ClassicBoard : AbstractBoard
    {
        public ClassicBoard(AbstractDeck deck1, AbstractDeck deck2)
            : base(deck1, deck2)
        {
            fields = [
               "Start",
                "Mediterranean Avenue",
                "Community Chest",
                "Baltic Avenue",
                "Income Tax",
                "Reading Railroad",
                "Oriental Avenue",
                "Chance",
                "Vermont Avenue",
                "Connecticut Avenue",
                "Jail/Just Visiting",
                "St. Charles Place",
                "Electric Company",
                "States Avenue",
                "Virginia Avenue",
                "Pennsylvania Railroad",
                "St. James Place",
                "Community Chest",
                "Tennessee Avenue",
                "New York Avenue",
                "Free Parking",
                "Kentucky Avenue",
                "Chance",
                "Indiana Avenue",
                "Illinois Avenue",
                "B&O Railroad",
                "Atlantic Avenue",
                "Ventnor Avenue",
                "Water Works",
                "Marvin Gardens",
                "Go To Jail",
                "Pacific Avenue",
                "North Carolina Avenue",
                "Community Chest",
                "Pennsylvania Avenue (Green)",
                "Short Line Railroad",
                "Chance (Dark Blue)",
                "Park Place (Dark Blue)",
                "Luxury Tax (Dark Blue)"
       ];
     }
    }
}
