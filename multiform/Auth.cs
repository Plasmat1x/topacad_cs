using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiform
{
    public struct User
    {
        public string Login;
        public string Password;
        public string Name;

        public User(string login, string password, string name)
        {
            Login = login;
            Password = password;
            Name = name;
        }
    }

    public class Auth
    {
        private List<User> users;

        public Auth()
        {
            users = new List<User>();
        }

        public User? Authorization(string login, string password)
        {
            foreach(var item in users)
            {
                if(item.Login == login && item.Password == password) return item;
            }

            return null;
        }

        public void Register(string login, string password, string name)
        {
            try
            {
                if (login.Length == 0 || password.Length == 0 || name.Length == 0)
                {
                    throw new Exception("one of string is empty");
                }

                users.Add(new User(login, password, name));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
