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
        private ThreadInfo thInfo;

        static int test = 0;

        public Filter(Bitmap b, FilterType.FilterNames filter, ThreadInfo thInfo)
        {
            this.b = b;
            this.filter = filter;
            this.thInfo = thInfo;

        }

        public bool kernel()
        {
            
            BitmapData bmData = this.b.LockBits(new Rectangle(0, 0, this.b.Width, this.b.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            /*
            switch (filter)
            {
                case FilterType.FilterNames.INVERT:
                    FilterThread filterThread = new FilterThread(b, Scan0, stride, b.Height, 11);
                   // Filter.invert(b, stride, Scan0);
                    break;
            }
             */

            doFilter( Scan0, stride );

            this.b.UnlockBits(bmData);
            return true;
        }

        private void doFilter( System.IntPtr Scan0, int stride)
        {
            int height = this.b.Height;
            int steps = computeHeightSteps(height);



            for (int i = 0; i < thInfo.getThreads(); i++)
            {
                
                int height_start = computeHeightStart(steps, i);
                int height_end = computeHeightEnd(height_start, steps, height);
                int pos        = computePixelPosition(height_start, b.Width);
                FilterThread f = new FilterThread(this.b, Scan0, stride, height_start, height_end, pos, this.thInfo);
                
                new Thread( f.invert ).Start();
            }
            
                
        }

        private int computeHeightStart(int steps, int i)
        {
            int height_start = steps * i;
            if (height_start == 0)
            {
                return 0;
            }

            return height_start + 1;
        }

        private int computeHeightEnd(int height_start, int steps, int height)
        {
            if (height == 0)
            {
                return (height_start + steps );
            }
            if ((height_start + steps ) <= height)
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
            int step = (int)(height / thInfo.getThreads());
            return Math.Max( 1, step );
            
        }

        


        private static void chooseFilter( Bitmap b, FilterType.FilterNames filter )
        {

        }

        

    }
}
