using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp96
{
    internal class Human
    {
        private string name;
        private string lastName;

        public Human(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }

        public void Show()
        {
            MessageBox.Show($"Name: {name} Last Name: {lastName}");
        }

    }
}
