using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp118
{
    public partial class Form1 : Form
    {
        Teacher teacher = new Teacher();
        Student s1 = new Student() { Task = "Task1" };
        Student s2 = new Student() { Task = "Task2" };
        Student s3 = new Student() { Task = "Task3" };
        Student s4 = new Student() { Task = "Task4" };
        Student s5 = new Student() { Task = "Task5"  };
        public Form1()
        {
            InitializeComponent();
            teacher.SetControlWork += s1.DoControlWork;
            teacher.SetControlWork += s2.DoControlWork;
            teacher.SetControlWork += s3.DoControlWork;
            teacher.SetControlWork += s4.DoControlWork;
            teacher.SetControlWork += s5.DoControlWork;

            teacher.Start();
        }
    }
}
