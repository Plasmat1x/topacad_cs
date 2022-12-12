using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp129
{
    public enum UserRole
    {
        Manager,
        Teller,
        Admin
    }
    public class User : EventArgs
    {
        //public event EventHandler RegisterEvent;
        private static int counter;
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public UserRole Role { get; set; }
        public int Rate { get; set; }

        public User()
        {
            counter++;
            Id = counter;
        }

        public void RecieveMessage(object sender, EventArgs e)
        {
            var user = (User)e;
            MessageBox.Show("Зарегистрирован новый пользователь: " + user.Id + "." +user.Login + " " + user.Password);
        }

        public override string ToString()
        {
            return $"{Id}. Должность: {Role} Рейтинг: {Rate}";
        }
    }
}
