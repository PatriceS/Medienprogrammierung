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
        static VideoCaptureDevice videoSource;
        FilterInfoCollection videosources;
        Image img;
        PictureBox pic;
        static int ii = 0;

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

        public void show_picture(KeyValuePair<int, string> src, PictureBox pic)
        {
            
            Dictionary<int, string> devices = this.get_devices();
            if (videosources.Count > src.Key)
            {
                videoSource = new VideoCaptureDevice(videosources[src.Key].MonikerString);
                this.pic = pic;

                try
                {
                    //Überprüfen ob die Aufnahmequelle eine Liste mit möglichen Aufnahme-
                    //Auflösungen mitliefert.
                    if (videoSource.VideoCapabilities.Length > 0)
                    {
                        string highestSolution = "0;0";
                        //Das Profil mit der höchsten Auflösung suchen
                        for (int i = 0; i < videoSource.VideoCapabilities.Length; i++)
                        {
                            if (videoSource.VideoCapabilities[i].FrameSize.Width > Convert.ToInt32(highestSolution.Split(';')[0]))
                            {
                                highestSolution = videoSource.VideoCapabilities[i].FrameSize.Width.ToString() + ";" + i.ToString();
                                pic.Size = new Size(videoSource.VideoCapabilities[i].FrameSize.Width, videoSource.VideoCapabilities[i].FrameSize.Height);
                            }
                               
                        }
                        //Dem Webcam Objekt ermittelte Auflösung übergeben
                        videoSource.DesiredFrameSize = videoSource.VideoCapabilities[Convert.ToInt32(highestSolution.Split(';')[1])].FrameSize;
                    }
                }
                catch { }
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
            return this.pic.Image;
        }

        public void stop_capture()
        {
            
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
        }
    }
}
