﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Facebook;

namespace Programming
{
    public partial class FacebookLoginDialog : Form
    {
        private Uri navigateUrl;

        public FacebookLoginDialog(string appId, string[] extendedPermissions)
            : this(appId, extendedPermissions, false)
        {

        }

        public FacebookLoginDialog(string appId, string[] extendedPermissions, bool logout)
        {
            var oauth = new FacebookOAuthClient { AppId = appId };

            var loginParameters = new Dictionary<string, object>
                    {
                        { "response_type", "token" },
                        { "display", "popup" }
                    };

            if (extendedPermissions != null && extendedPermissions.Length > 0)
            {
                var scope = new StringBuilder();
                scope.Append(string.Join(",", extendedPermissions));
                loginParameters["scope"] = scope.ToString();
            }

            var loginUrl = oauth.GetLoginUrl(loginParameters);

            if (logout)
            {
                var logoutParameters = new Dictionary<string, object>
                    {
                        { "next", loginUrl }
                    };
            }
            else
            {
                this.navigateUrl = loginUrl;
            }

            InitializeComponent();
        }

        private void FacebookLoginDialog_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate(this.navigateUrl.AbsoluteUri);
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            FacebookOAuthResult result;
            if (FacebookOAuthResult.TryParse(e.Url, out result))
            {
                this.FacebookOAuthResult = result;
                this.DialogResult = result.IsSuccess ? DialogResult.OK : DialogResult.No;
            }
            else
            {
                this.FacebookOAuthResult = null;
            }
        }

        public FacebookOAuthResult FacebookOAuthResult { get; private set; }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
