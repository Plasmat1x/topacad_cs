using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLWrite
{
    internal class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Item(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        public string GetInfo()
        {
            return $"{Id}\n{Name}\n{Type}";
        }
    }
}
