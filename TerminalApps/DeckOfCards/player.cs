using System.Collections.Generic;
namespace DeckOfCards
{
        public class Player
        {
            string Name;
            public List<Card> onHand = new List<Card>();
            public Player(string name)
            {
                Name = name;
            }
            public Card pickCard(Deck deck)
            {
                // System.Console.WriteLine("    ");
                // System.Console.WriteLine("     ");
                // System.Console.WriteLine("picking card");

                onHand.Add(deck.topMost());
                // foreach (Card card in onHand)
                // {
                //     System.Console.WriteLine(card.stringVal);
                // }
                return deck.topMost();
            }

            public Card discardCard(int index)
            {
                // foreach (Card card in onHand)
                // {
                //     System.Console.WriteLine(card.stringVal);
                // }

                if (onHand.Count > index)
                {
                    Card temp = onHand[index];
                    onHand.RemoveAt(index);
                    // foreach (Card card in onHand)
                    // {
                    //     System.Console.WriteLine(card.stringVal);
                    // }
                    return temp;
                }

                System.Console.WriteLine("Stop it you!!! you dont have card on that index");
                return null;
            }
        }
    
}