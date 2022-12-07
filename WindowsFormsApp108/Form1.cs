using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp108
{
    public delegate void RingDel(string subjectName);
    public partial class Form1 : Form
    {
        SchoolRing schoolRing = new SchoolRing();
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();

        public Form1()
        {
            InitializeComponent();

            students.Add(new Student(label1) { Subject = "Биология"});
            students.Add(new Student(label1) { Subject = "Математика"});
            students.Add(new Student(label1) { Subject = "История"});
            students.Add(new Student(label1) { Subject = "История" });
            students.Add(new Student(label1) { Subject = "Математика" });
            students.Add(new Student(label1) { Subject = "Биология"});
            students.Add(new Student(label1) { Subject = "Математика" });
            students.Add(new Student(label1) { Subject = "Биология"});
            
            teachers.Add(new Teacher(label2) { Subject = "Биология" });
            teachers.Add(new Teacher(label2) { Subject = "История" });
            teachers.Add(new Teacher(label2) { Subject = "История" });
            teachers.Add(new Teacher(label2) { Subject = "История" });
            teachers.Add(new Teacher(label2) { Subject = "Математика" });
            teachers.Add(new Teacher(label2) { Subject = "Биология" });
            teachers.Add(new Teacher(label2) { Subject = "Математика" });
            teachers.Add(new Teacher(label2) { Subject = "Биология" });

            foreach (Student item in students)
            {
                schoolRing.RingEvent += item.GoOnLesson;
            }
            foreach (Teacher item in teachers)
            {
                schoolRing.RingEvent += item.GoOnLesson;
            }
        }

        private void biology_Button_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            schoolRing.Ring("Биология");
        }

        private void math_Button_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            schoolRing.Ring("Математика");
        }

        private void history_Button_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            schoolRing.Ring("История");
        }
    }
}
