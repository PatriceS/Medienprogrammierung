using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bitmap     = System.Drawing.Bitmap;
using PictureBox = System.Windows.Forms.PictureBox;
using System.Windows.Forms;
using System.Drawing;

namespace Programming
{
    class StatistikController
    {
       
        private static System.Windows.Forms.PictureBox pic;
        private Form1 mainForm;
        

        public static StatistikController getInstance()
        {
            StatistikController con = new StatistikController();
            con.init();
            return con;
        }

        private void init()
        {
            try
            {
                pic = PixelState.getInstance().get_pictureBox();
            }
            catch { throw new EmptyPictureBoxException("Before initializing this controller, initialize PictureBox attribute of class PixelState first!"); }
        }

        public void setMainForm(Form1 form)
        {
            mainForm = form;
        }



    }
}

