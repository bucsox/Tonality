using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using System.Diagnostics;
using Microsoft.Phone.Tasks;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System.Windows;
using System.IO.IsolatedStorage;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Tonality.ViewModels
{
    public class SoundData : ViewModelBase
    {
        public string Title { get; set; }
        public string FilePath { get; set; }
        public string Items { get; set; }
        public string Groups { get; set; }
        #region New code
        public string SavePath { get; set; }
        public bool IsDownloaded
        {
            get
            {
                return IsolatedStorageFile.GetUserStoreForApplication().FileExists(this.SavePath) && this.Status == DownloadStatus.Downloaded;
            }
        }

        private DownloadStatus status;
        public DownloadStatus Status
        {
            get
            {
                return this.status;
            }
            set
            {
                if (this.status != value)
                {
                    this.status = value;
                    this.RaisePropertyChanged(() => this.Status);
                }
            }
        }

        private int downloadProgress;
        public int DownloadProgress
        {
            get
            {
                return this.downloadProgress;
            }
            set
            {
                if (this.downloadProgress != value)
                {
                    this.downloadProgress = value;
                    this.RaisePropertyChanged(() => this.DownloadProgress);
                }
            }
        }
        #endregion
        [XmlIgnore]
        public RelayCommand<string> SaveSoundAsRingtone { get; set; }

       
        private void ExecuteSaveSoundAsRingtone(string soundPath)
        {
            if (IsDownloaded == false)
            {
                MessageBox.Show("Will not download until you short press atleast once to play sound");
                return;
            }
            App.Current.RootVisual.Dispatcher.BeginInvoke(() =>
            {

                SaveRingtoneTask task = new SaveRingtoneTask();
                task.Source = new Uri("isostore:/" + this.SavePath);
                task.DisplayName = this.Title;
                task.Show();
            }
               );
        }
          
            
        
               
        public SoundData()
        {
            SaveSoundAsRingtone = new RelayCommand<string>(ExecuteSaveSoundAsRingtone);
            this.Status = DownloadStatus.NotDownloaded;
            this.DownloadProgress = 0;
        }

    }
}
