using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTabControll
{
    [Serializable]
    abstract class Electronic
    {
        public string Name { get; set; }
    }

    [Serializable]
    class el1 : Electronic
    {
        public el1()
        {
            Name = "Teapot";
        }
    }

    [Serializable]
    class el2 : Electronic
    {
        public el2()
        {
            Name = "Flatiron";
        }
    }

    [Serializable]
    class el3 : Electronic
    {
        public el3()
        {
            Name = "Fan";
        }
    }
}
