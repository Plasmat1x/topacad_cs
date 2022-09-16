using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventCalc
{
    public partial class Form1 : Form
    {
        Party party;
        Birthday bday;
        public Form1()
        {
            InitializeComponent();

            party = new Party();
            bday = new Birthday();

            summary();
            summaryBday();
        }

        private void guests_nud_ValueChanged(object sender, EventArgs e)
        {
            summary();
        }

        private void special_cb_CheckedChanged(object sender, EventArgs e)
        {
            summary();
        }

        private void health_cb_CheckedChanged(object sender, EventArgs e)
        {
            summary();
        }

        private void summary()
        {
            sum_label.Text = "$" + party.calc((int)guests_nud.Value, special_cb.Checked, health_cb.Checked);
        }

        private void summaryBday()
        {
            bday_sum.Text = "$ " + bday.calc((int)bday_nud.Value, bday_cb.Checked,cake_text.Text);
        }

        private void cake_text_TextChanged(object sender, EventArgs e)
        {
            if (bday_nud.Value < 4)
                cake_text.MaxLength = 15;
            else
                cake_text.MaxLength = 30;

            summaryBday();
        }

        private void bday_cb_CheckedChanged(object sender, EventArgs e)
        {
            summaryBday();
        }

        private void bday_nud_ValueChanged(object sender, EventArgs e)
        {
            summaryBday();
            cake_text.Text = "";
        }
    }
}
