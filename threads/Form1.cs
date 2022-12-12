using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threads
{
    public partial class Form1 : Form
    {
        int counter;
        public Form1()
        {
            InitializeComponent();
            Thread currThread = Thread.CurrentThread;

            Thread t1 = new Thread(show);
            t1.Start();
            t1.Join();
        }

        private void show()
        {
            for (int i = 0; i < 50; i++)
            {
                counter++;
                Thread.Sleep(1000);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = counter.ToString();
        }
    }
}
