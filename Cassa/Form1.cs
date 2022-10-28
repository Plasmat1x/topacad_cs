using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cassa
{
    public class Client
    {
        public string Name { get; set; }

        public Client(string name)
        {
            Name = name;
        }
    }

    public partial class Form1 : Form
    {
        Queue<Client> queue;

        Client[] windows;

        public Form1()
        {
            InitializeComponent();
            queue = new Queue<Client>();
            windows = new Client[3];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            windows[0] = null;
            queued();
            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            windows[1] = null;
            queued();
            update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            windows[2] = null;
            queued();
            update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            queue.Enqueue(new Client(textBox4.Text));
            textBox4.Text = "";
            queued();
            update();
        }

        private void update()
        {
            listBox1.Items.Clear();
            
            foreach(Client item in queue)
            {
                listBox1.Items.Add(item.Name);
            }

            for(int i = 0; i<windows.Length; i++)
            {
                if(windows[i] != null)
                {
                    switch (i)
                    {
                        case 0:
                            textBox1.Text = windows[i].Name;
                            break;
                        case 1:
                            textBox2.Text = windows[i].Name;
                            break;
                        case 2:
                            textBox3.Text = windows[i].Name;
                            break;
                    }
                }
            }
        }

        private void queued()
        {
            for (int i = 0; i < windows.Length; i++)
            {
                if (windows[i] == null)
                {
                    windows[i] = queue.Dequeue();
                    break;
                }
            }
        }
    }
}
