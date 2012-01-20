using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programming
{
    class Config
    {
        public enum value : int
        {
                // Anzahl der zwischenzuspeichernden Bilder
            PIXEL_STATE_CONTAINER_AMOUNT = 5, 
                // Threads fuer filterbildberechnung
            THREADS                      = 2,
                // Max maße der picturebox
            MAX_PICTUREBOX_SIZE          = 800,
                // benutzen um offset von stride zu berechnen
            BITMAP_OFFSET_MULTIPLIKATOR  = 3,
                // max Anzahl der histogramm werte 
            HISTOGRAM_VALUE_COUNT        = 256
        };

        public enum histogram_canal : int
        {
            
            GREY = 0, RED = 1, GREEN = 2, BLUE = 3
        };

            // temp pfad zum zwischenspeichern der bilder für facebook upload
        public static readonly string SAVE_TEMP_PATH = @"C:\Users\Public\Pictures\Sample Pictures\temp.jpeg";

        /**
         * Array mit RGB Farbwerten für SampleBoadFilter.cs
         **/
        public static readonly int[,] lut = new int[,] { { 139, 45, 13 }, { 30, 90, 255 },
                                                  { 20, 20, 20 }, { 200, 200, 200 },
                                                  { 0, 128, 0 }, { 128, 0, 0 },
                                                  { 255, 255, 0 }, { 0, 0, 200 },
                                                  { 128, 128, 0 }, { 255, 204, 102 },

                                                  { 0, 255, 255 }, { 255, 255, 255 },
                                                  { 0, 128, 128 }, { 0, 255, 0 },
                                                  { 128, 128, 128 }, { 51, 177, 177 }
                        };
    }
}
