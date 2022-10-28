using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    public partial class Form1 : Form
    {
        Queue<Cust> queue;

        public Form1()
        {
            InitializeComponent();

            queue = new Queue<Cust>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            queue.Enqueue(new Cust(textBox1.Text));
            upd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            upd();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void upd()
        {
            int n = 0;
            listBox1.Items.Clear();
            foreach (Cust item in queue)
            {
                listBox1.Items.Add(n + ". " + item.Name);
                n++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                queue.Peek().order(Food.food1, (int)numericUpDown1.Value);
            }
            else if(radioButton2.Checked)
            {
                queue.Peek().order(Food.food2, (int)numericUpDown1.Value);
            }
            else if(radioButton3.Checked)
            {
                queue.Peek().order(Food.food3, (int)numericUpDown1.Value);
            }
            else if(radioButton4.Checked)
            {
                queue.Peek().order(Food.food4, (int)numericUpDown1.Value);
            }

            label1.Text = queue.Peek().eat();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            queue.Peek().end();
            queue.Dequeue();

            upd();
        }
    }
}
