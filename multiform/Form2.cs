using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiform
{
    public partial class Form2 : Form
    {
        private Form1 main_frm;
        private Form3 reg_frm;
        private Auth auth;

        public Form2(Form1 form, Auth auth)
        {
            InitializeComponent();
            this.main_frm = form;
            this.auth = auth;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(main_frm.verify(auth.Authorization(textBox1.Text, textBox2.Text)))
            {
                main_frm.Visible = true;
                this.Close();
            }    
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

        private void button2_Click(object sender, EventArgs e)
        {
            reg_frm = new Form3(auth);
            reg_frm.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!main_frm.Visible)
            {
                main_frm.Close();
            }
        }
    }
}
