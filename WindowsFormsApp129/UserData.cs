using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WindowsFormsApp129.Services;

namespace WindowsFormsApp129
{
    public class UserData : ISerialize
    {
        public List<User> AllUsers { get; } = new List<User>();
        public string FileName { get; set; } = nameof(UserData);
        [XmlIgnore]
        public static bool Serialized { get; set; }

        public UserData()
        {

        }
        public User Authorization(string login, string password)
        {
            return AllUsers.FirstOrDefault(u => u.Login == login && u.Password == password);
        }
        public void AddUser(User user)
        {
            if(AllUsers.FirstOrDefault(u => u.Login == user.Login && u.Password == user.Password) == null)
            {
                AllUsers.Add(user);
            }
        }
    }
}
