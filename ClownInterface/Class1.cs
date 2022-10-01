using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClownInterface
{
    interface IClown
    {
        // what funny have clown
        string WFHC { get; set; } 
        string Honk();
    }

    interface ISecurity
    {
        string Shoot();
        string Radio();
        string Crossword();
    }

    class TallHuman
    {
        public virtual string About()
        {
            return "";
        }
    }

    class SecurityMan : TallHuman, ISecurity
    {
        public string Crossword()
        {
            return "Crossword\n";
        }

        public string Radio()
        {
            return "Radio\n";
        }

        public string Shoot()
        {
            return "Shoot\n";
        }

        public override string About()
        {
            string res = base.About();

            res += "Im Security, and i can:\n" + Shoot() + Radio() + Crossword();

            return res;
        }
    }

    class ClownMan : TallHuman, IClown
    {
        // what funny have clown
        public string WFHC { get; set; }

        public string Honk()
        {
            return "honk honk\n";
        }

        public override string About()
        {
            string res = base.About();

            res += "Im Clown i have:\n" + WFHC + "\n\nand i can: " + Honk();

            return res;
        }
    }
}
