using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddUsers
{

    class Spec
    {
        public string name;
        public float pay;
    }

    class Human
    {
        public string name;
        public int age;
        public Spec spec;
    }

    class Prog : Spec
    {
        public Prog(string name, float pay)
        {
            this.name = name;
            this.pay = pay;
        }
    }

    class Tech : Spec
    {
        public Tech(string name, float pay)
        {
            this.name = name;
            this.pay = pay;
        }
    }
}
