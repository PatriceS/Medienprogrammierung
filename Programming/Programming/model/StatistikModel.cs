using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Programming
{
    class StatistikModel
    {
        private Bitmap bitmap;
        private int[,] histo = new int[4, (int)Config.value.HISTOGRAM_VALUE_COUNT];
        private int[] peak = new int[4];
        private int min_grey = 255;
        private int max_grey = 0;
        private int average  = 0;
        private double entropy = 0.0;
        private double variance = 0.0;
        
        public StatistikModel(Image image)
        {
            this.bitmap = (Bitmap)image;
        }

        public void prepare_histogram_data()
        {
            BitmapData bmData = this.bitmap.LockBits(new Rectangle(0, 0, this.bitmap.Width, this.bitmap.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;

            int bytes = Math.Abs(bmData.Stride) * bmData.Height;

            System.IntPtr Scan0 = bmData.Scan0;
            int nOffset = stride - (bitmap.Width * (int)Config.value.BITMAP_OFFSET_MULTIPLIKATOR);
            int grey = 0;
            int blue, red, green = 0;
            int canal_grey = (int)Config.histogram_canal.GREY;
            int canal_red =   (int)Config.histogram_canal.RED;
            int canal_blue = (int)Config.histogram_canal.BLUE;
            int canal_green = (int)Config.histogram_canal.GREEN;
            int sum_grey_values = 0;
            int bitmap_height = this.bitmap.Height;
            int bitmap_width = this.bitmap.Width;
            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                for (int y = 0; y < bitmap_height; ++y)
                {
                    for (int x = 0; x < bitmap_width; ++x)
                    {
                        // BGR
                        red = p[2]; green = p[1]; blue = p[0];

                        grey = (int)Math.Round(0.3 * red + 0.6 * green + 0.1 * blue);

                         // min und maximum berechnen
                        findMinMax(grey);
                        // alle grau werte summieren
                        sum_grey_values += grey;
                        // leistung berechnen
                        this.variance += Math.Pow(grey, 2.0);
                        // 0 intensität nicht berücksichtigen!!
                        if (grey != 0)
                        {
                            this.histo[0, grey] ++;
                            this.peak[canal_grey] = calculate_peak(this.histo[0, grey], this.peak[canal_grey]);
                        }
                        if (red != 0)
                        {
                            this.histo[1, red] ++;
                            this.peak[canal_red] = calculate_peak(this.histo[1, red], this.peak[canal_red]);
                        }

                        if (green != 0)
                        {
                            this.histo[2, green] ++;
                            this.peak[canal_green] = calculate_peak(this.histo[2, green], this.peak[canal_green]);
                        }

                        if (blue != 0)
                        {
                            this.histo[3, blue] ++;
                            this.peak[canal_blue] = calculate_peak(this.histo[3, blue], this.peak[canal_blue]);
                        }
                       
                        p += 3;
                    }
                    p += nOffset;
                }
            }
            this.bitmap.UnlockBits(bmData);
            this.average = this.calculate_average(sum_grey_values);
            this.entropy = this.calculate_entropy();
            this.variance = this.calculate_variance();
            
        }

        

        private double calculate_variance()
        {
            try
            {
                this.variance /= (this.bitmap.Height * this.bitmap.Width);
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show(e.Message);
                return 0.0;
            }

            return this.variance - (this.average * this.average);
        }


        private double calculate_entropy()
        {
            double[] p = new double[(int)Config.value.HISTOGRAM_VALUE_COUNT];
            int canal = (int)Config.histogram_canal.GREY;
            int count = p.Count();
            for (int i = 0; i < count; i++)
            {
                try
                {
                    p[i] = (double)this.histo[canal, i] / (bitmap.Height * bitmap.Width);
                }
                catch (DivideByZeroException e)
                {
                    MessageBox.Show(e.Message);
                    p[i] = 0;
                }

                if (p[i] != 0)
                {
                    this.entropy -= p[i] * Math.Log(p[i]);
                }

            }

           return entropy /= Math.Log(2);
        }

        private int calculate_average(int sum_grey_values)
        {
            try
            {
                return sum_grey_values / (bitmap.Height * bitmap.Width);
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        // Maximum und Minimum im Histogramm bestimmen.
        public void findMinMax(int grey)
        {

            this.min_grey = (grey < this.min_grey) ? grey : this.min_grey;
            this.max_grey = (grey > this.max_grey) ? grey : this.max_grey;
           
        }

        public int calculate_peak( int histo, int peak )
        {
            if (histo > peak)
                return histo;

            return peak;
        }

        public void draw_histogram(System.Windows.Forms.PictureBox statistik_pic, Config.histogram_canal canal)
        {

            const int width = 256;
            const int height = 100;

            Bitmap bb = new Bitmap(width, height);
            Graphics objGraphic = Graphics.FromImage(bb);
            Pen pen = new Pen(Color.Black);
            pen.Width = 5;

            objGraphic.DrawLine(pen, 0, height, width -1, height);
           
            int peak = 0;
            int c = (int)canal;
            int value = 0;
            for (int x = 1; x < width; x++)
            {
                value = histo[c, x];
                peak = (value == 0) ? 0 : (value * height) / this.peak[(int)canal];
                objGraphic.DrawLine(pen, x, height, x, height - peak);

                System.Drawing.Drawing2D.GraphicsState graph = objGraphic.Save();
                objGraphic.Restore(graph);
            }

            statistik_pic.Image = bb;
            statistik_pic.Refresh();
        }

        public int get_average()
        {
            return this.average;
        }
        public double get_entropy()
        {
            return this.entropy;
        }
        public double get_variance()
        {
            return this.variance;
        }
        public int get_min_value()
        {
            return this.min_grey;
        }
        public int get_max_value()
        {
            return this.max_grey;
        }

    }
}
