using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitmap = System.Drawing.Bitmap;


namespace Programming
{
    
    class BlackWhiteFilter : Manipulate
    {
        public BlackWhiteFilter(Bitmap b, System.IntPtr Scan0, int stride, int height_start, int height_end, ThreadHandler thInfo) 
            : base( b, Scan0, stride,height_start, height_end, thInfo)
        {
          
        }

        public override void perform(  )
        {
            
            this.Scan0 += (this.stride * this.height_start);
            
            int r = 3; byte g = 6; byte b = 1;
            
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for ( int y = height_start; y < height_end; ++y)
                {
                    for ( int x = 0; x < this.bitmap_width; ++x)
                    {

                        int threshold = (r * p[0] + g * p[1] + b * p[2]) / 10;
                        // wenn schwelle größer/gleich 128 mach pixel weiß
                        if (threshold >= 128)
                        {
                            p[0] =  p[1] =  p[2] = (byte)255;
                        }
                        // ansonsten schwarz
                        else
                        {
                            p[0] = p[1] = p[2] = (byte)0;
                        }
                        p += 3;
                    }
                    p += nOffset;
                }
            }
           
        }


    }
}
