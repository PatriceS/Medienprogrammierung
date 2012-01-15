using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bitmap     = System.Drawing.Bitmap;
using PictureBox = System.Windows.Forms.PictureBox;
using System.Windows.Forms;
using System.Drawing;

namespace Programming
{
    class Controller
    {
        private static Controller con = null;
        private static System.Windows.Forms.PictureBox pic;
        private Form1 mainForm;
        private static int threads = (int)Config.value.THREADS;
      
        public void filter_invert( )
        {
           // for (int i = 0; i < 19; i++)
           // {
                
                ImageManipulatorType.Name name = ImageManipulatorType.Name.INVERT;
                PixelState.getInstance().add(new ImageObject(pic.Image, name));
                ThreadHandler thHandler = new ThreadHandler(threads);
                new ImageManipulator((Bitmap)pic.Image, name, thHandler).perform();
                this.show_picture(thHandler);
               
           // }
        }

        public void filter_oscillate()
        {
            ImageManipulatorType.Name name = ImageManipulatorType.Name.INVERT;
            PixelState.getInstance().add(new ImageObject(pic.Image, name));
            ThreadHandler thHandler = new ThreadHandler(threads);
            new ImageManipulator((Bitmap)pic.Image, ImageManipulatorType.Name.OSCILLATION, thHandler).perform();
            this.show_picture(thHandler);
        }

        public void filter_grayscale()
        {
            ImageManipulatorType.Name name = ImageManipulatorType.Name.GRAYSCALE;
            PixelState.getInstance().add(new ImageObject(pic.Image, name));
            ThreadHandler thHandler = new ThreadHandler(threads);
            new ImageManipulator((Bitmap)pic.Image, ImageManipulatorType.Name.GRAYSCALE, thHandler).perform();
            this.show_picture(thHandler);
           
        }

        public void filter_blackNwhite()
        {
            ImageManipulatorType.Name name = ImageManipulatorType.Name.BLACKWHITE;
            PixelState.getInstance().add(new ImageObject(pic.Image, name));
            ThreadHandler thHandler = new ThreadHandler(threads);
            new ImageManipulator((Bitmap)pic.Image, ImageManipulatorType.Name.BLACKWHITE, thHandler).perform();
            this.show_picture(thHandler);
            
        }

        public void filter_errorDiffusion()
        {
            ImageManipulatorType.Name name = ImageManipulatorType.Name.ERROR_DIFFUSION;
            PixelState.getInstance().add(new ImageObject(pic.Image, name));
            ThreadHandler thHandler = new ThreadHandler(threads);
            new ImageManipulator((Bitmap)pic.Image, ImageManipulatorType.Name.ERROR_DIFFUSION, thHandler).perform();
            this.show_picture(thHandler);
        }

        public void filter_sepia()
        {
            ImageManipulatorType.Name name = ImageManipulatorType.Name.SEPIA;
            PixelState.getInstance().add(new ImageObject(pic.Image, name));
            ThreadHandler thHandler = new ThreadHandler(threads);
            new ImageManipulator((Bitmap)pic.Image, ImageManipulatorType.Name.SEPIA, thHandler).perform();
            this.show_picture(thHandler);
        }

        
        public void filter_RGB_Mode( ImageManipulatorType.Name color )
        {
                // letztes zwischengespeichertes Bild holen
            PixelState state = PixelState.getInstance();
            I_ImageObject imgObj = state.get_last();
                // Vergleichsliste mit RGB Klassen Typen erstellen
            List<ImageManipulatorType.Name> container = new List<ImageManipulatorType.Name>();
            container.Add(ImageManipulatorType.Name.RGB_BLUE);
            container.Add(ImageManipulatorType.Name.RGB_RED);
            container.Add(ImageManipulatorType.Name.RGB_GREEN);

                // wenn das letzte zwischengespeicherte Bild mit dieser funktion verändert wurde
            if (container.Contains(imgObj.get_ImageManipulatorType()))
            {
                    /* dann diese Veränderung rückgängig machen, da ansonsten das Bild schwarz wird.
                     * 2 aufeinander folgende Kanal filter => schwarzes bild, da jeweils 2 Farbkanäle
                     * pro Funktions aufruf auf 0 gesetzt werden. Nach 2 Funktionsaufrufen sind also
                     * alle Kanäle 0 was schwarzes Bild ergibt.
                     */ 
                this.undo();
            }
            
            state.add(new ImageObject(pic.Image, color));
            
            ThreadHandler thHandler = new ThreadHandler(threads);
            new ImageManipulator((Bitmap)pic.Image, color, thHandler).perform();
            this.show_picture(thHandler);
        }

        public void filter_rotate(RotateFlipType type)
        {
            ImageManipulatorType.Name name = ImageManipulatorType.Name.ROTATE;
            PixelState.getInstance().add(new ImageObject(pic.Image, name));
            RotateFilter.rotate((Bitmap)pic.Image, type);
            
        }

        
        public void filter_Sample_Board( int count )
        {
            PixelState state = PixelState.getInstance();
            state.add(new ImageObject(pic.Image, ImageManipulatorType.Name.SAMPLE_BOARD));
            ThreadHandler thHandler = new ThreadHandler(threads);
            int[] colors = new int[1] { count };
            new ImageManipulator((Bitmap)pic.Image, ImageManipulatorType.Name.SAMPLE_BOARD, thHandler, colors).perform();
            this.show_picture(thHandler);
        }

        public static Controller getInstance()
        {
            if (con != null)
            {
                return con;
            }

            con = new Controller();
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

        public void filter(System.Windows.Forms.PictureBox name)
        {
            System.Windows.Forms.MessageBox.Show(name.ImageLocation);
        }

        public void setMainForm(Form1 form)
        {
            mainForm = form;
        }

        //@todo
        public void undo( )
        {
            pic.Image = PixelState.getInstance().remove_last().get_Image();
        }

        public void reset_pixel_state()
        {
            PixelState.getInstance().reset();
        }

        private void show_picture(ThreadHandler thHandler)
        {
            thHandler.refresh(pic);
            this.mainForm.setInfoBox(threads, thHandler.getTime());
        }


    }
}
