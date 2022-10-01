using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    class HR
    {
        IWorker[] workers;
        private int index;
        public HR()
        {
            workers = new IWorker[15];
        }

        public bool AddNewWorker(IWorker worker, double salary)
        {
            //workers[0] = worker;
            //index++;

            if (index > 14) return false;

            for (int i = 0; i < index; i++)
            {
                if(workers[i].SecondName == worker.SecondName)
                {
                    MessageBox.Show("Уже такой пользователь присутсвует");
                    return false;
                }
            }    

            if (worker is Programmer == true)
            {
                workers[index] = new Programmer(worker.Name, worker.SecondName, worker.Profession, salary);
            }
            else if (worker is Manager == true)
            {
                workers[index] = new Manager(worker.Name, worker.SecondName, worker.Profession, salary);
            }
            else if (worker is Assistent == true)
            {
                workers[index] = new Assistent(worker.Name, worker.SecondName, worker.Profession, salary);
            }

            index++;

            return true;
        }
        public string ShowAllWorkers()
        {
            string res = "";
            for (int i = 0; i < index; i++)
            {
                res += workers[i].Name + " " 
                    + workers[i].SecondName + " " 
                    + workers[i].Profession + " " 
                    + workers[i].Money 
                    + "\r\n";
            }

            return res;
        }

        public bool getPaid(int index)
        {
            /*
            if(workers[index] is Programmer)
            {
                //workers[index].Money += ((Programmer)workers[index]).Salary;
                workers[index].Money += (workers[index] as Programmer).Salary;
            }
            */

            workers[index].Money += workers[index].Salary;

            return true;
        }

        public bool getPenalty(int index)
        {
            switch(workers[index].Warning)
            {
                case 0:
                    workers[index].Warning++;
                    break;
                case 1:
                    workers[index].Warning++;
                    workers[index].Money -= workers[index].Money / 2; 
                    break;
                case 2:
                    workers[index].Warning++;
                    workers[index].Money -= workers[index].Money;
                    break;
                case 3:
                    MessageBox.Show("Уволен!!!");
                    //workers[index] = null;
                    //this.index--;
                    //TODO: delete user method
                    break;
            }

            return true;
        }

        public void FireWorker(int index)
        {
            workers[index] = null;

            for(int i = 0; i < this.index; i++)
            {
                if(workers[i] == null)
                {
                    IWorker tmp = workers[i];
                    //TODO swap empty cell with last element;
                }        
            }
        }
    }
}
