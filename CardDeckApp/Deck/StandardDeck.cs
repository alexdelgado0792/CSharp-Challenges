using Deck.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Deck
{
    public class StandardDeck : NumericalDeck
    {
        public IDictionary<StandardSuit, IList<int>> PlayedCards = new Dictionary<StandardSuit, IList<int>>()
        {
            { StandardSuit.Clubs, new List<int>() },
            { StandardSuit.Diamonds, new List<int>()},
            { StandardSuit.Hearts, new List<int>() },
            { StandardSuit.Spades, new List<int>() }
        };

        private readonly Random random = new Random();

        public override void Draw()
        {
            var suit = (StandardSuit)random.Next(0, 4);
            int number = random.Next(1, 14);

            if (AlreadyPlayed(suit, number))
            {
                Console.WriteLine($"*****Already played {ValueToName(number)}-{suit.ToString()}*****");
                Draw();
            }
            else
            {
                Console.WriteLine($"{MyDeck.Values.Sum(x => x.Count())} Left => {ValueToName(number)}-{suit.ToString()} played.");
                MyDeck[suit].Remove(number);
                PlayedCards[suit].Add(number);
            }
        }

        private bool AlreadyPlayed(StandardSuit suit, int number)
        {
            return PlayedCards[suit].Contains(number);
        }

        private string ValueToName(int number)
        {
            switch (number)
            {
                case 1:
                    return "Ace";
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    return number.ToString();
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                default:
                    throw new ArgumentException("Unrecognized card value.");

            }
        }
    }
}