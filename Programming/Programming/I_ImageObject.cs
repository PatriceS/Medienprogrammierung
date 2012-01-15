using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Programming
{
    interface I_ImageObject
    {
         Image get_Image();
         ImageManipulatorType.Name get_ImageManipulatorType();
         Bitmap get_Bitmap();
    }
}
