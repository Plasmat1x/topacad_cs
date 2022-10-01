using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddUsers
{
    public partial class Form1 : Form
    {

        Human[] array;
        int iter = 0;

        public Form1()
        {
            InitializeComponent();

            array = new Human[3];

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = new Human();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(iter > array.Length) iter = 0;

            array[iter].name = textBox1.Text;
            array[iter].age = (int)numericUpDown1.Value;
            if (comboBox1.SelectedItem.ToString() == "Programmer")
            {
                array[iter].spec = new Prog("Programmer", 600);
            }
            else if (comboBox1.SelectedItem.ToString() == "Technic")
            {
                array[iter].spec = new Tech("Technic", 500);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    
                    if (comboBox2.SelectedItem.ToString() == " ") //exception array[].**spec** was null.
                    {
                        label4.Text += $"Name: {array[i].name}\nAge: {array[i].age}\nSpec: {array[i].spec.name}\n\n";
                    }
                    else
                    {
                        if (comboBox2.SelectedItem.ToString() == array[i].spec.name) // exception array[].**spec** was null.
                        {
                            label4.Text += $"Name: {array[i].name}\nAge: {array[i].age}\nSpec: {array[i].spec.name}\n\n";
                        }
                    }
                }
            }
            else
            {
                label4.Text = " ";
            }
        }
    }
}
