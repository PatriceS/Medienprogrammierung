using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitmap = System.Drawing.Bitmap;
using System.Drawing;
using System.Drawing.Imaging;


namespace Programming
{

    class GrayscaleFilter : Manipulate
    {
       
        public GrayscaleFilter(Bitmap b, System.IntPtr Scan0, int stride, int height_start, int height_end, ThreadHandler thInfo)
            : base(b, Scan0, stride, height_start, height_end, thInfo)
        {

        }

        public override void perform()
        {
            
            this.Scan0 += (this.stride * this.height_start);
            
            
            byte red, green, blue;
            
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                
                for (int y = this.height_start; y < this.height_end; ++y)
                {
                    for (int x = 0; x < this.bitmap_width; ++x)
                    {
                        blue = p[0];
                        green = p[1];
                        red = p[2];

                        p[0] = p[1] = p[2] = (byte)(.299 * red
                            + .587 * green
                            + .114 * blue);

                        p += 3;
                    }
                    p += nOffset;
                }
            }
        }
    }
}
