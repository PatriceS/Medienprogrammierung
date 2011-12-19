using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Drawing.Imaging;

namespace Programming
{
    class PixelState
    {
        private static PixelState PState = null;
        private static List<ImageObject> container;
        private static int       amount;

        public static PixelState getInstance()
        {
            if (PState != null) return PState;

            PState = new PixelState();
            amount = (int)Config.value.PIXEL_STATE_CONTAINER_AMOUNT;
            container = new List<ImageObject>(amount);
            return PState;
        }

        /**
         * Fügt dem PixelState Container ein neues Bild hinzu. Ist der Container voll,
         * dann wird das älteste Element entfernt und das neue hinten angefügt.
         */
        public bool add( ImageObject imgObj  )
        {
            Bitmap img = (Bitmap)imgObj.get_Image();
            BitmapData bmData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            Image clone = (Bitmap)img.Clone();

            img.UnlockBits(bmData);

                // wenn maximale Grenze des containers noch nicht erreicht
            if (container.Count <= (int)Config.value.PIXEL_STATE_CONTAINER_AMOUNT)
            {

                    // Element hinten anfügen
                container.Add(new ImageObject(clone, imgObj.get_ImageManipulatorType()));
                return true;
            }
                // ältestes Element löschen und neues "oben reinpacken"
            container.RemoveAt(0);
            container.Add(new ImageObject(clone, imgObj.get_ImageManipulatorType()));
            return false;
        }

        /**
         * Liefert das letzte Element des PixelState containers zurück. Wenn container
         * leer, dann wird null zurückgegeben.
         *
         */
        public ImageObject get_last( )
        {
                // wenn min. 1 element im container
            if (container.Count != 0)
            {
                if (container[container.Count - 1] != null)
                {       //letztes element zurückgeben
                    return container[container.Count - 1];
                }
            }
                // wenn kein elment in der liste, null zurück geben
            return null;
        }

        /**
        * Liefert das letzte Element des PixelState containers zurück und entfernt dieses
         * aus dem container.Wenn container leer, dann wird null zurückgegeben.
        *
        */
        public ImageObject remove_last()
        {
            // wenn min. 1 element im container
            if (container.Count != 0)
            {
                if (container[container.Count - 1] != null)
                {       //letztes element zurückgeben
                    ImageObject imgObj = container[container.Count - 1];
                    //Bitmap img = (Bitmap)container[0];
                        // element aus container löschen
                    container.RemoveAt(container.Count - 1);
                    return imgObj;
                }
            }
            // wenn kein elment in der liste, null zurück geben
            return null;
        }

        /**
        * Leert den container Inhalt.
        * 
        *
        */
        public void reset()
        {
            // wenn min. 1 element im container
            if (container.Count != 0)
            {
                container = new List<ImageObject>(amount);
            }
            
        }




    }
}
