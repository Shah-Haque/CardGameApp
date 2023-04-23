using System.Collections.Generic;

namespace CardGameUI
{
    public class PokerDeck : Deck
    {
        public PokerDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();

            for (int i = 0; i < 5; i++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }

        public List<PlayingCardModel> RequestCards(List<PlayingCardModel > cardstoDiscard)
        {
            List<PlayingCardModel > output = new List<PlayingCardModel>();

            foreach (var card  in cardstoDiscard)
            {
                output.Add(DrawOneCard());
                DiscardPile.Add(card);
            }
            return output;
        }
    }
}