using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal
{
    public struct Location
    {
        public int x;
        public int y;
    }

    internal class AnimalBaseClass
    {
        protected string name;
        protected string food;
        protected int hunger;
        protected Boundries boundries;
        protected Location location;
        protected Image picture;
        protected int health;

        public void makeNoise()
        {
            MessageBox.Show(name);
        }
        public void eat()
        {
            MessageBox.Show(food);
        }

        public void sleep()
        {

        }

        public void roam()
        {

        }

        public virtual string getInfo()
        {
            return "Name: " + name + Environment.NewLine 
                +"food: " + food + Environment.NewLine 
                + "Health: " + health + Environment.NewLine;
        }

        public Image Picture
        {
            get { return picture; }
        }
    }
}
