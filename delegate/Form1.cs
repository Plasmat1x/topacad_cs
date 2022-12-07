using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @delegate
{
    public delegate void AccountHandler(string message);

    #region form1
    public partial class Form1 : Form
    {
        Account acc;
        public Form1()
        {
            InitializeComponent();
            acc = new Account(150);
            acc.handler = new AccountHandler(display);
        }

        private void display(string message)
        {
            label1.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acc.put((int)numericUpDown1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            acc.withdraw((int)numericUpDown1.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            acc.balance();
        }
    }
    #endregion


    #region Account
    public class Account
    {
        public AccountHandler handler { set; get; }
        public int cash { get; set; }

        public Account(int sum)
        {
            cash = sum;
        }

        public void put(int sum)
        {
            cash += sum;
            if (handler != null)
                handler.Invoke($"{sum} puted");
        }

        public void withdraw(int sum)
        {
            if (cash >= sum)
            {
                cash -= sum;
                handler($"{sum} withdraw");
            }
            else
            {
                handler($"balance to low");
            }
        }

        public void balance()
        {
            handler($"current cash = {cash}");
        }
    }
    #endregion
}
