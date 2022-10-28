using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public enum Food
    {
        food1,
        food2,
        food3,
        food4,
    }

    internal class Cust
    {
        public string Name { get; private set; }

        private Stack<Food> stack;

        public Cust(string name)
        {
            stack = new Stack<Food>();
            Name = name;
        }

        public void order(Food food, int count)
        {
            for(int i = 0; i < count; i++)
            {
                stack.Push(food);
            }
        }

        public string eat()
        {
            string res = "";
            foreach (Food food in stack)
            {
                res += food.ToString() + "\n";
            }
            return res;
        }

        public void end()
        {
            stack.Clear();
        }
    }
}
