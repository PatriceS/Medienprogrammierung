using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitmap = System.Drawing.Bitmap;
using System.Drawing;

namespace Programming
{
    class Rotate
    {

        public static void rotate(Bitmap b, RotateFlipType type)
        {
            b.RotateFlip(type);
        }
    }
}
