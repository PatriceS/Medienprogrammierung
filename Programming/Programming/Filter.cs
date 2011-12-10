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
        public static bool kernel( Bitmap b, FilterType.FilterNames filter )
        {
            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            switch (filter)
            {
                case FilterType.FilterNames.INVERT:
                    Filter.invert(b, stride, Scan0);
                    break;
            }
            

            b.UnlockBits(bmData);
            return true;
        }

        private static void chooseFilter( Bitmap b, FilterType.FilterNames filter )
        {

        }

        private static bool invert(Bitmap b, int stride, System.IntPtr Scan0)
        {

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                int nOffset = stride - b.Width * 3;
                int nWidth = b.Width * 3;
                for (int y = 0; y < b.Height; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        p[0] = (byte)(255 - p[0]);
                        ++p;
                    }
                    p += nOffset;
                }
            }
            return true;
        }

    }
}
