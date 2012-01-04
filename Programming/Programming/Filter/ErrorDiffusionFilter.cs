using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitmap = System.Drawing.Bitmap;


namespace Programming
{
    
    class ErrorDiffusionFilter : Manipulate
    {
        private const int THRESHOLD = 127;

        public ErrorDiffusionFilter(Bitmap b, System.IntPtr Scan0, int stride, int height_start, int height_end, ThreadHandler thInfo, int[] values) 
            : base( b, Scan0, stride,height_start, height_end, thInfo)
        {
          
        }

        public override void perform(  )
        {
            int error = 0;
            this.Scan0 += (this.stride * this.height_start);
            int r = 3; byte g = 6; byte b = 1;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (int y = height_start; y < height_end; ++y)
                {
                    for (int x = 0; x < this.bitmap_width; ++x)
                    {

                        int pixel_value = (b * p[0] + g * p[1] + r * p[2]) / 10;
                        // wenn schwelle größer/gleich 128 mach pixel weiß
                        if (error <= THRESHOLD)
                        {
                            error = pixel_value;
                            pixel_value = 0;
                        }
                        // ansonsten schwarz
                        else
                        {
                            error -= 255 + pixel_value;
                            pixel_value = 255;
                        }

                        p[0] = p[1] = p[2] = (byte)pixel_value;

                        p += 3;
                    }
                    p += nOffset;
                }
            }
           
        }


    }
}

