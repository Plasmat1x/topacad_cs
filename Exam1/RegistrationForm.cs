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
    public partial class RegistrationForm : Form
    {
        UserManager umgr;
        XmlSerializer serializer = new XmlSerializer(typeof(UserManager));
        string imagepath;


        public RegistrationForm(UserManager umgr)
        {
            InitializeComponent();
            this.umgr = umgr;
        }

        private void addphoto_bt_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Copy image to byte arr and save into root folder of program");
                photo_pb.Image = Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName;
            }
        }

        private void reg_bt_Click(object sender, EventArgs e)
        {
            //Check textBoxs;
            umgr.Register(new User(login.Text,password.Text,username.Text,email.Text,fname.Text, lname.Text, phone.Text, location.Text, imagepath));
            ser();
            this.DialogResult = DialogResult.OK;
        }

        private void ser()
        {
            try
            {
                using (FileStream fs = new FileStream("userlist.xml", FileMode.Create))
                {
                    serializer.Serialize(fs, umgr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
