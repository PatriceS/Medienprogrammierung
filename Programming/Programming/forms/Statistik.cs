using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Programming
{
    public partial class Statistik : Form
    {

        private static StatistikController con;
        public Statistik()
        {
            InitializeComponent();
        }

        private void Statistik_Load(object sender, EventArgs e)
        {

        }

        private void Statistik_Shown(object sender, EventArgs e)
        {
            con = new StatistikController();
            con.set_statistik_form(this);
            con.set_statistik_picture_box(statistikPictureBox);
            con.draw_histogram(statistikPictureBox, this, Config.histogram_canal.GREY);
            all_channel_radio.Select();
        }

        private void all_channel_radio_CheckedChanged(object sender, EventArgs e)
        {
            con.draw_histogram(statistikPictureBox, this, Config.histogram_canal.GREY);
        }

        private void red_channel_radio_CheckedChanged(object sender, EventArgs e)
        {
            con.draw_histogram(statistikPictureBox, this, Config.histogram_canal.RED);
        }

        private void green_channel_radio_CheckedChanged(object sender, EventArgs e)
        {
            con.draw_histogram(statistikPictureBox, this, Config.histogram_canal.GREEN);
        }

        private void blue_channel_radio_CheckedChanged(object sender, EventArgs e)
        {
            con.draw_histogram(statistikPictureBox, this, Config.histogram_canal.BLUE);
        }

        

        
    }
}
