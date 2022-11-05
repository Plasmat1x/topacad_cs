using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp79
{
    [Serializable]
    public class Human
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public Human() { }
        public Human(string firstName, string surname, string phoneNumber)
        {
            FirstName = firstName;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }
        public string Show()
        {
            return $"Имя: {FirstName} | Фамилия: {Surname} | Номер телефона: {PhoneNumber}";
        }
    }
}
