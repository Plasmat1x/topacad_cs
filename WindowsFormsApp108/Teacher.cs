using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp108
{
    public class Teacher
    {
        public string Subject;
        Label label;
        
        public Teacher(Label label)
        {
            this.label = label;
        }

        public void GoOnLesson(string subjectName)
        {
            if (Subject == subjectName)
            {
                label.Text += "Учитель пошел на " + Subject + Environment.NewLine;
            }
            else
            {
                label.Text += subjectName + " Учитель ждет своего урока! " + Subject + Environment.NewLine;
            }
        }
    }
}
