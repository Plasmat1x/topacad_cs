using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1
{
    public enum Priority
    {
        low,
        mid,
        high,
    }

    [Serializable]
    public class Task
    {
        public string TaskName { get; set; }
        public string TaskDetail { get; set; }
        public DateTime CompleteDate { get; set; }
        public Priority PriorityLevel{ get; set; }

        public Task()
        {

        }

        public Task(string name, string detail, DateTime completeDate, Priority priority)
        {
            TaskName = name;
            TaskDetail = detail;
            CompleteDate = completeDate;
            PriorityLevel = priority;
        }

        public override string ToString()
        {
            return $"{TaskName} {CompleteDate.Day}.{CompleteDate.Month}.{CompleteDate.Year} {CompleteDate.Hour}:{CompleteDate.Minute} {PriorityLevel.ToString()}";
        }
    }
}
