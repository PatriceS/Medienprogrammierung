using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitmap = System.Drawing.Bitmap;


namespace Programming
{
    
    class RGB_Mode : Manipulate
    {
        private ImageManipulatorType.Name color_type;

        public RGB_Mode(Bitmap b, System.IntPtr Scan0, int stride, int height_start, int height_end,
                        ThreadHandler thInfo, ImageManipulatorType.Name color_type) 
            : base( b, Scan0, stride,height_start, height_end, thInfo)
        {
            this.color_type = color_type;
        }

        public override void perform(  )
        {
            this.Scan0 += (this.stride * this.height_start);
            
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (int y = height_start; y < height_end; ++y)
                {
                    for (int x = 0; x < this.bitmap_width; ++x)
                    {
                          // BGR
                        switch (color_type)
                        {
                            case ImageManipulatorType.Name.RGB_RED:
                                p[0] = p[1] = 0;
                                 break;
                            case ImageManipulatorType.Name.RGB_GREEN:
                                 p[0] = p[2] = 0;
                                 break;
                            case ImageManipulatorType.Name.RGB_BLUE:
                                 p[1] = p[2] = 0;
                                 break;

                        }
                        p += 3;
                    }
                    p += nOffset;
                }
            }
           
        }


    }
}
