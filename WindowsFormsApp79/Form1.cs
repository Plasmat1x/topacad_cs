using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp79
{
    //Добавить каждому человеку в справочнике фотографию
    //Добавить возможность редактировать каждого человека из списка
    //Фотография должна сохраняться в корне проекта в формате .bin
    //Добавить свойство "Профессия" каждому человек
    //У каждой профессии есть свои, уникальные методы и свойства. Придумать интерфейс для вызова этих методов.
    //Профессии реализовать с помощью наследования и интерфейсов.
    public partial class Form1 : Form
    {
        AddHumanForm addHumanForm;
        PhoneBook phoneBook;
        public Form1()
        {
            InitializeComponent();
            phoneBook = new PhoneBook();
            SearchType_ComboBox.SelectedIndex = 0;
            base.Size = new Size(15, 16);
        }

        private void AddHumanInPhoneBook_Button_Click(object sender, EventArgs e)
        {
            addHumanForm = new AddHumanForm(this, phoneBook);
            if (addHumanForm.ShowDialog() == DialogResult.OK)
            {
                HumanInfo_ListBox.Items.Add(phoneBook.Humans.Last().Show());
            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            HumanInfo_ListBox.Items.Clear();
            foreach (Human item in phoneBook.Search(SearchType_ComboBox.SelectedItem.ToString(), SearchQuestions_TextBox.Text))
            {
                HumanInfo_ListBox.Items.Add(item.Show());
            }
        }
        XmlSerializer serializer = new XmlSerializer(typeof(PhoneBook));

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (File.Exists("phonebook.xml") == false) return;
            try
            {
                using (FileStream fs = new FileStream("phonebook.xml", FileMode.Open))
                {
                    phoneBook = (PhoneBook)serializer.Deserialize(fs);
                }
                foreach (Human item in phoneBook.Humans)
                {
                    HumanInfo_ListBox.Items.Add(item.Show());
                }
            }
            catch (FileNotFoundException)
            {
                
            }
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FileStream fs = new FileStream("phonebook.xml", FileMode.Create))
            {
                serializer.Serialize(fs, phoneBook);
            }
        }

        private void HumanInfo_ListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = phoneBook.Humans.Last().GetIMG();
        }
        private void UpdateHumanListBox()
        {
            HumanInfo_ListBox.Items.Clear();
            foreach (Human item in phoneBook.Humans)
            {
                HumanInfo_ListBox.Items.Add(item.Show());
            }
        }
        private void SortFirstName_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SortFirstName_RadioButton.Checked == true)
            {
                //Human.FirstNameSortFlag = true;
                phoneBook.Humans.Sort();
                UpdateHumanListBox();
            }
          
        }

        private void SortSurname_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SortSurname_RadioButton.Checked == true)
            {
                //Human.FirstNameSortFlag = false;
                //phoneBook.Humans.Sort();
                foreach (Human item in phoneBook.Humans)
                {
                    phoneBook.Humans.Sort(item.Compare);
                }


                UpdateHumanListBox();
            }
        }

        private void DeleteHuman_Button_Click(object sender, EventArgs e)
        {
            if (HumanInfo_ListBox.SelectedItem == null || HumanInfo_ListBox.Items.Count <= 0) return;
            if (phoneBook.Delete(HumanInfo_ListBox.SelectedItem.ToString()) == true)
            {
                HumanInfo_ListBox.Items.Remove(HumanInfo_ListBox.SelectedItem);
            }
        }

        private void HumanInfo_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
