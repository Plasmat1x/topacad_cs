using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    [Serializable]
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string Photo { get; set; }

        public User()
        {

        }
        public User(string login, string password, string username, string email, string firstName = null, string lastName = null, string phone = null, string location = null, string photo = null)
        {
            Login = login;
            Password = password;
            Username = username;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Photo = photo;
            Location = location;
        }

        public override string ToString()
        {
            return $"{Login}\n{Password}\n{Username}\n{Email}\n{FirstName}\n{LastName}\n{Phone}\n{Location}\n{Photo}";
        }
    }
}
