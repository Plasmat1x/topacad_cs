using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_tshirt
{
    internal class Player
    {
        public string Name { get; set; }
        public int YearRetired { get; set; }

        public Player(string name, int year)
        {
            Name = name;
            YearRetired = year;
        }
    }
}
