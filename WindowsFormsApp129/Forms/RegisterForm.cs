using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp129.Services;

namespace WindowsFormsApp129.Forms
{
    public partial class RegisterForm : Form
    {
        UserData userData;
        public RegisterForm(UserData userData)
        {
            InitializeComponent();
            this.userData = userData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in this.Controls)
                {
                    if (item is TextBox textBox)
                    {
                        if (string.IsNullOrWhiteSpace(textBox.Text) == true) throw new Exception();
                    }
                    if (item is ComboBox comboBox)
                    {
                        if (comboBox.SelectedItem == null) throw new Exception();
                    }
                }
                userData.AddUser(new User 
                {
                    Login = textBox1.Text,
                    Password = textBox2.Text, 
                    Role = (UserRole)comboBox1.SelectedIndex 
                });

                SendMaill();
                
                this.Close();
            }
            catch (Exception)
            {

                foreach (var item in this.Controls)
                {
                    if (item is TextBox textBox)
                    {
                        textBox.Text = "";
                    }
                }
                MessageBox.Show("Не все поля заполнены");
            }
           
        }
        private void SendMaill()
        {
            if (userData.AllUsers.Last().Role == UserRole.Admin || userData.AllUsers.Last().Role == UserRole.Manager) return;

            foreach (var item in userData.AllUsers)
            {
                if (item.Role == UserRole.Admin || item.Role == UserRole.Manager)
                {
                    MaillSenderService.MaillSend -= item.RecieveMessage;
                }
            }

            foreach (var item in userData.AllUsers)
            {
                if (item.Role == UserRole.Admin || item.Role == UserRole.Manager)
                {
                    MaillSenderService.MaillSend += item.RecieveMessage;
                }
            }
            MaillSenderService.Send(userData.AllUsers.Last());
        }
    }
}
