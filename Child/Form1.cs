using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Child
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Student student = new Student();
            
            student.FirstName = "Some";
            student.SecondName = "Student";
            student.Lessons = new string[3];
            student.Lessons[0] = "lesson 1";
            student.Lessons[1] = "lesson 2";
            student.Lessons[2] = "lesson 3";
            student.Score = 100;

            label1.Text = $"{student.FirstName} {student.SecondName}\nScore: {student.Score}\n{student.DoLessons()}and then {student.GoOnWalk()}";

            Sportsman sportsman = new Sportsman();
            sportsman.FirstName = "Some";
            sportsman.SecondName = "Sportsman";
            sportsman.SportName = "Basketball";
            sportsman.YearsInSport = 5;

            label2.Text = $"{sportsman.FirstName} {sportsman.SecondName}\nYears in {sportsman.SportName}: {sportsman.YearsInSport}\n{sportsman.GoOnWalk()} and then {sportsman.GoOnTraining()}"; 

        }
    }
}
