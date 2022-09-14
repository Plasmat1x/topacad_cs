using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class Form1 : Form
    {
        Image[] images;
        GameLogic gl;
        Random rand;
        int index;

        public Form1()
        {
            InitializeComponent();

            rand = new Random();
            gl = new GameLogic();

            images = new Image[6];
            images[0] = Image.FromFile("1.png");
            images[1] = Image.FromFile("2.png");
            images[2] = Image.FromFile("3.png");
            images[3] = Image.FromFile("4.png");
            images[4] = Image.FromFile("5.png");
            images[5] = Image.FromFile("6.png");

            gl.next(rand.Next(0, 6));
            image1.Image = images[gl.index1];
            
        }

        private void next_bt_Click(object sender, EventArgs e)
        {
            gl.next(index);

            image2.Image = images[gl.index2];

            if(index < 5)
            {
                index++;
            }
            else
            {
                index = 0;
            }   
        }

        private void play_bt_Click(object sender, EventArgs e)
        {
            if(gl.check())
            {
                label1.Text = "Points: " + gl.Points;
                gl.next(rand.Next(0, 6));
                image1.Image = images[gl.index1];
                image2.Image = null;
            }
        }
    }
}
