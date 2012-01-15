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

        public WebcamOptions(Dictionary<int, string> data)
        {
            
            InitializeComponent();
            show_devices(data);
            
            
        }

        private void show_devices(Dictionary<int, string> data)
        {
            BindingSource myBindingSource = new BindingSource();
            myBindingSource.DataSource = data;
            WebcamDevicescomboBox.DataSource = myBindingSource;
            WebcamDevicescomboBox.DisplayMember = "Value";
            WebcamDevicescomboBox.ValueMember = "Key";
        }

        private void WebcamDevicescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
