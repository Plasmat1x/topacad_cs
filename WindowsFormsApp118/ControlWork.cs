using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp118
{
    public class ControlWork : EventArgs
    {
        List<string> controlVariants = new List<string>() {"Task1", "Task2", "Task3", "Task4" };

        public string GetTask()
        {
            Random rnd = new Random();
            return controlVariants[rnd.Next(0,controlVariants.Count)];
        }
    }
}
