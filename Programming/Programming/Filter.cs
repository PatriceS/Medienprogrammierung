using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing.Imaging;
using System.Drawing;
using Bitmap     = System.Drawing.Bitmap;


namespace Programming
{
    class Filter
    {
        private static int threads = 2;
        public static bool kernel( Bitmap b, FilterType.FilterNames filter )
        {
            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            switch (filter)
            {
                case FilterType.FilterNames.INVERT:
                    FilterThread filterThread = new FilterThread(b, Scan0, stride, b.Height, 11);
                   // Filter.invert(b, stride, Scan0);
                    break;
            }
            

            b.UnlockBits(bmData);
            return true;
        }

        private static void doFilter(Bitmap b, System.IntPtr Scan0, int stride, int height)
        {
            int step = computeHeightSteps(height);
            int pos = computePixelPosition(step, b.Width);
           

            for (int i = 0; i < threads; i++)
            {
                FilterThread f = new FilterThread(b, Scan0, stride, b.Height, 11);
            }
                
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
