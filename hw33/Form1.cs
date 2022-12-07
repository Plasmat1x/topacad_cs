using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw33
{
    public delegate void handl();

    public partial class Form1 : Form
    {
        Employee empl;
        Fireman firem;
        FireSec fires;

        Disp d;

        public Form1()
        {
            InitializeComponent();

            empl = new Employee();
            firem = new Fireman();
            fires = new FireSec();

            d = new Disp();

            d.firehandler += empl.Evac;
            d.firehandler += firem.NeutFire;
            d.firehandler += fires.CheckSec;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d.Fire();
        }
    }

    public class Employee
    {
        public void Evac()
        {
            MessageBox.Show(this + " RUN");
        }
    }

    public class Fireman
    {
        public void NeutFire()
        {
            MessageBox.Show(this + " Neutralize fire");
        }
    }

    public class FireSec
    {
        public void CheckSec()
        {
            MessageBox.Show(this + " Check fire security");
        }
    }

    public class Disp
    {
        public event handl firehandler;

        public void Fire()
        {
            firehandler();
        }
    }
}
