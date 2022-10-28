using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public enum CardValue
    {
        six = 6,
        seven,
        eight,
        nine,
        ten,
        jack,
        queen,
        king,
    }
    public enum CardName
    {
        Spades,
        Diamonds,
        Hearts,
        Clubs, 
    }

    internal class Card
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public Image Suit { get; set; }

        public Card(Image suit, string value, string name)
        {
            Suit = suit;
            Value = value;
            Name = name;
        }
    }
}
