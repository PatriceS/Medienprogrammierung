using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitmap = System.Drawing.Bitmap;

namespace Programming
{
    
    class FilterThread
    {
        public Bitmap b;
        public System.IntPtr Scan0;
        public int stride;
        public int height;
       
        public int pos;

        public FilterThread(Bitmap b, System.IntPtr Scan0, int stride, int height, int pos)
        {
            this.b = b;
            this.Scan0 = Scan0;
            this.stride = stride;
            this.height = height;
            
            this.pos = pos;

        }

      

        public bool invert(Bitmap b, int stride, System.IntPtr Scan0)
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
