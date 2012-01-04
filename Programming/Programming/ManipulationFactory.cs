using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Programming
{
    abstract class ManipulationFactory
    {
        /*
        public Manipulate perform(ImageManipulatorType.Name name, Bitmap bitmap, System.IntPtr Scan0, int stride, int height_start, int height_end, ThreadHandler thHandler, int[] values)
        {

            return create(name, bitmap, Scan0, stride, height_start, height_end, thHandler, values);
        }
         */ 

        public abstract Manipulate create(ImageManipulatorType.Name name, Bitmap bitmap, System.IntPtr Scan0, int stride, int height_start, int height_end, ThreadHandler thHandler, int[] values);
        
    }
}
