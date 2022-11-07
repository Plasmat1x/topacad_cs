using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLWrite
{
    internal class List
    {
        public List<Item> list { set; get; } = new List<Item>();

        public int itemsCounter = 0;

        public List()
        {

        }

        public void AddItem(string Name, string Type)
        {
            list.Add(new Item(++itemsCounter, Name, Type));
        }

        public void WriteInXML()
        {
            XmlDocument doc = new XmlDocument();
            XmlNode root = doc.CreateElement("List");

            foreach(var item in list)
            {
                XmlNode itemElement = doc.CreateElement("Item");

                XmlNode itemChild = doc.CreateElement("Id");
                XmlNode itemText = doc.CreateTextNode(item.Id.ToString());
                itemChild.AppendChild(itemText);
                itemElement.AppendChild(itemChild);

                itemChild = doc.CreateElement("Name");
                itemText = doc.CreateTextNode(item.Name);
                itemChild.AppendChild(itemText);
                itemElement.AppendChild(itemChild);

                itemChild = doc.CreateElement("Type");
                itemText = doc.CreateTextNode(item.Type);
                itemChild.AppendChild(itemText);
                itemElement.AppendChild(itemChild);

                root.AppendChild(itemElement);
            }

            doc.AppendChild(root);
            doc.Save("list.xml");
        }

        public void ReadFromXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("list.xml");
            XmlNode root = doc.FirstChild; //<List>

            for(XmlNode item = root.FirstChild; item != null; item = item.NextSibling) //<Item>
            {
                XmlNode child = item.FirstChild; //<Id>

                child = child.NextSibling; //<Name>
                string name = child.InnerText;

                child = child.NextSibling; //<Type>
                string type = child.InnerText;

                AddItem(name, type); //!error (string == null, string == null)
            }
        }
    }
}
