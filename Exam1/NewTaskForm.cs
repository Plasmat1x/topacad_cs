using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1
{
    public partial class NewTaskForm : Form
    {
        TaskManager mgr;
        Point startLocation;

        public NewTaskForm(TaskManager mgr, Point location)
        {
            this.startLocation = location;

            InitializeComponent();
            this.mgr = mgr;
            prioirty_select.SelectedIndex = 0;
            date_select.MinDate = DateTime.Now;
        }

        private void createtask_bt_Click(object sender, EventArgs e)
        {
            Priority priority = Priority.low;

            switch (prioirty_select.SelectedItem)
            {
                case "Low":
                    priority = Priority.low;
                    break;
                case "Mid":
                    priority = Priority.mid;
                    break;
                case "High":
                    priority = Priority.high;
                    break;
                default:
                    priority = Priority.low;
                    break;
            }
            mgr.NewTask(new Task(name_text.Text, detail_text.Text, date_select.Value, priority));

            this.DialogResult = DialogResult.OK;
        }

        private void NewTaskForm_Load(object sender, EventArgs e)
        {
            this.Location = startLocation;
        }
    }
}
