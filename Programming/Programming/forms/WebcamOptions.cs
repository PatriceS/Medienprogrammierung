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
        private List<String> devices;
        Dictionary<string, string> data;
        public WebcamOptions(List<String> devices)
        {
            
            InitializeComponent();
            this.devices = devices;
            data = new Dictionary<string, string>();
            int i = 0;
            foreach(String device in devices)
            {
                data.Add(i.ToString(),device);
                i++;
            }

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
