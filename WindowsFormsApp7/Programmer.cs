using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Programmer: IWorker
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Profession { get; set; }
        public double Money { get; set; }
        public double Salary { get; set; }
        public int Warning { get; set; }

        public Programmer(string name, string secondName, string profession, double salary)
        {
            Name = name;
            SecondName = secondName;
            Profession = profession;
            Salary = salary;
        }
        public void GetPaid()
        {

        }
        public void GetPenalty()
        {

        }
    }
}
