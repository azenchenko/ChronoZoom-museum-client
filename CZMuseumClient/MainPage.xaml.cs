using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CZMuseumClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void WebView_LoadCompleted(object sender, NavigationEventArgs e)
        {
            Debug.WriteLine("Page was loaded");

            Progress.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            ClientWebView.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        private void WebView_NavigationFailed(object sender, WebViewNavigationFailedEventArgs e)
        {
            Debug.WriteLine("Page load failed");

            Progress.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            FailedMessage.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }
    }
}
