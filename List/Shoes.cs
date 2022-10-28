using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public enum Color
    {
        RED,
        BLACK,
        PINK,
        GREEN,
        BLUE
    }

    public enum Type
    {
        moccasins,
        sneakers,
        flip_flops,
        boots,
        valens,
    }


    internal class Shoes
    {
        public Type Type { get; set; }
        public Color Color { get; set; }
        public double Price { get; set; }

        public Shoes(Type type, Color color, double price)
        {
            Type = type;
            Color = color;
            Price = price;
        }

        public string Show()
        {
            string res = "";

            res += $"{Color.ToString()} {Type.ToString()} {Price.ToString()}";

            return res;
        }
    }
}
