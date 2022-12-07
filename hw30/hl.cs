using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw30
{
    internal class hl
    {
        public List<Human> list { set; get; } = new List<Human>();
        static public int comparetype;
        public hl()
        {

        }

        public Human search(string name)
        {
            Predicate<Human> searchable = (Human human) => { return human.Name == name; }; //lambda fnc (anonym fnc)

            return list.Find(searchable);
        }

        public void update(ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (var item in list)
            {
                listbox.Items.Add(item.ToString());
            }
        }

        public int compare(Human x, Human y)
        {
            switch (comparetype)
            {
                case 11: return x.Name.CompareTo(y.Name);
                case 12: return x.Age.CompareTo(y.Age);
                case 14: return x.Weight.CompareTo(y.Weight);

                case 21: return y.Name.CompareTo(x.Name);
                case 22: return y.Age.CompareTo(x.Age);
                case 24: return y.Weight.CompareTo(x.Weight);

                default:
                    return 0;
            }
        }
        
    }
}
