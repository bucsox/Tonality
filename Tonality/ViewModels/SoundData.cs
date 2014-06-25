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
using System.Threading.Tasks;

namespace Tonality.ViewModels
{
    public class SoundData : ViewModelBase
    {
        public string Title { get; set; }
        public string FilePath { get; set; }
        public string Items { get; set; }
        public string Groups { get; set; }
        
        public RelayCommand<string> SaveSoundAsRingtone { get; set; }


        private void ExecuteSaveSoundAsRingtone(string soundPath)
        {
            App.Current.RootVisual.Dispatcher.BeginInvoke(() =>
            {
                SaveRingtoneTask task = new SaveRingtoneTask();
                task.Source = new Uri("appdata:/" + this.FilePath);
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
