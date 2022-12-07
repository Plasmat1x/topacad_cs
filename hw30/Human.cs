using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw30
{
    internal class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }

        public Human(string name, int age, float weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{Name} {Age} {Weight}";
        }
    }
}
