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
        public int height_start;
        public int height_end;
        public int pos;
        private static readonly object _locker = new object();
        private ThreadInfo thInfo;




        public FilterThread(Bitmap b, System.IntPtr Scan0, int stride, int height_start, int height_end, int pos, ThreadInfo thInfo)
        {
            this.b = b;
            this.Scan0 = Scan0;
            this.stride = stride;
            this.height_start = height_start;
            this.height_end = height_end;
            this.pos = pos;
            this.thInfo = thInfo;
           

        }

        public void invert(  )
        {
            Bitmap b = this.b;
            int stride = this.stride;
            System.IntPtr Scan0 = this.Scan0;

            int height_start = this.height_start;
            int height_end = this.height_end;

            int height_step = height_end - height_start;

            int bytes = Math.Abs(stride) * height_step;
            byte[] rgbValues = new byte[bytes];
            // Copy the RGB values into the array.
            Scan0 += (stride * height_start);
            System.Runtime.InteropServices.Marshal.Copy(Scan0, rgbValues, 0, bytes);
            int position = this.pos;

            // Set every third value to 255. A 24bpp bitmap will look red.  
            for (int counter = 0; counter < rgbValues.Length; counter += 3)
            {
                rgbValues[counter] = (byte) ((255) - rgbValues[counter]);
                rgbValues[counter + 1] = (byte) ((255) - rgbValues[counter + 1]);
                rgbValues[counter + 2] = (byte)((255) - rgbValues[counter + 2]);
            }
               

            // Copy the RGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, Scan0, bytes);
            
            /*
            
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;
                p += this.pos;
                
               int nOffset = stride - b.Width * 3;
                
               int nWidth =  1;
               nWidth = b.Width * 3;
               byte red, green, blue;
                for (int y = height_start; y < height_end ; ++y)
                {
                    for (int x = 0; x < b.Width; ++x)
                    {
                        lock (_locker)
                        {
                          //  p[0] = (byte)(255 - p[0]);
                            blue = p[0];
                            green = p[1];
                            red = p[2];

                            p[0] = p[1] = p[2] = (byte)(.299 * red
                                + .587 * green
                                + .114 * blue);

                            p += 3;
                           
                           
                            int k = 4;
                          //  p+=3;
                            position++;
                        }
                       
                    }
                   p += nOffset;
                }
            }
             */ 
           // System.Windows.Forms.MessageBox.Show("sart: " + height_start + " end: " + height_end + " p: " + test);
            
            thInfo.finished();
           
        }


    }
}
