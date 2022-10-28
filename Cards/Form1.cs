using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        PictureBox[] pictureBoxes = new PictureBox[32];

        Deck deck;

        Card card1;
        Card card2;

        public Form1()
        {
            InitializeComponent();

            initPB();

            deck = new Deck();

            deck.ShowCards(pictureBoxes);
        }

        private void initPB()
        {
            pictureBoxes[0] = pictureBox1;
            pictureBoxes[1] = pictureBox2;
            pictureBoxes[2] = pictureBox3;
            pictureBoxes[3] = pictureBox4;
            pictureBoxes[4] = pictureBox5;
            pictureBoxes[5] = pictureBox6;
            pictureBoxes[6] = pictureBox7;
            pictureBoxes[7] = pictureBox8;
            pictureBoxes[8] = pictureBox9;
            pictureBoxes[9] = pictureBox10;
            pictureBoxes[10] = pictureBox11;
            pictureBoxes[11] = pictureBox12;
            pictureBoxes[12] = pictureBox13;
            pictureBoxes[13] = pictureBox14;
            pictureBoxes[14] = pictureBox15;
            pictureBoxes[15] = pictureBox16;
            pictureBoxes[16] = pictureBox17;
            pictureBoxes[17] = pictureBox18;
            pictureBoxes[18] = pictureBox19;
            pictureBoxes[19] = pictureBox20;
            pictureBoxes[20] = pictureBox21;
            pictureBoxes[21] = pictureBox22;
            pictureBoxes[22] = pictureBox23;
            pictureBoxes[23] = pictureBox24;
            pictureBoxes[24] = pictureBox25;
            pictureBoxes[25] = pictureBox26;
            pictureBoxes[26] = pictureBox27;
            pictureBoxes[27] = pictureBox28;
            pictureBoxes[28] = pictureBox29;
            pictureBoxes[29] = pictureBox30;
            pictureBoxes[30] = pictureBox31;
            pictureBoxes[31] = pictureBox32;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Card[] cards = deck.Shuffle();

            for(int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Image = cards[i].Suit;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            card1 = deck.PickCard();
            label1.Text = $"{card1.Value}\n{card1.Name}";
            pictureBox33.Image = card1.Suit;

            System.Threading.Thread.Sleep(3);

            card2 = deck.PickCard();
            label2.Text = $"{card2.Value}\n{card2.Name}";
            pictureBox34.Image = card2.Suit;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if(card1.value > card2.value) проверка значений карты (для этого лопатить класс карты менять строки на необходимый тип данных)
        }
    }
}
