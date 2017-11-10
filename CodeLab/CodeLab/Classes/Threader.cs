using System;
using System.Windows.Forms;

namespace CodeLab.Classes
{
    internal class Threader
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
            _childThread.Abort();
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
                        try
                        {
                            control.Invoke((MethodInvoker) (() => control.Text += '.'));
                        }
                        catch (Exception)
                        {
                            break;
                        }
                        Application.DoEvents();
                    }
                    try
                    {
                        control.Invoke((MethodInvoker) (() => control.Text = text));
                    }
                    catch (Exception) { break;}
                    Application.DoEvents();
                }
            };
        }
    }
}
