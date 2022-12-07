using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp118
{
    public class Teacher
    {
        private SortedList<int, EventHandler> list = new SortedList<int, EventHandler>();
        private Random rnd = new Random();

        public event EventHandler SetControlWork
        {
            add
            {
                for (;;)
                {
                    int key = rnd.Next();
                    if (list.ContainsKey(key) == false)
                    {
                        list.Add(key, value);
                        break;
                    }
                }
            }
            remove
            {
                list.RemoveAt(list.IndexOfValue(value));
            }
        }


        public void Start()
        {
            foreach (int key in list.Keys)
            {
                list[key](this, null);
            }
        }
    }
}
