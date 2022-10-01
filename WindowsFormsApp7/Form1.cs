using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        HR hr;
        public Form1()
        {
            InitializeComponent();
            hr = new HR();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null) return;

            bool check = false;
            IWorker worker = null;

            

            if (comboBox2.SelectedItem.ToString() == "Программист")
            {

                worker = new Programmer(textBox1.Text, textBox2.Text, comboBox2.SelectedItem.ToString(),
                    (double)numericUpDown1.Value);

                check = hr.AddNewWorker(worker, (double)numericUpDown1.Value);
            }
            else if (comboBox2.SelectedItem.ToString() == "Менеджер")
            {
                worker = new Manager(textBox1.Text, textBox2.Text, comboBox2.SelectedItem.ToString(),
                    (double)numericUpDown1.Value);

                check = hr.AddNewWorker(worker, (double)numericUpDown1.Value);
            }
            else if (comboBox2.SelectedItem.ToString() == "Ассистент")
            {
                worker = new Assistent(textBox1.Text, textBox2.Text, comboBox2.SelectedItem.ToString(),
                    (double)numericUpDown1.Value);

                check = hr.AddNewWorker(worker, (double)numericUpDown1.Value);
            }

            if (check)
            {
                comboBox1.Items.Add(worker.SecondName + " " + worker.Name);
                label1.Text = hr.ShowAllWorkers();
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == null)
            {
                return;
            }

            hr.getPaid(comboBox1.SelectedIndex);
            label1.Text = hr.ShowAllWorkers();

            comboBox1.SelectedItem = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                return;
            }

            hr.getPenalty(comboBox1.SelectedIndex);
            label1.Text = hr.ShowAllWorkers();

            comboBox1.SelectedItem = null;
        }
    }
}
