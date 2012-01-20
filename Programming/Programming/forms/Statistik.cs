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
            con.calculate_histogram(statistikPictureBox);
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

        internal void set_entropyLabel(double p)
        {
            entropyLabel.Text = "Entropie: " +  p.ToString();
        }

        internal void set_maxLabel(int p)
        {
            maxLabel.Text = "Max: " + p.ToString();
        }

        internal void set_minLabel(int p)
        {
            minLabel.Text = "Min: " + p.ToString();
        }

        internal void set_averageLabel(int p)
        {
            averageLabel.Text = "Mittelwert: " + p.ToString();
        }

        internal void set_varianceLabel(double p)
        {
            varianceLabel.Text = "Varianz: " + p.ToString();
        }

        private void statistikRefreshButton_Click(object sender, EventArgs e)
        {
            con.calculate_histogram(statistikPictureBox);
        }
    }
}
