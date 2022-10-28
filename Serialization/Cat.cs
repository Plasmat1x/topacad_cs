using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    internal class Cat
    {
        public string Name;
        public Color ColorCat;

        public string show()
        {
            return $"{Name} {ColorCat}";
        }
    }
}
