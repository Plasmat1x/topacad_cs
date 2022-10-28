using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueStack
{
    public partial class Form1 : Form
    {
        Stack<string> stack;
        Queue<string> queue;

        public Form1()
        {
            InitializeComponent();

            queue = new Queue<string>();
            stack = new Stack<string>();

            label1.Text = "";
            label2.Text = "";

        }

        //queue btns
        private void button1_Click(object sender, EventArgs e)
        {
            queue.Enqueue(textBox1.Text);
            updateQueue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (queue.Count == 0)
            {
                MessageBox.Show("queue is empty");
                return;
            }
            MessageBox.Show(queue.Dequeue());
            updateQueue();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateQueue();
        }

        private void updateQueue()
        {
            label1.Text = "";
            foreach (string item in queue)
            {
                label1.Text += item + Environment.NewLine;
            }
        }

        //stack btns
        private void button4_Click(object sender, EventArgs e)
        {
            stack.Push(textBox2.Text);
            updateStack();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(stack.Count == 0)
            {
                MessageBox.Show("stack is empty");
                return;
            }
            MessageBox.Show(stack.Pop());
            updateStack();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updateStack();
        }

        private void updateStack()
        {
            label2.Text = "";
            foreach (string item in stack)
            {
                label2.Text += item + Environment.NewLine;
            }
        }
    }
}
