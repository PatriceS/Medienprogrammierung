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
            List<String> devices = model.get_devices();
            WebcamOptions cam = new WebcamOptions(devices);
            cam.Show();
        }
    }
}
