using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitmap = System.Drawing.Bitmap;


namespace Programming
{
    
    class InvertFilter : Manipulate
    {
        public InvertFilter(Bitmap b, System.IntPtr Scan0, int stride, int height_start, int height_end, ThreadHandler thInfo) 
            : base( b, Scan0, stride,height_start, height_end, thInfo)
        {
          
        }

        public override void perform(  )
        {
           
            this.Scan0 += (this.stride * this.height_start);
           
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (int y = this.height_start; y < this.height_end; ++y)
                {
                    for (int x = 0; x < this.bitmap_width; ++x)
                    {
                        p[0] = (byte)(0 );
                        p[1] = (byte)(0);
                        p[2] = (byte)(255 - p[2]);

                        p += 3;
                    }
                    p += nOffset;
                }
            }
           
        }


    }
}
