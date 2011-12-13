using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Facebook;

namespace Programming
{
    public class User
    {
        static User user = null;
        public String name;
        public String first_name;
        public String facebookID;
        public String authError;
        public String graphUrl;
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
                       
                    }
                }
        }

        public Dictionary<string, string> getAlbumNames()
        {
            return this.names;
        }

        public void uploadPicture(string albumID, String Fileame)
        {

            //string photoAlbumID = "1106973079181";

            //FacebookMediaObject facebookUploader = new FacebookMediaObject { FileName = pictureBox1.ImageLocation, ContentType = "image/jpg" };

            //var bytes = System.IO.File.ReadAllBytes(facebookUploader.FileName);
            //facebookUploader.SetValue(bytes);

            //var postInfo = new Dictionary<string, object>();
            //postInfo.Add("message", "test photo");
            //postInfo.Add("image", facebookUploader);
            //var fbResult = fb.Post("/" + photoAlbumID + "/photos", postInfo);
            //dynamic resultDic = (IDictionary<string, object>)fbResult;
        }

      }
}
