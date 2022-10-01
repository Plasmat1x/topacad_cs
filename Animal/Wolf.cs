using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Wolf : Predator
    {
        public Wolf()
        {
            name = "wolf";
            picture = Image.FromFile("..\\..\\wolf.png");
            food = "meat";
            hunger = 50;
            boundries = new Boundries(10, 500, "Siberia");
            location.x = 10;
            location.y = 50;
            weapon = "jaws";
            strenght = 300;
            health = 150;
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
