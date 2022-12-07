using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw30
{
    public partial class Form1 : Form
    {
        hl h;
        public Form1()
        {
            InitializeComponent();
            h = new hl();
            h.list.Add(new Human("Bob", 22, 80));
            h.list.Add(new Human("Jhoe", 53, 90));
            h.list.Add(new Human("Anton", 22, 120));
            h.list.Add(new Human("Mike", 25, 60));
            h.list.Add(new Human("Sam", 15, 60));

            h.update(listBox1);
        }

        bool reverse = false;

        /*
                case 11: return x.Name.CompareTo(y.Name);
                case 12: return x.Age.CompareTo(y.Age);
                case 14: return x.Weight.CompareTo(y.Weight);

                case 21: return x.Name.CompareTo(y.Name);
                case 22: return x.Age.CompareTo(y.Age);
                case 24: return x.Weight.CompareTo(y.Weight);
         */

        private void button1_Click(object sender, EventArgs e)
        {
            //sort name
            if(reverse)
            {
                hl.comparetype = 21;
                reverse = !reverse;
            }
            else
            {
                hl.comparetype = 11;
                reverse = !reverse;
            }

            h.list.Sort(h.compare);
            h.update(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sort age
            if (reverse)
            { 
                hl.comparetype = 22;
                reverse = !reverse;
            }
            else
            { 
                hl.comparetype = 12;
                reverse = !reverse;
            }

            h.list.Sort(h.compare);
            h.update(listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sort weight
            if (reverse)
            {
                hl.comparetype = 24;
                reverse = !reverse;
            }      
            else
            {
                hl.comparetype = 14;
                reverse = !reverse;
            }

            h.list.Sort(h.compare);
            h.update(listBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //search by name
            Human hu = h.search(textBox1.Text);

            if(hu != null)
            {
                MessageBox.Show(hu.ToString());
            }
            else
            {
                MessageBox.Show("Does not exits");
            }
        }
    }
}
