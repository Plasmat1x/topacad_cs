using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp129.Services;

namespace WindowsFormsApp129
{
    public class DishData : ISerialize
    {
        public List<Dish> AllDishes { get; } = new List<Dish>();
        public string FileName { get; set; } = nameof(DishData);

        public DishData() { }
        public void AddNewDish(Dish dish)
        {
            AllDishes.Add(dish);
        }
    }
}
