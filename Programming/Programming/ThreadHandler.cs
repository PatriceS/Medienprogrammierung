using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;
using PictureBox = System.Windows.Forms.PictureBox;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;



namespace Programming
{
    public class ThreadHandler
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

        /**
         * Funktion zum speichern von veränderten Bildern (Zwischenschritten)
         * 
         */
        public void save_PixelState( Bitmap bitmap )
        {
            Thread t = new Thread(() => this.try_save_PixelState(bitmap));
            t.Name = "bg_PixelState_thread";
            t.Start();
        }

        private void try_refresh()
        {

            while (this.threadsAreAlive())
            {
                // bg_filter_thread
                Thread.Sleep(2);
            }

            this.pic.Invoke(new MethodInvoker(invoke_refresh));
                
        }


        private void try_save_PixelState(Bitmap bitmap)
        {
                // solange noch nicht alle Threads beendet wurden -> warten
            while (this.threadsAreAlive())
            {
                // bg_filter_thread
                Thread.Sleep(2);
            }
                // PixelState Objekt besorgen
            PixelState state = PixelState.getInstance();
                // ab hier Thread sicher speichern
            lock (_locker)
            {
                state.add(bitmap);
            }
        }

        private void invoke_refresh()
        {
            this.pic.Refresh();
        }

      

    }
}
