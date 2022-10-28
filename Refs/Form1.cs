using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refs
{
    class Pers
    {
        private string text;
        public string Text { get { return text; } }

        public Pers(string text)
        {
            this.text = text;
        }

        public void show(ref Label label)
        {
            label.Text = text;
        }
    }

    class Desck
    {
        private Pers[] persons;
        private Label[] labels;
        private int iter = 0;
        public Desck()
        {
            persons = new Pers[4];

            persons[0] = new Pers("very big text on desck");
            persons[1] = new Pers("litle bit text");
            persons[2] = new Pers("sht txt n dsk");
            persons[3] = new Pers("sasfdsfah");

            labels = new Label[4];
        }

        public void addLabel(ref Label label)
        {
            labels[iter] = label;
            iter++;
        }

        public void show()
        {
            for(int i = 0; i < labels.Length; i++)
            {
                persons[i].show(ref labels[i]);
            }
        }

        public void swap(int sourceIndex, int destIndex)
        {
            Pers p = new Pers(persons[destIndex].Text);
            persons[destIndex] = persons[sourceIndex];
            persons[sourceIndex] = p;
        }
    }

    public partial class Form1 : Form
    {
        Desck d;
        Random rand;

        public Form1()
        {
            InitializeComponent();
            rand = new Random();

            d = new Desck();

            d.addLabel(ref label1);
            d.addLabel(ref label2);
            d.addLabel(ref label3);
            d.addLabel(ref label4);

            d.show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d.swap(0, rand.Next(0,4));
            d.show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d.swap(1, rand.Next(0, 4));
            d.show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            d.swap(2, rand.Next(0, 4));
            d.show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            d.swap(3, rand.Next(0, 4));
            d.show();
        }
    }
}
