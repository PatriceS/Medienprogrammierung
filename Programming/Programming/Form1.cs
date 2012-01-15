using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.Net.Sockets;
using System.Threading;
using Facebook;

namespace Programming
{
    public partial class Form1 : Form
    {
        private int MAX_SIZE = 800;
        
        private ManipulationController con;
        private const int threads = 4;
        private FacebookClient fb;
        private User user;
        private string selectedAlbumID;
        private Dictionary<string, string> albumNames;
        

        public Form1()
        {
            InitializeComponent();
            this.fb = new FacebookClient();
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

                    // PixelState als ERSTES initialisieren, da pictureBox beim initialisieren der
                    // controller Klassen gebraucht wird. Ansonsten EmptyPixelState exception.
                PixelState.getInstance().set_pictureBox(pictureBox1);
                this.con = ManipulationController.getInstance();
                this.con.setMainForm(this);
                setPictureBoxSize(pictureBox1.Image);
                this.con.reset_pixel_state();
                filterToolStripMenuItem.Enabled = true;
                bildSchließenToolStripMenuItem.Enabled = true;
                bildSpeichernToolStripMenuItem.Enabled = true;
                bildÖffnenToolStripMenuItem.Enabled = false;
                rueckgaengigMachenToolStripMenuItem.Enabled = true;
            }
        }

        private void setPictureBoxSize(Image img)
        {
            if (img.Width > img.Height)
            {
                double scaleFactor = ((double)img.Width / (double)MAX_SIZE);

                pictureBox1.Height = (int)(img.Height / scaleFactor);
                pictureBox1.Width = MAX_SIZE;
            }
            else
            {
                double scaleFactor = ((double)img.Height / (double)MAX_SIZE);

                pictureBox1.Width = (int)(img.Width / scaleFactor);
                pictureBox1.Height = MAX_SIZE;
            }
            pictureBox1.Refresh();
          
        }
                 
        private void bildSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Bild gespeichert");
            }
        }

        private void bildSchließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            bildSpeichernToolStripMenuItem.Enabled = false;
            bildSchließenToolStripMenuItem.Enabled = false;
            bildÖffnenToolStripMenuItem.Enabled = true;
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
            ManipulationController.getInstance().filter_invert();
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
            ManipulationController.getInstance().filter_oscillate();
        }

        private void graustufenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManipulationController.getInstance().filter_grayscale();
        }

        private void schwarzWeißToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManipulationController.getInstance().filter_blackNwhite();
        }

        private void errorDiffusionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManipulationController.getInstance().filter_errorDiffusion();
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManipulationController.getInstance().filter_sepia();
        }


        private void rueckgaengigMachenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManipulationController.getInstance().undo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void rotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManipulationController.getInstance().filter_RGB_Mode(ImageManipulatorType.Name.RGB_RED);
        }

        private void grünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManipulationController.getInstance().filter_RGB_Mode(ImageManipulatorType.Name.RGB_GREEN);
        }

        private void blauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManipulationController.getInstance().filter_RGB_Mode(ImageManipulatorType.Name.RGB_BLUE);

        }

        private void farben_4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManipulationController.getInstance().filter_Sample_Board(4);
        }

        private void farben_8ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManipulationController.getInstance().filter_Sample_Board(8);
        }

        private void farben_16ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ManipulationController.getInstance().filter_Sample_Board(16);
        }

       

        

        

        /*   Mathias From Ende                                            */

       
    }
}
