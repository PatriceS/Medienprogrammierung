using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;

namespace Programming
{
    class PixelState
    {
        private static PixelState PState = null;
        private static ArrayList container;
        private static int       amount;

        public static PixelState getInstance()
        {
            if (PState != null) return PState;

            PState = new PixelState();
            amount = (int)Config.value.PIXEL_STATE_CONTAINER_AMOUNT;
            container = new ArrayList(amount);
            return PState;
        }

        /**
         * Fügt dem PixelState Container ein neues Bild hinzu. Ist der Container voll,
         * dann wird das älteste Element entfernt und das neue hinten angefügt.
         */
        public bool add( Bitmap img  )
        {
            if (container.Count <= (int)Config.value.PIXEL_STATE_CONTAINER_AMOUNT)
            {
                container.Add(img);
                return true;
            }

            container.RemoveAt(0);
            container.Add(img);
            return false;
        }

        /**
         * Liefert das letzte Element des PixelState containers zurück. Wenn container
         * leer, dann wird null zurückgegeben.
         *
         */
        public Bitmap get_last( )
        {
                // wenn min. 1 element im container
            if (container.Count != 0)
            {
                if (container[container.Count - 1] != null)
                {       //letztes element zurückgeben
                    return (Bitmap)container[container.Count - 1];
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
        public Bitmap remove_last( )
        {
            // wenn min. 1 element im container
            if (container.Count != 0)
            {
                if (container[container.Count - 1] != null)
                {       //letztes element zurückgeben
                    Bitmap img = (Bitmap)container[container.Count - 1];
                        // element aus container löschen
                    container.RemoveAt(container.Count - 1);
                    return img;
                }
            }
            // wenn kein elment in der liste, null zurück geben
            return null;
        }




    }
}
