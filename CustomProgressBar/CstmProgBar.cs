using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomProgressBar
{
    internal class CstmProgBar : ProgressBar
    {
        public CstmProgBar() : base()
        {

        }

        public void action()
        {
            if(this.Value >= 100)
            {
                MessageBox.Show("window");
            }
        }
    }
}
