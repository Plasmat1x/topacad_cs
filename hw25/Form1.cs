using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw25
{
    public partial class Form1 : Form
    {
        Storage storage = new Storage();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            storage.Add(comboBox2.SelectedItem.ToString(), (TechEnum)comboBox1.SelectedIndex);
            UpdateForm();
        }

        private void UpdateForm()
        {
            listBox1.Items.Clear();
            foreach (var item in storage.storage)
            {
                listBox1.Items.Add(item);
            }
            
        }
    }
}
