using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Programming
{
    class NullImageObject : I_ImageObject
    {
        public Image get_Image()
        {
            return Controller.getInstance().getPictureBox().Image;
        }

        public ImageManipulatorType.Name get_ImageManipulatorType()
        {
            return ImageManipulatorType.Name.DEFAULT;
        }

        public Bitmap get_Bitmap()
        {
            return (Bitmap)Controller.getInstance().getPictureBox().Image;
        }
    }
}
