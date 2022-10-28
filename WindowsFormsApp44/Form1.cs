using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp44
{
    public partial class Form1 : Form
    {
        List<Execuse> exes = new List<Execuse>();
        public Form1()
        {
            InitializeComponent();

            dateTimePicker1.CustomFormat = "dd.MM.yyyy hh:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            Save_Button.Enabled = false;
            Read_Button.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        private void Directory_Button_Click(object sender, EventArgs e)
        {
            
            DialogResult choose = folderBrowserDialog1.ShowDialog();
            if(choose == DialogResult.OK)
            {
                openFileDialog1.InitialDirectory = folderBrowserDialog1.SelectedPath;
                saveFileDialog1.InitialDirectory = folderBrowserDialog1.SelectedPath;
                Save_Button.Enabled = true;
                Read_Button.Enabled = true;
                dateTimePicker1.Enabled = true;
            }
        }

        private void Read_Button_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                foreach (Execuse item in exes)
                {
                    if (item.ExecusePath == openFileDialog1.FileName)
                    {
                        Info_TextBox.Text = item.ReadFile(openFileDialog1.FileName);

                        item.LastUsed = File.GetLastAccessTime(openFileDialog1.FileName);
                    }
                }
                dateTimePicker1.Value = File.GetLastWriteTime(openFileDialog1.FileName);
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Description_TextBox.Text) == true || string.IsNullOrWhiteSpace(Results_TextBox.Text) == true)
            {
                MessageBox.Show("Поля: Причина и Результат нужно заполнить!");
                return;
            }
            DialogResult res =  saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                Execuse temp = new Execuse()
                {
                    Description = Description_TextBox.Text,
                    Results = Results_TextBox.Text,
                    ExecusePath = saveFileDialog1.FileName,
                    LastUsed = File.GetLastWriteTime(saveFileDialog1.FileName)
                };

                if(exes.Contains(temp) == false)
                {
                    exes.Add(temp);
                    exes[exes.Count - 1].SaveFile(saveFileDialog1.FileName, Info_TextBox.Text);
                }
                else
                {
                    foreach (Execuse item in exes)
                    {
                        if (item.ExecusePath == saveFileDialog1.FileName)
                        {
                            item.ExecusePath = saveFileDialog1.FileName;
                            item.Results = Results_TextBox.Text;
                            item.Description = Description_TextBox.Text;
                            item.LastUsed = File.GetLastWriteTime(saveFileDialog1.FileName);
                            item.SaveFile(saveFileDialog1.FileName, Info_TextBox.Text);
                        }
                    }
                } 
                dateTimePicker1.Value = DateTime.Now;
            }
        }
    }
}
