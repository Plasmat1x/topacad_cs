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
    public partial class ManagerForm : Form
    {
        UserData userData;
        public ManagerForm()
        {
            InitializeComponent();
            userData = new UserData();
            this.Load += ManagerForm_Load;
            this.FormClosing += ManagerForm_FormClosing;
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeService.ObjSerialize(userData, userData.GetType(), new XmlSerializeCustom());
            UserData.Serialized = true;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            userData = (UserData)SerializeService
                .ObjDeserialize(userData,typeof(UserData),new XmlSerializeCustom()) ?? new UserData();
            userData.AllUsers.ForEach(ShowInfo);
            //userData.AllUsers.ForEach(u => listBox1.Items.Add(u));
        }
        private void ShowInfo(User user)
        {
            if(user.Role == UserRole.Teller) listBox1.Items.Add(user);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var res = (User)listBox1.SelectedItem;
            if (res != null)
            { 
                res.Rate = (int)numericUpDown1.Value;
                listBox1.Items[listBox1.SelectedIndex] = res;
            }

        }
    }
}
