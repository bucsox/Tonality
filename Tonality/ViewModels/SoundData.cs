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
                return IsolatedStorageFile.GetUserStoreForApplication().FileExists(this.SavePath);
            }
        }
        #endregion
        public RelayCommand<string> SaveSoundAsRingtone { get; set; }


        private void ExecuteSaveSoundAsRingtone(string soundPath)
        {
            App.Current.RootVisual.Dispatcher.BeginInvoke(() =>
            {
                SaveRingtoneTask task = new SaveRingtoneTask();
                #region New code
                // TODO: disable ringtone saving if the file isn't downloaded, otherwise the app will crash.
                task.Source = new Uri("isostore:/" + this.SavePath);
                #endregion
                task.DisplayName = this.Title;
                task.Show();
            }
                );
        }   

        public SoundData()
        {
            SaveSoundAsRingtone = new RelayCommand<string>(ExecuteSaveSoundAsRingtone);
        }

    }
}
