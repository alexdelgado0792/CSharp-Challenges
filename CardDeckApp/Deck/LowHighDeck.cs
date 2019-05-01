using Deck.Enums;
using System;
using System.Linq;

namespace Deck
{
    public class LowHighDeck : NumericalDeck
    {
        private Card myCard;
        private Card drawCard;
        public bool mismatch;

        public LowHighDeck()
        {
            myCard = GetCard();
        }

        public override void Draw()
        {
            Console.WriteLine($"My Card is {myCard.Number}.");

            var option = Menu();
            var result = LowHigh(option);

            Console.Clear();

            Console.WriteLine($"New card is [{drawCard.Number}] and {option} than My Card [{myCard.Number}] =>  {result}");

            if (result)
            {
                myCard = drawCard;
            }
            else
            {
                mismatch = true;
                Console.WriteLine($"You Lose!!!!");
            }
        }

        public bool LowHigh(Option option)
        {
            drawCard = new Card()
            {
                Suit = (StandardSuit)random.Next(0, 4),
                Number = random.Next(1, 14)
            };

            bool result;

            if (option == Option.Lower)
            {
                result = drawCard.Number <= myCard.Number;
            }
            else
            {
                result = drawCard.Number >= myCard.Number;
            }

            return result;
        }

        private static Option Menu()
        {
            Console.WriteLine("Next Card will be Low or High?");
            Console.WriteLine("0.- Low.     1.- High.");
            var option = Console.ReadLine();

            if (!option.All(char.IsDigit))
            {
                Console.WriteLine("Not Valid option. Try Again.");
                Menu();
            }

            var value = Convert.ToInt32(option);
            if (value < 0 || value > 1)
            {
                Console.WriteLine("Not Valid option. Try Again.");
                Menu();
            }

            Console.Clear();

            return (Option)value;
        }

        public bool ContinuePlaying()
        {
            Console.WriteLine("Continue Playing ?");
            Console.WriteLine("0.- No.     1.- Yes.");
            var option = Console.ReadLine();

            if (!option.All(char.IsDigit))
            {
                Console.WriteLine("Not Valid option. Try Again.");
                ContinuePlaying();
            }

            var value = Convert.ToInt32(option);
            if (value < 0 || value > 1)
            {
                Console.WriteLine("Not Valid option. Try Again.");
                ContinuePlaying();
            }

            Console.Clear();
            return Convert.ToBoolean(value);
        }

        public Card GetCard()
        {
            return new Card()
            {
                Suit = (StandardSuit)random.Next(0, 4),
                Number = random.Next(1, 14)
            };
        }
    }

    #region Support Classes 

    public class Card
    {
        public StandardSuit Suit { get; set; }
        public int Number { get; set; }
    }

    public enum Option
    {
        Lower,
        Higher
    }

    #endregion
}
