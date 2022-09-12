using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random
{
    class Cat
    {
        private int id;
        int ids;
        public string name;
        protected string secondName;
        int[] array;

        public Cat()
        {
            array = new int[6];
            MessageBox.Show("Cat constructor");
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }
}
