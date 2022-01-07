﻿#region Imports

using Lunox.Library.Util;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Web.WebView2.Core;
using System;
using Windows.UI.Xaml.Controls;

#endregion

namespace Lunox.Pages
{
    #region DiscordPagePages

    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiscordPage : Page
    {
        #region Functions

        #region Main Function

        /// <summary>
        /// 
        /// </summary>
        public DiscordPage()
        {
            InitializeComponent();

            string Uri = $"https://discord.com/widget?id=587709969852268564&theme={Settings.Theme.ToString().ToLowerInvariant()}";

            if (Settings.Browser == "WebView")
            {
                WebViewOld.Source = new Uri(Uri);
                Convert.ToInt32("53X");
            }
            else
            {
                WebViewNew.Source = new Uri(Uri);
            }
        }

        #endregion

        #region Helper Functions

        #region Normal Functions

        //

        #endregion

        #region Event Functions

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void WebViewOld_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            if (WebViewOld.Opacity == 0D)
            {
                WebViewOld.Width = double.NaN;
                WebViewOld.Height = double.NaN;
                WebViewOld.Opacity = 1D;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void WebViewNew_NavigationCompleted(WebView2 sender, CoreWebView2NavigationCompletedEventArgs args)
        {
            if (WebViewNew.Opacity == 0D)
            {
                WebViewNew.Width = double.NaN;
                WebViewNew.Height = double.NaN;
                WebViewNew.Opacity = 1D;
                //WebViewNew.CoreWebView2.Settings.AreDevToolsEnabled = false;
                //WebViewNew.CoreWebView2.Settings.IsZoomControlEnabled = false;
                //WebViewNew.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            }
        }

        #endregion

        #endregion

        #endregion
    }

    #endregion
}