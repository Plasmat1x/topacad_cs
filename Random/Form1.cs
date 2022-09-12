using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random
{
    public partial class Form1 : Form
    {
        bool dir = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((label1.Left + label1.Size.Width) >= this.Size.Width)
                dir = true;
            else if (label1.Left <= this.Location.X)
                dir = false;

            if (!dir)
                label1.Left += 50;
            else
                label1.Left -= 50;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((button2.Left + button2.Size.Width) >= this.Size.Width)
                dir = true;
            else if (button2.Left <= this.Location.X)
                dir = false;

            if (!dir)
                button2.Left += 50;
            else
                button2.Left -= 50;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if ((label2.Left + label2.Size.Width) >= this.Size.Width)
                dir = true;
            else if (label2.Left <= this.Location.X)
                dir = false;

            if (!dir)
                label2.Left += 50;
            else
                label2.Left -= 50;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if ((button3.Left + button3.Size.Width) >= this.Size.Width)
                dir = true;
            else if (button3.Left <= this.Location.X)
                dir = false;

            if (!dir)
                button3.Left += 50;
            else
                button3.Left -= 50;
        }
    }
}
