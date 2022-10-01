using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class Form1 : Form
    {
        Student[] students;
        public Form1()
        {
            InitializeComponent();

            students = new Student[3];
            students[0] = new Student();
            students[1] = new Student();
            students[2] = new Student();
        }
    }
}
