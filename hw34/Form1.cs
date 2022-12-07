using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw34
{

    public partial class Form1 : Form
    {
        public enum type
        {
            _fname,
            _lname,
            _age
        }

        List<User> users = new List<User>();

        public Form1()
        {
            InitializeComponent();

            users.Add(new User { Fname = "A", Lname = "a", Age = 1 });
            users.Add(new User { Fname = "A", Lname = "c", Age = 2 }); //!
            users.Add(new User { Fname = "B", Lname = "b", Age = 2 });
            users.Add(new User { Fname = "C", Lname = "c", Age = 3 });
            users.Add(new User { Fname = "D", Lname = "d", Age = 4 });
            users.Add(new User { Fname = "E", Lname = "e", Age = 5 });


            // Задание выполнено без граф. интерфейса
            MessageBox.Show(getstr(search("A", type._fname)));
        }

        private string getstr(IEnumerable<User> ul)
        {
            //ul.ToList().ForEach(getelem); //getelem => return elem.ToString()

            string res = "";

            foreach(var item in ul.ToList())
            {
                res += item.ToString() + Environment.NewLine;
            }

            return res;
        }

        // через переменную _type выбираем по какому полю искать элементы
        // param что ищем
        private IEnumerable<User> search(string param, type _type)
        {
            Predicate<User> s = null;

            //пачка лямбд для предиката
            switch (_type)
            {
                case type._fname:
                    s = (User u) => { return u.Fname == param; };
                    break;
                case type._lname:
                    s = (User u) => { return u.Lname == param; };
                    break;
                case type._age:
                    s = (User u) => { return u.Age == int.Parse(param); };
                    break;
                default:
                    break;
            }

            if (s == null)
                return null;

            return users.FindAll(s);
        }
    }

    public class User
    {
        public string Fname;
        public string Lname;
        public int Age;

        public override string ToString()
        {
            return $"{Fname} {Lname} {Age}";
        }
    }
}
