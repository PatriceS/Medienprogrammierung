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
        private static int threads = 1;
        public static bool kernel( Bitmap b, FilterType.FilterNames filter )
        {
            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
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

            doFilter( b, Scan0, stride, b.Height );

            b.UnlockBits(bmData);
            return true;
        }

        private static void doFilter(Bitmap b, System.IntPtr Scan0, int stride, int height)
        {
            int steps = computeHeightSteps(height);
            
           

            for (int i = 0; i < threads; i++)
            {
                int height_start = steps * i;
                int height_end = computeHeightEnd(height_start, steps, height);
                int pos          = computePixelPosition(height_start, b.Width);
                FilterThread f = new FilterThread(b, Scan0, stride, height_start,height_end, pos);
                
                new Thread( f.invert ).Start();
               
            }
                
        }

        private static int computeHeightEnd(int height_start, int steps, int height)
        {
            if ((height_start + steps) <= height)
            {
                return (height_start + steps);
            }

            return height;
        }

        private static int computePixelPosition(int step, int width)
        {
            return (step * width);
        }

        private static int computeHeightSteps(int height)
        {
            int step = (int)(height / threads);
            return Math.Max( 1, step );
            
        }

        


        private static void chooseFilter( Bitmap b, FilterType.FilterNames filter )
        {

        }

        

    }
}
