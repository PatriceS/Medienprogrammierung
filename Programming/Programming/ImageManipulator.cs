using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing.Imaging;
using System.Drawing;
using Bitmap     = System.Drawing.Bitmap;
using System.Threading;


namespace Programming
{
    class ImageManipulator
    {
        private Bitmap bitmap;
        private ImageManipulatorType.Name filter;
        private ThreadHandler thHandler;
        private int[] values;      

        public ImageManipulator(Bitmap bitmap, ImageManipulatorType.Name filter, ThreadHandler thHandler, int[] values = null )
        {
            this.bitmap = bitmap;
            this.filter = filter;
            this.thHandler = thHandler;
            this.values = values;
        } 

        public bool perform()
        {
            
            BitmapData bmData = this.bitmap.LockBits(new Rectangle(0, 0, this.bitmap.Width, this.bitmap.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;

            int bytes = Math.Abs(bmData.Stride) * bmData.Height;

            System.IntPtr Scan0 = bmData.Scan0;


            perform( Scan0, stride );

            this.bitmap.UnlockBits(bmData);
            return true;
        }

        private void perform( System.IntPtr Scan0, int stride)
        {
            int height = this.bitmap.Height;
            int steps = computeHeightSteps(height);

            // anzahl der threads die mehr als die min elemente berechnen
            int sectorThreshold = height % thHandler.getThreads();

            try
            {
                for (int i = 0; i < thHandler.getThreads(); i++)
                {
                        // Zu bearbeitende Zeilen für jeden Thread berechnen
                    int startIndex = i * steps + Math.Min(i, sectorThreshold);
                    int stopIndex = startIndex + steps + (i < sectorThreshold ? 1 : 0);

                        // Das entsprechende Filterobjekt erzeugen und aufrufen
                    ManipulationFactory factory = new FilterFactory();
                    Manipulate manip = factory.create(this.filter, this.bitmap, Scan0, stride, startIndex, stopIndex, this.thHandler, this.values);
                    Thread thread = new Thread(manip.perform);

                    // Thread starten
                    thread.Start();
                    // Thread registrieren, um später abzufragen ob thread läuft oder nicht
                    this.thHandler.register(thread);

                }
            }
            catch (FilterUndefinedException e)
            {
                Console.WriteLine( e.Message);
            }
            
            
        }

        /**
         * Anzahl der zu bearbeitenden Zeilen pro Thread berechnen.
         */
        private int computeHeightSteps(int height)
        {
            int threads = thHandler.getThreads();
            int step = (int)(height / threads );
            return Math.Max( 1, step );
            
        }

    }
}
