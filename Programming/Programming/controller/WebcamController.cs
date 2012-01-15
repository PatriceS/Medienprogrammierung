using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programming
{
    class WebcamController
    {
        private static WebcamController con = null;
        private static System.Windows.Forms.PictureBox pic;
        private Form1 mainForm;


        public static WebcamController getInstance()
        {
            if (con != null)
            {
                return con;
            }

            con = new WebcamController();
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
