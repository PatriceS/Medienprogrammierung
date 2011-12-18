using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitmap = System.Drawing.Bitmap;


namespace Programming
{
    
    class SepiaFilter : Manipulate
    {
        private const int THRESHOLD = 127;

        public SepiaFilter(Bitmap b, System.IntPtr Scan0, int stride, int height_start, int height_end, ThreadHandler thInfo) 
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

                for (int y = height_start; y < height_end; ++y)
                {
                    for (int x = 0; x < this.bitmap_width; ++x)
                    {

                        int pixel_value = (b * p[0] + g * p[1] + r * p[2]) / 10;

                        p[0] = (byte)((10 * pixel_value) / 255);
                        p[1] = (byte)((120 * pixel_value) / 255);
                        p[2] = (byte)((220 * pixel_value) / 255);

                        p += 3;
                    }
                    p += nOffset;
                }
            }
           
        }


    }
}


