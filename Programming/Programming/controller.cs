using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programming
{
    class Controller
    {
        static Controller con = null;
        System.Windows.Forms.PictureBox pic;

      
        public void rotate(System.Windows.Forms.PictureBox pictureBox1)
        {
            Manipulations.rotate90(pictureBox1);
            pictureBox1.Refresh();
        }

        public static Controller getInstance()
        {
            if(con!=null)  return con;

            return new Controller();
        }

        internal void setPictureBox(System.Windows.Forms.PictureBox pictureBox1)
        {
            pic = pictureBox1;
        }

        public void filter(System.Windows.Forms.PictureBox name)
        {
            System.Windows.Forms.MessageBox.Show(name.ImageLocation);
        }
    }
}
