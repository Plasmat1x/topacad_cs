using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicTabControll
{
    public partial class Form1 : Form
    {
        List<Electronic> cart;
        public Form1()
        {
            InitializeComponent();
            cart = new List<Electronic>();
            button1.Text = "add cart";
            listBox1.Items.Add("Teapot");
            listBox1.Items.Add("Flatiron");
            listBox1.Items.Add("Fan");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("cart.bin"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (Stream s = File.OpenRead("cart.bin"))
                {
                    cart = (List<Electronic>)formatter.Deserialize(s);
                }
            }

            listBox2.Items.Clear();
            foreach (var item in cart)
            {     
                listBox2.Items.Add(item.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(listBox1.SelectedIndex)
            {
                case 0:
                    cart.Add(new el1());
                    break;
                case 1:
                    cart.Add(new el2());
                    break;
                case 2:
                    cart.Add(new el3());
                    break;
            }

            listBox2.Items.Clear();
            foreach (var item in cart)
            {
                listBox2.Items.Add(item.Name);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream s = File.OpenWrite("cart.bin"))
            {
                formatter.Serialize(s, cart);
            }
        }
    }
}
