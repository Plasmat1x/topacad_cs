using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trycatch
{
    internal class Human
    {
        public string Name { get; set; }

        public long Phone { get; set; }

        public int Age { get; set; }

        public Human(string name, long phone, int age)
        {
            Name = name;
            Phone = phone;
            Age = age;
        }
    }
    
    class Humans
    {
        private List<Human> list;

        public Humans()
        {
            list = new List<Human>();
        }

        public void AddHuman(string name, long phone, int age)
        {
            try
            {
                if (age < 0)
                    throw new Exception("Negative value: Age");

                if (phone < 0)
                    throw new Exception("Negative value: Phone");

                if (name.Length < 1)
                    throw new Exception("Empty string: Name");

                Human human = new Human(name, phone, age);
                list.Add(human);
            }
            catch(Exception ex)
            {
                //Продолжение работы приложения при возникновении исключения (Добавляет человека без имени, с нулевыми значениям)
                list.Add(new Human("Exception", 0, 0));
                //Вывод исключения
                MessageBox.Show(ex.ToString());
            }
            
        }

        public void DeleteHuman(int index)
        {
            try
            {
                if(index < 0)
                    throw new Exception("Negative value: index");

                list.RemoveAt(index);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void show(ref ListBox listbox)
        {
            listbox.Items.Clear();

            foreach(var item in list)
            {
                listbox.Items.Add($"{item.Name} {item.Phone} {item.Age}");
            }
        }
    }
}
