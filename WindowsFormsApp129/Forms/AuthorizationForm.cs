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
    public partial class AuthorizationForm : Form
    {
        
        UserData userData;
        public AuthorizationForm()
        {
            InitializeComponent();
            userData = new UserData();
            this.FormClosing += AuthorizationForm_FormClosing;
            this.Load += AuthorizationForm_Load;
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            userData = (UserData)SerializeService
                .ObjDeserialize(userData, userData.GetType(), new XmlSerializeCustom()) ?? new UserData();
   
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(UserData.Serialized == false)
                SerializeService.ObjSerialize(userData,typeof(UserData), new XmlSerializeCustom());
        }
        SelectForm selectForm;
        private void enter_Button_Click(object sender, EventArgs e)
        {
            User user =  userData.Authorization(textBox1.Text, textBox2.Text);

            if(user != null)
            {
                selectForm = new SelectForm(user);
                this.Visible = false;
                if (selectForm.ShowDialog() == DialogResult.OK)
                {

                }

                //this.Visible = true;
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterForm(userData).ShowDialog();
        }
    }
}
