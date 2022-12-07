using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp97
{
    public delegate string ShowInfoDel();
    public delegate void _sum_(int x);
    public partial class Form1 : Form
    {

        Car car;
        Bicycle bicycle;
        Ship ship;
        
        ShowInfoDel infoDel;
        _sum_ sum;
        public Form1()
        {
            InitializeComponent();
            car = new Car("car", 123);
            bicycle = new Bicycle("bicycle", 12344);
            ship = new Ship("ship", 1233);

            infoDel = car.info;
            infoDel += ship.info;
            infoDel += bicycle.info;

            sum = car.upweight;
            sum += ship.upweight;
            sum += bicycle.upweight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            sum((int)numericUpDown1.Value);

            label1.Text += car.info() + "\n";
            label1.Text += ship.info() + "\n";
            label1.Text += bicycle.info();
        }
    }
}
