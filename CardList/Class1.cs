using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardList
{
    public enum Value
    {
        six,
        seven,
        eight,
        nine,
        ten,
        jack,
        queen,
        king,
        ace,
    }

    public enum Suits
    {
        clubs,
        hearts,
        diamonds,
        spades,
    }

    class Card
    {
        private Value value;
        private Suits suits;

        public Card(Value value, Suits suits)
        {
            this.value = value;
            this.suits = suits;
        }

        public string show()
        {
            return $"{value} -- {suits}";
        }
    }

    class Deck
    {
        private List<Card> cards;

        public Deck(IEnumerable<Card> cards)
        {
            this.cards = new List<Card>(cards);
        }
        public Deck()
        {
            this.cards = new List<Card>();
        }

        public IEnumerable<string> show()
        {
            List<string> res = new List<string>();

            if (cards.Count > 0)
            {
                foreach (Card card in cards)
                {
                    res.Add(card.show());
                }
            }

            return res;
        }

        public Card deleteCard(int index)
        {
            Card tmp = this.cards[index];
            cards.RemoveAt(index);

            return tmp;
        }

        public void addCard(Card card)
        {
            cards.Add(card);
        }
    }
}
