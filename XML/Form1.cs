using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";

            /*
            //creation
            XmlTextWriter writer = new XmlTextWriter("File.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            */
            #region
            /*
            writer.WriteStartDocument();
            {

                writer.WriteStartElement("Store");

                writer.WriteStartElement("Cars");
                {
                    writer.WriteStartElement("Mazda");
                    {
                        writer.WriteElementString("Model", "rx-7");
                        writer.WriteElementString("Speed", "240");
                        writer.WriteElementString("Price", "2000000");
                    }
                    writer.WriteEndElement();

                    writer.WriteStartElement("Rangerover");
                    {
                        writer.WriteElementString("Model", "Rangerover");
                        writer.WriteElementString("Speed", "180");
                        writer.WriteElementString("Price", "10000000");
                    }
                    writer.WriteEndElement();

                    writer.WriteStartElement("Lada");
                    {
                        writer.WriteElementString("Model", "2107");
                        writer.WriteElementString("Speed", "120");
                        writer.WriteElementString("Price", "10000");
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                writer.WriteStartElement("Bikes");
                {
                    writer.WriteStartElement("Honda");
                    {
                        writer.WriteElementString("Model", "cbr1000rr");
                        writer.WriteElementString("Speed", "320");
                        writer.WriteElementString("Price", "5000000");
                    }
                    writer.WriteEndElement();

                    writer.WriteStartElement("Kawasaki");
                    { 
                        writer.WriteElementString("Model", "H2");
                        writer.WriteElementString("Speed", "400");
                        writer.WriteElementString("Price", "10000000");
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                writer.WriteEndDocument();
            }
            writer.Close();
            */
            #endregion


            //read / modify

            #region
            /*
            XmlDocument doc = new XmlDocument();
            doc.Load("File.xml");
            XmlNode root = doc.DocumentElement;
            Out(root);
            Remove(root, "Speed");
            doc.Save("FileMod.xml");
            */
            #endregion


            #region
            //creation v2
            /*
            XmlDocument doc = new XmlDocument();
            XmlNode root = doc.CreateElement("vehical");
            XmlNode item1 = doc.CreateElement("car");
            XmlNode item2 = doc.CreateElement("bike");
            XmlNode item3 = doc.CreateElement("jet");

            XmlNode text1 = doc.CreateTextNode("car1");
            XmlNode text2 = doc.CreateTextNode("bike1");
            XmlNode text3 = doc.CreateTextNode("jet1");

            item1.AppendChild(text1);
            item2.AppendChild(text2);
            item3.AppendChild(text3);

            root.AppendChild(item1);
            root.AppendChild(item2);
            root.AppendChild(item3);

            doc.AppendChild(root);
            doc.Save("file3.xml");

            doc.Load("file3.xml");
            XmlNode item4 = doc.CreateElement("submarine");
            XmlNode item5 = doc.CreateElement("yacht");

            XmlNode text4 = doc.CreateTextNode("submarine1");
            XmlNode text5 = doc.CreateTextNode("yacht1");

            item4.AppendChild(text4);
            item5.AppendChild(text5);

            doc.DocumentElement.AppendChild(item4);
            doc.DocumentElement.AppendChild(item5);
            doc.Save("file3.xml");
            */
            #endregion

            //read v2
            XmlTextReader reader = new XmlTextReader("file3.xml");

            reader.WhitespaceHandling = WhitespaceHandling.None;

            while(reader.Read())
            {
                label1.Text += reader.NodeType + " " + reader.Name + " " + reader.Value + Environment.NewLine;
            }
        }

        private void Remove(XmlNode node, string value)
        {
            if (node.HasChildNodes)
            {
                foreach (XmlNode item in node.ChildNodes)
                {
                    Remove(item, value);
                    if(item.Name == value)
                    {
                        node.RemoveChild(item);
                    }
                }
            }
        }

        private void Out(XmlNode node)
        {
            label1.Text += "Type " + node.NodeType + "    Name " + node.Name + "    Value " + node.Value + Environment.NewLine;
            if(node.HasChildNodes)
            {
                foreach (XmlNode item in node.ChildNodes)
                {   
                    Out(item); 
                }
            }
        }
    }
}
