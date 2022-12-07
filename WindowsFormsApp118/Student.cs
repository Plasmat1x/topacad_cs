using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp118
{
    public class Student
    {
        public string Task { get; set; }
        public void DoControlWork(object sender, EventArgs e)
        {
            
            MessageBox.Show($"Студент решает контрольную: " + Task);
        }
    }
}
