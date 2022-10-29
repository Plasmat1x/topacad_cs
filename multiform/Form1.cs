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
    public partial class Form1 : Form
    {
        private Auth auth;
        private Form2 next;
        private User user;

        public Form1()
        {
            InitializeComponent();
            auth = new Auth();
            next = new Form2(this, auth);        
        }

        public bool verify(User? user)
        {
            if (user != null)
            {
                this.user = (User)user;
                show();
                return true;
            }
            else
            {
                MessageBox.Show("Invalid authorization data");
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            next.ShowDialog();
        }

        private void show()
        {
            label1.Text = "Login: " + user.Login;
            label2.Text = "Password: " + user.Password;
            label3.Text = "Name: " + user.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.user = null;
            this.Visible = false;
            next.ShowDialog();

        }
    }
}
