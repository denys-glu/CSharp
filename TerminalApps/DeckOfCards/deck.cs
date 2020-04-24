using System;
using System.Collections.Generic;
namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> Cards = new List<Card>();
        Random rand = new Random();
        string[] valTemplate = new string[13] {
                "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"
            };
        string[] suitNames = new string[4] { "Clubs", "Spades", "Hearts", "Diamonds" };

        public Deck()
        {
            fillDeck();
        }
        public void resetDeck()
        {
            Cards.RemoveRange(0, Cards.Count);
            fillDeck();
        }

        void fillDeck()
        {
            for (int i = 0; i < suitNames.Length; i++)
            {
                for (int j = 0; j < valTemplate.Length; j++)
                {
                    Card newCard = new Card(valTemplate[j], suitNames[i], j + 1);
                    Cards.Add(newCard);
                }
            }
        }
        public Card topMost()
        {
            Card topMost = Cards[0];
            Cards.RemoveAt(0);
            // System.Console.WriteLine(Cards.Count);
            // System.Console.WriteLine(topMost.stringVal);
            return topMost;
        }
        public void Shuffle()
        {
            for (var i = 0; i < Cards.Count; i++)
            {
                int k = rand.Next(i + 1);
                var temp = Cards[k];
                Cards[k] = Cards[i];
                Cards[i] = temp;
            }
        }
    }
}