using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeCast
{
    internal class ClassA
    {
        int X;

        public ClassA(int val)
        {
            X = val;
        }
    }

    class ClassB : ClassA
    {
        public ClassB(int val) : base(val)
        {

        }
    }

}
