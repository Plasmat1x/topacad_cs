using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelecomAdressBook
{
    public partial class Form3 : Form
    {
        private Form1 main;
        private Human sel_contact;
        private byte[] imgBuffer;

        public Form3(Human human, Form1 form)
        {
            InitializeComponent();

            pictureBox1.Image = Image.FromFile("../../add-plus-icon-28.png");

            sel_contact = human;

            textBox1.Text = sel_contact.Id.ToString();
            textBox2.Text = sel_contact.FirstName;
            textBox3.Text = sel_contact.LastName;
            textBox4.Text = sel_contact.PhoeneNumber;
            if(sel_contact.Photo != null)
                pictureBox1.Image = Image.FromStream(new MemoryStream(sel_contact.Photo));

            main = form;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Location = main.Location;
        }

        static public byte[] ImageToBinary(string imagePath)
        {
            if (imagePath == null) return null;

            FileStream fS = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            byte[] b = new byte[fS.Length];
            fS.Read(b, 0, (int)fS.Length);
            fS.Close();
            return b;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgBuffer = ImageToBinary(openFileDialog1.FileName);
                pictureBox1.Image = Image.FromStream(new MemoryStream(imgBuffer));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;

            if (textBox2.Text.Length <= 0)
            {
                textBox2.BackColor = Color.Red;
                MessageBox.Show("Empty First name, enter data");
            }
            if (textBox3.Text.Length <= 0)
            {
                textBox3.BackColor = Color.Red;
                MessageBox.Show("Empty Last name, enter data");
            }
            if (textBox4.Text.Length <= 0)
            {
                textBox4.BackColor = Color.Red;
                MessageBox.Show("Empty Phone number, enter data");
            }

            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0)
            {
                sel_contact.FirstName = textBox2.Text;
                sel_contact.LastName = textBox3.Text;
                sel_contact.PhoeneNumber = textBox4.Text;

                if(imgBuffer != null)
                {
                    sel_contact.Photo = imgBuffer;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Double click for adding image", pictureBox1);
            toolTip1.ReshowDelay = 2;
        }
    }
}
