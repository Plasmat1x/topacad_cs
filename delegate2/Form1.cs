using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegate2
{
    public delegate T exDelegate<T>(T value1, T value2);
    public partial class Form1 : Form
    {
        exDelegate<int> deleg;

        public Form1()
        {
            InitializeComponent();

           
        }

        int sum(int x, int y)
        {
            return x + y;
        }

        double div(double x, double y)
        {
            return x / y;
        }

        float mul(float x, float y)
        {
            return x * y;
        }

        int sub(int x, int y)
        {
            return x - y;
        }
    }
}
