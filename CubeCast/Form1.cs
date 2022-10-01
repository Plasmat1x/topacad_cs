using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeCast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cube1.AddImage(imageList1);
            label1.Text = cube1.Statistic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = cube1.Statistic();
            cube1.Cast();

            Thread.Sleep(3);
        }
    }
}
