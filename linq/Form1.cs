using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<Group> groups = new List<Group>();

        public Form1()
        {
            InitializeComponent();

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            //IEnumerable<int> resarr = from number in arr  
            //                          //where number % 2 == 0
            //                          orderby number descending
            //                          select number;

            //string resstr = "";

            //foreach (var item in resarr)
            //{
            //    resstr += item;
            //}

            //MessageBox.Show(resstr);

            students.Add(new Student() {GroupID = 1, Name = "f", LastName = "fd" });
            students.Add(new Student() {GroupID = 1, Name = "a", LastName = "sa" });
            students.Add(new Student() {GroupID = 1, Name = "s", LastName = "aw" });
            students.Add(new Student() {GroupID = 2, Name = "g", LastName = "bf" });
            students.Add(new Student() {GroupID = 2, Name = "f", LastName = "df" });

            groups.Add(new Group() { ID = 1, GroupName = "1" });
            groups.Add(new Group() { ID = 2, GroupName = "2" });

            IEnumerable<IGrouping<int, Student>> res = from s in students
                                                   group s by s.GroupID into value
                                                   where value.Key > 1
                                                   select value;
            string Resault = "";
            foreach (var item in res)
            {
                Resault += item.Key + "\n";
                foreach( var s in item)
                {
                    Resault += "\t" + s.Name + " " + s.LastName + "\n";
                }
                Resault += Environment.NewLine;
            }

            MessageBox.Show(Resault);
        }
    }

    public class Student
    { 
        public int GroupID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }

    public class Group
    {
        public int ID { get; set; }
        public string GroupName { get; set; }
    }
}
