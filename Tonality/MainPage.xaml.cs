using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Tonality.Resources;
using GalaSoft.MvvmLight;
using System.Windows.Input;
using Microsoft.Phone.Tasks;
using Tonality.ViewModels;
using Coding4Fun.Toolkit.Controls;
using System.Windows.Shapes;
using System.IO;
using System.IO.IsolatedStorage;

namespace Tonality
{


    public partial class MainPage : PhoneApplicationPage
    {
        public string FilePath { get; set; }


        #region New code
        private Stream audioStream;
        #endregion

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            SoundModel svm = new SoundModel();
            svm.LoadData();
            this.LongList1.ItemsSource = CustomKeyGroup<SoundData>.GetSoundGroups(svm.Software.Items);
            this.LongList2.ItemsSource = CustomKeyGroup<SoundData>.GetSoundGroups(svm.Messengers.Items);
            this.LongList3.ItemsSource = CustomKeyGroup<SoundData>.GetSoundGroups(svm.GamesMsc.Items);
            this.LongList4.ItemsSource = CustomKeyGroup<SoundData>.GetSoundGroups(svm.Android.Items);
            this.LongList5.ItemsSource = CustomKeyGroup<SoundData>.GetSoundGroups(svm.Entertainment.Items);

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;

        }


        // Check to make sure there are enough space available on the phone
        // in order to save the image that we are downloading on to the phone
        private bool IsSpaceIsAvailable(long spaceReq)
        {
            using (var store = IsolatedStorageFile.GetUserStoreForApplication())
            {

                long spaceAvail = store.AvailableFreeSpace;
                if (spaceReq > spaceAvail)
                {
                    return false;
                }
                return true;
            }
        }
        // Sample code to localize the ApplicationBar




        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LongListSelector selector = sender as LongListSelector;

            // verifying our sender is actually a LongListSelector
            if (selector == null)
                return;

            SoundData data = selector.SelectedItem as SoundData;

            // verifying our sender is actually SoundData
            if (data == null)
                return;

            #region New code
            if (data.IsDownloaded)
            {
                if (audioStream != null)
                {
                    audioStream.Close();
                    audioStream.Dispose();
                }

                audioStream = IsolatedStorageFile.GetUserStoreForApplication().OpenFile(data.SavePath, FileMode.Open, FileAccess.Read, FileShare.Read);

                AudioPlayer.SetSource(audioStream);
                AudioPlayer.Play();

            }
            else
            {
                // TODO: the application should check if there is an internet connection available and warn the user if
                // it's disconnected. Otherwise it won't pass certification.
                WebClient client = new WebClient();
                client.OpenReadCompleted += (senderClient, args) =>
                {
                    using (IsolatedStorageFileStream fileStream = IsolatedStorageFile.GetUserStoreForApplication().CreateFile(data.SavePath))
                    {
                        if (args == null || args.Cancelled || args.Error != null)
                        {
                            MessageBox.Show("Please check your network/cellular connection. If you have a network connection, verify that you can reach drobox.com");
                            return;
                        }

                        args.Result.Seek(0, SeekOrigin.Begin);
                        args.Result.CopyTo(fileStream);
                        AudioPlayer.SetSource(fileStream);
                        AudioPlayer.Play();


                    }
                };
                client.OpenReadAsync(new Uri(data.FilePath));

            }
            #endregion


            selector.SelectedItem = null;

        }

        // Sample code for building a localized ApplicationBar





        private void Review_Click(object sender, RoutedEventArgs e)
        {
            MarketplaceReviewTask objReviewTask = new MarketplaceReviewTask();
            objReviewTask.Show();
        }

        private void Email_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask EmailComposeTask = new EmailComposeTask();
            EmailComposeTask.To = "BBSounds@outlook.com";
            EmailComposeTask.Show();

        }

        private void Share_Click(object sender, EventArgs e)
        {
            EmailComposeTask task = new EmailComposeTask();
            task.Subject = "Check out this app";
            task.Body = "Check out Tonality for free popular notification sounds http://www.windowsphone.com/en-us/store/app/tonality/7ac59477-9b21-41a7-9433-9f9f602e8f77";
            task.Show();
        }

        private void fb_Click(object sender, EventArgs e)
        {
            ShareLinkTask shareLinkTask = new ShareLinkTask();
            shareLinkTask.LinkUri = new Uri("http://www.windowsphone.com/en-us/store/app/tonality/7ac59477-9b21-41a7-9433-9f9f602e8f77", UriKind.Absolute);
            shareLinkTask.Message = "Check out Tonality";
            shareLinkTask.Show();
        }

        private void twitter_Click(object sender, EventArgs e)
        {
            ShareLinkTask shareLinkTask = new ShareLinkTask();
            shareLinkTask.LinkUri = new Uri("http://www.windowsphone.com/en-us/store/app/tonality/7ac59477-9b21-41a7-9433-9f9f602e8f77", UriKind.Absolute);
            shareLinkTask.Message = "Check out Tonality!";
            shareLinkTask.Show();
        }

        private void Paid_Click(object sender, EventArgs e)
        {
            WebBrowserTask weblinktask = new WebBrowserTask();

            weblinktask.Uri = new Uri("http://www.windowsphone.com/en-us/store/app/tonality-8-1/0940431a-2eec-4d19-bed6-41379538da76", UriKind.Absolute);

            weblinktask.Show();
        }

        private void adcontrol_adrefreshed(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Adcontrol new ad received");
        }
        private void AdControl_ErrorOccurred(object sender, Microsoft.Advertising.AdErrorEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Ad Error : ({0}) {1}", e.ErrorCode, e.Error);
        }

    }
}
       
               
        
       
        
    

