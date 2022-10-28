using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    internal class Deck
    {
        Card[] cards;

        public Deck()
        {
            cards = new Card[32];

            for (int i = 0,z = 6,y = 0; i < cards.Length;i++)
            {
                if(i < 8)
                {
                    cards[i] = new Card(Image.FromFile($@"../../images/cards/Spades/{z}.png"),
                        ((CardValue)z).ToString(),
                        ((CardName)y).ToString());

                    z++;
                }
                else if (i > 7 && i < 16)
                {
                    if(y == 0)
                    {
                        y++;
                        z = 6;
                    }

                    cards[i] = new Card(Image.FromFile($@"../../images/cards/Diamonds/{z}.png"),
                        ((CardValue)z).ToString(),
                        ((CardName)y).ToString());

                    z++;
                }
                else if (i > 15 && i < 24)
                {
                    if (y == 1)
                    {
                        y++;
                        z = 6;
                    }

                    cards[i] = new Card(Image.FromFile($@"../../images/cards/Hearts/{z}.png"),
                        ((CardValue)z).ToString(),
                        ((CardName)y).ToString());

                    z++;
                }

                else if (i > 23 && i < 32)
                {
                    if (y == 2)
                    {
                        y++;
                        z = 6;
                    }

                    cards[i] = new Card(Image.FromFile($@"../../images/cards/Clubs/{z}.png"),
                        ((CardValue)z).ToString(),
                        ((CardName)y).ToString());

                    z++;
                }
            }
        }

        public Card[] Shuffle()
        {
            Random random = new Random();
            Card[] newCards = new Card[32];

            int index;

            for(int i = 0; i < 32; i++)
            {
                index = random.Next(0,32);
                if(newCards.Contains(cards[index]) == false)
                {
                    newCards[i] = cards[index];
                }
                else
                {
                    i--;
                }
            }

            return newCards;
        }

        public Card PickCard()
        {
            Random rand = new Random();

            return cards[rand.Next(0, 32)];
        }

        public void ShowCards(PictureBox[] pbarr)
        {
            for(int i = 0; i < cards.Length; i++)
            {
                pbarr[i].Image = cards[i].Suit;
            }
        }
    }
}
