﻿using System;
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
        System.Windows.Forms.PictureBox pic;

        public Controller()
        {
            
        }

        public void oeffneBild() {
                
        }

        public void invert(PictureBox pictureBox1)
        {
            
            //Test.rotate(pictureBox1);
            Filter.kernel( (Bitmap)pictureBox1.Image, FilterType.FilterNames.INVERT  );
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
