using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Programming
{
    interface I_ImageObject
    {
        public Image get_Image();
        public ImageManipulatorType.Name get_ImageManipulatorType();
        public Bitmap get_Bitmap();
    }
}
