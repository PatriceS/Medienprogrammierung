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
    class StatistikController
    {
       
        private static System.Windows.Forms.PictureBox pic;
        private static PictureBox  statistic_pic;
        private static Form1 mainForm;
        private Programming.Statistik statistikForm;
        private StatistikModel model;

        public static StatistikController getInstance()
        {
            StatistikController con = new StatistikController();
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

        public void setMainForm(Form1 form)
        {
            mainForm = form;
        }

        public void setStatisticForm(Statistik form)
        {
            statistikForm = form;
        }

        internal void set_statistik_form(Statistik statistik)
        {
            statistikForm = statistik;
        }

        public void openStatistikWindow()
        {
            statistikForm = new Statistik();
            statistikForm.Show();
        }


        public void draw_histogram(System.Windows.Forms.PictureBox statistikPictureBox, Statistik form, Config.histogram_canal canal)
        {
            model.draw_histogram(statistikPictureBox, canal);
        }

        public void calculate_histogram(PictureBox statistikPictureBox)
        {
            statistic_pic = statistikPictureBox;

            if (pic.Image == null)
            {
                Bitmap b = new Bitmap(1, 1);
                pic.Image = b;
                model = new StatistikModel(pic.Image);
            }
            else
            {
                model = new StatistikModel(pic.Image);
                
            }
            model.prepare_histogram_data();
            statistikForm.set_entropyLabel(model.get_entropy());
            statistikForm.set_varianceLabel(model.get_variance());
            statistikForm.set_averageLabel(model.get_average());
            statistikForm.set_minLabel(model.get_min_value());
            statistikForm.set_maxLabel(model.get_max_value());
            
            
        }


    }
}

