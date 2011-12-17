using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bitmap = System.Drawing.Bitmap;

namespace Programming
{
    public abstract class Manipulate
    {

        protected Bitmap b;
        protected System.IntPtr Scan0;
        protected int stride;
        protected int height_start;
        protected int height_end;
       
        protected static readonly object _locker = new object();
        public ThreadHandler thInfo;


        public Manipulate(Bitmap b, System.IntPtr Scan0, int stride, int height_start, int height_end, ThreadHandler thInfo)
        {
            this.b = b;
            this.Scan0 = Scan0;
            this.stride = stride;
            this.height_start = height_start;
            this.height_end = height_end;
            this.thInfo = thInfo;
        }

        public abstract void perform();





    }
}
