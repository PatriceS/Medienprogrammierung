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
        Controller con = new Controller();

        private const string AppId = "263439397045819";
        private string[] extendedPermissions = new[] { "user_about_me", "offline_access" };

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }


        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            con.rotate(pictureBox1);
        }

        private void bildÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
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

        private void DisplayAppropriateMessage(FacebookOAuthResult facebookOAuthResult)
        {
            if (facebookOAuthResult != null)
            {
                if (facebookOAuthResult.IsSuccess)
                {
                    var fb = new FacebookClient(facebookOAuthResult.AccessToken);

                    dynamic result = fb.Get("/me");
                    usernameLabel.Text = "Hi " + result.first_name;
                    loginFacebook.Text = "bei Facebook eingeloggt";
                    loginFacebook.Enabled = false;

                    // Profilbild einstellen
                    setProfilePicture(result.id);

                    string photoAlbumID = "1106973079181";

                    FacebookMediaObject facebookUploader = new FacebookMediaObject { FileName = pictureBox1.ImageLocation, ContentType = "image/jpg" };

                    var bytes = System.IO.File.ReadAllBytes(facebookUploader.FileName);
                    facebookUploader.SetValue(bytes);

                    var postInfo = new Dictionary<string, object>();
                    postInfo.Add("message", "test photo");
                    postInfo.Add("image", facebookUploader);
                    var fbResult = fb.Post("/" + photoAlbumID + "/photos", postInfo);
                    dynamic resultDic = (IDictionary<string, object>)fbResult;
                }
                else
                {
                    MessageBox.Show(facebookOAuthResult.ErrorDescription);
                }
            }
        }

        private void setProfilePicture(string id)
        {
            string picUrl = string.Format("https://graph.facebook.com/{0}/picture", id);

            WebRequest req = WebRequest.Create(picUrl);
            WebResponse res = req.GetResponse();
            
            Image profilePicture = Image.FromStream(res.GetResponseStream());

            pictureBoxProfile.Image = profilePicture;
        }
       
        private void loginFacebook_Click(object sender, EventArgs e)
        {
            var fbLoginDialog = new FacebookLoginDialog(AppId, extendedPermissions);
            fbLoginDialog.ShowDialog();

            DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);
        }

        private void publishTwitter_Click(object sender, EventArgs e)
        {

        }

        private void publishFacebook_Click(object sender, EventArgs e)
        {

        }
    }
}
