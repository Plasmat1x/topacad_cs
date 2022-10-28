using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardList
{
    public partial class Form1 : Form
    {
        List<Card>cards = new List<Card>();

        Deck One;
        Deck Two;

        public Form1()
        {
            InitializeComponent();

            button1.Text = " > > ";

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    cards.Add(new Card((Value)j, (Suits)i));
                }
            }

            One = new Deck(cards);
            Two = new Deck();

            update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count > 0 && listBox1.SelectedIndex != -1)
            {
                Two.addCard(One.deleteCard(listBox1.SelectedIndex));
            }

            update();
        }

        private void update()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            foreach(var item in One.show())
            {
                listBox1.Items.Add(item);
            }

            foreach (var item in Two.show())
            {
                listBox2.Items.Add(item);
            }
        }
    }
}
