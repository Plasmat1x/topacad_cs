using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp97
{
    internal class Car
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Car(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
        public void upweight(int x)
        {
            this.Weight += x;
        }

        public string info()
        {
            return $"Name: {Name} Weight: {Weight}";
        }
    }
}
