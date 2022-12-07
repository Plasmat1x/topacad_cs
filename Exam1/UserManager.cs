using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Exam1
{
    public enum UserParamater
    {
        Login,
        Username,
        Email,
    }

    [Serializable]
    public class UserManager
    {
        public List<User> users { get; set; } = new List<User>();

        [NonSerialized]
        private User currentUser;

        public UserManager()
        {

        }

        public User Verification(string login, string password)
        {
            User ver = getUser(login, UserParamater.Login);
            if (ver != null)
            {
                if (ver.Password == password)
                    return ver;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        private void RegisterUser(User user)
        {
            users.Add(user);

            //serialization;
        }

        public void Register(User user)
        { 
            if(!RegisterCheck(user.Login, user.Username, user.Email))
            {
                MessageBox.Show("Somthin wrong in registration");
                return;
            }
            currentUser = user;

            RegisterUser(currentUser);
        }

        private bool RegisterCheck(string Login, string Username, string Email)
        {
            try
            {
                foreach (var item in users)
                {
                    if (item.Username == Username)
                        throw new Exception($"{Username} alredy registred");
                    if (item.Login == Login)
                        throw new Exception($"{Login} alredy registred");
                    if(item.Email == Email)
                        throw new Exception($"{Email} alredy registred");
                }

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private User getUser(string param, UserParamater uparam)
        {
            foreach (var item in users)
            {
                switch (uparam)
                {
                    case UserParamater.Login:
                        item.Login = param;
                        return item;
                    case UserParamater.Username:
                        item.Username = param;
                        return item;
                    case UserParamater.Email:
                        item.Email = param;
                        return item;
                    default:
                        return null;
                }
            }
            return null;
        }
    }
}
