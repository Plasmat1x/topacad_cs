using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Child
{
    interface IChild
    {
        string GoOnWalk();
    }

    abstract class Child : IChild
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public string GoOnWalk()
        {
            return "Go walk";
        }
    }

    class Student : Child
    {
        public int Score { get; set; }
        public string[] Lessons { get; set; }

        public string DoLessons()
        {
            string res = "";

            foreach (string s in Lessons)
            {
                res += s + "\n";
            }

            return res;
        }
    }

    class Sportsman : Child
    {
        public string SportName { get; set; }
        public int YearsInSport { get; set; }

        public string GoOnTraining()
        {
            return "Training";
        }
    }
}
