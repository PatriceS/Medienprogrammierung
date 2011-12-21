using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Facebook;
using System.Drawing.Imaging;


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
        private FacebookMediaObject fmo;
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
                Environment.Exit(-1);
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
            dynamic albumNames = this.fb.Get(albumUrl);
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
        /*
        public void uploadPicture(string albumID, String FileName)
        {
            if (this.fmo == null)
            {
                fmo = new FacebookMediaObject { FileName = FileName, ContentType = "image/jpg" };
            }
            else
            {
                fmo.FileName = FileName;
                fmo.ContentType = "image/jpg";
            }
            
            var bytes = System.IO.File.ReadAllBytes(fmo.FileName);
            fmo.SetValue(bytes);
            
            var postInfo = new Dictionary<string, object>();
            postInfo.Add("message", "Tolle Nachricht");
            postInfo.Add("image", fmo);
            this.fb.UploadProgressChanged += fb_UploadProgressChanged;
            this.fb.PostCompleted += fb_PostCompleted;
            this.fb.PostAsync("/" + albumID + "/photos", postInfo);
            this.mainForm.cancelUploadButton.Enabled = true;
            this.mainForm.publishFacebook.Enabled = false;
            
        }
        */
        
        public void uploadPicture(string albumID, PictureBox pictureBox)
        {


            String path = Config.SAVE_TEMP_PATH;
            
            Bitmap bitmap = (Bitmap)pictureBox.Image;
            Graphics g = Graphics.FromImage(bitmap);
            g.Save();
            g.Dispose();

            bitmap.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
            //bitmap.Dispose();

            /*
            BitmapData bmData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
            ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;

            

            System.IntPtr Scan0 = bmData.Scan0;

           
           

            // Get the address of the first line.
       //     IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            int testBytes = Math.Abs(bmData.Stride) * bmData.Height;
            byte[] rgbValues = new byte[testBytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(Scan0, rgbValues, 0, testBytes);

            // Unlock the bits.
            bitmap.UnlockBits(bmData);
            */

            if (this.fmo == null)
            {
                fmo = new FacebookMediaObject
                {
                    FileName = path, 
                    ContentType = "image/jpeg" };
            }
            else
            {
                fmo.FileName = path;
                fmo.ContentType = "image/jpeg";
            }
           // MessageBox.Show(rgbValues.Length.ToString());

            var bytes = System.IO.File.ReadAllBytes(fmo.FileName);
            fmo.SetValue(bytes);

            var postInfo = new Dictionary<string, object>();
            postInfo.Add("message", "Tolle Nachricht");
            postInfo.Add("image", fmo);
            this.fb.UploadProgressChanged += fb_UploadProgressChanged;
            this.fb.PostCompleted += fb_PostCompleted;
            this.fb.PostAsync("/" + albumID + "/photos", postInfo);
            this.mainForm.cancelUploadButton.Enabled = true;
            this.mainForm.publishFacebook.Enabled = false;


        }
        
        public void cancelUpload()
        {
            this.mainForm.progressBar1.Value = 0;
            this.mainForm.publishFacebook.Enabled = true;
            this.fb.CancelAsync();
        }

        private void fb_PostCompleted(object sender, FacebookApiEventArgs e)
        {
            if (e.Cancelled)
            {
                var cancellationError = e.Error;
                MessageBox.Show("Upload unterbrochen");
            }
            else if (e.Error == null)
            {

                // upload successful.
                MessageBox.Show(e.GetResultData().ToString());
            }
            else
            {
                // upload failed
                MessageBox.Show(e.Error.Message);
            }
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
