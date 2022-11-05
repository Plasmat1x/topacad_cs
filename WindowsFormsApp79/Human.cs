using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp79
{
    [Serializable]
    
    public class Human : IComparable<Human>, IComparer<Human>
    {
        
        public int Id { get;  set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        
        public string HumanPhotoPath { get; set; }
        [NonSerialized]
        private Image humanPhotoImg;
        public Human() { }
        public Human(string firstName, string surname, string phoneNumber, int id, string humanPhoto)
        {
            FirstName = firstName;
            Surname = surname;
            PhoneNumber = phoneNumber;

            Id = id;
            HumanPhotoPath = humanPhoto;
            humanPhotoImg = Image.FromFile(HumanPhotoPath);
        }
        public string Show()
        {
            return $"{Id}. Имя: {FirstName} | Фамилия: {Surname} | Номер телефона: {PhoneNumber}";
        }
        public Image GetIMG()
        {
            return humanPhotoImg;
        }
        public static bool FirstNameSortFlag;
        public int CompareTo(Human other)
        {
            //if (FirstNameSortFlag == true)
            //{
                return FirstName.CompareTo(other.FirstName);
            //}
            //else
            //{
            //    return Surname.CompareTo(other.Surname);
            //}
            
        }

        public int Compare(Human x, Human y)
        {
            return x.Surname.CompareTo(y.Surname);
        }
    }
}
