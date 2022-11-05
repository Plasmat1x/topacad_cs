using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelecomAdressBook
{
    [Serializable]
    public class ContactBook
    {
        public List<Human> Contacts { get; private set; } = new List<Human>();

        public int ContactId;

        public ContactBook()
        {
        
        }

        public void AddContact(string First, string Last, string Phone, string Photo = null)
        {
            Contacts.Add(new Human(First, Last, Phone, CheckId(), Photo));
        }

        public IEnumerable<Human> SearchContact(string search, string parameter)
        {
            List<Human> list = new List<Human>();
            foreach (var item in Contacts)
            {
                switch (parameter)
                {
                    case "First name":
                        if (item.FirstName.ToLower() == search.ToLower())
                        {
                            list.Add(item);
                        }
                        break;

                    case "Last name":
                        if (item.LastName.ToLower() == search.ToLower())
                        {
                            list.Add(item);
                        }
                        break;

                    case "Phone number":

                        for (int i = 0; i < search.Length; i++)
                        {
                            if(!Char.IsDigit(search[i]))
                            {
                                MessageBox.Show("Only digit chars");
                                return Contacts;
                            }
                        }

                        string number = "";

                        for(int i = 0; i < item.PhoeneNumber.Length; i++)
                        {
                            if (Char.IsDigit(item.PhoeneNumber[i]))
                            {
                                number += item.PhoeneNumber[i];
                            }
                        }

                        if (number == search)
                        {
                            list.Add(item);
                        }
                        break;

                    default:
                        return Contacts;

                }

            }

            if(list.Count > 0)
            {
                return list;
            }

            return Contacts;
        }

        public bool Delete(string selected)
        {
            try
            {


                /*
                string tmp = "";
                for (int i = 0; i < selected.Length; i++)
                {
                    if (selected[i] != ' ')
                    {
                        tmp += selected[i];
                    }
                }
                string[] array = tmp.Split(' ');
                */
                /*
                string[] array = selected.Split(' ');
                Contacts.Remove(new Human(array[0], array[1], array[2]));
                */

                string[] array = selected.Split(' ');

                foreach (var item in Contacts)
                {
                    if(item.Id == int.Parse(array[0]))
                    {
                        Contacts.Remove(item);
                    }
                }

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        private int CheckId()
        {
            bool check = true;

            if (Contacts.Count <= 0) return ++ContactId;

            while(true)
            {
                check = true;

                for (int i = 0; i < Contacts.Count; i++)
                {
                    if (ContactId == Contacts[i].Id)
                    {
                        ContactId++;
                        check = false;
                    }
                }

                if(check)
                {
                    break;
                }
            }

            return ContactId;
        }
    }
}
