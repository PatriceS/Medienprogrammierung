using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bitmap     = System.Drawing.Bitmap;
using PictureBox = System.Windows.Forms.PictureBox;
namespace Programming
{
    class Controller
    {
        static Controller con = null;
        private static System.Windows.Forms.PictureBox pic;
        private int threads = 4;

      
        public void invert( )
        {
            
            //Test.rotate(pictureBox1);
            ThreadInfo thInfo = new ThreadInfo(threads);
            Filter f = new Filter((Bitmap)pic.Image, FilterType.FilterNames.INVERT, thInfo);
            f.kernel();
            thInfo.isAlive();
            System.Threading.Thread.Sleep(300);
            pic.Refresh();
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
