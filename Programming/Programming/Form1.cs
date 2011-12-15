using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Facebook;


namespace Programming
{
    public partial class Form1 : Form
    {
        private Controller con;
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
                this.con = Controller.getInstance();
                this.con.setPictureBox(pictureBox1);
                this.con.setMainForm(this);
               
                
                filterToolStripMenuItem.Enabled = true;
            }
        }

        private void bildSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Bild gespeichert");
            }
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

            setProfilePicture();

            usernameLabel.Text = "Hi " + this.user.first_name;
            loginFacebook.Text = "bei Facebook eingeloggt";
            loginFacebook.Enabled = false;

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
                this.user.uploadPicture(this.selectedAlbumID, pictureBox1.ImageLocation);
            }
            else
            {
                MessageBox.Show("Bitte zuerst ein Bild öffnen");
            }
            
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void infoBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        internal void setInfoBox(int thread_count, long time)
        {
            string str = "Threads: " + thread_count.ToString() + " time: " + time.ToString() + " ms ";
            infoBox.Text = str;
        }

        private void filterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void negativToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Controller.getInstance().invert();
        }
    }
}
