using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    interface IWorker
    {
        string Name { get; set; }
        string SecondName { get; set; }
        string Profession { get; set; }
        double Money { get; set; }
        double Salary { get; set; }
        int Warning { get; set; }

        void GetPaid();

        void GetPenalty();
    }
}
