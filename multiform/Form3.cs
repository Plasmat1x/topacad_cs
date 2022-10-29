using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiform
{
    public partial class Form3 : Form
    {
        private Auth auth;
        public Form3(Auth auth)
        {
            InitializeComponent();
            this.auth = auth;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.PasswordChar = '*';
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            auth.Register(textBox1.Text, textBox2.Text, textBox3.Text);
            this.Close();
        }
    }
}
