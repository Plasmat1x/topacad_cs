using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddRecipe
{
    internal class Burger
    {
        public string Name { get; set; }
        public List<string> Ingridients { get; set; } = new List<string>();

        public Burger(string name)
        {
            Name = name;
        }

        public Burger(string name, List<string> recipe)
        {
            Name = name;
            Ingridients = recipe;
        }
    }
}
