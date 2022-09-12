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

        public Form1()
        {
            InitializeComponent();

            player = new Player();

            health_bar.Value = player.Health;
            hungry_bar.Value = player.Hungry;
            happy_bar.Value = player.Happy;
            clear_bar.Value = player.Clear;
            sleep_bar.Value = player.Sleep;

            money_val.Text = 500 + "$";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Health -= 5;
            player.Happy -= 10;
            player.Hungry -= 3;
            player.Sleep -= 2;
            player.Clear -= 1;

            health_bar.Value = player.Health;
            hungry_bar.Value = player.Hungry;
            happy_bar.Value = player.Happy;
            clear_bar.Value = player.Clear;
            sleep_bar.Value = player.Sleep;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Health = 100;
            player.Happy = 100;
            player.Hungry = 100;
            player.Sleep = 100;
            player.Clear = 100;

            health_bar.Value = player.Health;
            hungry_bar.Value = player.Hungry;
            happy_bar.Value = player.Happy;
            clear_bar.Value = player.Clear;
            sleep_bar.Value = player.Sleep;
        }
    }
}
