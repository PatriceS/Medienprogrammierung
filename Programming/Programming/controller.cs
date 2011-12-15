using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bitmap     = System.Drawing.Bitmap;
using PictureBox = System.Windows.Forms.PictureBox;
using System.Windows.Forms;
namespace Programming
{
    class Controller
    {
        static Controller con = null;
        private static System.Windows.Forms.PictureBox pic;
        private Form1 mainForm;
        private int threads = 2;


      
        public void invert( )
        {
            ThreadHandler thHandler = new ThreadHandler(threads);
            new Filter((Bitmap)pic.Image, FilterType.FilterNames.INVERT, thHandler).kernel();
            thHandler.refresh(pic);
        
            this.mainForm.setInfoBox(this.threads, thHandler.getTime());
            
           
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
    }
}
