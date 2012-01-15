using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Programming
{
    class WebcamModel
    {
        //Anlegen eines Webcam-Objektes
        VideoCaptureDevice videoSource;

        public Dictionary<int, string> get_devices()
        {
            Dictionary<int, string> data = new Dictionary<int, string>();
            //Anlegen einer Liste mit allen Videoquellen. (Hier können neben der gewünschten Webcam
            //auch TV-Karten, etc. auftauchen)
            FilterInfoCollection videosources = new FilterInfoCollection(FilterCategory.VideoInputDevice);

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
    }
}
