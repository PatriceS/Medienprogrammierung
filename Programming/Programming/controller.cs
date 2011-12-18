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
        static Controller con = null;
        private static System.Windows.Forms.PictureBox pic;
        private Form1 mainForm;
        private const int threads = 2;


      
        public void invert( )
        {
            ThreadHandler thHandler = new ThreadHandler(threads);
            new ImageManipulator((Bitmap)pic.Image, ImageManipulatorType.Name.INVERT, thHandler).perform();
            this.show_picture(thHandler);
        }

        public void oscillate()
        {
            
            ThreadHandler thHandler = new ThreadHandler(threads);
            new ImageManipulator((Bitmap)pic.Image, ImageManipulatorType.Name.OSCILLATION, thHandler).perform();
            this.show_picture(thHandler);
        }

        public void grayscale()
        {
            ThreadHandler thHandler = new ThreadHandler(threads);
            new ImageManipulator((Bitmap)pic.Image, ImageManipulatorType.Name.GRAYSCALE, thHandler).perform();
            this.show_picture(thHandler);
        }

        public void blackNwhite()
        {
            ThreadHandler thHandler = new ThreadHandler(threads);
            new ImageManipulator((Bitmap)pic.Image, ImageManipulatorType.Name.BLACKWHITE, thHandler).perform();
            this.show_picture(thHandler);
        }

        public void errorDiffusion()
        {
            ThreadHandler thHandler = new ThreadHandler(threads);
            new ImageManipulator((Bitmap)pic.Image, ImageManipulatorType.Name.ERROR_DIFFUSION, thHandler).perform();
            this.show_picture(thHandler);
        }

        public void sepia()
        {
            ThreadHandler thHandler = new ThreadHandler(threads);
            new ImageManipulator((Bitmap)pic.Image, ImageManipulatorType.Name.SEPIA, thHandler).perform();
            this.show_picture(thHandler);
        }

        public void rotate(RotateFlipType type)
        {
            Rotate.rotate((Bitmap)pic.Image, type);
        }

        public static Controller getInstance()
        {
            if(con!=null)  return con;

            con = new Controller();
            return con;
        }

        internal void setPictureBox(System.Windows.Forms.PictureBox pictureBox1)
        {
            pic = pictureBox1;
        }

        public void filter(System.Windows.Forms.PictureBox name)
        {
            System.Windows.Forms.MessageBox.Show(name.ImageLocation);
        }

        public void setMainForm(Form1 form)
        {
            mainForm = form;
        }

        private void show_picture(ThreadHandler thHandler)
        {
            thHandler.refresh(pic);
            this.mainForm.setInfoBox(threads, thHandler.getTime());
        }

    }
}
