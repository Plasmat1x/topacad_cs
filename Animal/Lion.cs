using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Animal
{
    internal class Lion : Predator
    {
        public Lion()
        {
            name = "Lion";
            picture = Image.FromFile("..\\..\\lion.png");
            food = "meat";
            hunger = 50;
            boundries = new Boundries(10,500, "Africa");
            location.x = 10;
            location.y = 50;
            weapon = "claws";
            strenght = 350;
            health = 100;
        }

        public override string getInfo()
        {
            string str = base.getInfo();

            str += "weapon: " + weapon + Environment.NewLine
                + "strenght: " + strenght + Environment.NewLine; 

            return str;
        }
    }
}
