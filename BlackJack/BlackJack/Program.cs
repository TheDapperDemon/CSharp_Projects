using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Card
    {
        public class Deck
        {
            public Deck()
            {
                //Cards = new List<Card>();
                //Card cardOne = new Card();
                //cardOne.Face = "Two";
                //cardOne.Suit = "Hearts";
                //Cards.Add(cardOne);

                Cards = new List<Cards>();
                List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
                List<string> Faces = new List<string>()
                {
                    "Two", "Three", "Four", "Five", "Six", "Seven",
                    "Eight", "Nine", "Ten", "Jack", "King", "Queen", "Ace"
                };

                foreach (string in Faces)
                {
                    foreach (string in Suits)
                    {
                        Card card = new Card();
                        card.Suit = suit;
                        card.Face = face;
                        Cards.Add(card);
                    }
                }
            }
            public List<Card> Cards { get; set; }
        }
    }
}
