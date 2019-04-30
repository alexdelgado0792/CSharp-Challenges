using Deck.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Deck
{
    public abstract class NumericalDeck
    {
        public IDictionary<StandardSuit, IList<int>> MyDeck = new Dictionary<StandardSuit, IList<int>>()
        {
            { StandardSuit.Clubs, Enumerable.Range(1, 13).Select(x => x).ToList() },
            { StandardSuit.Diamonds, Enumerable.Range(1, 13).Select(x => x).ToList() },
            { StandardSuit.Hearts, Enumerable.Range(1, 13).Select(x => x).ToList() },
            { StandardSuit.Spades, Enumerable.Range(1, 13).Select(x => x).ToList() }
        };

        public virtual void Draw()
        {
            throw new NotImplementedException();
        }

        public bool CardsLeft()
        {
            return MyDeck.Values.Sum(x => x.Count()) > 0;
        }
    }
}
