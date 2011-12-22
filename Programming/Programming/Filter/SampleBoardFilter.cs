using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitmap = System.Drawing.Bitmap;


namespace Programming
{
    
    class SampleBoardFilter : Manipulate
    {
        

        public SampleBoardFilter(Bitmap b, System.IntPtr Scan0, int stride, int height_start, int height_end, ThreadHandler thInfo, int[] values) 
            : base( b, Scan0, stride,height_start, height_end, thInfo, values)
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
                        int[,] lut = new int[,] { { 139, 45, 13 }, { 30, 90, 255 },
                                                  { 20, 20, 20 }, { 200, 200, 200 },
                                                  { 0, 128, 0 }, { 128, 0, 0 },
                                                  { 255, 255, 0 }, { 0, 0, 200 },
                                                  { 128, 128, 0 }, { 255, 204, 102 },

                                                  { 0, 255, 255 }, { 255, 255, 255 },
                                                 { 0, 128, 128 }, { 0, 255, 0 },
                                                    { 128, 128, 128 }, { 51, 177, 177 }
                        };
                        int minI = -1;
                        int minDist = Int32.MaxValue;

                        // schaue für alle 4 farben welche am ehesten zur farbe des pixels passt
                        for (int i = 0; i < this.values[0]; i++)
                        {
                            // BGR
                            int db = p[0] - lut[i,0];
                            int dg = p[1] - lut[i, 1];
                            int dr = p[2] - lut[i, 2];

                            // je kleiner der wert desto passender der farbwert
                            int dist = dr * dr + dg * dg + db * db;
                            // speichere den kleinsten farbwert
                            if (dist < minDist)
                            {
                                minDist = dist;
                                minI = i;
                            }
                        }

                        p[0] = (byte)lut[minI,0];
                        p[1] = (byte)lut[minI, 1];
                        p[2] = (byte)lut[minI, 2];

                        p += 3;
                    }
                    p += nOffset;
                }
            }
           
        }


    }
}

