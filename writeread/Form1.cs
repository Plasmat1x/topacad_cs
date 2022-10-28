using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace writeread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = @"C:\Users\Administrator\desktop";
            openFileDialog1.Filter = "All files|*.*|Text file|*.txt|Image|*.png";
            openFileDialog1.FileName = "";
            openFileDialog1.CheckFileExists = false;

            saveFileDialog1.InitialDirectory = @"C:\Users\Administrator\desktop";
            saveFileDialog1.Filter = "All files|*.*|Text file|*.txt|Image|*.png";
            saveFileDialog1.FileName = "Name.txt";
            saveFileDialog1.CheckFileExists = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
            }
        }

        private void appendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true);
                sw.WriteLine("\n\n" + richTextBox1.Text);
                sw.Close();
            }
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                fs.Close();
            }
        }

        private void open2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                /*
                FileStream fs = File.OpenRead(openFileDialog1.FileName);

                byte[] buf = (byte)File.OpenRead(openFileDialog1.FileName);
                fs.read(buf,0,buf.lenght);
                ...
                fs.Close();
                */
                richTextBox1.Text = "";
                foreach(string str in File.ReadAllLines(openFileDialog1.FileName))
                {
                    richTextBox1.Text += str + "\n==========================\n";
                }
            }
        }
    }
}
