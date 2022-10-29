using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp69
{
    internal class Money
    {
        public double Cash = 0.00d;

        public static Money operator +(Money obj1, Money obj2)
        {
            return new Money() { Cash = obj1.Cash + obj2.Cash };
        }
        public static Money operator -(Money obj1, Money obj2)
        {
            try
            {
                if (obj1.Cash - obj2.Cash < 0) throw new Exception();
                return new Money() { Cash = obj1.Cash - obj2.Cash };
            }
            catch (Exception)
            {
                MessageBox.Show("Банкрот");
                return new Money() { Cash = 0 };
            }
        }

        public static Money operator *(Money obj1, int number)
        {
            return new Money() { Cash = obj1.Cash * number };
        }

        public static Money operator /(Money obj1, int number)
        {
            try
            {
                if ( number == 0) throw new Exception();
                return new Money() { Cash = obj1.Cash / number };
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return new Money() { Cash = 0 };
            }
            
        }
        public static Money operator ++(Money obj)
        {
            obj.Cash += 0.01;
            return obj;
        }
        public static Money operator --(Money obj)
        {
            try
            {
                if (obj.Cash - 0.01 < 0) throw new Exception();
                obj.Cash -= 0.01;
                return obj;
            }
            catch (Exception)
            {

                MessageBox.Show("Банкрот");
                return new Money() { Cash = 0 };
            }
           
        }
    }
}
