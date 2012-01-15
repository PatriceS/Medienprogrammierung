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

        public List<String> get_devices()
        {
            List<String> container = new List<string>();
            //Anlegen einer Liste mit allen Videoquellen. (Hier können neben der gewünschten Webcam
            //auch TV-Karten, etc. auftauchen)
            FilterInfoCollection videosources = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //Überprüfen, ob mindestens eine Aufnahmequelle vorhanden ist
            if (videosources != null)
            {
                for(int i = 0; i < videosources.Count; i++)
                {
                    container.Add(videosources[i].Name);
                }
            }

            return container;

        }
    }
}
