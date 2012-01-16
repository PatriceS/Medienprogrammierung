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
        private WebcamModel model;
        private WebcamOptions cam;

        public WebcamController()
        {
            model = new WebcamModel();
        }

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
            Dictionary<int, string> devices  = model.get_devices();
            Dictionary<int, string> solutions = model.get_solution_modes();
            cam = new WebcamOptions(devices, solutions);
            cam.Show();
        }

        public void set_Webcam_picture(KeyValuePair<int, string> src)
        {
            pic.Image = model.get_Image();
            mainForm.setPictureBoxSize(pic.Image);
            pic.Refresh();
            mainForm.enable_filter_menue();
            mainForm.enable_edit_menue();
            PixelState state = PixelState.getInstance();
            state.set_pictureBox(pic);
            state.reset();

        }

        public void stop_capture()
        {
            model.stop_capture();
        }

        public void show_Webcam_picture( System.Windows.Forms.PictureBox webcamPictureBox, WebcamOptions form)
        {
            model.show_picture(webcamPictureBox, form);
        }


        public void set_solution(KeyValuePair<int, string> selob)
        {
            model.set_solution(selob);
        }

        public void set_device(KeyValuePair<int, string> selob)
        {
            model.set_device(selob);
        }
    }
}
