using System;
using System.Threading;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class ThreadClassDemo : Form
    {
        public ThreadClassDemo()
        {
            InitializeComponent();
            Thread myThread = new Thread(work);
            myThread.IsBackground = true;
            myThread.Name = "T1";
            myThread.Start();
            Thread.Sleep(1000);
            Thread myThread2 = new Thread(work);
            myThread2.Name = "T2";
            myThread2.Start();
        }

        //Shared Resource
        int i;

        public void work()
        {
            i = 0;
            for ( ; i < 1000; i++)
            {
                Thread.Sleep(100);
                Console.Write(Thread.CurrentThread.Name+":"+i+",");
            }
        }
    }
}
