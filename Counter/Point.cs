using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    internal class Point
    {
        //поля
        private int x;
        private int y;


        //методы
        public void setPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        //свойства
        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

    }
}
