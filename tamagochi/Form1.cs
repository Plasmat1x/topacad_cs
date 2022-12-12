using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamagochi
{
    public partial class Form1 : Form
    {
        Tama tam;
        Random rnd;
        int ireq;
        int ireqp;
        int ireqlt;
        bool breq;

        public Form1()
        {
            InitializeComponent();

            tam = new Tama() { Status = 0, Lifetime = 120, Miss = 0 };
            rnd = new Random();

            ireq = rnd.Next(1,6);
            ireqp = 0;
            ireqlt = 5;
            breq = true;

            button1.Text = "start";
            label1.Text = " ";
        }


        //в идеале для дебага обновлять информацию сразу после того как измениться значение
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = tam.Lifetime.ToString();

            label4.Text = $"--debug--\nireq: {ireq} == {((Request)ireq).ToString()}\nirep: {ireqp}\nireqlt: {ireqlt}\nbreq: {breq.ToString()}\n--Tam--\nStatus: {tam.Status}\nMiss: {tam.Miss}\nLifetime: {tam.Lifetime}";

            if ((tam.Lifetime < 0) || (tam.Status >= 2)) // gameover
            {
                timer1.Stop();
                MessageBox.Show("Game Over!");
                return;
            }

            if (ireqlt < 0) //gen new request
            {
                button1.Enabled = true;

                ireqp = ireq;
                ireq = rnd.Next(1, 6);
                ireqlt = 5;

                if (tam.Status == 1) // if sick need heal
                {
                    ireq = 4;
                }
                else
                {
                    do
                    {
                        ireq = rnd.Next(1, 6);
                    } while (ireqp == ireq); //reroll request
                }

                label1.Text = "I need " + ((Request)ireq).ToString();
                button1.Text = ((Request)ireq).ToString() + " me";
            }
            else // request liftime
            {
                ireqlt--;

                if (ireqlt == 0)
                {
                    breq = false;
                }

                if (breq == false) // chek fault request
                {
                    ireqlt = -1;
                    breq = true;
                    tam.Miss++;
                    label2.Text = $"Miss requests: {tam.Miss}";
                }
            }

            if (tam.Miss > 2) // check missings
            {
                tam.Status++;
                tam.Miss = 0;

                switch (tam.Status) //select status
                {
                    case 0: label3.Text = "status: Helthy"; break;
                    case 1: label3.Text = "status: Sick"; break;
                    case 2: label3.Text = "status: Dead"; break;
                }
            }

            tam.Lifetime--;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == false)
            {
                timer1.Start();
                button1.Text = ((Request)ireq).ToString();
                label1.Text = "I need " + ((Request)ireq).ToString();
                return;
            }
                
            button3_Click(sender, e);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            tam.Miss = 0;
            tam.Status = 0;
            ireq = 0;
            ireqlt = 0;
            breq = true;
            button1.Enabled = false;

            label1.Text = "I need " + ((Request)ireq).ToString();
            button1.Text = ((Request)ireq).ToString() + " me";
            label2.Text = $"Miss requests: {tam.Miss}";
            switch (tam.Status)
            {
                case 0: label3.Text = "status: Helthy"; break;
                case 1: label3.Text = "status: Sick"; break;
                case 2: label3.Text = "status: Dead"; break;
            }
        }
    }

    public enum Request
    {
        nil = 0,
        feed,
        walk,
        sleep,
        heal,
        play,
    }

    class Tama
    {
        public int Status;
        public int Miss;
        public int Lifetime;
    }
}
