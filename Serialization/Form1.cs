using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public partial class Form1 : Form
    {
        Person person;
        Cat cat;
        public Form1()
        {
            InitializeComponent();
            cat = new Cat();
            cat.Name = "Barsik";
            cat.ColorCat = Color.Beige;
            label1.Text = cat.show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            cat.Name = textBox1.Text;

            using (FileStream fs = new FileStream("cat.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, cat);
            }

            label1.Text = cat.show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (Stream input = File.OpenRead("cat.txt"))
            {
                cat = (Cat)formatter.Deserialize(input);
            }

            label2.Text = $"{cat.Name} {cat.ColorCat}";
        }
    }
}
