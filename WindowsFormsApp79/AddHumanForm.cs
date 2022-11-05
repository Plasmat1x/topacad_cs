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
        public AddHumanForm(Form1 form1, PhoneBook phoneBook)
        {
            InitializeComponent();
            this.form1 = form1;
            this.phoneBook = phoneBook;
            this.form1.Visible = false;
        }

        private void AddHumanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Visible = true;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            phoneBook.AddHuman(FirstName_TextBox.Text, Surname_TextBox.Text, PhoneNumber_MaskedTextBox.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
