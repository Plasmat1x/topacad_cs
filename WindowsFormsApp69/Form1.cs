using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp69
{
    public partial class Form1 : Form
    {
        Money money;
        Money money2;
        public Form1()
        {
            InitializeComponent();
            money = new Money();
            money2 = new Money();
        }

        private void Div_Button_Click(object sender, EventArgs e)
        {
            money /= (int)numericUpDown1.Value;
            label1.Text = money.Cash.ToString();
        }

        private void Sum_Button_Click(object sender, EventArgs e)
        {
            money2.Cash = (double)numericUpDown1.Value;
            money += money2;
            label1.Text = money.Cash.ToString();
        }

        private void Sub_Button_Click(object sender, EventArgs e)
        {
            money2.Cash = (double)numericUpDown1.Value;
            money -= money2;
            label1.Text = money.Cash.ToString();
        }

        private void Multi_Button_Click(object sender, EventArgs e)
        {
            money *= (int)numericUpDown1.Value;
            label1.Text = money.Cash.ToString();
        }

        private void Incr_Button_Click(object sender, EventArgs e)
        {
            money++;
            label1.Text = money.Cash.ToString();
        }

        private void Decr_Button_Click(object sender, EventArgs e)
        {
            money--;
            label1.Text = money.Cash.ToString();
        }
    }
}
