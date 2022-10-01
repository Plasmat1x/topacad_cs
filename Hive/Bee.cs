using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hive
{
    internal class Bee
    {
        public string role;
        public bool avalable;
        public int shifts;
        public string name;

        public double foodAvailable;
        public double dailyLimit;
    }

    internal class Worker : Bee
    {
        public Worker()
        {
            role = "Harvest nectar";
            name = "worker";
            avalable = true;
            shifts = 0;
        }

    }

    internal class Queen : Bee
    {
        private Bee[] bees;
        private int shiftNumber;

        public Queen()
        {
            bees = new Bee[6];

            for(int i = 0; i < bees.Length; i++)
            {
                if (i > 2)
                {
                    bees[i] = new GuardBee();
                }
                else
                {
                    bees[i] = new Worker();
                }
            }
        }

        public void Order(string role, int shifts)
        {
            bool check = false;
            for (int i = 0; i < bees.Length; i++)
            {
                //workers[i].Order(role, shifts);

                if(bees[i].avalable && bees[i].role == role && !check)
                {
                    bees[i].shifts = shifts;
                    bees[i].avalable = false;
                    check = true;
                    break;
                }
            }

            if (!check)
            {
                MessageBox.Show("Error all bees busy");
            }
        }

        public string showinfo()
        {
            string res = "";

            for(int i = 0; i < bees.Length; i++)
            {
                if(!bees[i].avalable)
                { 
                    res += $"{bees[i].name} Start {bees[i].role}, shifts remain {bees[i].shifts}\n"; 
                }
                
            }

            return res;
        }

        public void endShift()
        {
            for (int i = 0; i < bees.Length; i++)
            {
                if(!bees[i].avalable)
                {
                    bees[i].shifts--;
                }

                if(bees[i].shifts < 1)
                {
                    bees[i].avalable = true;
                }
            }

            MessageBox.Show("End shift");
        }
    }

    class GuardBee : Bee
    {
        public GuardBee()
        {
            role = "Guard hive";
            name = "guardian";
            avalable = true;
            shifts = 0;
        }
    }
}
