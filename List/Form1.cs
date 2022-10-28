using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        List<Shoes> shoes;
        Random rand;
        public Form1()
        {
            InitializeComponent();
            rand = new Random();
            shoes = new List<Shoes>();

            label1.Text = "";
            for (int i = 0; i < 15; i++)
            {
                shoes.Add(new Shoes((Type)rand.Next(0, 5), (Color)rand.Next(0, 5), rand.Next(10, 100)));
                label1.Text += shoes[i].Show() + "\n";
            }

            update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(shoes[0].Show());
            shoes.RemoveAt(0);
            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < shoes.Count; i++)
            {
                if(shoes[i].Type == Type.moccasins)
                {
                    shoes[i].Color = Color.RED;
                }
            }
            update();
        }

        private void update()
        {
            label1.Text = "";
            for (int i = 0; i < shoes.Count; i++)
            {
                label1.Text += shoes[i].Show() + "\n";
            }
        }
    }
}
