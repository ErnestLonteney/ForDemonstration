using MonopolyFactory.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonopolyFactory.Builder
{
    abstract class MonopolyBoardBuilder
    {
        protected AbstractBoard board;

        public abstract AbstractDeck CreateDeck1();

        public abstract AbstractDeck CreateDeck2();

        public abstract AbstractBoard BuildBoard(AbstractDeck deck1, AbstractDeck deck2);
    }
}
