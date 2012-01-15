using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Programming
{
    class NullImageObject : I_ImageObject
    {
        private System.Windows.Forms.PictureBox pic;

        public NullImageObject(System.Windows.Forms.PictureBox pic)
        {
            this.pic = pic;
        }
        public Image get_Image()
        {
            return pic.Image;
        }

        public ImageManipulatorType.Name get_ImageManipulatorType()
        {
            return ImageManipulatorType.Name.DEFAULT;
        }

        public Bitmap get_Bitmap()
        {
            return (Bitmap)pic.Image;
        }
    }
}
