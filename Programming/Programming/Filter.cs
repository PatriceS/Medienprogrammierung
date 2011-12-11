using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing.Imaging;
using System.Drawing;
using Bitmap     = System.Drawing.Bitmap;
using System.Threading;


namespace Programming
{
    class Filter
    {
        private Bitmap b;
        private FilterType.FilterNames filter;
        private ThreadHandler thHandler;

       

        public Filter(Bitmap b, FilterType.FilterNames filter, ThreadHandler thHandler)
        {
            this.b = b;
            this.filter = filter;
            this.thHandler = thHandler;

        }

        public bool kernel()
        {
            
            BitmapData bmData = this.b.LockBits(new Rectangle(0, 0, this.b.Width, this.b.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;

            int bytes = Math.Abs(bmData.Stride) * bmData.Height;

            System.IntPtr Scan0 = bmData.Scan0;

            doFilter( Scan0, stride );

            this.b.UnlockBits(bmData);
            return true;
        }

        private void doFilter( System.IntPtr Scan0, int stride)
        {
            int height = this.b.Height;
            int steps = computeHeightSteps(height);

            // anzahl der threads die mehr als die min elemente berechnen
            int sectorThreshold = height % thHandler.getThreads();


            for (int i = 0; i < thHandler.getThreads(); i++)
            {
                int startIndex = i * steps + Math.Min(i, sectorThreshold);
                int stopIndex = startIndex + steps + (i < sectorThreshold ? 1 : 0);


                switch (this.filter)
                {
                    case FilterType.FilterNames.INVERT:
                        FilterThread f = new FilterThread(this.b, Scan0, stride, startIndex, stopIndex, this.thHandler);
                        Thread thread = new Thread( f.invert );
                        thread.Start();
                        this.thHandler.register(thread);
                        break;
                }

            }
            
                
        }

        private int computeHeightStart(int steps, int i)
        {
            int height_start = steps * i;
            

            return Math.Max(0,height_start) ;
        }

        private int computeHeightEnd(int height_start, int steps, int height)
        {
            if (height == 0)
            {
                return (height_start + steps );
            }
            if ((height_start + steps ) < height)
            {
                return (height_start + steps );
            }

            return height;
        }

        private int computePixelPosition(int step, int width)
        {
            return (step * width);
        }

        private int computeHeightSteps(int height)
        {
            int threads = thHandler.getThreads();
            int step = (int)(height / threads );
            return Math.Max( 1, step );
            
        }

        


        private static void chooseFilter( Bitmap b, FilterType.FilterNames filter )
        {

        }

        

    }
}
