using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;
using PictureBox = System.Windows.Forms.PictureBox;
using System.Windows.Forms;
using System.Diagnostics;



namespace Programming
{
    class ThreadHandler
    {
      
        private int threads;
        private ArrayList alive;
        private static readonly object _locker = new object();
        private static ThreadHandler _object = null;
        private PictureBox pic;
        private Stopwatch watch;
        
 
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

        public long getTime()
        {
            if (this.watch != null)
            {
                return this.watch.ElapsedMilliseconds;
            }

            return 0;
        }

        private void startTime()
        {
            this.watch = new Stopwatch();
            this.watch.Start();
        }

        public ThreadHandler( int threads)
        {
            this.threads = threads;
            alive = new ArrayList(threads);
            this.startTime();
        }

        public bool threadsAreAlive()
        {
            foreach (Thread thread in alive)
            {
                if (thread.IsAlive)
                {
                    return true;
                }
            }
            this.watch.Stop();
          
            return false;
        }

        public void refresh(PictureBox pic)
        {
            this.pic = pic;
            Thread t = new Thread(  () => this.try_refresh()  );
            t.Name = "bg_filter_thread";
            t.Start();

        }

        private void try_refresh()
        {

            while (this.threadsAreAlive())
            {
                // bg_filter_thread
               // Thread.Sleep(2);
            }

            this.pic.Invoke(new MethodInvoker(invoke_refresh));
                
        }

        private void invoke_refresh()
        {
            this.pic.Refresh();
        }

      

    }
}
