using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Programming
{
    class ThreadInfo
    {
        private int threads;
        public ArrayList alive;
        private static readonly object _locker = new object();
        private static ThreadInfo _object = null;

        public static ThreadInfo getInstance()
        {
            return _object;
        }

        public int getThreads()
        {
            return this.threads;
        }

        public ThreadInfo( int threads)
        {
            this.threads = threads;
            alive = new ArrayList(threads);
        }

        public bool isAlive()
        {
            if (this.alive.Count != this.alive.Capacity)
            {
                return false;
            }

            return true;
        }

        public void finished()
        {
            lock (_locker)
            {
                alive.Add("finished");
                
            }
        }





    }
}
