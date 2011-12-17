﻿using System;
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
        private Bitmap b;
        private ImageManipulatorType.Name filter;
        private ThreadHandler thHandler;
        private Bitmap bitmap;
        private ImageManipulatorType.Name name;

        public ImageManipulator(Bitmap bitmap, ImageManipulatorType.Name filter, ThreadHandler thHandler)
        {
            this.bitmap = bitmap;
            this.filter = filter;
            this.thHandler = thHandler;

        }

        public ImageManipulator(Bitmap bitmap, ImageManipulatorType.Name filter)
        {
            this.bitmap = bitmap;
            this.filter = filter;
        }

        public bool perform()
        {
            
            BitmapData bmData = this.b.LockBits(new Rectangle(0, 0, this.b.Width, this.b.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;

            int bytes = Math.Abs(bmData.Stride) * bmData.Height;

            System.IntPtr Scan0 = bmData.Scan0;

            perform( Scan0, stride );

            this.b.UnlockBits(bmData);
            return true;
        }

        private void perform( System.IntPtr Scan0, int stride)
        {
            int height = this.b.Height;
            int steps = computeHeightSteps(height);

            // anzahl der threads die mehr als die min elemente berechnen
            int sectorThreshold = height % thHandler.getThreads();


            for (int i = 0; i < thHandler.getThreads(); i++)
            {
                int startIndex = i * steps + Math.Min(i, sectorThreshold);
                int stopIndex = startIndex + steps + (i < sectorThreshold ? 1 : 0);
                Thread thread = null;

                switch (this.filter)
                {
                    case ImageManipulatorType.Name.INVERT:
                        Invert f = new Invert(this.b, Scan0, stride, startIndex, stopIndex, this.thHandler);
                        thread = new Thread( f.perform );
                        break;
                }

                    // Thread starten
                thread.Start();
                    // Thread registrieren, um später abzufragen ob thread läuft oder nicht
                this.thHandler.register(thread);

            }
            
        }

        private int computeHeightStart(int steps, int i)
        {
            int height_start = steps * i;
            return Math.Max(0,height_start) ;
        }

        private int computeHeightEnd(int height_start, int steps, int height)
        {
            if (height == 0)
            {
                return (height_start + steps );
            }
            if ((height_start + steps ) < height)
            {
                return (height_start + steps );
            }

            return height;
        }

        private int computePixelPosition(int step, int width)
        {
            return (step * width);
        }

        private int computeHeightSteps(int height)
        {
            int threads = thHandler.getThreads();
            int step = (int)(height / threads );
            return Math.Max( 1, step );
            
        }

    }
}