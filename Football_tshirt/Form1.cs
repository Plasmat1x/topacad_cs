using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_tshirt
{
    public partial class Form1 : Form
    {
        Dictionary<int, Player> players;
        public Form1()
        {
            InitializeComponent();

            players = new Dictionary<int, Player>();

            players.Add(24, new Player("Petr", 1948));
            players.Add(52, new Player("Ivan", 1997));

            comboBox1.Items.Add(24);
            comboBox1.Items.Add(52);
            comboBox1.SelectedIndex = 0;

            label3.Text = "Number";
            label1.Text = "worn";
            label2.Text = "year";
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = players[int.Parse(comboBox1.SelectedItem.ToString())].Name;
            textBox2.Text = players[int.Parse(comboBox1.SelectedItem.ToString())].YearRetired.ToString();
        }
    }
}
