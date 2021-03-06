﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.Net.Sockets;
using System.Threading;
using Facebook;
using System.Drawing.Imaging;

namespace Programming
{
    public partial class Form1 : Form
    {
        
        
        private FacebookClient fb;
        private User user;
        private string selectedAlbumID;
        private Dictionary<string, string> albumNames;
        private ManipulationController manipulateCon;

        public Form1()
        {
            InitializeComponent();
            this.fb = new FacebookClient();
            // PixelState als ERSTES initialisieren, da pictureBox beim initialisieren der
            // controller Klassen gebraucht wird. Ansonsten EmptyPixelState exception.
            PixelState.getInstance().set_pictureBox(pictureBox1);
            manipulateCon = ManipulationController.getInstance();
            manipulateCon.setMainForm(this);

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }


        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            
        }

        

        private void bildÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                setPictureBoxSize(pictureBox1.Image);
                manipulateCon.reset_pixel_state();
                filterToolStripMenuItem.Enabled = true;
                bildSchließenToolStripMenuItem.Enabled = true;
                bildSpeichernToolStripMenuItem.Enabled = true;
                bildÖffnenToolStripMenuItem.Enabled = false;
                enable_edit_menue(true);
            }
        }

        public void setPictureBoxSize(Image img)
        {
            if (img.Width > img.Height)
            {
                double scaleFactor = ((double)img.Width / (double)Config.value.MAX_PICTUREBOX_SIZE);

                pictureBox1.Height = (int)(img.Height / scaleFactor);
                pictureBox1.Width = (int)Config.value.MAX_PICTUREBOX_SIZE;
            }
            else
            {
                double scaleFactor = ((double)img.Height / (double)Config.value.MAX_PICTUREBOX_SIZE);

                pictureBox1.Width = (int)(img.Width / scaleFactor);
                pictureBox1.Height = (int)Config.value.MAX_PICTUREBOX_SIZE;
            }
            pictureBox1.Refresh();
          
        }

        private void bildSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "BMP|*.bmp|PNG|*.png|JPEG|*.jpeg";
            saveFileDialog1.FilterIndex = 1;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bild = new Bitmap(pictureBox1.Image);
                ImageFormat format;
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                    default:
                        format = ImageFormat.Jpeg;
                        break;
                    case 2:
                        format = ImageFormat.Png;
                        break;
                    case 3:
                        format = ImageFormat.Bmp;
                        break;
                }
                bild.Save(saveFileDialog1.FileName, format);
                MessageBox.Show("Bild gespeichert");
            }
        }
             
           
    

        private void bildSchließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            bildSpeichernToolStripMenuItem.Enabled = false;
            bildSchließenToolStripMenuItem.Enabled = false;
            bildÖffnenToolStripMenuItem.Enabled = true;
            rueckgaengigMachenToolStripMenuItem.Enabled = false;
            
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void überSompeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SOcialMediaPictureEditor SOMPE");
        }
        
        
       
        private void loginFacebook_Click(object sender, EventArgs e)
        {
            this.user = User.getInstance();
            this.user.setMainForm(this);
            this.user.getLoginDialog();

            setSettings();
        }

        private void setSettings()
        {
            setProfilePicture();

            usernameLabel.Text = "Hi " + this.user.first_name;
            loginFacebook.Text = "bei Facebook eingeloggt";
            loginFacebook.Enabled = false;
            publishFacebook.Enabled = true;

            this.albumNames = this.user.getAlbumNames();
            foreach(KeyValuePair<string, string> albumName in this.albumNames)
            {
                selectAlbumComboBox.Items.Add(albumName.Value);

                if (this.selectedAlbumID == null)
                    this.selectedAlbumID = albumName.Key;
            }
            if (selectAlbumComboBox.Items.Count > 0)
            {
                selectAlbumComboBox.SelectedIndex = 0;
            }
        }
         
    

        private void selectAlbumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, string> albumName in this.albumNames)
            {
                if (selectAlbumComboBox.SelectedItem.ToString() == albumName.Value)
                {
                    this.selectedAlbumID = albumName.Key;
                }
            }
            
        }

        private void setProfilePicture()
        {
            string graphUrl = string.Format("https://graph.facebook.com/{0}/", this.user.facebookID);
            
            string picUrl = graphUrl + "picture";

            WebRequest req = WebRequest.Create(picUrl);
            WebResponse res = req.GetResponse();

            Image profilePicture = Image.FromStream(res.GetResponseStream());

            pictureBoxProfile.Image = profilePicture;

        }

        private void publishTwitter_Click(object sender, EventArgs e)
        {

        }

        private void publishFacebook_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
               // this.user.uploadPicture(this.selectedAlbumID, pictureBox1.ImageLocation);
                this.user.uploadPicture(this.selectedAlbumID, pictureBox1);
            }
            else
            {
                MessageBox.Show("Bitte zuerst ein Bild öffnen", "Bitte Bild öffnen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        internal void setInfoBox(int thread_count, long time)
        {
            infoThreads.Text = thread_count.ToString();
            infoTime.Text = time.ToString() + " ms ";
        }

        private void filterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void negativToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            manipulateCon.filter(ImageManipulatorType.Name.INVERT);
        }

        private void cancelUploadButton_Click(object sender, EventArgs e)
        {
            this.user.cancelUpload();
            cancelUploadButton.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /*    Mathias Form Anfang                                       */
        private void schwingungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manipulateCon.filter(ImageManipulatorType.Name.OSCILLATION);
        }

        private void graustufenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manipulateCon.filter(ImageManipulatorType.Name.GRAYSCALE);
        }

        private void schwarzWeißToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manipulateCon.filter(ImageManipulatorType.Name.BLACKWHITE);
        }

        private void errorDiffusionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manipulateCon.filter(ImageManipulatorType.Name.ERROR_DIFFUSION);
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manipulateCon.filter(ImageManipulatorType.Name.SEPIA);
        }


        private void rueckgaengigMachenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manipulateCon.undo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void rotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manipulateCon.filter_RGB_Mode(ImageManipulatorType.Name.RGB_RED);
        }

        private void grünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manipulateCon.filter_RGB_Mode(ImageManipulatorType.Name.RGB_GREEN);
        }

        private void blauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manipulateCon.filter_RGB_Mode(ImageManipulatorType.Name.RGB_BLUE);

        }

        private void farben_4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manipulateCon.filter_Sample_Board(4);
        }

        private void farben_8ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            manipulateCon.filter_Sample_Board(8);
        }

        private void farben_16ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            manipulateCon.filter_Sample_Board(16);
        }

        private void webcamPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PixelState.getInstance().set_pictureBox(pictureBox1);
            WebcamController con = WebcamController.getInstance();
            con.setMainForm(this);
            con.openWebcamWindow();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // this.Close();
            Application.Exit();
        }

        public void enable_filter_menue(bool enable = true)
        {
            filterToolStripMenuItem.Enabled = (enable) ?  true :  false;
        }

        public void enable_edit_menue( bool enable = true )
        {
            rueckgaengigMachenToolStripMenuItem.Enabled = (enable) ? true : false;
        }

        public void enable_menue()
        {
            bildSpeichernToolStripMenuItem.Enabled = true;
            bildSchließenToolStripMenuItem.Enabled = true;
        }

        private void histogrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PixelState.getInstance().set_pictureBox(pictureBox1);
            StatistikController con = StatistikController.getInstance();
            con.setMainForm(this);
            con.openStatistikWindow();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           // Bitmap bitmap = new Bitmap("C:\\test.bmp");
           // pictureBox1.Image = bitmap;
        }



        

        

        

        /*   Mathias Form Ende                                            */

       
    }
}
