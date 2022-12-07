using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw32
{
    public partial class Form1 : Form
    {
        MGR mgr = new MGR();
        Animal A1;
        Animal A2;
        Animal A3;
        public Form1()
        {
            InitializeComponent();
            A1 = new Animal(listBox1);
            A2 = new Animal(listBox2);
            A3 = new Animal(listBox3);

            mgr.feedAnimal1 += A1.Eat;
            mgr.feedAnimal2 += A2.Eat;
            mgr.feedAnimal3 += A3.Eat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
                mgr.feedAnimal("1");
            else if(radioButton2.Checked)
                mgr.feedAnimal("2");
            else if(radioButton3.Checked)
                mgr.feedAnimal("3");
        }
    }

    public class Animal
    {
        private ListBox lb;

        public Animal(ListBox lb)
        {
            this.lb = lb;
        }

        public void Eat(object sender, string food)
        {
            lb.Items.Add(food);
        }

    }

    public class MGR
    {
        public event EventHandler<string> feedAnimal1;
        public event EventHandler<string> feedAnimal2;
        public event EventHandler<string> feedAnimal3;

        public void feedAnimal(string timeOfDay)
        {
            switch (timeOfDay)
            {
                case "1":
                    feedAnimal1(this, "Ration1.A1");
                    feedAnimal2(this, "Ration1.A2");
                    feedAnimal3(this, "Ration1.A3");
                    break;

                case "2":
                    feedAnimal1(this, "Ration2.A1");
                    feedAnimal2(this, "Ration2.A2");
                    feedAnimal3(this, "Ration2.A3");
                    break;

                case "3":
                    feedAnimal1(this, "Ration3.A1");
                    feedAnimal2(this, "Ration3.A2");
                    feedAnimal3(this, "Ration3.A3");
                    break;
            }
        }
    }
}
