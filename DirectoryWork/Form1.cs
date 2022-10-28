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

namespace DirectoryWork
{
    struct DirFil
    {
        public string Name { private set; get; }
        public DateTime Time { private set; get; }
        public string Dir { private set;  get; }

        public DirFil(string name, string dir, DateTime time)
        {
            Name = name;
            Dir = dir;
            Time = time;
        }
    }

    public partial class Form1 : Form
    {
        List<DirFil> list;

        public Form1()
        {
            InitializeComponent();
            list = new List<DirFil>();

            label1.Text = "";
            button1.Text = "Open folder";

            button2.Text = "Load file";
            button2.Enabled = false;

            button3.Text = "Save folder";
            button3.Enabled = false;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult choose = folderBrowserDialog1.ShowDialog();
            if (choose == DialogResult.OK)
            {
                openFileDialog1.InitialDirectory = folderBrowserDialog1.SelectedPath;
                saveFileDialog1.InitialDirectory = folderBrowserDialog1.SelectedPath;
                button2.Enabled = true;
                button3.Enabled = true;

                foreach(var item in Directory.GetFiles(folderBrowserDialog1.SelectedPath))
                {
                    comboBox1.Items.Add(item);
                    list.Add(new DirFil(item, folderBrowserDialog1.SelectedPath, File.GetLastWriteTime(item)));
                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //"Загрузка файла из папки", куда?
            DialogResult choose = openFileDialog1.ShowDialog();
            if (choose == DialogResult.OK)
            {
                StreamReader stream = new StreamReader(openFileDialog1.FileName);
                label1.Text += "\n\n" + stream.ReadToEnd();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //"Сохранение программы в текстовый файл" ?
            
            //Создание каталогов
            DialogResult choose = saveFileDialog1.ShowDialog();
            if (choose == DialogResult.OK)
            {
                Directory.CreateDirectory(saveFileDialog1.FileName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Уменьшить названия файла с полного названия до сокращенного
            label1.Text = list.ElementAt(comboBox1.SelectedIndex).Name + Environment.NewLine
                + list.ElementAt(comboBox1.SelectedIndex).Time.ToString();
        }
    }
}

/*
 P.S.

ДЗ
Создать программу для создания папок на компьютере.(класс Directory)
Создать два диалоговых окна(.showDialog) на загрузку файла из папки
И сохранения программы в текстовый файл.
Также, добавить список всех файлов в выбранной папке в comboBoxи
При выборе файла вывести на экран дату изменения.

Роман поработйте над составлением задачи, ибо текущая задача говорит о создании папок, а по факту работа с файлами.
 */