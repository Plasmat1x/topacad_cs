using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        byte[] imgBuffer;

        public Form2(Form1 form1, ContactBook manager)
        {
            InitializeComponent();

            main = form1;
            this.manager = manager;
            openFileDialog1.Filter = " |*.jpg| |*.png| |*.bmp| |*.jpeg";

            //pictureBox1.Image = Image.FromFile("add-plus-icon-28.png");
            pictureBox1.Image = Image.FromFile("add-plus-icon-28.png");
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

            if (firstname_tb.Text.Length > 0 && lastname_tb.Text.Length > 0 && number_tb.Text.Length > 0)
            {
                manager.AddContact(firstname_tb.Text, lastname_tb.Text, number_tb.Text);
                main.Update_List();
            }

            if (imgBuffer != null)
            {
                Form3.BinaryToFile(imgBuffer, manager.Contacts.Last<Human>().Id.ToString());
                manager.Contacts.Last<Human>().Photo = $"{manager.Contacts.Last<Human>().Id.ToString()}.bin";
            }

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
            this.Location = main.Location;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgBuffer = Form3.ImageToBinary(openFileDialog1.FileName);
                pictureBox1.Image = Image.FromStream(new MemoryStream(imgBuffer));
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Double click for adding image", pictureBox1);
            toolTip1.ReshowDelay = 1000;
        }
    }
}
