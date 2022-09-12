using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabControll
{
    class Player
    {
        private int health;
        private int hungry;
        private int happy;
        private int clear;
        private int sleep;

        public Player()
        {
            health = 100;
            hungry = 100;
            happy = 100;
            clear = 100;
            sleep = 100;
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Hungry
        {
            get { return hungry; }
            set { hungry = value; }   
        }

        public int Happy
        {
            get { return happy; }
            set { happy = value; }
        }

        public int Clear
        {
            get { return clear; }
            set { clear = value; }
        }

        public int Sleep
        {
            get { return sleep; }
            set { sleep = value; }
        }
    }
}
