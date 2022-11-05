using System;
using System.Collections.Generic;
using System.Drawing;
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
        public int humanId;
        public void AddHuman(string firstName, string surname, string phoneNumber, string humanPhoto)
        {
            Humans.Add(new Human(firstName, surname, phoneNumber, CheckId(), humanPhoto));
        }
        private int CheckId()
        {
            bool check = true;
            if (Humans.Count <= 0) return ++humanId;

            while (true)
            {
                check = true;
                for (int i = 0; i < Humans.Count; i++)
                {
                    if (humanId == Humans[i].Id)
                    {
                        ++humanId;
                        check = false;
                    }
                    
                }
                if (check == true)
                {
                    break;
                }
            }
            return humanId;
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
                string[] array = humanInfo.Split('.');
                int humanId = int.Parse(array[0]);
                for(int i = 0; i < Humans.Count; i++)
                {
                    if (Humans[i].Id == humanId)
                    {
                        Humans.Remove(Humans[i]);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
     
  
        }
    }
}
