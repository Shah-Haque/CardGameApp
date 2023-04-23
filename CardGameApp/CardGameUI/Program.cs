using System;
using System.Text;
using System.Threading.Tasks;

namespace CardGameUI
{

    class Program
    {
        static void Main(string[] args)
        {
            ///You can choose between blackJack or Poker by commenting out the variable and its call for either game

            //PokerDeck deck = new PokerDeck();

            //var hand = deck.DealCards();

            BlackJackDeck deck = new BlackJackDeck();

            var hand = deck.DealCards();

            foreach (var card in hand)
            {
                Console.WriteLine($"{card.Suit.ToString()} of {card.Value.ToString()}");
            }

            Console.ReadLine();
        }


    }
}