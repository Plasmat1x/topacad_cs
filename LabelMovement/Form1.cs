using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelMovement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_left_Click(object sender, EventArgs e)
        {
            center_cb.Checked = false;
            switch ((int)label1.TextAlign)
            {
                case 1:
                    label1.TextAlign = (ContentAlignment)4;
                    break;
                case 2:
                    label1.TextAlign = (ContentAlignment)1;
                    break;
                case 4:
                    label1.TextAlign = (ContentAlignment)2;
                    break;

                case 0x10:
                    label1.TextAlign = (ContentAlignment)0x40;
                    break;
                case 0x20:
                    label1.TextAlign = (ContentAlignment)0x10;
                    break;
                case 0x40:
                    label1.TextAlign = (ContentAlignment)0x20;
                    break;

                case 0x100:
                    label1.TextAlign = (ContentAlignment)0x400;
                    break;
                case 0x200:
                    label1.TextAlign = (ContentAlignment)0x100;
                    break;
                case 0x400:
                    label1.TextAlign = (ContentAlignment)0x200;
                    break;

            }

            if ((int)label1.TextAlign == 0x20)
                center_cb.Checked = true;


        }

        private void bt_right_Click(object sender, EventArgs e)
        {
            center_cb.Checked = false;

            switch((int)label1.TextAlign)
            {
                case 1:
                    label1.TextAlign = (ContentAlignment)2;
                    break;
                case 2:
                    label1.TextAlign = (ContentAlignment)4;
                    break;
                case 4:
                    label1.TextAlign = (ContentAlignment)1;
                    break;

                case 0x10:
                    label1.TextAlign = (ContentAlignment)0x20;
                    break;
                case 0x20:
                    label1.TextAlign = (ContentAlignment)0x40;       
                    break;
                case 0x40:
                    label1.TextAlign = (ContentAlignment)0x10;
                    break;

                case 0x100:
                    label1.TextAlign = (ContentAlignment)0x200;
                    break;
                case 0x200:
                    label1.TextAlign = (ContentAlignment)0x400;
                    break;
                case 0x400:
                    label1.TextAlign = (ContentAlignment)0x100;
                    break;

            }


            if ((int)label1.TextAlign == 0x20)
                center_cb.Checked = true;
        }

        private void bt_down_Click(object sender, EventArgs e)
        {
            center_cb.Checked = false;

            switch ((int)label1.TextAlign)
            {
                case 1:
                    label1.TextAlign = (ContentAlignment)0x10;
                    break;
                case 0x10:
                    label1.TextAlign = (ContentAlignment)0x100;
                    break;
                case 0x100:
                    label1.TextAlign = (ContentAlignment)1;
                    break;

                case 2:
                    label1.TextAlign = (ContentAlignment)0x20;
                    break;
                case 0x20:
                    label1.TextAlign = (ContentAlignment)0x200;
                    break;
                case 0x200:
                    label1.TextAlign = (ContentAlignment)2;
                    break;


                case 4:
                    label1.TextAlign = (ContentAlignment)0x40;
                    break;
                case 0x40:
                    label1.TextAlign = (ContentAlignment)0x400;
                    break;
                case 0x400:
                    label1.TextAlign = (ContentAlignment)4;
                    break;

            }

            if ((int)label1.TextAlign == 0x20)
                center_cb.Checked = true;
        }

        private void bt_up_Click(object sender, EventArgs e)
        {
            center_cb.Checked = false;

            switch ((int)label1.TextAlign)
            {
                case 1:
                    label1.TextAlign = (ContentAlignment)0x100;
                    break;
                case 0x10:
                    label1.TextAlign = (ContentAlignment)1;
                    break;
                case 0x100:
                    label1.TextAlign = (ContentAlignment)0x10;
                    break;

                case 2:
                    label1.TextAlign = (ContentAlignment)0x200;
                    break;
                case 0x20:
                    label1.TextAlign = (ContentAlignment)2;
                    break;
                case 0x200:
                    label1.TextAlign = (ContentAlignment)0x20;
                    break;


                case 4:
                    label1.TextAlign = (ContentAlignment)0x400;
                    break;
                case 0x40:
                    label1.TextAlign = (ContentAlignment)4;
                    break;
                case 0x400:
                    label1.TextAlign = (ContentAlignment)0x40;
                    break;

            }

            if ((int)label1.TextAlign == 0x20)
                center_cb.Checked = true;
        }

        private void center_cb_CheckedChanged(object sender, EventArgs e)
        {
            if(center_cb.Checked)
            {
                label1.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
