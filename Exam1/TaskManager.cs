using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1
{
    public enum SearchType
    {
        All,
        Name,
        Date,
        Priority,
    }

    [Serializable]
    public class TaskManager
    {
        public List<Task> Tasks { set; get; } = new List<Task>();

        public TaskManager()
        {

        }

        public void NewTask(Task task)
        {
            try
            {
                Tasks.Add(task);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public IEnumerable<Task> search(string input, SearchType type)
        {
            List<Task> result = new List<Task>();

            bool check = false;
            bool s = false;

            switch (type)
            {
                case SearchType.Name:
                    foreach(var item in Tasks)
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            if (item.TaskName.ToLower()[i] == input.ToLower()[i])
                            {
                                check = true;
                            }
                            else
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check)
                            result.Add(item);

                        /*
                        if (input == item.TaskName)
                        {
                            result.Add(item);
                        }
                        */
                    }
                    break;

                case SearchType.Date:
                    foreach (var item in Tasks)
                    {
                        if (input == $"{item.CompleteDate.Day}.{item.CompleteDate.Month}.{item.CompleteDate.Year}")
                        {
                            result.Add(item);
                        }
                    }
                    break;

                case SearchType.Priority:
                    foreach (var item in Tasks)
                    {
                        if (input == item.PriorityLevel.ToString())
                        {
                            result.Add(item);
                        }
                    }
                    break;

                case SearchType.All:
                    foreach (var item in Tasks)
                    {
                        if (input.Length > 0)
                        {
                            int Index;

                            for (Index = 0; Index < item.ToString().Length; Index++)
                            {
                                if (item.ToString().ToLower()[Index] == input.ToLower()[0])
                                {
                                    s = true;
                                    break;
                                }
                            }

                            if (Index >= item.ToString().Length) Index = 0;

                            for (int i = 0, j = Index; i < input.Length; i++, j++)
                            {
                                if (item.ToString().ToLower()[j] == input.ToLower()[i])
                                {
                                    check = true;
                                }
                                else
                                {
                                    check = false;
                                    break;
                                }
                            }

                            if (check)
                                result.Add(item);
                        }
                        else
                        {
                            return Tasks;
                        }
                    }
                    break;
                default:
                    return Tasks;
            }

            return result;
        }

        public Task GetTask(string input)
        {
            string[] arr = input.Split(' ');

            foreach(Task item in Tasks)
            {
                if(item.ToString() == input)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
