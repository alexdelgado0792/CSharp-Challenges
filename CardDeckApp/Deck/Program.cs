using System;

namespace Deck
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //NormalGame();
            HighLowGame();

        }

        private static void HighLowGame()
        {
            var play = new LowHighDeck();
            bool retry;
            do
            {
                play.Draw();

                retry = play.ContinuePlaying();

                if (retry && play.mismatch)
                {
                    play.GetCard();
                }

            } while (retry);
        }

        private static void NormalGame()
        {
            var play = new StandardDeck();

            while (play.CardsLeft())
            {
                play.Draw();
            }
        }
    }
}
