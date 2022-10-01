using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal
{
    public partial class Form1 : Form
    {
        Lion lion;
        Wolf wolf;
        public Form1()
        {
            InitializeComponent();

            lion = new Lion();
            wolf = new Wolf();

            label3.Text = " ";

            pictureBox1.Image = wolf.Picture;
            label1.Text = wolf.getInfo();

            pictureBox2.Image = lion.Picture;
            label2.Text = lion.getInfo();
        }

        private void hunt_bt_Click(object sender, EventArgs e)
        {
            label3.Text = wolf.hunt(lion.Strenght, lion.Weapon);
        }
    }
}
