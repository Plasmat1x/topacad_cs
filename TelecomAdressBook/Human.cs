using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelecomAdressBook
{
    [Serializable]
    public class Human : IComparable<Human>, IComparer<Human>
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoeneNumber { get; set; }
        public string Photo { get; set; }

        public Human() { }
        public Human(string firstname, string lastname, string phoenenumber, int id, string photo = null)
        {
            FirstName = firstname;
            LastName = lastname;
            PhoeneNumber = phoenenumber;
            Id = id;
            Photo = photo;
        }

        public string Get()
        {
            return $"{Id} {FirstName} {LastName} {PhoeneNumber}";
        }

        public static bool SortVar = false;
        public static bool IdSort = false;
        public int CompareTo(Human other)
        {
            if (SortVar)
            {
                return FirstName.CompareTo(other.FirstName);
            }
            else if (IdSort)
            {
                return Id.CompareTo(other.Id);
            }
            else
            {
                return LastName.CompareTo(other.LastName);
            }
        }

        public int Compare(Human x, Human y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }
}
