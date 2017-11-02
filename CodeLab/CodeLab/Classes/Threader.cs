using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLab.Classes
{
    class Threader
    {
        private readonly System.Threading.Thread _childThread;
        private bool _run = true;
        public Threader(Control control,string text)
        {
            var childref = WaitingText(control,text);
            _childThread = new System.Threading.Thread(childref);
        }

        public void Run()
        {
            _childThread.Start();
        }

        public void Stop()
        {
            _run = false;
        }
        private System.Threading.ThreadStart WaitingText(Control control,string text)
        {
            return () =>
            {
                while (_run)
                {
                    for (var i = 0; i < 4; i++)
                    {
                        System.Threading.Thread.Sleep(100);
                        control.Invoke((MethodInvoker) (() => control.Text += '.'));
                        Application.DoEvents();
                    }
                    control.Invoke((MethodInvoker) (() => control.Text = text));
                    Application.DoEvents();
                }
            };
        }
    }
}
