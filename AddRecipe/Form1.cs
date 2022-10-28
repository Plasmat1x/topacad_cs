using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddRecipe
{
    public partial class Form1 : Form
    {
        Stack<Burger> burgerStack = new Stack<Burger>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count < 10 && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
            else if(string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter ingridient");
            }
            else
            {
                MessageBox.Show("Maximum ingridients");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (string item in listBox1.Items)
            {
                list.Add(item);
            }
            burgerStack.Push(new Burger(textBox2.Text, list));
            listBox1.Items.Clear();
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            listBox2.Items.Clear();
            foreach(Burger item in burgerStack)
            {
                listBox2.Items.Add(item.Name);
            }  
        }
    }
}
