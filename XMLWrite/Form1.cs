using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLWrite
{
    public partial class Form1 : Form
    {
        List list;
        public Form1()
        {
            InitializeComponent();
            list = new List();

            listBox2.Items.Add("Ryzen 5");
            listBox2.Items.Add("Geforce RTX 3060");
            listBox2.Items.Add("Corsair Vengence");
        }

        private void UpdateList()
        {
            listBox1.Items.Clear();

            foreach (var item in list.list)
            {
                listBox1.Items.Add(item.GetInfo());
            }
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            switch (listBox2.SelectedIndex)
            {
                case 0:
                    list.AddItem("Ryzen 5", "CPU");
                    break;
                case 1:
                    list.AddItem("Geforce RTX 3060", "GPU");
                    break;
                case 2:
                    list.AddItem("Corsair Vengence", "RAM");
                    break;

                default:
                    break;
            }

            UpdateList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.WriteInXML();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list.ReadFromXML();
            UpdateList();
        }
    }
}
