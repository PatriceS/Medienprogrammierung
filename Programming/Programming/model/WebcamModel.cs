using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using System.Windows.Forms;

namespace Programming
{
    class WebcamModel
    {
        //Anlegen eines Webcam-Objektes
        private static VideoCaptureDevice videoSource;
        private FilterInfoCollection videosources;
        private PictureBox pic;
        private KeyValuePair<int, string> solution;
        private KeyValuePair<int, string> device;
        
        public Dictionary<int, string> get_devices()
        {
            Dictionary<int, string> data = new Dictionary<int, string>();
            //Anlegen einer Liste mit allen Videoquellen. (Hier können neben der gewünschten Webcam
            //auch TV-Karten, etc. auftauchen)
            videosources = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //Überprüfen, ob mindestens eine Aufnahmequelle vorhanden ist
            if (videosources != null)
            {
                for(int i = 0; i < videosources.Count; i++)
                {
                    data.Add(i, videosources[i].Name);
                }
                
            }
            
            return data;
        }

        public Dictionary<int, string> get_solution_modes()
        {
            VideoCaptureDevice videoSource;
            FilterInfoCollection videosources;
            videosources = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            
            //Überprüfen, ob mindestens eine Aufnahmequelle vorhanden ist
            if (videosources == null)
            {
                Dictionary<int, string> solutions = new Dictionary<int, string>();
            //    solutions.Add(1, "");
                return solutions;
                
            }
            videoSource = new VideoCaptureDevice(videosources[this.get_device().Key].MonikerString);
            return get_solution_modes(videoSource);
        }

        private Dictionary<int, string> get_solution_modes(VideoCaptureDevice videoSource)
        {
            Dictionary<int, string> data = new Dictionary<int, string>();

            try
            {
                //Überprüfen ob die Aufnahmequelle eine Liste mit möglichen Aufnahme-
                //Auflösungen mitliefert.
                if (videoSource.VideoCapabilities.Length > 0)
                {
                    string solution = "0;0";
                    //Das Profil mit der höchsten Auflösung suchen
                    for (int i = 0; i < videoSource.VideoCapabilities.Length; i++)
                    {
                        if (videoSource.VideoCapabilities[i].FrameSize.Width > Convert.ToInt32(solution.Split(';')[0]))
                        {
                            solution = videoSource.VideoCapabilities[i].FrameSize.Width.ToString() + ";" + i.ToString();
                            data.Add(i, solution);
                        }
                    }
                }
            }
            catch { }
            return data;
        }

        public void show_picture( PictureBox pic, WebcamOptions form)
        {
            this.pic = pic;
            Dictionary<int, string> devices = this.get_devices();
            if (videosources.Count > this.device.Key && devices.Count > 1)
            {
                videoSource = new VideoCaptureDevice(videosources[this.get_device().Key].MonikerString);
                string solution = "0;0";
                solution = get_solution(videoSource).Value;

                //Dem Webcam Objekt ermittelte Auflösung übergeben
                videoSource.DesiredFrameSize = videoSource.VideoCapabilities[Convert.ToInt32(solution.Split(';')[1])].FrameSize;
                //pic.Size = new Size(videoSource.DesiredFrameSize.Width, videoSource.DesiredFrameSize.Height);
                //form.Size = new Size(videoSource.DesiredFrameSize.Width +100, videoSource.DesiredFrameSize.Height +100);
                pic.SizeMode = PictureBoxSizeMode.Zoom; 
            //    
                //NewFrame Eventhandler zuweisen anlegen.
                //(Dieser registriert jeden neuen Frame der Webcam)
                videoSource.NewFrame += new AForge.Video.NewFrameEventHandler(videoSource_NewFrame);
                //  videoSource.SnapshotFrame += new AForge.Video.NewFrameEventHandler(videoSource_NewFrame);
                //Das Aufnahmegerät aktivieren
                videoSource.Start();
            }
        }
            
              

        void videoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            this.pic.Image = (Image)eventArgs.Frame.Clone();
        }

        public Image get_Image()
        {
            if (this.pic != null)
            {
                return this.pic.Image;
            }
            return null;
        }

        /*Stopt die Aufnahme und gibt die Aufnahmequelle frei.*/
        public void stop_capture()
        {
            
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
        }

        internal void set_solution(KeyValuePair<int, string> selob)
        {
            this.solution = selob;
        }

        internal void set_device(KeyValuePair<int, string> selob)
        {
            this.device = selob;
        }

        private KeyValuePair<int, string> get_solution(VideoCaptureDevice videoSource)
        {
            String str = this.solution.Value;
            if (str != null)
            {
                return this.solution;
            }
            Dictionary<int, string> data = get_solution_modes( videoSource);
            return new KeyValuePair<int, string>(data.First().Key, data.First().Value);

            
        }

        private KeyValuePair<int, string> get_device()
        {
            String str = this.device.Value;
            if (str != null)
            {
                return this.device;
            }

            Dictionary<int, string> data = get_devices();
            return new KeyValuePair<int, string>(data.First().Key, data.First().Value);
        }
    }
}
