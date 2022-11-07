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

namespace TelecomAdressBook
{
    //Фотография должна сохраняться в корне проекта в формате .bin +-
    //Добавить свойство "Профессия" каждому человек -
    //У каждой профессии есть свои, уникальные методы и свойства. Придумать интерфейс для вызова этих методов. -
    //Профессии реализовать с помощью наследования и интерфейсов. -

    public partial class Form1 : Form
    {
        Form2 addContactForm;
        Form3 editContactForm;
        ContactBook manager;
        XmlSerializer serializer = new XmlSerializer(typeof(ContactBook));

        public Form1()
        {
            InitializeComponent();
            manager = new ContactBook();
            comboBox1.SelectedIndex = 0;
        }

        private void addNewContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addContactForm = new Form2(this, manager);
            //addContactForm.ShowDialog();
            addContactForm.Show();
        }

        private void search_bt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var item in manager.SearchContact(textBox1.Text, comboBox1.SelectedItem.ToString()))
            {
                listBox1.Items.Add(item.Get());
            }
        }

        public void Update_List()
        {
            listBox1.Items.Clear();
            
            foreach(var item in manager.Contacts)
            {
                listBox1.Items.Add(item.Get());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream("ContactBook.xml", FileMode.Open))
                {
                    manager = (ContactBook)serializer.Deserialize(fs);
                }
            }
            catch (FileNotFoundException)
            {

            }

            Update_List();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FileStream fs = new FileStream("ContactBook.xml", FileMode.Create))
            {
                serializer.Serialize(fs, manager);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void deleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count <= 0) return;
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Select item from list");
                return;
            }

                if (manager.Delete(listBox1.SelectedItem.ToString()))
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }

            Update_List();
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                foreach (var item in manager.Contacts)
                {
                    editContactForm = new Form3(manager.GetContact(listBox1.SelectedItem.ToString()), this);
                }
                if (editContactForm.ShowDialog() == DialogResult.OK)
                    Update_List();
            }
            else
            {
                MessageBox.Show("Select item from list");
            }
        }

        private void FirstNameSort_CheckedChanged(object sender, EventArgs e)
        {
            if(FirstNameSort.Checked)
            {
                Human.SortVar = true;
                manager.Contacts.Sort();
                Update_List();
            }
        }

        private void LastNameSort_CheckedChanged(object sender, EventArgs e)
        {
            if (LastNameSort.Checked)
            {
                //Human.SortVar = false;
                //manager.Contacts.Sort();

                foreach (var item in manager.Contacts)
                {
                    manager.Contacts.Sort(item.Compare);
                }

                Update_List();
            }
        }
    }
}
