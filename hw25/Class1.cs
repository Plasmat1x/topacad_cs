using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw25
{
    class Tech
    {
        public string Name { get; set; }

        public string Show()
        {
            return Name;
        }
    }

    class Tech1 : Tech
    {
        public Tech1(string Name)
        {
            this.Name = Name;
        }
    }

    class Tech2 : Tech
    {
        public Tech2(string Name)
        {
            this.Name = Name;
        }
    }

    class Storage
    {
        public List<Tech> storage { set; get; } = new List<Tech>();

        public enum TechEnum
        {
            TECH1,
            TECH2,
        }

        public Storage()
        {

        }

        public void Add(string Name, TechEnum type)
        {
            switch(type)
            {
                case TechEnum.TECH1:
                    storage.Add(new Tech1(Name));
                    break;
                case TechEnum.TECH2:
                    storage.Add(new Tech2(Name));
                    break;
                default:
                    break;
            }
        }

        public string show()
        {
            string str = "";
            foreach(Tech tech in storage)
            {
                str += tech.Show() + Environment.NewLine;
            }
            return str;
        }
    }
}
