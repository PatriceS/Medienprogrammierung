using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitmap = System.Drawing.Bitmap;

namespace Programming
{
    
    class FilterThread
    {
        public Bitmap b { get; set; }

        public System.IntPtr Scan0 { get; set; }

        public int Stride { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public int pos { get; set; }


    }
}
