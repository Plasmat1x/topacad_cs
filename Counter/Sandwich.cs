using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter
{
    internal class Sandwich
    {
        private string name;
        private string[] ingridients = {"meat", "jam", "butter", "vegetables", "cheese"};
        private double price;
        public Sandwich(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public void show()
        {
            string str = " ";
            for (int i = 0; i < ingridients.Length; i++)
            {
                str += ingridients[i] + ", ";
            }
            MessageBox.Show(name + " \n" + price + " \n" + str);
        }

        public string[] Ingridients
        {
            set 
            {
                ingridients = value;
            }
        }
    }
}
