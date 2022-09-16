using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter
{
    public partial class Form1 : Form
    {
        /* //counter
        int counter = 0;

        public Form1()
        {
            InitializeComponent();

            label1.Text = counter.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
        }
        */

        /* //Point
        Point p;

        public Form1()
        {
            InitializeComponent();

            p = new Point();

            label1.Text = p.X + " | " + p.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.setPoint(p.X + 5, p.Y + 3);
            label1.Text = p.X + " | " + p.Y;
        }
         */

        /* //sandwich
         
         */
        Sandwich s1;
        Sandwich s2;
        Sandwich s3;

        public Form1()
        {
            InitializeComponent();

            s1 = new Sandwich("chees", 20.1);
            s2 = new Sandwich("meat", 15.5);
            s3 = new Sandwich("vegetables", 5.9);

            s2.Ingridients = new string[]{ "meat","meat","cheese"};
            s3.Ingridients = new string[]{ "vegetables","butter","cheese"};

            s1.show();
            s2.show();
            s3.show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
