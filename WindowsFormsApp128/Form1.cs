using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp128
{
    public partial class Form1 : Form
    {
        List<Student> student = new List<Student>();
        List<Group> groups = new List<Group>();
        
        public Form1()
        {
            InitializeComponent();
            #region
            //int[] array = { 4, 2, 3, 1, 5, 6, 7 };
            ////array.First(i => i == 2);
            //string res = "";
            //IEnumerable<int> arr = from number in array;

            //foreach (int item in arr)
            //{
            //    res += item + Environment.NewLine;
            //}

            //array[0] = 69; 
            //foreach (int item in arr)
            //{
            //    res += item + Environment.NewLine;
            //}
            #endregion
            student.Add(new Student { GroupId = 1, Name = "First", LastName = "FirstLast" });
            student.Add(new Student { GroupId = 1, Name = "Second", LastName = "SecondtLast" });
            student.Add(new Student { GroupId = 2, Name = "Third", LastName = "FirstLast" });
            student.Add(new Student { GroupId = 1, Name = "Fourth", LastName = "FirstLast" });
            student.Add(new Student { GroupId = 2, Name = "Five", LastName = "FirstLast" });

            groups.Add(new Group { GroupName = "1", Id = 1 });
            groups.Add(new Group { GroupName = "2", Id = 2 });
            var x = 10;
            var y = "sdas";
            var u = new Student();


            string text = "";
            //IEnumerable<IGrouping<int, Student>> res = from s in student
            //                                           group s by s.GroupId into value
            //                                           where value.Count() > 2
            //                                           select value;

            //foreach (IGrouping<int, Student> item in res)
            //{
            //    text += "Студенты группы " + item.Key + ":";
            //    foreach (Student s in item)
            //    {
            //        text += s.Name + " " + s.LastName + ", ";
            //    }
            //    text += Environment.NewLine;
            //}
            IEnumerable<Student> res = student.Where(s => s.GroupId == 1).Select(p => p);

            IEnumerable<Student> result  = student.OrderByDescending(s => s.Name);

            //student.ForEach(s => s.Name += "Test 1");
            //student.Where(s => s.GroupId == 2).ToList().ForEach(s => s.Name += " test1");
            //List<Student> temp =  student.Where(s => s.GroupId == 2).Select(s => s).ToList();
            //temp.ForEach(s => s.Name += " test 1");
            //Student x = student.FirstOrDefault(s => s.GroupId == 3);
            //Student a = student.SingleOrDefault(s => s.GroupId == 3);

            //if(student.Any(s => s == null) == true)
            //{
            //    MessageBox.Show("true");
            //}
            //else
            //{
            //    MessageBox.Show("false");
            //}
            //IEnumerable<Student> temp = student.FindAll(s => s.GroupId == 2);

            //if(x != null) MessageBox.Show(x.Name + " " + x.LastName);
            //foreach (Student item in temp)
            //{
            //    text += item.Name + " " + item.LastName + Environment.NewLine;
            //}
            //MessageBox.Show(text);
            //string temp = "hello";
            //temp.Out();

            var temp = new Student();

            var example = 10;
            foreach (var item in student)
            {

            }

            var newStudent = new { Id = 1, Name = "String" };
            
        }
        

        public class Student
        {
            public int GroupId { get; set; }
            public string Name { get; set; }    
            public string LastName { get; set; }
        }
        public class Group 
        {
            public int Id { get; set; }
            public string GroupName { get; set; }
        
        
        }

    }

    public static class A
    {
        public static void Out(this string value)
        {
            MessageBox.Show(value);
        }
    }
}
