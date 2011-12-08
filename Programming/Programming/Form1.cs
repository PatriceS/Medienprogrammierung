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
    public partial class Datei1 : Form
    {
        public Datei1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

     

            Controller x = Controller.getInstance();
            x.setPictureBox(pictureBox1);
            x.rotate(pictureBox1);
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        public void filterBlur_CLick(object sender, EventArgs e)
        {
           
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipX);
            
            
            }
        }

    }
}
