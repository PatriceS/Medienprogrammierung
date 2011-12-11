using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;
using PictureBox = System.Windows.Forms.PictureBox;

namespace Programming
{
    class ThreadHandler
    {
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

               () => refresh_()

                );

        }

        private void refresh_(  )
        {
            while( this.isAlive() )
            {
                System.Threading.Thread.Sleep(10);
            }
            pic.Refresh();
        }

    }
}
