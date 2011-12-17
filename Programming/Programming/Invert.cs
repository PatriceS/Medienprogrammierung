using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitmap = System.Drawing.Bitmap;


namespace Programming
{
    
    class Invert : Manipulate
    {
        public Invert(Bitmap b, System.IntPtr Scan0, int stride, int height_start, int height_end, ThreadHandler thInfo) 
            : base( b, Scan0, stride,height_start, height_end, thInfo)
        {
          
        }

        public override void perform(  )
        {
           
            int stride = this.stride;
            System.IntPtr Scan0 = this.Scan0;

            int height_start = this.height_start;
            int height_end   = this.height_end;

            int height_step = height_end - height_start;

            int bytes = Math.Abs(stride) * height_step;
            byte[] rgbValues = new byte[bytes];
         //    Copy the RGB values into the array.
            Scan0 += (stride * height_start);
            System.Runtime.InteropServices.Marshal.Copy(Scan0, rgbValues, 0, bytes);


            
            // Set every third value to 255. A 24bpp bitmap will look red.  
            for (int counter = 0; counter + 4 < rgbValues.Length; counter += 3)
            {
                rgbValues[counter] = (byte)((255) - rgbValues[counter]);
                rgbValues[counter + (1)] = (byte)((255) - rgbValues[counter + 1]);
                rgbValues[counter + (2)] = (byte)((255) - rgbValues[counter + 2]);

                //   rgbValues[counter] = (byte)0;
            //    rgbValues[counter + (1)] = (byte)0;
            //    rgbValues[counter + (2)] = (byte)0;
                   
             
            }
               

            // Copy the RGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, Scan0, bytes);
            
           
           // System.Windows.Forms.MessageBox.Show("sart: " + height_start + " end: " + height_end + " p: " + test);
            
           
           
        }


    }
}
