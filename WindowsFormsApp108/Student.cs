using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp108
{
    public class Student
    {
        public string Subject { get; set; }
        Label label;
        public Student(Label label)
        {
            this.label = label;
        }
        public void GoOnLesson(string subjectName)
        {
            if (Subject == subjectName)
            {
                label.Text += "Студент пошел на " + Subject + Environment.NewLine;
            }
            else
            {
                label.Text += subjectName + " Студент ждет своего урока! " + Subject + Environment.NewLine;
            }
        }
    }
}
