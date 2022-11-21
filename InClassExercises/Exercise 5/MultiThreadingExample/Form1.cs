using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreadingExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void startBT_Click(object sender, EventArgs e)
        {
            Thread longThread = new Thread(LongRunningTask);
            longThread.Start();
        }

        public void LongRunningTask() 
        {
            for (int i = 0; i <= taskPB.Maximum; i++)
            {
                Thread.Sleep(100);
                if (taskPB.InvokeRequired)
                {
                    MethodInvoker invoker = new MethodInvoker(delegate ()
                    {
                        taskPB.Value = i;
                    });
                    startBT.Invoke(invoker);
                }
                else 
                {
                    taskPB.Value = i;
                }
            }
        }
    }
}
