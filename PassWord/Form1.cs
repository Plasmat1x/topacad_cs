using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassWord
{
    public partial class Form1 : Form
    {
        string Login = "Login";
        string Password = "Password";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Login)
            {
                if (textBox2.Text == Password)
                {
                    MessageBox.Show("Login succefull");
                }
                else
                {
                    MessageBox.Show("Wrong password");
                }
            }
            else
            {
                MessageBox.Show("Wrong login or password");
            }
        }
    }
}
