using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Boundries
    {
        public int height;
        public int width;
        public string location;

        public Boundries(int height, int width, string location)
        {
            this.width = width;
            this.height = height;

            this.location = location;
        }

    }
}
