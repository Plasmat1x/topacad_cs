using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topacad_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string z = "";
            string message = "some tesxt" + z;
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dialog window");
        }
    }
}
