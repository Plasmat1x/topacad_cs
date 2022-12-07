using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    /*
    delegate void notifyHandler(string msg);
    public partial class Form1 : Form
    {
        Notifyer notify;
        C1 c1;
        C2 c2;
        C3 c3;
        C4 c4;
        public Form1()
        {
            InitializeComponent();

            notify = new Notifyer();
            c1 = new C1();    
            c2 = new C2();    
            c3 = new C3();    
            c4 = new C4();

            notify.handler += c1.getMsg;
            notify.handler += c2.getMsg;
            notify.handler += c3.getMsg;
            notify.handler += c4.getMsg;

            notify.send("Hello newbie");
        }
    }

    class Notifyer
    {
        public event notifyHandler handler;

        public void send(string msg)
        {
            if(handler != null)
                handler(msg);
        }
    }

    class C1
    {
        public void getMsg(string msg)
        {
            MessageBox.Show(msg);
        }
    }

    class C2
    {
        public void getMsg(string msg)
        {
            MessageBox.Show(msg);
        }
    }
    class C3
    {
        public void getMsg(string msg)
        {
            MessageBox.Show(msg);
        }
    }
    class C4
    {
        public void getMsg(string msg)
        {
            MessageBox.Show(msg);
        }
    }
    */
    /*
    public partial class Form1 : Form
    {
        MyClass obj;
        MyClass2 obj2;
        public Form1()
        {
            InitializeComponent();

            obj = new MyClass();
            obj2 = new MyClass2();

            obj.Event += check;

            obj.Start(obj2);
        }

        //private void check(object sender, string e)
        private void check(object sender, EventArgs e)
        {
            //MyClass2 res = e as MyClass2;

            if(e is MyClass2 res)
            {
                res.show();
            }
            //else if (e is MyClassX res) { ... }
            
        }
    }

    class MyClass
    {
        //public event EventHandler<string> Event;
        public event EventHandler Event;

        public void Start(MyClass2 obj)
        {
            //Event(this, obj.ToString());
            Event(this, obj);
        }

    }

    class MyClass2 : EventArgs
    {
        public void show()
        {

        }
    }
    */
}
