using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal
{
    internal class Predator : AnimalBaseClass
    {
        protected int strenght;
        protected string weapon;

        public string hunt(int str, string weapon)
        {
            if(this.strenght > str)
            {
                return name + " hunted by" + this.weapon;
            }
            else
            {
                return name + " hunted by" + weapon;
            }
        }

        public int Strenght
        {
            get { return strenght; }
        }

        public string Weapon
        {
            get { return weapon; }
        }

    }
}
