using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp79
{
    public partial class AddHumanForm : Form
    {
        Form1 form1;
        PhoneBook phoneBook;
        Image photo;
        public AddHumanForm(Form1 form1, PhoneBook phoneBook)
        {
            InitializeComponent();
            this.form1 = form1;
            this.phoneBook = phoneBook;
            this.form1.Visible = false;
            openFileDialog1.Filter = "Фотография|*.jpg||*.jpeg";
            openFileDialog1.InitialDirectory = @"C:\Users\feday\Pictures";
        }

        private void AddHumanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Visible = true;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            phoneBook.AddHuman(FirstName_TextBox.Text, Surname_TextBox.Text, PhoneNumber_MaskedTextBox.Text, openFileDialog1.FileName);

            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddHumanPhoto_Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                photo = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
