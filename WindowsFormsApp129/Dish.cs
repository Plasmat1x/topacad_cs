using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp129
{
    public class Dish
    {
        private static int counter;
        public int Id { get; set; }
        public string Name { get; set; }
        public double CookingTime { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();
        public Dish() { }
        public Dish(string name, double cookingTime, IEnumerable<string> ingredients)
        {
            counter++;
            Id = counter;
            Name = name;
            CookingTime = cookingTime;
            Ingredients = ingredients.ToList();
        }

        public override string ToString()
        {
            return $"Название: {Name} Время приготовления: {CookingTime}";
        }
    }
}
