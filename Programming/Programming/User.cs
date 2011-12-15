using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Facebook;


namespace Programming
{
    class User
    {
        static User user = null;
        private Form1 mainForm;
        public String name;
        public String first_name;
        public String facebookID;
        public String authError;
        public FacebookClient fb;
        private const string AppId = "263439397045819";
        private string[] extendedPermissions = new[] { "user_about_me", "offline_access", "user_photos" };
        public Dictionary<string, string> names;

        public static User getInstance()
        {
            if(user != null) 
                return user;
            user = new User();
            
            return user;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setFirstName(String first_name)
        {
            this.first_name = first_name;
        }

        public void setAuthError(String error)
        {
            this.authError = error;
        }

        public void getLoginDialog()
        {
            var fbLoginDialog = new FacebookLoginDialog(AppId, extendedPermissions);
            fbLoginDialog.ShowDialog();

            if (DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult))
            {
                setUserData();
                setAlbumNames();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Fehler bei der Authentifizierung");
              
            }
               
        }

        private bool DisplayAppropriateMessage(FacebookOAuthResult facebookOAuthResult)
        {
            if (facebookOAuthResult != null)
            {
                if (facebookOAuthResult.IsSuccess)
                {
                    this.fb = new FacebookClient(facebookOAuthResult.AccessToken);

                    return true;

                }
                else
                    return false;
            }
            return false;
        }

        private void setUserData() 
        {
            dynamic result = this.fb.Get("/me");

            this.name = result.name;
            this.first_name = result.first_name;
            this.facebookID = result.id;
        }

        private void setAlbumNames()
        {   
            string albumUrl = string.Format("https://graph.facebook.com/{0}/albums", this.facebookID);
            dynamic albumNames = fb.Get(albumUrl);
            this.names = new Dictionary<string, string>();
            
            foreach (dynamic albumObj in albumNames.data)
                {
                    try
                    {
                        this.names.Add(albumObj["id"], albumObj["name"]);
                    }
                    catch (System.ArgumentException e)
                    {
                        System.Windows.Forms.MessageBox.Show("Fehler: " + e.Message);
                    }
                }
        }

        public Dictionary<string, string> getAlbumNames()
        {
            return this.names;
        }

        public void uploadPicture(string albumID, String FileName)
        {

            FacebookMediaObject facebookUploader = new FacebookMediaObject { FileName = FileName, ContentType = "image/jpg" };

            var bytes = System.IO.File.ReadAllBytes(facebookUploader.FileName);
            facebookUploader.SetValue(bytes);

            var postInfo = new Dictionary<string, object>();
            postInfo.Add("message", "Tolle Nachricht");
            postInfo.Add("image", facebookUploader);
            this.fb.UploadProgressChanged += fb_UploadProgressChanged;
            this.fb.PostAsync("/" + albumID + "/photos", postInfo);
            
        }
        

        public void fb_UploadProgressChanged(object sender, FacebookUploadProgressChangedEventArgs e)
        {
            this.mainForm.progressBar1.BeginInvoke(
               new MethodInvoker(() =>
               {
                   var totalBytesToSend = e.TotalBytesToSend;
                   var bytesSent = e.BytesSent;
                   var state = e.UserState;
                   this.mainForm.progressBar1.Value = e.ProgressPercentage;
               }));
        }

        public void setMainForm(Form1 form)
        {
            mainForm = form;
        }

      }
}
