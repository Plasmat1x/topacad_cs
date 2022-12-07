using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw35
{
    public partial class Form1 : Form
    {
        List<Item> items = new List<Item>();

        public Form1()
        {
            InitializeComponent();

            items.Add(new Item { ID = 1, Name = "Snack", Type = ItemType.food, Price = 50 });
            items.Add(new Item { ID = 2, Name = "Carbonised water", Type = ItemType.drink, Price = 40 });
            items.Add(new Item { ID = 3, Name = "Washer", Type = ItemType.chemical, Price = 150 });
            items.Add(new Item { ID = 4, Name = "Cleaner", Type = ItemType.chemical, Price = 100 });
            items.Add(new Item { ID = 5, Name = "Meat", Type = ItemType.food, Price = 250 });

            IEnumerable<Item> res = from item in items
                                    where item.Price > 100 // instead 500
                                    select item;
            MessageBox.Show("price > 100:\n\n" + getstr(res));

            res = from item in items
                  where item.Type == ItemType.food
                  select item;
            MessageBox.Show("is food:\n\n" + getstr(res));

            res = from item in items
                  orderby item.Name ascending
                  select item;
            MessageBox.Show("sorted by name ascending:\n\n" + getstr(res));

            res = from item in items
                  orderby item.Price descending
                  select item;
            MessageBox.Show("sorted by price descending:\n\n" + getstr(res));
        }

        private string getstr(IEnumerable<Item> col)
        {
            string res = "";
            foreach (var item in col)
            {
                res += item.ToString() + Environment.NewLine;
            }

            return res;
        }
    }



    public enum ItemType
    {
        food,
        drink,
        chemical
    }

    public class Item
    {
        public uint ID;
        public string Name;
        public ItemType Type;
        public float Price;

        public override string ToString()
        {
            return $"{ID} {Name} {Type} {Price}";
        }
    }
}
