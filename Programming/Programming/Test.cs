using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Programming
{
    class Test
    {
        public static void rotate(System.Windows.Forms.PictureBox picBox)
        {
            picBox.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            System.Windows.Forms.MessageBox.Show(picBox.ImageLocation);
            
        }
    }
}
