namespace Deck
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var play = new StandardDeck();

            while (play.CardsLeft())
            {
                play.Draw();
            }

        }

    }
}
