using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClownInterface
{
    public partial class Form1 : Form
    {
        TallHuman person;

        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Clown")
            {
                ClownMan clown = new ClownMan();
                clown.WFHC = "    Red nose\n    Long shoes\n    Funny costume\n";
                person = clown;
                label1.Text = person.About();
            }
            else if (comboBox1.SelectedItem == "Security")
            {
                person = new SecurityMan();
                label1.Text = person.About();
            }
        }
    }
}
