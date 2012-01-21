using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace Programming
{
    class WebcamController
    {
        
        private static System.Windows.Forms.PictureBox pic;
        private static Form1 mainForm;
        private WebcamModel model;
        private WebcamOptions cam;
        private static bool capture_possible = false;

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
            Dictionary<int, string> devices   = new Dictionary<int,string>();
            Dictionary<int, string> solutions = new Dictionary<int, string>();
            devices = model.get_devices();
            
            // Aufnahmegeräte verfügbar
            if (devices.Count > 0)
            {
                solutions = model.get_solution_modes();
                if (solutions.Count > 0)
                {
                    cam = new WebcamOptions(devices, solutions);
                    cam.Show();
                    // Aufnahmemöglichkeit aktivieren
                    capture_possible = true;
                }
                else
                {
                    MessageBox.Show("Kein Eingabegerät vorhanden.");
                }
            }
            else
            {
                MessageBox.Show("Kein Eingabegerät vorhanden.");
            }

            
           
            
        }

        /*
         * Wenn ok button geklickt wurde, bild in das hauptformular übernehmen.
         */
        public void set_Webcam_picture(KeyValuePair<int, string> src)
        {
                // wenn aufnahme geräate verfügbar
            if (capture_possible)
            {
                Image image = model.get_Image();
                if (image != null)
                {
                    pic.Image = image;
                    mainForm.setPictureBoxSize(pic.Image);
                    pic.Refresh();
                    mainForm.enable_filter_menue();
                    mainForm.enable_edit_menue();
                    mainForm.enable_menue();
                    PixelState state = PixelState.getInstance();
                    state.set_pictureBox(pic);
                    state.reset();
                }
                else
                {
                    MessageBox.Show("Bitte auf Geräteinitialisierung warten.");
                }
                
            }
            else
            {
                MessageBox.Show("Kein Eingabegerät vorhanden.");
            }
            this.stop_capture();
            
        }

        public void stop_capture()
        {
            model.stop_capture();
        }

        public void show_Webcam_picture( System.Windows.Forms.PictureBox webcamPictureBox, WebcamOptions form)
        {
             if (capture_possible)
                model.show_picture(webcamPictureBox, form);
        }


        public void set_solution(KeyValuePair<int, string> selob)
        {
            if (capture_possible)
                model.set_solution(selob);
        }

        public void set_device(KeyValuePair<int, string> selob)
        {
            if (capture_possible)
                model.set_device(selob);
        }
    }
}
