using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

            pictureBox1.Image = Image.FromFile("add-plus-icon-28.png");

            sel_contact = human;

            textBox1.Text = sel_contact.Id.ToString();
            textBox2.Text = sel_contact.FirstName;
            textBox3.Text = sel_contact.LastName;
            textBox4.Text = sel_contact.PhoeneNumber;

            if(sel_contact.Photo != null)
                //pictureBox1.Image = Image.FromStream(new MemoryStream(sel_contact.Photo));
                pictureBox1.Image = Image.FromStream(new MemoryStream(FromFileToBin(sel_contact.Photo)));

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

        static public void BinaryToFile(byte[] stream, string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using(FileStream fs = new FileStream(filename+".bin", FileMode.Create))
            {
                formatter.Serialize(fs, stream);
            }
        }

        static public byte[] FromFileToBin(string filename)
        {
            byte[] r;

            BinaryFormatter formatter = new BinaryFormatter();

            using (Stream input = File.OpenRead(filename))
            {
                r = (byte[])formatter.Deserialize(input);
            }

            return r;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgBuffer = ImageToBinary(openFileDialog1.FileName);
                BinaryToFile(imgBuffer, $"{sel_contact.Id}.bin");
                pictureBox1.Image = Image.FromStream(new MemoryStream(FromFileToBin($"{sel_contact.Id}")));
                
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
                    sel_contact.Photo = $"{sel_contact.Id}.bin";
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
