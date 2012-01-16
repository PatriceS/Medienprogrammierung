using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programming
{
    class WebcamController
    {
        
        private static System.Windows.Forms.PictureBox pic;
        private static Form1 mainForm;


        public static WebcamController getInstance()
        {
            WebcamController con = new WebcamController();
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

        public void openWebcamWindow()
        {
            
            WebcamModel model = new WebcamModel();
            Dictionary<int, string> devices = model.get_devices();
            WebcamOptions cam = new WebcamOptions(devices);
            cam.Show();
        }

        public void set_Webcam_picture(KeyValuePair<int, string> src)
        {
            WebcamModel model = new WebcamModel();
            model.get_picture(src, pic);
            pic.Image = model.get_Image();
            pic.Refresh();
        }
    }
}
