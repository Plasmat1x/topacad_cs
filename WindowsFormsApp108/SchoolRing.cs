using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp108
{
    public class SchoolRing
    {
        public event RingDel RingEvent;

        public void Ring(string subjectName)
        {
            if (RingEvent != null)
            {
                RingEvent(subjectName);
            }
           
        }
    }
}
