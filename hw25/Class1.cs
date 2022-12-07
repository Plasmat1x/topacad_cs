using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw25
{
    abstract public class Tech
    {
        virtual public string Name { get; set; }

        //base params all tech

        public override string ToString()
        {
            return Name + " " + this.GetType().ToString();
        }
    }

    class Tech1 : Tech
    {
        //special params for concrete tech + methods
        public Tech1(string Name)
        {
            this.Name = Name;
        }
    }

    class Tech2 : Tech
    {
        //special params for concrete tech + methods
        public Tech2(string Name)
        {
            this.Name = Name;
        }
    }

    public enum TechEnum
    {
        TECH1,
        TECH2,
    }

    class Storage
    {
        public List<Tech> storage { set; get; } = new List<Tech>();

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

        //serialization like TelephoneBook
    }
}
