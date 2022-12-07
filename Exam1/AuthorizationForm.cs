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
using System.Xml.Serialization;

namespace Exam1
{
    public partial class AuthorizationForm : Form
    {
        Form1 main;
        UserManager umgr;
        RegistrationForm regf;
        XmlSerializer serializer = new XmlSerializer(typeof(UserManager));

        public AuthorizationForm(Form1 form)
        {
            InitializeComponent();
            main = form;
            umgr = new UserManager();
            des();
        }

        private void login_bt_Click(object sender, EventArgs e)
        {
            
            main.cuser = umgr.Verification(textBox1.Text, textBox2.Text);

            if(main.cuser != null)
            {
                main.Visible = true;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void reg_bt_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            regf = new RegistrationForm(umgr);

            if (regf.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
            else
            {
                this.Visible = true;
            }
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            this.Location = main.Location;
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!main.Visible)
            {
                main.Close();
            }
        }

        private void des()
        {
            try
            {
                using (FileStream fs = new FileStream("userlist.xml", FileMode.Open))
                {
                    umgr = (UserManager)serializer.Deserialize(fs);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
