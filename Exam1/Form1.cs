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
using System.Xml.Serialization;

namespace Exam1
{
    public partial class Form1 : Form
    {
        NewTaskForm ntf;
        AuthorizationForm authform;
        TaskManager mgr;
        XmlSerializer serializer = new XmlSerializer(typeof(TaskManager));

        public User cuser;

        public Form1()
        {
            InitializeComponent();
            mgr = new TaskManager();

            search_select.SelectedIndex = 0;

            //prog_comment.Text += "\n" + "* Нету визуального выбора времени, только через ввод\n";
        }

        private void newtask_bt_Click(object sender, EventArgs e)
        {
            ntf = new NewTaskForm(mgr, this.Location);
            if(ntf.ShowDialog() == DialogResult.OK)
            {
                Update_list();
            }
        }

        private void Update_list()
        {
            tasklist.Items.Clear();
            foreach(Task item in mgr.Tasks)
            {
                tasklist.Items.Add(item);
            }
        }

        private void search_bt_Click(object sender, EventArgs e)
        {
            if(mgr.Tasks.Count > 0)
            {
                switch (search_select.SelectedItem)
                {
                    case "Name":
                        tasklist.Items.Clear();
                        foreach (var item in mgr.search(search_text.Text, SearchType.Name))
                        {
                            tasklist.Items.Add(item);
                        }
                        break;
                    case "Date":
                        tasklist.Items.Clear();
                        foreach (var item in mgr.search($"{datesearch_picker.Value.Day}.{datesearch_picker.Value.Month}.{datesearch_picker.Value.Year}", SearchType.Date))
                        {
                            tasklist.Items.Add(item);
                        }
                        break;
                    case "Priority":
                        tasklist.Items.Clear();
                        foreach (var item in mgr.search(search_text.Text, SearchType.Priority))
                        {
                            tasklist.Items.Add(item);
                        }
                        break;
                    case "All":
                        tasklist.Items.Clear();
                        foreach (var item in mgr.search(search_text.Text, SearchType.All))
                        {
                            tasklist.Items.Add(item);
                        }
                        break;
                    default:
                        break;
                }
            }       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            authform = new AuthorizationForm(this);
            if(authform.ShowDialog() == DialogResult.OK)
            {
                label1.Text = cuser.Username;

                try
                {
                    using (FileStream fs = new FileStream("tasklist.xml", FileMode.Open))
                    {
                        mgr = (TaskManager)serializer.Deserialize(fs);
                    }

                    Update_list();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream("tasklist.xml", FileMode.Create))
                {
                    serializer.Serialize(fs, mgr);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tasklist_DoubleClick(object sender, EventArgs e)
        {
            prog_comment.Text = mgr.GetTask(tasklist.SelectedItem.ToString()).TaskDetail;
        }

        private void search_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(search_select.SelectedItem.ToString() == "Date")
            {
                search_text.ReadOnly = true;
                datesearch_picker.Visible = true;
            }
            else
            {
                search_text.ReadOnly = false;
                datesearch_picker.Visible = false;
            }

            if(mgr.Tasks.Count > 0)
            {
                Update_list();
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("logout");
        }
    }
}
