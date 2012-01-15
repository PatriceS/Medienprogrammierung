using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Programming
{
    public class ImageObject : I_ImageObject
    {
        private ImageManipulatorType.Name manipulator;
        private Image img;

        public ImageObject(Image img, ImageManipulatorType.Name manipulator)
        {
            // TODO: Complete member initialization
            this.img = img;
            this.manipulator = manipulator;
        }

        public Image get_Image()
        {
            return this.img;
        }

        public ImageManipulatorType.Name get_ImageManipulatorType()
        {
            return this.manipulator;
        }

        public Bitmap get_Bitmap()
        {
            return (Bitmap)this.img;
        }
    }
}
