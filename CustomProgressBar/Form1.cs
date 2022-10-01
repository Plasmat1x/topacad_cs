using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CustomProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        private void cstmProgBar1_Click(object sender, EventArgs e)
        {
            int timer = 0;
            while (timer < 100)
            {
                timer++;
                Thread.Sleep(50);
                cstmProgBar1.Value = timer;
            }
            cstmProgBar1.action();
        }
    }
}
