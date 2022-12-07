using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp96
{
    public delegate void HumanShowDel();
    public partial class Form1 : Form
    {
        Human human1;
        Human human2;
        Human human3;

        HumanShowDel humanShowDel;
        public Form1()
        {
            InitializeComponent();
           
            human1 = new Human("Bob", "Bobov");
            human2 = new Human("Bob", "Vovov");
            human3 = new Human("Bob", "Rorov");

            humanShowDel = human1.Show;
            humanShowDel += human2.Show;
            humanShowDel += human3.Show;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            humanShowDel();
        }
    }
}
