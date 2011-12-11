using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Programming
{
    class Manipulations
    {
        public static void rotate90(System.Windows.Forms.PictureBox picBox)
        {
            if (picBox.Image != null)
            {
                picBox.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
            }
            else
            {
                MessageBox.Show("Bitte zuerst ein Bild öffnen");
            }
        }

        public static void rotate270(System.Windows.Forms.PictureBox picBox)
        {
            if (picBox.Image != null)
            {
                picBox.Image.RotateFlip(RotateFlipType.Rotate270FlipX);
            }
            else
            {
                MessageBox.Show("Bitte zuerst ein Bild öffnen");
            }
        }
    }
}
