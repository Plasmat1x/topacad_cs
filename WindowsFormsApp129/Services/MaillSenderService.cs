using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp129.Services
{
    public static class MaillSenderService
    {
        public static event EventHandler MaillSend;


        public static void Send(EventArgs e)
        {
            if (MaillSend != null)
            {
                MaillSend(null, e);
            }
        }
    }
}
