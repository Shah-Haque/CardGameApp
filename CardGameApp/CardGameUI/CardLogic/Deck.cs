using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGameUI
{
    public abstract class Deck
    {

        /// <summary>
        /// List of cards variables
        /// </summary>
        protected List<PlayingCardModel> FullDeck = new List<PlayingCardModel>();
        protected List<PlayingCardModel> DrawPile = new List<PlayingCardModel>();
        protected List<PlayingCardModel> DiscardPile = new List<PlayingCardModel>();


        protected void CreateDeck()
        {
            FullDeck.Clear();

            for (int suit = 0; suit < 4; suit++)
            {
                for (int val = 0; val < 13; val++)
                {
                    FullDeck.Add(new PlayingCardModel { Suit = (CardSuit)suit, Value = (CardValue)val});
                }
            }
        }

        public virtual void ShuffleDeck()
        {
            //This will create a new system where the system
            //will generate pseudo random numbers
            var random = new Random();

            //This will order the list by the value and display it as a list
            DrawPile = FullDeck.OrderBy(x => random.Next()).ToList();
        }

        public abstract List<PlayingCardModel> DealCards();

        protected virtual PlayingCardModel DrawOneCard()
        {
            PlayingCardModel output = DrawPile.Take(1).First();
            DrawPile.Remove(output);
            return output;
        }
    }
}