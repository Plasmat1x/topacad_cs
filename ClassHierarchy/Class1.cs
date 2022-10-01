using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    class Animal
    {
        protected string name;
    }

    class Owl : Animal
    {
        //owl fields, methods
    }

    class LongEaredOwl : Owl
    {
        //Long-eared owl fields, methods
    }

    class Filin : Owl
    {
        //Filin fields, methods
    }
    class WhiteOwl : Owl
    {
        //White owl fields, methods
    }
}
