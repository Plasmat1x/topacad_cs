using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TabControll
{
    public partial class Form1 : Form
    {
        Player player;
        Random random;
        Image[] images;
        CardGame cardgame;
        int index;

        public Form1()
        {
            InitializeComponent();

            player = new Player();
            random = new Random();
            cardgame = new CardGame();

            images = new Image[6];
            images[0] = Image.FromFile("../../img/1.png");
            images[1] = Image.FromFile("../../img/2.png");
            images[2] = Image.FromFile("../../img/3.png");
            images[3] = Image.FromFile("../../img/4.png");
            images[4] = Image.FromFile("../../img/5.png");
            images[5] = Image.FromFile("../../img/6.png");

            cardgame.next(random.Next(0, 6));
            card1.Image = images[cardgame.index1];

            health_bar.Value = player.Health;
            hungry_bar.Value = player.Hungry;
            happy_bar.Value = player.Happy;
            clear_bar.Value = player.Clear;
            sleep_bar.Value = player.Sleep;

            money_val.Text = "$" + cardgame.Points;
            
        }

        private void playerUpdate()
        {
            if (player.Health < 0)
            {
                player.Health = 0;
                MessageBox.Show("Need ambulance");
            }
            else if (player.Health > 100) player.Health = 100;

            if (player.Hungry < 0)
            {
                player.Hungry = 0;
                MessageBox.Show("Need dishes");
            }
            else if (player.Hungry > 100) player.Hungry = 100;

            if (player.Happy < 0)
            {
                player.Happy = 0;
                MessageBox.Show("Need play");
            }
            else if (player.Happy > 100) player.Happy = 100;

            if (player.Sleep < 0)
            {
                player.Sleep = 0;
                MessageBox.Show("Need sleep");
            }
            else if (player.Sleep > 100) player.Sleep = 100;

            if (player.Clear < 0)
            {
                player.Clear = 0;
                MessageBox.Show("Need bath");
            }
            else if (player.Clear > 100) player.Clear = 100;

            health_bar.Value = player.Health;
            hungry_bar.Value = player.Hungry;
            happy_bar.Value = player.Happy;
            clear_bar.Value = player.Clear;
            sleep_bar.Value = player.Sleep;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Health -= 5;
            player.Happy -= 10;
            player.Hungry -= 3;
            player.Sleep -= 2;
            player.Clear -= 1;

            playerUpdate();
        }

        private void refresh_bt_Click(object sender, EventArgs e)
        {
            player.Health = 100;
            player.Happy = 100;
            player.Hungry = 100;
            player.Sleep = 100;
            player.Clear = 100;

            playerUpdate();
        }

        private void play_bt_Click(object sender, EventArgs e)
        {
            if((random.Next() % 3) > 1)
            {
                player.Health -= 5;
            }

            player.Sleep -= 25;
            player.Hungry -= 20;
            player.Happy += 15;
            player.Clear -= 17;


            pictureBox1.Visible = true;

            //TODO: thread sleeping
            //pictureBox1.Visible = false;

            playerUpdate();
        }

        private void dish_bt_Click(object sender, EventArgs e)
        {
            player.Sleep -= 5;
            player.Hungry += 15;
            player.Happy += 15;
            player.Clear -= 10;

            playerUpdate();
        }

        private void sleep_bt_Click(object sender, EventArgs e)
        {
            player.Sleep += 50;
            player.Hungry -= 25;
            player.Happy -= 20;
            player.Clear -= 25;

            playerUpdate();
        }

        private void bath_bt_Click(object sender, EventArgs e)
        {
            player.Sleep -= 5;
            player.Hungry -= 10;
            player.Happy += 5;
            player.Clear += 100;

            playerUpdate();
        }

        private void cardplay_bt_Click(object sender, EventArgs e)
        {
            if (cardgame.check())
            {
                money_val.Text = "$" + cardgame.Points;
                cardgame.next(random.Next(0, 6));
                card1.Image = images[cardgame.index1];
                card2.Image = null;
            }
            else 
            {
                cardgame.Points -= 100;
                money_val.Text = "$" + cardgame.Points;
                cardgame.next(random.Next(0, 6));
                card1.Image = images[cardgame.index1];
                card2.Image = null;
            }

            if (cardgame.Points <= 0)
            {
                MessageBox.Show("zero points");
            }
        }

        private void cardnext_bt_Click(object sender, EventArgs e)
        {
            cardgame.next(index);

            card2.Image = images[cardgame.index2];

            if (index < 5)
            {
                index++;
            }
            else
            {
                index = 0;
            }
        }
    }
}
