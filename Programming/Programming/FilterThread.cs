﻿using System;
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
        public int height_start;
        public int height_end;
        public int pos;

        public FilterThread(Bitmap b, System.IntPtr Scan0, int stride, int height_start, int height_end, int pos)
        {
            this.b = b;
            this.Scan0 = Scan0;
            this.stride = stride;
            this.height_start = height_start;
            this.height_end = height_end;
            this.pos = pos;

        }

      

        public void invert(  )
        {
            Bitmap b = this.b;
            int stride = this.stride;
            System.IntPtr Scan0 = this.Scan0;

            int height_start = this.height_start;
            int height_end = this.height_end;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                p += this.pos;
                int nOffset = stride - b.Width * 3;
                int nWidth = b.Width * 3;
                for (int y = height_start; y < height_end; ++y)
                {
                    for (int x = 0; x < nWidth; ++x)
                    {
                        p[0] = (byte)(255 - p[0]);
                        ++p;
                    }
                    p += nOffset;
                }
            }
           
        }


    }
}
