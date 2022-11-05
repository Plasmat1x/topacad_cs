using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelecomAdressBook
{
    public partial class Form2 : Form
    {
        Form1 main;
        ContactBook manager;

        public Form2(Form1 form1, ContactBook manager)
        {
            InitializeComponent();

            main = form1;
            this.manager = manager;
            openFileDialog1.Filter = " |*.jpg| |*.png| |*.bmp| |*.jpeg";
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            lastname_tb.BackColor = Color.White;
            firstname_tb.BackColor = Color.White;
            number_tb.BackColor = Color.White;


            if (firstname_tb.Text.Length <= 0)
            {
                firstname_tb.BackColor = Color.Red;
                MessageBox.Show("First name is empty, please enter data");
            }

            if (lastname_tb.Text.Length <= 0)
            {
                lastname_tb.BackColor = Color.Red;
                MessageBox.Show("Last name is empty, please enter data");
            }

            if (number_tb.Text.Length <= 0)
            {
                number_tb.BackColor = Color.Red;
                MessageBox.Show("Phone number is empty, please enter data");
            }

            manager.AddContact(firstname_tb.Text, lastname_tb.Text, number_tb.Text, openFileDialog1.FileName);
            main.Update_List();
            //main.Visible = true;
            //this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //main.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //main.Visible = false;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
             
            }
        }
    }
}
