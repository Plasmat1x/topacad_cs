using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp79
{
    [Serializable]
    public class PhoneBook
    {
        public List<Human> Humans { get; private set; } = new List<Human>(); 

        public void AddHuman(string firstName, string surname, string phoneNumber)
        {
            Humans.Add(new Human(firstName, surname, phoneNumber));
        }

        public IEnumerable<Human> Search(string requestType, string requestSearch)
        {
            List<Human> list = new List<Human>();
            foreach (Human human in Humans)
            {
                switch (requestType)
                {
                    case "По имени":
                        if (human.FirstName.ToLower() == requestSearch.ToLower())
                        {
                            list.Add(human);
                        }
                        break;
                    case "По фамилии":
                        if (human.Surname.ToLower() == requestSearch.ToLower())
                        {
                            list.Add(human);
                        }
                        break;
                    case "По телефону":
                        long temp;
                        if(long.TryParse(requestSearch, out temp) == false)
                        {
                            MessageBox.Show("номер должен быть из цифр");
                            return Humans;
                        }
                        string phone = "";
                        for (int i = 0; i < human.PhoneNumber.Length; i++)
                        {
                            if (Char.IsDigit(human.PhoneNumber[i]) == true)
                            {
                                phone += human.PhoneNumber[i];
                            }
                        }
                        if (phone == requestSearch)
                        {
                            list.Add(human);
                        }
                        break;
                    default:
                        return Humans;
                }
            }
            if (list.Count > 0)
            {
                return list;
            }
            return Humans;
        }
        public bool Delete(string humanInfo)
        {
            try
            {
                string tempStr = "";
                for (int i = 0; i < humanInfo.Length; i++)
                {
                    if (humanInfo[i] != ' ')
                    {
                        tempStr += humanInfo[i];
                    }
                }
                string[] array = tempStr.Split(':', '|');
                Human temp = new Human(array[1], array[3], array[5]);
                Humans.Remove(temp);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
     
  
        }
    }
}
