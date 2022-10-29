using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trycatch
{
    public partial class Form1 : Form
    {
        Humans humans;
        public Form1()
        {
            InitializeComponent();
            humans = new Humans();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Исключение парсинга строки, как ловить исключение?
            humans.AddHuman(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            humans.show(ref listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            humans.DeleteHuman(listBox1.SelectedIndex);
            humans.show(ref listBox1);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
    }
}
