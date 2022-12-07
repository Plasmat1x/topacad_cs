using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp101
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            students.Add(new Student { Name = "Joe", Birthday = new DateTime(1995, 12, 10) });
            students.Add(new Student { Name = "Aoe", Birthday = new DateTime(1995, 12, 10) });
            students.Add(new Student { Name = "Tony", Birthday = new DateTime(1995, 12, 10) });
            students.Add(new Student { Name = "Casper", Birthday = new DateTime(1995, 12, 10) });
            
            students.ForEach(ShowInfo);



            //bool res = students.All(AllJoe);

            //MessageBox.Show(res.ToString());

            //List<Student> students1 = students.FindAll(AllObject);

            //MessageBox.Show(students.FirstOrDefault(AllJoe).Name);
            //foreach (Student item in students)
            //{
            //    students.Sort(item.Compare);
            //}

            students.Sort(CompareStudent);

            label1.Text += "===================";

            students.ForEach(ShowInfo);


            //IEnumerable<string> strings =  students.Select(SelectStudent);
            //label1.Text += "=====================";
            //foreach (string item in strings)
            //{
            //    label1.Text += item;
            //}

            

            //students1.ForEach(ShowInfo);
        }
        public int CompareStudent(Student student1, Student student2)
        {
            return student1.Name.CompareTo(student2.Name);
        }
        public bool AllObject(Student student)
        {
            if (student.Birthday == new DateTime(1995, 12, 10))
            {
                return true;
            }
            return false;
        }
        public bool AllJoe(Student student)
        {
            if (student.Name == "Casper")
            {
                return true;
            }
            return false;
        }
        public void ShowInfo(Student student)
        {
            label1.Text += student.Name + " " + student.Birthday + Environment.NewLine;
        }
        public string SelectStudent(Student student)
        {
            return student.Name + " " + student.Birthday + Environment.NewLine;
        }
    }

    public class Student : IComparer<Student>
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public int Compare(Student x, Student y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
