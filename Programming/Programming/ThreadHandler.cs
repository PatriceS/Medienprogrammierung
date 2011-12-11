using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;
using PictureBox = System.Windows.Forms.PictureBox;
using System.Windows.Forms;



namespace Programming
{
    class ThreadHandler
    {
        delegate void StringParameterDelegate(string value);
        private int threads;
        private ArrayList alive;
        private static readonly object _locker = new object();
        private static ThreadHandler _object = null;
        private PictureBox pic;

        public static ThreadHandler getInstance()
        {
            return _object;
        }

        public int getThreads()
        {
            return this.threads;
        }

        public void register(Thread thread)
        {
            lock (_locker)
            {
                alive.Add(thread);
            }
        }

        public ThreadHandler( int threads)
        {
            this.threads = threads;
            alive = new ArrayList(threads);
        }

        public bool isAlive()
        {
            foreach (Thread thread in alive)
            {
                if (thread.IsAlive)
                {
                    return true;
                }
            }

            return false;
        }

        public void refresh(PictureBox pic)
        {
            this.pic = pic;
            Thread t = new Thread(

               () => this.pic.Invoke(new MethodInvoker(invoke_refresh))

                );
            t.Start();

        }

        private void invoke_refresh()
        {
            
            while( this.isAlive() )
            {
                System.Threading.Thread.Sleep(5);
            }

            lock (_locker)
            {
                this.pic.Refresh();
            }
            
        }

      

    }
}
