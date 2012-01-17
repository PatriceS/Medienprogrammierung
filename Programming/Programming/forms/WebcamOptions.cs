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
    public partial class WebcamOptions : Form
    {

        KeyValuePair<int, string> selob;
        private WebcamController con;

        public WebcamOptions(Dictionary<int, string> devices, Dictionary<int, string> solutions)
        {
            InitializeComponent();
            this.con = new WebcamController();
            show_devices(devices);
            show_solutions(solutions);
            
        }

        private void show_devices(Dictionary<int, string> data)
        {
            BindingSource myBindingSource = new BindingSource();
            myBindingSource.DataSource = data;
            WebcamDevicescomboBox.DataSource = myBindingSource;
            WebcamDevicescomboBox.DisplayMember = "Value";
            WebcamDevicescomboBox.ValueMember = "Key";
        }

        private void show_solutions(Dictionary<int, string> data)
        {
            BindingSource myBindingSource = new BindingSource();
            myBindingSource.DataSource = data;
            resolutionComboBox.DataSource = myBindingSource;
            resolutionComboBox.DisplayMember = "Value";
            resolutionComboBox.ValueMember = "Key";
        }

        private void WebcamDevicescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.stop_capture();
            selob = (KeyValuePair<int, string>)WebcamDevicescomboBox.SelectedItem;
            con.set_device(selob);
            con.show_Webcam_picture(webcamPictureBox, this);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            con.set_Webcam_picture(selob);
        }

        private void WebcamOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.stop_capture();
            
        }

        private void resolutionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.stop_capture();
            selob = (KeyValuePair<int, string>)resolutionComboBox.SelectedItem;
            con.set_solution(selob);
            con.show_Webcam_picture(webcamPictureBox, this);
        }


    }
}
