using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitmap = System.Drawing.Bitmap;

namespace Programming
{
    public abstract class Manipulate
    {

        protected Bitmap        bitmap;
        protected System.IntPtr Scan0;
        protected int           stride;
        protected int           height_start;
        protected int           height_end;
        protected int           rgb_step        = 3;
        protected int           nOffset;
        protected int           bitmap_height;
        protected int           bitmap_width;
        protected int[]         values;

        protected static readonly object _locker = new object();
        protected ThreadHandler thInfo;


        public Manipulate(Bitmap b, System.IntPtr Scan0, int stride, int height_start, int height_end, ThreadHandler thInfo, int[] values = null)
        {
            this.bitmap = b;
            this.Scan0 = Scan0;
            this.stride = stride;
            this.height_start = height_start;
            this.height_end = height_end;
            this.thInfo = thInfo;
            this.values = values;
            lock (_locker)
            {
                this.bitmap_height = b.Height;
                this.bitmap_width = b.Width;
            }
            

            nOffset = stride - (bitmap_width * 3);

        }

        public abstract void perform();





    }
}
