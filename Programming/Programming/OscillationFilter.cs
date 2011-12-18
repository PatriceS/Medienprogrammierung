using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitmap = System.Drawing.Bitmap;


namespace Programming
{
    
    class OscillationFilter : Manipulate
    {
        public OscillationFilter(Bitmap b, System.IntPtr Scan0, int stride, int height_start, int height_end, ThreadHandler thInfo) 
            : base( b, Scan0, stride,height_start, height_end, thInfo)
        {
          
        }

        public override void perform(  )
        {
            this.Scan0 += (this.stride * this.height_start);
            
            double v = 0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (int y = height_start; y < height_end; ++y)
                {
                    for (int x = 0; x < this.bitmap_width; ++x)
                    {
                        v = y * 127 / (height_end - 1) * Math.Sin(Math.Exp(x * 0.01));
                        p[0] = (byte)(128 - v);
                        p += 3;
                    }
                    p += nOffset;
                }
            }
           
        }


    }
}
