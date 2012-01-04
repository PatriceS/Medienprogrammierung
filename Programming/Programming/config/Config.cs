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
            PIXEL_STATE_CONTAINER_AMOUNT = 5, THREADS = 2
        };

        public static readonly string SAVE_TEMP_PATH = @"C:\Users\Public\Pictures\Sample Pictures\temp.jpeg";

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
