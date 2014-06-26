using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using Tonality.ViewModels;
using System.Threading.Tasks;

namespace Tonality.ViewModels
{
    public class SoundModel: BindableBase
    {
        public SoundGroup NewAdds { get; set; }
        public SoundGroup Software { get; set; }
        public SoundGroup Messengers { get; set; }
        public SoundGroup Entertainment { get; set; }
        public SoundGroup GamesMsc { get; set; }
        public SoundGroup Android { get; set; }
        public SoundGroup Groups { get; set; }

        public bool IsDataLoaded { get; set; }

        public const string CustomSoundKey = "CustomSound";

        public void LoadData()
        {
            // Load data into the model
            Software = CreateSoftwareGroup();
            Messengers = CreateMessengersGroup();
            Entertainment = CreateEntertainmentGroup();
            GamesMsc = CreateGamesMscGroup();
            Android = CreateAndroidGroup();
            
            

            IsDataLoaded = true;
        }

        private SoundGroup LoadCustomSounds()
        {
            SoundGroup data;
            string dataFromAppSettings;

            if (IsolatedStorageSettings.ApplicationSettings.TryGetValue(CustomSoundKey, out dataFromAppSettings))
            {
                data = JsonConvert.DeserializeObject<SoundGroup>(dataFromAppSettings);
            }
            else
            {
                data = new SoundGroup();
                data.Title = "mine";
            }

            return data;
        }


        



        private SoundGroup CreateSoftwareGroup()
        {
            SoundGroup data = new SoundGroup();

            data.Title = "OS/Software";
            
              
            data.Items.Add(new SoundData 
            { 
                Title = "Vine", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Vine_Notification.mp3",
                Groups = "Vine",
                SavePath =    "Vine Notification.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "WPCentral", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/WPCentral.mp3",
                Groups = "WPCentral",
                SavePath =    "WPCentral.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Kaspersky Alert", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Kaspersky_Alert.mp3",
                Groups = "Anti-virus",
                SavePath =    "Kaspersky Alert.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Win8 Notify ", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Win8_Notify.mp3",
                Groups = "Windows",
                SavePath =    "Win8 Notify.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Win8 Email", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Win8_Email.mp3",
                Groups = "Windows",
                SavePath =    "Win8 Email.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Win8 Calendar", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Win8_Calendar.mp3",
                Groups = "Windows",
                SavePath =    "Win8 Calendar.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Win8 Logon", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Kaspersky_Alert.mp3",
                Groups = "Windows",
                SavePath =    "Win8 Logon.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Win8 Logoff", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Win8_Logoff.mp3",
                Groups = "Windows",
                SavePath =    "Win8 Logoff.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Win8 Unlock", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Win8_Unlock.mp3",
                Groups = "Windows",
                SavePath =    "Win8 Unlock.mp3",
            });
             
            data.Items.Add(new SoundData 
            { 
                Title = "Windows XP", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Windows_XP.mp3",
                Groups = "Windows",
                SavePath =    "Windows XP.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Windows 98", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Windows_98.mp3",
                Groups = "Windows",
                SavePath =    "Windows 98.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Windows 3.1", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Windows_3_1.mp3",
                Groups = "Windows",
                SavePath =    "Windows 3 1.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Windows 95", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Windows_3_1.mp3",
                Groups = "Windows",
                SavePath =    "Windows 95.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "6Tag Aperggio", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/6Tag_Aperggio.mp3",
                Groups = "6Tag",
                SavePath =    "6Tag Aperggio.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "6Tag Symbian", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/6Tag_Symbian.mp3",
                Groups = "6Tag",
                SavePath =    "6Tag Symbian.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "6Tag Space", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/6Tag_Space.mp3",
                Groups = "6Tag",
                SavePath =    "6Tag Space.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "6Tag Pictures", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/6Tag_Pictures.mp3",
                Groups = "6Tag",
                SavePath =    "6Tag Pictures.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Google Glass On", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Google_Glass_on.mp3",
                Groups = "Google",
                SavePath =    "Google Glass On.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Google Glass Navigation", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Google_Glass_navigation.mp3",
                Groups = "Google",
                SavePath =    "Google Glass Navigation.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Google Glass Notification", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Google_Glass_notification.mp3",
                Groups = "Google",
                SavePath =    "Google Glass Notification.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Google Glass Notification Multiple", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Google_Glass_notification_multiple.mp3",
                Groups = "Google",
                SavePath =    "Google Glass Notification Multiple.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Google Glass Photo Shutter", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Google_Glass_photo_shutter.mp3",
                Groups = "Google",
                SavePath =    "Google Glass Photo Shutter.mp3"
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Google Glass Pwr", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Google_Glass_Pwr.mp3",
                Groups = "Google",
                SavePath =    "Google Glass Pwr.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Google Glass Scale Resolve", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Google_Glass_scale_resolve.mp3",
                Groups = "Google",
                SavePath =    "Google Glass Scale Resolve.mp3"
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Google Glass Shut Down", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Google_Glass_shut_down.mp3",
                Groups = "Google",
                SavePath =    "Google Glass Shut Down.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Google Glass Success", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Google_Glass_success.mp3",
                Groups = "Google",
                SavePath =    "Google Glass Success.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Google Glass Tap", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Google_Glass_tap.mp3",
                Groups = "Google",
                SavePath =    "Google Glass Tap.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Google Glass Call Incoming Ring", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Google_Glass_call_incoming_ring.mp3",
                Groups = "Google",
                SavePath =    "Google Glass Call Incoming Ring.mp3"
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Google Glass Call Start", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Google_Glass_call_start.mp3",
                Groups = "Google",
                SavePath =    "Google Glass Call Start.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Google Glass Call Stop", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Google_Glass_call_stop.mp3",
                Groups = "Google",
                SavePath =    "Google Glass Call Stop.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Google Glass Off", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Google_Glass_off.mp3",
                Groups = "Google",
                SavePath =    "Google Glass Off.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Google Glass Video Stop", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Google_Glass_video_stop.mp3",
                Groups = "Google",
                SavePath =    "Google Glass Video Stop.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Win 7 Lock", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Win_7_Lock.mp3",
                Groups = "Windows",
                SavePath =    "Win 7 Lock.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Win 7 Unlock", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Win_7_Unlock.mp3",
                Groups = "Windows",
                SavePath =    "Win 7 Unlock.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Ubuntu OS Question", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Ubuntu_OS_question.mp3",
                Groups = "Ubuntu",
                SavePath =    "Ubuntu OS Question.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Ubuntu OS Login", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Ubuntu_OS_Login.mp3",
                Groups = "Ubuntu",
                SavePath =    "Ubuntu OS Login.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Ubuntu OS Logout", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Ubuntu_OS_Logout.mp3",
                Groups = "Ubuntu",
                SavePath =    "Ubuntu OS Logout.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Ubuntu Touch Rhodes", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Ubuntu_Touch_Rhodes.mp3",
                Groups = "Ubuntu",
                SavePath =    "Ubuntu Touch Rhodes.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Ubuntu Touch Slick", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Ubuntu_Touch_Slick.mp3",
                Groups = "Ubuntu",
                SavePath =    "Ubuntu Touch Slick.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Ubuntu Touch Soft delay", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Ubuntu_Touch_Soft_delay.mp3",
                Groups = "Ubuntu",
                SavePath =    "Ubuntu Touch Soft delay.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Ubuntu Touch Xylo", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Ubuntu_Touch_Xylo.mp3",
                Groups = "Ubuntu",
                SavePath =    "Ubuntu Touch Xylo.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Ubuntu Touch Amsterdam", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Ubuntu_Touch_Amsterdam.mp3",
                Groups = "Ubuntu",
                SavePath =    "Ubuntu Touch Amsterdam.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Ubuntu Touch Blip", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Ubuntu_Touch_Blip.mp3",
                Groups = "Ubuntu",
                SavePath =    "Ubuntu Touch Blip.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Ubuntu Touch Mallet", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Ubuntu_Touch_Mallet.mp3",
                Groups = "Ubuntu",
                SavePath =    "Ubuntu Touch Mallet.mp3",
            });
 
            data.Items.Add(new SoundData 
            { 
                Title = "Ubuntu Touch Positive", 
                FilePath = "https://googledrive.com/host/0B8EaOYJiTtnVR3RuREluYllEa28/Ubuntu_Touch_Positive.mp3",
                Groups = "Ubuntu",
                SavePath =    "Ubuntu Touch Positive.mp3",
            });



            
            return data;
        }

        private SoundGroup CreateMessengersGroup()
        {
            SoundGroup data = new SoundGroup();
            data.Title = "Messengers";
            string basePath = "assets/audio/Messengers/";


            data.Items.Add(new SoundData
            {
                Title = "AOL Connect",
                FilePath = basePath + "AOLConnect.mp3",
                Groups = "AOL"
            });

            data.Items.Add(new SoundData
            {
                Title = "MSN ",
                FilePath = basePath + "MSN.mp3",
                Groups = "MSN"
            });

            data.Items.Add(new SoundData
            {
                Title = "Skype Online",
                FilePath = basePath + "Skype Online.mp3",
                Groups = "Skype"
            });

            data.Items.Add(new SoundData
            {
                Title = "Skype Offline",
                FilePath = basePath + "Skype Offline.mp3",
                Groups = "Skype"
            });

            data.Items.Add(new SoundData
            {
                Title = "Skype Ring",
                FilePath = basePath + "Skype Ring.mp3",
                Groups = "Skype"
            });

            data.Items.Add(new SoundData
            {
                Title = "Skype Ringout",
                FilePath = basePath + "Skype Ringout.mp3",
                Groups = "Skype"
            });

            data.Items.Add(new SoundData
            {
                Title = "Skype 2",
                FilePath = basePath + "Skype 2.mp3",
                Groups = "Skype"
            });

            data.Items.Add(new SoundData
            {
                Title = "AOL Message",
                FilePath = basePath + "AOL Message.mp3",
                Groups = "AOL"
            });

            data.Items.Add(new SoundData
            {
                Title = "AOL Door Open",
                FilePath = basePath + "AOL Door Open.mp3",
                Groups = "AOL"
            });

            data.Items.Add(new SoundData
            {
                Title = "AOL Door Shut",
                FilePath = basePath + "AOL Door Shut.mp3",
                Groups = "AOL"
            });


            data.Items.Add(new SoundData
            {
                Title = "Facebook Chat",
                FilePath = basePath + "Facebook Chat.mp3",
                Groups = "Facebook"
            });

            data.Items.Add(new SoundData
            {
                Title = "Facebook Notification",
                FilePath = basePath + "Facebook Notify.mp3",
                Groups = "Facebook"
            });

            data.Items.Add(new SoundData
            {
                Title = "Twitter",
                FilePath = basePath + "Twitter.mp3",
                Groups = "Twitter"
            });

            data.Items.Add(new SoundData
            {
                Title = "Trillian Astra Ring",
                FilePath = basePath + "Trillian Astra Ring.mp3",
                Groups = "Trillian"
            });

            data.Items.Add(new SoundData
            {
                Title = "Trillian Chat In",
                FilePath = basePath + "Trillian Chat In.mp3",
                Groups = "Trillian"
            });

            data.Items.Add(new SoundData
            {
                Title = "Trillian Chat Out",
                FilePath = basePath + "Trillian Chat Out.mp3",
                Groups = "Trillian"
            });

            data.Items.Add(new SoundData
            {
                Title = "Trillian Online",
                FilePath = basePath + "Trillian On.mp3",
                Groups = "Trillian"
            });

            data.Items.Add(new SoundData
            {
                Title = "Trillian Offline",
                FilePath = basePath + "Trillian Off.mp3",
                Groups = "Trillian"
            });

            data.Items.Add(new SoundData
            {
                Title = "Trillian Mail",
                FilePath = basePath + "Trillian Mail.mp3",
                Groups = "Trillian"
            });

            data.Items.Add(new SoundData
            {
                Title = "Trillian Msg In",
                FilePath = basePath + "Trillian Msg In.mp3",
                Groups = "Trillian"
            });

            data.Items.Add(new SoundData
            {
                Title = "Trillian Msg Out",
                FilePath = basePath + "Trillian Msg Out.mp3",
                Groups = "Trillian"
            });

            data.Items.Add(new SoundData
            {
                Title = "Trillian Meta On",
                FilePath = basePath + "Trillian Meta On.mp3",
                Groups = "Trillian"
            });

            data.Items.Add(new SoundData
            {
                Title = "Trillian Meta Off",
                FilePath = basePath + "Trillian Meta Off.mp3",
                Groups = "Trillian"
            });

            data.Items.Add(new SoundData
            {
                Title = "Trillian Notify",
                FilePath = basePath + "Trillian Notify.mp3",
                Groups = "Trillian"
            });

            data.Items.Add(new SoundData
            {
                Title = "Trillian Load",
                FilePath = basePath + "Trillian Load.mp3",
                Groups = "Trillian"
            });

            data.Items.Add(new SoundData
            {
                Title = "Trillian Capture",
                FilePath = basePath + "Trillian Capture.mp3",
                Groups = "Trillian"
            });

            data.Items.Add(new SoundData
            {
                Title = "WhatsApp Incoming",
                FilePath = basePath + "WhatsApp Incoming.mp3",
                Groups = "WhatsApp"
            });

            data.Items.Add(new SoundData
            {
                Title = "WhatsApp Ringback",
                FilePath = basePath + "WhatsApp Ringback.mp3",
                Groups = "WhatsApp"
            });


            data.Items.Add(new SoundData
            {
                Title = "WhatsApp Voice Error",
                FilePath = basePath + "WhatsApp Voice Error.mp3",
                Groups = "WhatsApp"
            });

            data.Items.Add(new SoundData
            {
                Title = "LINE A3",
                FilePath = basePath + "LINE A3.mp3",
                Groups = "LINE"
            });

            data.Items.Add(new SoundData
            {
                Title = "LINE A7",
                FilePath = basePath + "LINE A7.mp3",
                Groups = "LINE"
            });

            data.Items.Add(new SoundData
            {
                Title = "LINE A14",
                FilePath = basePath + "LINE A14.mp3",
                Groups = "LINE"
            });

            data.Items.Add(new SoundData
            {
                Title = "LINE A66",
                FilePath = basePath + "LINE A66.mp3",
                Groups = "LINE"
            });

            data.Items.Add(new SoundData
            {
                Title = "LINE B6",
                FilePath = basePath + "LINE B6.mp3",
                Groups = "LINE"
            });

            data.Items.Add(new SoundData
            {
                Title = "LINE B13",
                FilePath = basePath + "LINE B13.mp3",
                Groups = "LINE"
            });

            data.Items.Add(new SoundData
            {
                Title = "LINE UI FAIL",
                FilePath = basePath + "LINE UI FAIL.mp3",
                Groups = "LINE"
            });

            data.Items.Add(new SoundData
            {
                Title = "LINE BIRD",
                FilePath = basePath + "LINE BIRD.mp3",
                Groups = "LINE"
            });

            data.Items.Add(new SoundData
            {
                Title = "LINE BELL 1",
                FilePath = basePath + "LINE BELL 1.mp3",
                Groups = "LINE"
            });

            data.Items.Add(new SoundData
            {
                Title = "LINE BELL 2",
                FilePath = basePath + "LINE BELL 2.mp3",
                Groups = "LINE"
            });

            data.Items.Add(new SoundData
            {
                Title = "LINE Ding Dong",
                FilePath = basePath + "LINE Ding Dong.mp3",
                Groups = "LINE"
            });

            data.Items.Add(new SoundData
            {
                Title = "LINE Xylopohone",
                FilePath = basePath + "LINE Xylophone.mp3",
                Groups = "LINE"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Spirit",
                FilePath = basePath + "Blackberry Spirit.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Zen Spirit",
                FilePath = basePath + "Blackberry Zen Spirit.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Text Brief",
                FilePath = basePath + "Blackberry Text Brief.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Text Pure",
                FilePath = basePath + "Blackberry Text Pure.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Text Tight",
                FilePath = basePath + "Blackberry Text Tight.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Google Hangout Incoming",
                FilePath = basePath + "Google Hangout Incoming.mp3",
                Groups = "Google"
            });

            data.Items.Add(new SoundData
            {
                Title = "Google Hangout Outgoing",
                FilePath = basePath + "Google Hangout Outgoing.mp3",
                Groups = "Google"
            });

            data.Items.Add(new SoundData
            {
                Title = "Google Hangout Msg",
                FilePath = basePath + "Google Hangout Msg.mp3",
                Groups = "Google"
            });

            data.Items.Add(new SoundData
            {
                Title = "Google Hangout Join",
                FilePath = basePath + "Google Hangout Join.mp3",
                Groups = "Google"
            });

            data.Items.Add(new SoundData
            {
                Title = "Google Hangout Leave",
                FilePath = basePath + "Google Hangout Leave.mp3",
                Groups = "Google"
            });

            data.Items.Add(new SoundData
            {
                Title = "Google Hangout Ring",
                FilePath = basePath + "Google Hangout Ring.mp3",
                Groups = "Google"
            });

            data.Items.Add(new SoundData
            {
                Title = "Google Hangout Join 2",
                FilePath = basePath + "Google Hangout Join 2.mp3",
                Groups = "Google"
            });

            data.Items.Add(new SoundData
            {
                Title = "Google Hangout Leave 2",
                FilePath = basePath + "Google Hangout Leave 2.mp3",
                Groups = "Google"
            });

            data.Items.Add(new SoundData
            {
                Title = "iChat Msg",
                FilePath = basePath + "iChat Msg.mp3",
                Groups = "iChat"
            });

            data.Items.Add(new SoundData
            {
                Title = "iChat Ringer",
                FilePath = basePath + "iChat Ringer.mp3",
                Groups = "iChat"
            });

            data.Items.Add(new SoundData
            {
                Title = "iChat Log in",
                FilePath = basePath + "iChat Log in.mp3",
                Groups = "iChat"
            });

            data.Items.Add(new SoundData
            {
                Title = "Adium Inhale",
                FilePath = basePath + "Adium Inhale.mp3",
                Groups = "Adium"
            });

            data.Items.Add(new SoundData
            {
                Title = "Adium Exhale",
                FilePath = basePath + "Adium Exhale.mp3",
                Groups = "Adium"
            });

            data.Items.Add(new SoundData
            {
                Title = "Adium Inflate",
                FilePath = basePath + "Adium Inflate.mp3",
                Groups = "Adium"
            });

            data.Items.Add(new SoundData
            {
                Title = "Adium Deflate",
                FilePath = basePath + "Adium Deflate.mp3",
                Groups = "Adium"
            });

            data.Items.Add(new SoundData
            {
                Title = "Adium Feather Ruffle",
                FilePath = basePath + "Adium Feather Ruffle.mp3",
                Groups = "Adium"
            });

            data.Items.Add(new SoundData
            {
                Title = "Adium Quack",
                FilePath = basePath + "Adium Quack.mp3",
                Groups = "Adium"
            });

            data.Items.Add(new SoundData
            {
                Title = "Adium Tokyo 1",
                FilePath = basePath + "Adium Tokyo Contact_Off.mp3",
                Groups = "Adium"
            });

            data.Items.Add(new SoundData
            {
                Title = "Adium Tokyo 2",
                FilePath = basePath + "Adium Tokyo Contact_On.mp3",
                Groups = "Adium"
            });

            data.Items.Add(new SoundData
            {
                Title = "Adium Tokyo 3",
                FilePath = basePath + "Adium Tokyo Message_Received.mp3",
                Groups = "Adium"
            });

            data.Items.Add(new SoundData
            {
                Title = "Adium Tokyo 4",
                FilePath = basePath + "Adium Tokyo Message_sent.mp3",
                Groups = "Adium"
            });

            data.Items.Add(new SoundData
            {
                Title = "Adium Tokyo 5",
                FilePath = basePath + "Adium Tokyo New_Message.mp3",
                Groups = "Adium"
            });

            data.Items.Add(new SoundData
            {
                Title = "Kakao Ns 18",
                FilePath = basePath + "Kakao Ns 18.mp3",
                Groups = "Kakao"
            });

            data.Items.Add(new SoundData
            {
                Title = "Kakao Ns 07",
                FilePath = basePath + "Kakao Ns 07.mp3",
                Groups = "Kakao"
            });

            data.Items.Add(new SoundData
            {
                Title = "Kakao Ns 06",
                FilePath = basePath + "Kakao Ns 06.mp3",
                Groups = "Kakao"
            });

            data.Items.Add(new SoundData
            {
                Title = "Kakao Ns 08",
                FilePath = basePath + "Kakao Ns 08.mp3",
                Groups = "Kakao"
            });

            data.Items.Add(new SoundData
            {
                Title = "Kakao Ns 09",
                FilePath = basePath + "Kakao Ns 09.mp3",
                Groups = "Kakao"
            });

            data.Items.Add(new SoundData
            {
                Title = "Kakao Ns 10",
                FilePath = basePath + "Kakao Ns 10.mp3",
                Groups = "Kakao"
            });

            data.Items.Add(new SoundData
            {
                Title = "Kakao Ns 05",
                FilePath = basePath + "Kakao Ns 05.mp3",
                Groups = "Kakao"
            });

            data.Items.Add(new SoundData
            {
                Title = "Kakao Call Ring",
                FilePath = basePath + "Kakao Call Ring.mp3",
                Groups = "Kakao"
            });

            data.Items.Add(new SoundData
            {
                Title = "Kakao Member Leave",
                FilePath = basePath + "Kakao Member Leave.mp3",
                Groups = "Kakao"
            });

            data.Items.Add(new SoundData
            {
                Title = "Kakao Member Join",
                FilePath = basePath + "Kakao Member Join.mp3",
                Groups = "Kakao"
            });

            data.Items.Add(new SoundData
            {
                Title = "Viber Activate Secondary",
                FilePath = basePath + "Viber Activate Secondary.mp3",
                Groups = "Viber"
            });

            data.Items.Add(new SoundData
            {
                Title = "Viber Incoming Bg",
                FilePath = basePath + "Viber Incoming Bg.mp3",
                Groups = "Viber"
            });

            data.Items.Add(new SoundData
            {
                Title = "Viber Incoming Fg",
                FilePath = basePath + "Viber Incoming Fg.mp3",
                Groups = "Viber"
            });

            data.Items.Add(new SoundData
            {
                Title = "Viber Send Sticker",
                FilePath = basePath + "Viber Send Sticker.mp3",
                Groups = "Viber"
            });

            data.Items.Add(new SoundData
            {
                Title = "Viber Transfer Confirm",
                FilePath = basePath + "Viber Transfer Confirm.mp3",
                Groups = "Viber"
            });

            data.Items.Add(new SoundData
            {
                Title = "Viber Transfer In",
                FilePath = basePath + "Viber Transfer In.mp3",
                Groups = "Viber"
            });

            data.Items.Add(new SoundData
            {
                Title = "Viber Ring",
                FilePath = basePath + "Viber Ring.mp3",
                Groups = "Viber"
            });

            data.Items.Add(new SoundData
            {
                Title = "QQ Classic",
                FilePath = basePath + "QQ Classic.mp3",
                Groups = "QQ"
            });

            data.Items.Add(new SoundData
            {
                Title = "QQ Close",
                FilePath = basePath + "QQ Close.mp3",
                Groups = "QQ"
            });


            data.Items.Add(new SoundData
            {
                Title = "QQ Incoming",
                FilePath = basePath + "QQ Incoming.mp3",
                Groups = "QQ"
            });

            data.Items.Add(new SoundData
            {
                Title = "QQ Office",
                FilePath = basePath + "QQ Office.mp3",
                Groups = "QQ"
            });



            data.Items.Add(new SoundData
            {
                Title = "QQ Request",
                FilePath = basePath + "QQ Request.mp3",
                Groups = "QQ"
            });



            data.Items.Add(new SoundData
            {
                Title = "Nimbuzz Incoming",
                FilePath = basePath + "Nimbuzz Incoming.mp3",
                Groups = "Nimbuzz"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nimbuzz Incoming Video",
                FilePath = basePath + "Nimbuzz Incommingvideo.mp3",
                Groups = "Nimbuzz"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nimbuzz Notification",
                FilePath = basePath + "Nimbuzz Notification.mp3",
                Groups = "Nimbuzz"
            });

            data.Items.Add(new SoundData
            {
                Title = "Tango Msg Sent",
                FilePath = basePath + "Tango Msg Sent.mp3",
                Groups = "Tango"
            });

            data.Items.Add(new SoundData
            {
                Title = "Tango New Msg",
                FilePath = basePath + "Tango New Msg.mp3",
                Groups = "Tango"
            });

            data.Items.Add(new SoundData
            {
                Title = "Tango Ringtone",
                FilePath = basePath + "Tango Ringtone.mp3",
                Groups = "Tango"
            });

            data.Items.Add(new SoundData
            {
                Title = "Tango Shake 2",
                FilePath = basePath + "Tango Shake 2.mp3",
                Groups = "Tango"
            });

            data.Items.Add(new SoundData
            {
                Title = "Tango Shake",
                FilePath = basePath + "Tango Shake.mp3",
                Groups = "Tango"
            });

            data.Items.Add(new SoundData
            {
                Title = "WeChat On",
                FilePath = basePath + "WeChat On.mp3",
                Groups = "WeChat"
            });

            data.Items.Add(new SoundData
            {
                Title = "WeChat Phone Ring",
                FilePath = basePath + "WeChat phonering.mp3",
                Groups = "WeChat"
            });

            data.Items.Add(new SoundData
            {
                Title = "WeChat Play End",
                FilePath = basePath + "WeChat playend.mp3",
                Groups = "WeChat"
            });

            data.Items.Add(new SoundData
            {
                Title = "ChatOn Error",
                FilePath = basePath + "ChatOn Error.mp3",
                Groups = "ChatOn"
            });

            data.Items.Add(new SoundData
            {
                Title = "ChatOn Glass",
                FilePath = basePath + "ChatOn Glass.mp3",
                Groups = "ChatOn"
            });

            data.Items.Add(new SoundData
            {
                Title = "ChatOn Horn",
                FilePath = basePath + "ChatOn Horn.mp3",
                Groups = "ChatOn"
            });

            data.Items.Add(new SoundData
            {
                Title = "ChatOn Melody",
                FilePath = basePath + "ChatOn Melody.mp3",
                Groups = "ChatOn"
            });

            data.Items.Add(new SoundData
            {
                Title = "ChatOn Piano",
                FilePath = basePath + "ChatOn Piano.mp3",
                Groups = "ChatOn"
            });

            data.Items.Add(new SoundData
            {
                Title = "Facebook Msgr Down",
                FilePath = basePath + "Facebook Msgr Down.mp3",
                Groups = "Facebook"
            });

            data.Items.Add(new SoundData
            {
                Title = "Facebook Msgr Growinig",
                FilePath = basePath + "Facebook Msgr Growinig.mp3",
                Groups = "Facebook"
            });

            data.Items.Add(new SoundData
            {
                Title = "Facebook Msgr incoming",
                FilePath = basePath + "Facebook Msgr incoming.mp3",
                Groups = "Facebook"
            });

            data.Items.Add(new SoundData
            {
                Title = "Facebook Msgr large",
                FilePath = basePath + "Facebook Msgr large.mp3",
                Groups = "Facebook"
            });

            data.Items.Add(new SoundData
            {
                Title = "Facebook Msgr medium",
                FilePath = basePath + "Facebook Msgr medium.mp3",
                Groups = "Facebook"
            });

            data.Items.Add(new SoundData
            {
                Title = "Facebook Msgr Message",
                FilePath = basePath + "Facebook Msgr Message.mp3",
                Groups = "Facebook"
            });

            data.Items.Add(new SoundData
            {
                Title = "Facebook Msgr Refresh",
                FilePath = basePath + "Facebook Msgr Refresh.mp3",
                Groups = "Facebook"
            });

            data.Items.Add(new SoundData
            {
                Title = "Facebook Msgr small",
                FilePath = basePath + "Facebook Msgr small.mp3",
                Groups = "Facebook"
            });

            data.Items.Add(new SoundData
            {
                Title = "Facebook Msgr Sticker In",
                FilePath = basePath + "Facebook Msgr Sticker In.mp3",
                Groups = "Facebook"
            });

            data.Items.Add(new SoundData
            {
                Title = "Facebook Msgr Sticker Out",
                FilePath = basePath + "Facebook Msgr Sticker Out.mp3",
                Groups = "Facebook"
            });

            data.Items.Add(new SoundData
            {
                Title = "Facebook Msgr timeout",
                FilePath = basePath + "Facebook Msgr timeout.mp3",
                Groups = "Facebook"
            });

            data.Items.Add(new SoundData
            {
                Title = "Facebook Msgr Typing",
                FilePath = basePath + "Facebook Msgr Typing.mp3",
                Groups = "Facebook"
            });

            data.Items.Add(new SoundData
            {
                Title = "Hike Messenger",
                FilePath = basePath + "Hike Messenger.mp3",
                Groups = "Hike"
            });

            data.Items.Add(new SoundData
            {
                Title = "IMO Beep",
                FilePath = basePath + "IMO beep.mp3",
                Groups = "IMO"
            });

            data.Items.Add(new SoundData
            {
                Title = "IMO",
                FilePath = basePath + "IMO.mp3",
                Groups = "IMO"
            });

            return data;
        }

        private SoundGroup CreateEntertainmentGroup()
        {
            SoundGroup data = new SoundGroup();
            data.Title = "Entertainment";
            string basePath = "assets/audio/Entertainment/";

            data.Items.Add(new SoundData
            {
                Title = "Fox News Alert",
                FilePath = basePath + "Fox News Alert.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "X-Files SMS",
                FilePath = basePath + "X-Files SMS.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "X-Files Ring Short",
                FilePath = basePath + "X-Files Ring Short.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "X-Files Ring",
                FilePath = basePath + "X-Files Ring.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "Breaking Bad SMS 1",
                FilePath = basePath + "Breaking Bad SMS 1.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "Breaking Bad SMS 2",
                FilePath = basePath + "Breaking Bad SMS 2.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "Breaking Bad Theme",
                FilePath = basePath + "Breaking Bad Theme.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "Pyscho",
                FilePath = basePath + "Pyscho.mp3",
                Groups = "Movies"
            });

            data.Items.Add(new SoundData
            {
                Title = "Bates Motel",
                FilePath = basePath + "Bates Motel.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "Law and Order",
                FilePath = basePath + "Law and Order.mp3",
                Groups = "Television"
            });


            data.Items.Add(new SoundData
            {
                Title = "ESPN da da da",
                FilePath = basePath + "ESPN da da da.mp3",
                Groups = "Sports"
            });

            data.Items.Add(new SoundData
            {
                Title = "ESPN MNF 1",
                FilePath = basePath + "ESPN MNF 1.mp3",
                Groups = "Sports"
            });

            data.Items.Add(new SoundData
            {
                Title = "ESPN MNF 2",
                FilePath = basePath + "ESPN MNF 2.mp3",
                Groups = "Sports"
            });

            data.Items.Add(new SoundData
            {
                Title = "ESPN NHL",
                FilePath = basePath + "ESPN NHL 1.mp3",
                Groups = "Sports"
            });

            data.Items.Add(new SoundData
            {
                Title = "ESPN NBA",
                FilePath = basePath + "ESPN NBA.mp3",
                Groups = "Sports"
            });

            data.Items.Add(new SoundData
            {
                Title = "ESPN Opening",
                FilePath = basePath + "ESPN Opening.mp3",
                Groups = "Sports"
            });

            data.Items.Add(new SoundData
            {
                Title = "A-Team SMS 1",
                FilePath = basePath + "A-Team SMS1.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "A-Team SMS 2",
                FilePath = basePath + "A-Team SMS2.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "A-Team SMS 3",
                FilePath = basePath + "A-Team SMS3.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "A-team SMS 4",
                FilePath = basePath + "A-team SMS4.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "Halloween",
                FilePath = basePath + "Halloween.mp3",
                Groups = "Movies"
            });

            data.Items.Add(new SoundData
            {
                Title = "Jason Friday the 13th",
                FilePath = basePath + "Jason Friday the 13th.mp3",
                Groups = "Movies"
            });

            data.Items.Add(new SoundData
            {
                Title = "The Rifleman",
                FilePath = basePath + "The Rifleman.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "Knight Ryder Short",
                FilePath = basePath + "Knight Ryder Short.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "Knight Ryder Ring",
                FilePath = basePath + "Knight Ryder Ring.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "Fox NFL 1",
                FilePath = basePath + "Fox NFL 1.mp3",
                Groups = "Sports"
            });

            data.Items.Add(new SoundData
            {
                Title = "Fox NFL 2",
                FilePath = basePath + "Fox NFL 2.mp3",
                Groups = "Sports"
            });

            data.Items.Add(new SoundData
            {
                Title = "Fox NFL 3",
                FilePath = basePath + "Fox NFL 3.mp3",
                Groups = "Sports"
            });


            data.Items.Add(new SoundData
            {
                Title = "Hannibal 1",
                FilePath = basePath + "Hannibal 1.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "Hannibal 2",
                FilePath = basePath + "Hannibal 2.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "Hannibal 3",
                FilePath = basePath + "Hannibal 3.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "Hannibal 4",
                FilePath = basePath + "Hannibal 4.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "Jetsons Car",
                FilePath = basePath + "Jetsons Car.mp3",
                Groups = "Cartoons"
            });

            data.Items.Add(new SoundData
            {
                Title = "Jetsons Doorbell",
                FilePath = basePath + "Jetsons Doorbell.mp3",
                Groups = "Cartoons"
            });

            data.Items.Add(new SoundData
            {
                Title = "Jetsons SMS",
                FilePath = basePath + "Jetsons SMS.mp3",
                Groups = "Cartoons"
            });

            data.Items.Add(new SoundData
            {
                Title = "Inception",
                FilePath = basePath + "Inception.mp3",
                Groups = "Movies"
            });

            data.Items.Add(new SoundData
            {
                Title = "Road Runner Meep 1",
                FilePath = basePath + "Road Runner Meep 1.mp3",
                Groups = "Cartoons"
            });

            data.Items.Add(new SoundData
            {
                Title = "Road Runner Meep 2",
                FilePath = basePath + "Road Runner Meep 2.mp3",
                Groups = "Cartoons"
            });

            data.Items.Add(new SoundData
            {
                Title = "Road Runner Tongue",
                FilePath = basePath + "Road Runner Tongue.mp3",
                Groups = "Cartoons"
            });

            data.Items.Add(new SoundData
            {
                Title = "Old Spice Whistle",
                FilePath = basePath + "Old Spice Whistle.mp3",
                Groups = "Commercials"
            });

            data.Items.Add(new SoundData
            {
                Title = "Star Trek Chirp",
                FilePath = basePath + "Star Trek Chirp.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "Star Trek Door Lift",
                FilePath = basePath + "Star Trek Door Lift.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "Star Trek Intercom",
                FilePath = basePath + "Star Trek Intercom.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "Transformers Scene Change",
                FilePath = basePath + "Transformers Scene Chg.mp3",
                Groups = "Cartoons"
            });

            data.Items.Add(new SoundData
            {
                Title = "Transformers Transform",
                FilePath = basePath + "Transformers Transform.mp3",
                Groups = "Cartoons"
            });

            data.Items.Add(new SoundData
            {
                Title = "24 CTU",
                FilePath = basePath + "24 CTU.mp3",
                Groups = "Television"
            });

            data.Items.Add(new SoundData
            {
                Title = "Willy Wonka  Flute",
                FilePath = basePath + "Willy Wonka  Flute.mp3",
                Groups = "Movies"
            });

            data.Items.Add(new SoundData
            {
                Title = "Tazmanian Spin",
                FilePath = basePath + "Tazmanian Spin.mp3",
                Groups = "Cartoons"
            });

            return data; 
            
                        
        }

        private SoundGroup CreateGamesMscGroup()
        {
            SoundGroup data = new SoundGroup();
            data.Title = "GamesMsc";
            string basePath = "assets/audio/GamesMsc/";

            data.Items.Add(new SoundData
            {
                Title = "SSgtBruskowiz TorchWoodv2",
                FilePath = basePath + "SSgtBruskowiz TorchWoodv2.mp3",
                Groups = "Miscellaneous"
            });

            data.Items.Add(new SoundData
            {
                Title = "SSgtBruskowiz Modern Ringtone",
                FilePath = basePath + "SSgtBruskowiz Modern Ringtone.mp3",
                Groups = "Miscellaneous"
            });


            data.Items.Add(new SoundData
            {
                Title = "Zelda Item 1",
                FilePath = basePath + "Zelda Item 1.mp3",
                Groups = "Video Games"
            });

            data.Items.Add(new SoundData
            {
                Title = "Zelda Item 2",
                FilePath = basePath + "Zelda Item 2.mp3",
                Groups = "Video Games"
            });

            data.Items.Add(new SoundData
            {
                Title = "Zelda Secret",
                FilePath = basePath + "Zelda Secret.mp3",
                Groups = "Video Games"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sonic 2 Check Point1",
                FilePath = basePath + "Sonic 2 Check Point 1.mp3",
                Groups = "Video Games"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sonic 2 Check Point2",
                FilePath = basePath + "Sonic 2 Check Point 2.mp3",
                Groups = "Video Games"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sonic Ring Effect",
                FilePath = basePath + "Sonic Ring Effect.mp3",
                Groups = "Video Games"
            });

            data.Items.Add(new SoundData
            {
                Title = "Splinter Cell Night Vision",
                FilePath = basePath + "Splinter Cell Night Vision.mp3",
                Groups = "Video Games"
            });


            data.Items.Add(new SoundData
            {
                Title = "Portal 2 Gun Blue",
                FilePath = basePath + "Portal 2 Gun Blue.mp3",
                Groups = "Video Games"
            });

            data.Items.Add(new SoundData
            {
                Title = "Portal 2 Gun Orange",
                FilePath = basePath + "Portal 2 Gun Orange.mp3",
                Groups = "Video Games"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Sweet",
                FilePath = basePath + "CandyCrush Sweet.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Devine",
                FilePath = basePath + "CandyCrush Devine.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Delicious",
                FilePath = basePath + "CandyCrush Delicious.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Tasty",
                FilePath = basePath + "CandyCrush Tasty.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Choc",
                FilePath = basePath + "CandyCrush Choc.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Color Bomb1",
                FilePath = basePath + "CandyCrush Color Bomb1.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Color Bomb2",
                FilePath = basePath + "CandyCrush Color Bomb2.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Fish 1",
                FilePath = basePath + "CandyCrush Fish 1.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Fish 2",
                FilePath = basePath + "CandyCrush Fish 2.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Flash",
                FilePath = basePath + "CandyCrush Flash.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Level Done",
                FilePath = basePath + "CandyCrush Level Done.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Level Fail",
                FilePath = basePath + "CandyCrush Level Fail.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Line Blast",
                FilePath = basePath + "CandyCrush Line Blast.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Nut",
                FilePath = basePath + "CandyCrush Nut.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Owl Freeze",
                FilePath = basePath + "CandyCrush Owl Freeze.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Square Remove",
                FilePath = basePath + "CandyCrush Square Remove.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Stripped",
                FilePath = basePath + "CandyCrush Stripped.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Super Color Bomb",
                FilePath = basePath + "CandyCrush Super Color Bomb.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Swoop In",
                FilePath = basePath + "CandyCrush Swoop In.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Swoop Out",
                FilePath = basePath + "CandyCrush Swoop Out.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Time Warn",
                FilePath = basePath + "CandyCrush Time Warn.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Tornado 1",
                FilePath = basePath + "CandyCrush Tornado 1.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Tornado 2",
                FilePath = basePath + "CandyCrush Tornado 2.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Tornado 3",
                FilePath = basePath + "CandyCrush Tornado 3.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Unlock",
                FilePath = basePath + "CandyCrush Unlock.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Wrapped",
                FilePath = basePath + "CandyCrush Wrapped.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Update",
                FilePath = basePath + "CandyCrush Update.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Candy Crush Swoosh",
                FilePath = basePath + "CandyCrush Swoosh.mp3",
                Groups = "Candy Crush"
            });

            data.Items.Add(new SoundData
            {
                Title = "Coin Drop",
                FilePath = basePath + "Coin Drop.mp3",
                Groups = "Miscellaneous"
            });


            data.Items.Add(new SoundData
            {
                Title = "Ringer",
                FilePath = basePath + "Ringer.mp3",
                Groups = "Miscellaneous"
            });

            data.Items.Add(new SoundData
            {
                Title = "Tada",
                FilePath = basePath + "Tada.mp3",
                Groups = "Miscellaneous"
            });

            data.Items.Add(new SoundData
            {
                Title = "Star Craft Chat",
                FilePath = basePath + "StarCraft Chat.mp3",
                Groups = "Video Games"
            });

            data.Items.Add(new SoundData
            {
                Title = "Star Craft Comm Beep",
                FilePath = basePath + "StarCraft Comm Beep.mp3",
                Groups = "Video Games"
            });

            data.Items.Add(new SoundData
            {
                Title = "Video On",
                FilePath = basePath + "Video On.mp3",
                Groups = "Miscellaneous"
            });

            data.Items.Add(new SoundData
            {
                Title = "Video Off",
                FilePath = basePath + "Video Off.mp3",
                Groups = "Miscellaneous"
            });

            data.Items.Add(new SoundData
            {
                Title = "Xbox Achievement",
                FilePath = basePath + "Xbox Achievement.mp3",
                Groups = "Consoles"
            });

            data.Items.Add(new SoundData
            {
                Title = "Gamecube Bootup",
                FilePath = basePath + "Gamecube Bootup.mp3",
                Groups = "Consoles"
            });

            data.Items.Add(new SoundData
            {
                Title = "Gamecube Bootup 34",
                FilePath = basePath + "Gamesube Bootup 34.mp3",
                Groups = "Consoles"
            });

            data.Items.Add(new SoundData
            {
                Title = "Half Life Sharp Fear",
                FilePath = basePath + "Half Life Sharp Fear.mp3",
                Groups = "Video Games"
            });

            data.Items.Add(new SoundData
            {
                Title = "Megaman Legends Get Item ",
                FilePath = basePath + "Megaman Legends Get Item .mp3",
                Groups = "Video Games"
            });

            data.Items.Add(new SoundData
            {
                Title = "Metal Gear Alert",
                FilePath = basePath + "Metal Gear Alert.mp3",
                Groups = "Video Games"
            });

            data.Items.Add(new SoundData
            {
                Title = "Portal 2 Button Positive",
                FilePath = basePath + "Portal 2 Button Positive.mp3",
                Groups = "Video Games"
            });

            data.Items.Add(new SoundData
            {
                Title = "Shakeup",
                FilePath = basePath + "Shakeup.mp3",
                Groups = "Miscellaneous"
            });


            return data;

            
        }

        private SoundGroup CreateAndroidGroup()
        {
            SoundGroup data = new SoundGroup();
            data.Title = "Cellular OS";
            string basePath = "assets/audio/Android/";

            data.Items.Add(new SoundData
            {
                Title = "Nokia 3D Effect 01",
                FilePath = basePath + "Nokia 3D Effect 01.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia 3D Effect 02",
                FilePath = basePath + "Nokia 3D Effect 02.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia 3D Effect 03",
                FilePath = basePath + "Nokia 3D Effect 03.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia 3D Effect 04",
                FilePath = basePath + "Nokia 3D Effect 04.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia 3D Effect 05",
                FilePath = basePath + "Nokia 3D Effect 05.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Alarm 02",
                FilePath = basePath + "Nokia Alarm 02.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Alarm 06",
                FilePath = basePath + "Nokia Alarm 06.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Alarm 07",
                FilePath = basePath + "Nokia Alarm 07.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Alarm 11",
                FilePath = basePath + "Nokia Alarm 11.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Alarm 17",
                FilePath = basePath + "Nokia Alarm 17.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Alarm 18",
                FilePath = basePath + "Nokia Alarm 18.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Alarm 20",
                FilePath = basePath + "Nokia Alarm 20.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Alarm 21",
                FilePath = basePath + "Nokia Alarm 21.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Amazement",
                FilePath = basePath + "Nokia Amazement.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Amethyst",
                FilePath = basePath + "Nokia Amethyst.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Applause",
                FilePath = basePath + "Nokia Applause.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Aquamarine",
                FilePath = basePath + "Nokia Aquamarine.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Bc110",
                FilePath = basePath + "Nokia Bc110.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Beep",
                FilePath = basePath + "Nokia Beep.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Bells",
                FilePath = basePath + "Nokia Bells.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Belly dance",
                FilePath = basePath + "Nokia Belly dance.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Bespoke",
                FilePath = basePath + "Nokia Bespoke.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Birdcall",
                FilePath = basePath + "Nokia Birdcall.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Birdsong",
                FilePath = basePath + "Nokia Birdsong.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Braindrenelin",
                FilePath = basePath + "Nokia Braindrenelin.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Breakage",
                FilePath = basePath + "Nokia Breakage.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Brightness",
                FilePath = basePath + "Nokia Brightness.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Bugler",
                FilePath = basePath + "Nokia Bugler.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Bullfrog",
                FilePath = basePath + "Nokia Bullfrog.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Bureau",
                FilePath = basePath + "Nokia Bureau.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Buzzer",
                FilePath = basePath + "Nokia Buzzer.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Cab",
                FilePath = basePath + "Nokia Cab.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Cackle",
                FilePath = basePath + "Nokia Cackle.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Cassiterite",
                FilePath = basePath + "Nokia Cassiterite.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Cavalier",
                FilePath = basePath + "Nokia Cavalier.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Clari",
                FilePath = basePath + "Nokia Clari.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Clerk",
                FilePath = basePath + "Nokia Clerk.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Clogged",
                FilePath = basePath + "Nokia Clogged.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Coin",
                FilePath = basePath + "Nokia Coin.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Crystal",
                FilePath = basePath + "Nokia Crystal.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Cubes",
                FilePath = basePath + "Nokia Cubes.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Cubicle",
                FilePath = basePath + "Nokia Cubicle.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Cycle",
                FilePath = basePath + "Nokia Cycle.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Dawning",
                FilePath = basePath + "Nokia Dawning.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Daydream",
                FilePath = basePath + "Nokia Daydream.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Delays",
                FilePath = basePath + "Nokia Delays.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Digital",
                FilePath = basePath + "Nokia Digital.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Ding",
                FilePath = basePath + "Nokia Ding.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Diplex",
                FilePath = basePath + "Nokia Diplex.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Door Knock",
                FilePath = basePath + "Nokia Door Knock.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Doughnut",
                FilePath = basePath + "Nokia Doughnut.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Drill",
                FilePath = basePath + "Nokia Drill.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Dynamic",
                FilePath = basePath + "Nokia Dynamic.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Echo",
                FilePath = basePath + "Nokia Echo.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Ecliptic",
                FilePath = basePath + "Nokia Ecliptic.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Electronic",
                FilePath = basePath + "Nokia Electronic.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Email alert 01",
                FilePath = basePath + "Nokia Email alert 01.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Email alert 02",
                FilePath = basePath + "Nokia Email alert 02.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Email alert 03",
                FilePath = basePath + "Nokia Email alert 03.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Email alert 04",
                FilePath = basePath + "Nokia Email alert 04.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Email alert 05",
                FilePath = basePath + "Nokia Email alert 05.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Email alert 06",
                FilePath = basePath + "Nokia Email alert 06.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Email alert 07",
                FilePath = basePath + "Nokia Email alert 07.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Email alert 08",
                FilePath = basePath + "Nokia Email alert 08.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Email alert 09",
                FilePath = basePath + "Nokia Email alert 09.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Emerald",
                FilePath = basePath + "Nokia Emerald.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Fete",
                FilePath = basePath + "Nokia Fete.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Fiesta",
                FilePath = basePath + "Nokia Fiesta.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Flight",
                FilePath = basePath + "Nokia Flight.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Flight H457",
                FilePath = basePath + "Nokia Flight H457.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Flurry",
                FilePath = basePath + "Nokia Flurry.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Fried",
                FilePath = basePath + "Nokia Fried.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Glider",
                FilePath = basePath + "Nokia Glider.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Grand Prix",
                FilePath = basePath + "Nokia Grand Prix.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Grapefruit",
                FilePath = basePath + "Nokia Grapefruit.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Grasshopper",
                FilePath = basePath + "Nokia Grasshopper.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Hawaii",
                FilePath = basePath + "Nokia Hawaii.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Heather",
                FilePath = basePath + "Nokia Heather.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Here",
                FilePath = basePath + "Nokia Here.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Imperial",
                FilePath = basePath + "Nokia Imperial.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Incoming",
                FilePath = basePath + "Nokia Incoming.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Jazz",
                FilePath = basePath + "Nokia Jazz.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Kaleidoscope",
                FilePath = basePath + "Nokia Kaleidoscope.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Kalimba",
                FilePath = basePath + "Nokia Kalimba.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Kiwi",
                FilePath = basePath + "Nokia Kiwi.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Klavier",
                FilePath = basePath + "Nokia Klavier.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Knock 2",
                FilePath = basePath + "Nokia Knock 2.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Laugh",
                FilePath = basePath + "Nokia Laugh.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Lime tree",
                FilePath = basePath + "Nokia Lime tree.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Locomotion",
                FilePath = basePath + "Nokia Locomotion.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Low",
                FilePath = basePath + "Nokia Low.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Low bell",
                FilePath = basePath + "Nokia Low bell.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Lumina",
                FilePath = basePath + "Nokia Lumina.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Main Alert",
                FilePath = basePath + "Nokia Main Alert.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Marbles",
                FilePath = basePath + "Nokia Marbles.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Marina",
                FilePath = basePath + "Nokia Marina.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Mashie",
                FilePath = basePath + "Nokia Mashie.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Mbit",
                FilePath = basePath + "Nokia Mbit.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Mellow",
                FilePath = basePath + "Nokia Mellow.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 01",
                FilePath = basePath + "Nokia Message 01.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 02",
                FilePath = basePath + "Nokia Message 02.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 03",
                FilePath = basePath + "Nokia Message 03.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 04",
                FilePath = basePath + "Nokia Message 04.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 05",
                FilePath = basePath + "Nokia Message 05.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 06",
                FilePath = basePath + "Nokia Message 06.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 07",
                FilePath = basePath + "Nokia Message 07.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 08",
                FilePath = basePath + "Nokia Message 08.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 09",
                FilePath = basePath + "Nokia Message 09.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 10",
                FilePath = basePath + "Nokia Message 10.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 11",
                FilePath = basePath + "Nokia Message 11.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 12",
                FilePath = basePath + "Nokia Message 12.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 13",
                FilePath = basePath + "Nokia Message 13.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 14",
                FilePath = basePath + "Nokia Message 14.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 15",
                FilePath = basePath + "Nokia Message 15.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 16",
                FilePath = basePath + "Nokia Message 16.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 17",
                FilePath = basePath + "Nokia Message 17.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 18",
                FilePath = basePath + "Nokia Message 18.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 19",
                FilePath = basePath + "Nokia Message 19.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 20",
                FilePath = basePath + "Nokia Message 20.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 21",
                FilePath = basePath + "Nokia Message 21.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 22",
                FilePath = basePath + "Nokia Message 22.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 23",
                FilePath = basePath + "Nokia Message 23.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 24",
                FilePath = basePath + "Nokia Message 24.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 25",
                FilePath = basePath + "Nokia Message 25.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 26",
                FilePath = basePath + "Nokia Message 26.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 27",
                FilePath = basePath + "Nokia Message 27.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 28",
                FilePath = basePath + "Nokia Message 28.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 29",
                FilePath = basePath + "Nokia Message 29.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 30",
                FilePath = basePath + "Nokia Message 30.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 31",
                FilePath = basePath + "Nokia Message 31.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 32",
                FilePath = basePath + "Nokia Message 32.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 33",
                FilePath = basePath + "Nokia Message 33.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 34",
                FilePath = basePath + "Nokia Message 34.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 35",
                FilePath = basePath + "Nokia Message 35.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 36",
                FilePath = basePath + "Nokia Message 36.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 37",
                FilePath = basePath + "Nokia Message 37.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 38",
                FilePath = basePath + "Nokia Message 38.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 39",
                FilePath = basePath + "Nokia Message 39.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 40",
                FilePath = basePath + "Nokia Message 40.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 41",
                FilePath = basePath + "Nokia Message 41.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 42",
                FilePath = basePath + "Nokia Message 42.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Message 43",
                FilePath = basePath + "Nokia Message 43.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Minima",
                FilePath = basePath + "Nokia Minima.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Monkey drum",
                FilePath = basePath + "Nokia Monkey drum.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Monocle",
                FilePath = basePath + "Nokia Monocle.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Mood",
                FilePath = basePath + "Nokia Mood.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Motorway",
                FilePath = basePath + "Nokia Motorway.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Theme Guitar short",
                FilePath = basePath + "Nokia Theme Guitar short.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia tune remix (Nokia 600 Tune)",
                FilePath = basePath + "Nokia tune remix (Nokia 600 Tune).mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia tune-8800",
                FilePath = basePath + "Nokia tune-8800.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia tune-8800 Saphire",
                FilePath = basePath + "Nokia tune-8800 Saphire.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia tune-OLD",
                FilePath = basePath + "Nokia tune-OLD.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Nostalgia",
                FilePath = basePath + "Nokia Nostalgia.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Opal",
                FilePath = basePath + "Nokia Opal.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Oscillation",
                FilePath = basePath + "Nokia Oscillation.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Peace",
                FilePath = basePath + "Nokia Peace.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Peal",
                FilePath = basePath + "Nokia Peal.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Peridot",
                FilePath = basePath + "Nokia Peridot.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Polaris",
                FilePath = basePath + "Nokia Polaris.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Polaris 2",
                FilePath = basePath + "Nokia Polaris 2.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Pong pong",
                FilePath = basePath + "Nokia Pong pong.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Princess",
                FilePath = basePath + "Nokia Princess.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Prowl",
                FilePath = basePath + "Nokia Prowl.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Quadratic",
                FilePath = basePath + "Nokia Quadratic.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Rattle",
                FilePath = basePath + "Nokia Rattle.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Reed",
                FilePath = basePath + "Nokia Reed.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Rides",
                FilePath = basePath + "Nokia Rides.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Ring ring",
                FilePath = basePath + "Nokia Ring ring.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Rooster",
                FilePath = basePath + "Nokia Rooster.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Ruby",
                FilePath = basePath + "Nokia Ruby.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Ryudegaul",
                FilePath = basePath + "Nokia Ryudegaul.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Sanukite",
                FilePath = basePath + "Nokia Sanukite.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Sapphire",
                FilePath = basePath + "Nokia Sapphire.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Shine",
                FilePath = basePath + "Nokia Shine.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Shore",
                FilePath = basePath + "Nokia Shore.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Signum",
                FilePath = basePath + "Nokia Signum.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Silk",
                FilePath = basePath + "Nokia Silk.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Sordino",
                FilePath = basePath + "Nokia Sordino.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Stack",
                FilePath = basePath + "Nokia Stack.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Startup tone",
                FilePath = basePath + "Nokia Startup tone.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Subtile",
                FilePath = basePath + "Nokia Subtile.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Synloop",
                FilePath = basePath + "Nokia Synloop.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Telegraph",
                FilePath = basePath + "Nokia Telegraph.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Tiger eye",
                FilePath = basePath + "Nokia Tiger eye.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Timer",
                FilePath = basePath + "Nokia Timer.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Tinker",
                FilePath = basePath + "Nokia Tinker.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Titanics",
                FilePath = basePath + "Nokia Titanics.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Topic",
                FilePath = basePath + "Nokia Topic.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Tourmaline",
                FilePath = basePath + "Nokia Tourmaline.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Turntablism",
                FilePath = basePath + "Nokia Turntablism.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Turquoise",
                FilePath = basePath + "Nokia Turquoise.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Wolf",
                FilePath = basePath + "Nokia Wolf.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Wood bell",
                FilePath = basePath + "Nokia Wood bell.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Xylophone",
                FilePath = basePath + "Nokia Xylophone.mp3",
                Groups = "Nokia"
            });

           
            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Polaris",
                FilePath = basePath + "Sony Xperia Z1 Polaris.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Pop",
                FilePath = basePath + "Sony Xperia Z1 Pop.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Ray",
                FilePath = basePath + "Sony Xperia Z1 Ray.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Reminder",
                FilePath = basePath + "Sony Xperia Z1 Reminder.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Signature",
                FilePath = basePath + "Sony Xperia Z1 Signature.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Soft_Bell",
                FilePath = basePath + "Sony Xperia Z1 Soft_Bell.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Synth_Chime",
                FilePath = basePath + "Sony Xperia Z1 Synth_Chime.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Tada",
                FilePath = basePath + "Sony Xperia Z1 Tada.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Tinkle",
                FilePath = basePath + "Sony Xperia Z1 Tinkle.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Tweeters",
                FilePath = basePath + "Sony Xperia Z1 Tweeters.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Whisper",
                FilePath = basePath + "Sony Xperia Z1 Whisper.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Allegro",
                FilePath = basePath + "Sony Xperia Z1 Allegro.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Ascensions",
                FilePath = basePath + "Sony Xperia Z1 Ascensions.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Bellatrix",
                FilePath = basePath + "Sony Xperia Z1 Bellatrix.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Climb",
                FilePath = basePath + "Sony Xperia Z1 Climb.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Climb_Up",
                FilePath = basePath + "Sony Xperia Z1 Climb_Up.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Cosmic",
                FilePath = basePath + "Sony Xperia Z1 Cosmic.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Cricket",
                FilePath = basePath + "Sony Xperia Z1 Cricket.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Deep",
                FilePath = basePath + "Sony Xperia Z1 Deep.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Deneb",
                FilePath = basePath + "Sony Xperia Z1 Deneb.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Dimension",
                FilePath = basePath + "Sony Xperia Z1 Dimension.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Drip",
                FilePath = basePath + "Sony Xperia Z1 Drip.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Excitement",
                FilePath = basePath + "Sony Xperia Z1 Excitement.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Exemplify",
                FilePath = basePath + "Sony Xperia Z1 Exemplify.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Happy",
                FilePath = basePath + "Sony Xperia Z1 Happy.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Harmonics",
                FilePath = basePath + "Sony Xperia Z1 Harmonics.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Iridium",
                FilePath = basePath + "Sony Xperia Z1 Iridium.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Luxury",
                FilePath = basePath + "Sony Xperia Z1 Luxury.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Message_Alert",
                FilePath = basePath + "Sony Xperia Z1 Message_Alert.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Moonbeam",
                FilePath = basePath + "Sony Xperia Z1 Moonbeam.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Notification",
                FilePath = basePath + "Sony Xperia Z1 Notification.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z1 Pizzicato",
                FilePath = basePath + "Sony Xperia Z1 Pizzicato.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Luxury",
                FilePath = basePath + "Sony Xperia Z2 Luxury.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Message_Alert",
                FilePath = basePath + "Sony Xperia Z2 Message_Alert.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Notification",
                FilePath = basePath + "Sony Xperia Z2 Notification.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Pizzicato",
                FilePath = basePath + "Sony Xperia Z2 Pizzicato.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Pop",
                FilePath = basePath + "Sony Xperia Z2 Pop.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Ray",
                FilePath = basePath + "Sony Xperia Z2 Ray.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Reminder",
                FilePath = basePath + "Sony Xperia Z2 Reminder.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Reveille",
                FilePath = basePath + "Sony Xperia Z2 Reveille.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Signature",
                FilePath = basePath + "Sony Xperia Z2 Signature.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Sirius",
                FilePath = basePath + "Sony Xperia Z2 Sirius.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Soft_Bell",
                FilePath = basePath + "Sony Xperia Z2 Soft_Bell.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Synth_Chime",
                FilePath = basePath + "Sony Xperia Z2 Synth_Chime.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Tinkle",
                FilePath = basePath + "Sony Xperia Z2 Tinkle.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Whisper",
                FilePath = basePath + "Sony Xperia Z2 Whisper.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Acoustic",
                FilePath = basePath + "Sony Xperia Z2 Acoustic.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Aldebaran",
                FilePath = basePath + "Sony Xperia Z2 Aldebaran.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Allegro",
                FilePath = basePath + "Sony Xperia Z2 Allegro.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Altair",
                FilePath = basePath + "Sony Xperia Z2 Altair.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Antares",
                FilePath = basePath + "Sony Xperia Z2 Antares.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Antimony",
                FilePath = basePath + "Sony Xperia Z2 Antimony.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Climb",
                FilePath = basePath + "Sony Xperia Z2 Climb.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Cosmic",
                FilePath = basePath + "Sony Xperia Z2 Cosmic.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Deep",
                FilePath = basePath + "Sony Xperia Z2 Deep.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Dimension",
                FilePath = basePath + "Sony Xperia Z2 Dimension.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Doink",
                FilePath = basePath + "Sony Xperia Z2 Doink.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Excitement",
                FilePath = basePath + "Sony Xperia Z2 Excitement.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Exemplify",
                FilePath = basePath + "Sony Xperia Z2 Exemplify.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Happy",
                FilePath = basePath + "Sony Xperia Z2 Happy.mp3",
                Groups = "Sony Xperia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Sony Xperia Z2 Harmonics",
                FilePath = basePath + "Sony Xperia Z2 Harmonics.mp3",
                Groups = "Sony Xperia"
            });


            data.Items.Add(new SoundData
            {
                Title = "LavaIris Andromeda",
                FilePath = basePath + "LavaIris Andromeda.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Aquila",
                FilePath = basePath + "LavaIris Aquila.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Backroad",
                FilePath = basePath + "LavaIris Backroad.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris BeatPlucker",
                FilePath = basePath + "LavaIris BeatPlucker.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris BentleyDubs",
                FilePath = basePath + "LavaIris BentleyDubs.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Big Easy",
                FilePath = basePath + "LavaIris Big Easy.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris BirdLoop",
                FilePath = basePath + "LavaIris BirdLoop.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Bollywood",
                FilePath = basePath + "LavaIris Bollywood.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris BussaMove",
                FilePath = basePath + "LavaIris BussaMove.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Cairo",
                FilePath = basePath + "LavaIris Cairo.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Canismajor",
                FilePath = basePath + "LavaIris Canismajor.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris CaribbeanIce",
                FilePath = basePath + "LavaIris CaribbeanIce.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Carina",
                FilePath = basePath + "LavaIris Carina.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Cassiopeia",
                FilePath = basePath + "LavaIris Cassiopeia.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Centaurus",
                FilePath = basePath + "LavaIris Centaurus.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Champagne Edition",
                FilePath = basePath + "LavaIris Champagne Edition.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Club Cubano",
                FilePath = basePath + "LavaIris Club Cubano.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris CrayonRock",
                FilePath = basePath + "LavaIris CrayonRock.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris CurveBall",
                FilePath = basePath + "LavaIris CurveBall.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Cygnus",
                FilePath = basePath + "LavaIris Cygnus.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris DancinFool",
                FilePath = basePath + "LavaIris DancinFool.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris DonMessWivIt",
                FilePath = basePath + "LavaIris DonMessWivIt.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Draco",
                FilePath = basePath + "LavaIris Draco.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Eastern Sky",
                FilePath = basePath + "LavaIris Eastern Sky.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Enter the Nexus",
                FilePath = basePath + "LavaIris Enter the Nexus.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Eridani",
                FilePath = basePath + "LavaIris Eridani.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris EtherShake",
                FilePath = basePath + "LavaIris EtherShake.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris FriendlyGhost",
                FilePath = basePath + "LavaIris FriendlyGhost.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Funk Yall",
                FilePath = basePath + "LavaIris Funk Yall.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris GameOverGuitar",
                FilePath = basePath + "LavaIris GameOverGuitar.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Gimme Mo Town",
                FilePath = basePath + "LavaIris Gimme Mo Town.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Girtab",
                FilePath = basePath + "LavaIris Girtab.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Glacial Groove",
                FilePath = basePath + "LavaIris Glacial Groove.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Growl",
                FilePath = basePath + "LavaIris Growl.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris HalfwayHome",
                FilePath = basePath + "LavaIris HalfwayHome.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris hydra",
                FilePath = basePath + "LavaIris hydra.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris InsertCoin",
                FilePath = basePath + "LavaIris InsertCoin.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris LoopyLounge",
                FilePath = basePath + "LavaIris LoopyLounge.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris LoveFlute",
                FilePath = basePath + "LavaIris LoveFlute.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Lyra",
                FilePath = basePath + "LavaIris Lyra.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Machina",
                FilePath = basePath + "LavaIris Machina.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris MidEvilJaunt",
                FilePath = basePath + "LavaIris MidEvilJaunt.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris MildlyAlarming",
                FilePath = basePath + "LavaIris MildlyAlarming.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Nairobi",
                FilePath = basePath + "LavaIris Nairobi.mp3",
                Groups = "LavaIris"
            });


            data.Items.Add(new SoundData
            {
                Title = "LavaIris NewPlayer",
                FilePath = basePath + "LavaIris NewPlayer.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris No Limits",
                FilePath = basePath + "LavaIris No Limits.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Noises1",
                FilePath = basePath + "LavaIris Noises1.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Noises2",
                FilePath = basePath + "LavaIris Noises2.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Noises3",
                FilePath = basePath + "LavaIris Noises3.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris OrganDub",
                FilePath = basePath + "LavaIris OrganDub.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Orion",
                FilePath = basePath + "LavaIris Orion.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Paradise Island",
                FilePath = basePath + "LavaIris Paradise Island.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Pegasus",
                FilePath = basePath + "LavaIris Pegasus.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Perseus",
                FilePath = basePath + "LavaIris Perseus.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Playa",
                FilePath = basePath + "LavaIris Playa.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Revelation",
                FilePath = basePath + "LavaIris Revelation.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Rigel",
                FilePath = basePath + "LavaIris Rigel.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Ring Classic 02",
                FilePath = basePath + "LavaIris Ring Classic 02.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Ring Digital 02",
                FilePath = basePath + "LavaIris Ring Digital 02.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Ring Synth 02",
                FilePath = basePath + "LavaIris Ring Synth 02.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Ring Synth 04",
                FilePath = basePath + "LavaIris Ring Synth 04.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Road Trip",
                FilePath = basePath + "LavaIris Road Trip.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Romancing the tone",
                FilePath = basePath + "LavaIris Romancingthetone.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Safari",
                FilePath = basePath + "LavaIris Safari.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Savannah",
                FilePath = basePath + "LavaIris Savannah.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Scarabaeus",
                FilePath = basePath + "LavaIris Scarabaeus.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Seville",
                FilePath = basePath + "LavaIris Seville.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Shes All That",
                FilePath = basePath + "LavaIris Shes All That.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Silkyway",
                FilePath = basePath + "LavaIris Silkyway.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Sitarvssitar",
                FilePath = basePath + "LavaIris Sitarvssitar.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Solarium",
                FilePath = basePath + "LavaIris Solarium.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Springyjalopy",
                FilePath = basePath + "LavaIris Springyjalopy.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Steppin Out",
                FilePath = basePath + "LavaIris Steppin Out.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Terminated",
                FilePath = basePath + "LavaIris Terminated.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Testudo",
                FilePath = basePath + "LavaIris Testudo.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Third Eye",
                FilePath = basePath + "LavaIris Third Eye.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Thunderfoot",
                FilePath = basePath + "LavaIris Thunderfoot.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Twirlaway",
                FilePath = basePath + "LavaIris Twirlaway.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Veryalarmed",
                FilePath = basePath + "LavaIris Veryalarmed.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Vespa",
                FilePath = basePath + "LavaIris Vespa.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris World",
                FilePath = basePath + "LavaIris World.mp3",
                Groups = "LavaIris"
            });

            data.Items.Add(new SoundData
            {
                Title = "LavaIris Zeta",
                FilePath = basePath + "LavaIris Zeta.mp3",
                Groups = "LavaIris"
            });


            data.Items.Add(new SoundData
            {
                Title = "iPhone Aurora",
                FilePath = basePath + "Aurora.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Bamboo",
                FilePath = basePath + "Bamboo.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Chord",
                FilePath = basePath + "Chord.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Circles",
                FilePath = basePath + "Circles.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Complete",
                FilePath = basePath + "Complete.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Hello",
                FilePath = basePath + "Hello.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Input",
                FilePath = basePath + "Input.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Keys",
                FilePath = basePath + "Keys.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Note",
                FilePath = basePath + "Note.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Popcorn",
                FilePath = basePath + "Popcorn.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Pulse",
                FilePath = basePath + "Pulse.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Synth",
                FilePath = basePath + "Synth.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Apex",
                FilePath = basePath + "Apex.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Bulletin",
                FilePath = basePath + "Bulletin.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone By The Seaside",
                FilePath = basePath + "By The Seaside.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Chimes",
                FilePath = basePath + "Chimes.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Circuit",
                FilePath = basePath + "Circuit.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Constellation",
                FilePath = basePath + "Constellation.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Cosmic",
                FilePath = basePath + "Cosmic.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Crystals",
                FilePath = basePath + "Crystals.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Hillside",
                FilePath = basePath + "Hillside.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Illuminate",
                FilePath = basePath + "Illuminate.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Night Owl",
                FilePath = basePath + "Night Owl.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Opening",
                FilePath = basePath + "Opening.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Playtime",
                FilePath = basePath + "Playtime.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Presto",
                FilePath = basePath + "Presto.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Radar",
                FilePath = basePath + "Radar.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Radiate",
                FilePath = basePath + "Radiate.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Ripples",
                FilePath = basePath + "Ripples.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Sencha",
                FilePath = basePath + "Sencha.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Signal",
                FilePath = basePath + "Signal.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Silk",
                FilePath = basePath + "Silk.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Slow Rise",
                FilePath = basePath + "Slow Rise.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Stargaze",
                FilePath = basePath + "Stargaze.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Summit",
                FilePath = basePath + "Summit.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Twinkle",
                FilePath = basePath + "Twinkle.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Uplift",
                FilePath = basePath + "Uplift.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Waves",
                FilePath = basePath + "Waves.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Alarm",
                FilePath = basePath + "iPhone Alarm.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "iPhone Marimba",
                FilePath = basePath + "iPhone Marimba.mp3",
                Groups = "iPhone"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Tune from Star Trek 1",
                FilePath = basePath + "Nokia Tune from Star Trek 1.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "WinMobile Ring",
                FilePath = basePath + "WinMobile Ring.mp3",
                Groups = "WinMobile"
            });


            data.Items.Add(new SoundData
            {
                Title = "BlackBerry 3Beeps",
                FilePath = basePath + "BlackBerry 3Beeps.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry 3Bells",
                FilePath = basePath + "BlackBerry 3Bells.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Action",
                FilePath = basePath + "BlackBerry Action.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Adventurous",
                FilePath = basePath + "BlackBerry Adventurous.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Alarm EarlyRiser",
                FilePath = basePath + "BlackBerry Alarm EarlyRiser.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Antelope",
                FilePath = basePath + "BlackBerry Antelope.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Aspiration",
                FilePath = basePath + "BlackBerry Aspiration.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Assured",
                FilePath = basePath + "BlackBerry Assured.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Astute",
                FilePath = basePath + "BlackBerry Astute.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Attentive",
                FilePath = basePath + "BlackBerry Attentive.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Balance",
                FilePath = basePath + "BlackBerry Balance.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry ClassicPhoneRemix",
                FilePath = basePath + "BlackBerry ClassicPhoneRemix.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Confidence",
                FilePath = basePath + "BlackBerry Confidence.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry ConfirmRemix",
                FilePath = basePath + "BlackBerry ConfirmRemix.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Considerate",
                FilePath = basePath + "BlackBerry Considerate.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry ContentmentRemix",
                FilePath = basePath + "BlackBerry ContentmentRemix.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry EagerRemix",
                FilePath = basePath + "BlackBerry EagerRemix.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry LightSpeedRemix",
                FilePath = basePath + "BlackBerry LightSpeedRemix.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry MentalNote",
                FilePath = basePath + "BlackBerry MentalNote.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry 2Loud",
                FilePath = basePath + "BlackBerry 2Loud.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry BBpro 5",
                FilePath = basePath + "BlackBerry BBpro 5.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry BBpro 6",
                FilePath = basePath + "BlackBerry BBpro 6.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry BikeBell",
                FilePath = basePath + "BlackBerry BikeBell.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Caffeine",
                FilePath = basePath + "BlackBerry Caffeine.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry ChiGong",
                FilePath = basePath + "BlackBerry ChiGong.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Contentment",
                FilePath = basePath + "BlackBerry Contentment.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Dimples",
                FilePath = basePath + "BlackBerry Dimples.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Eager",
                FilePath = basePath + "BlackBerry Eager.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Greeter",
                FilePath = basePath + "BlackBerry Greeter.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry LightSpeed",
                FilePath = basePath + "BlackBerry LightSpeed.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Lucid",
                FilePath = basePath + "BlackBerry Lucid.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Ninja",
                FilePath = basePath + "BlackBerry Ninja.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Sonar",
                FilePath = basePath + "BlackBerry Sonar.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry StarPortal",
                FilePath = basePath + "BlackBerry StarPortal.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry UFO",
                FilePath = basePath + "BlackBerry UFO.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Novel",
                FilePath = basePath + "BlackBerry Novel.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Prompt",
                FilePath = basePath + "BlackBerry Prompt.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Pursuit",
                FilePath = basePath + "BlackBerry Pursuit.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Revelation",
                FilePath = basePath + "BlackBerry Revelation.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry BBpro 1",
                FilePath = basePath + "BlackBerry BBpro 1.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry BBpro 2",
                FilePath = basePath + "BlackBerry BBpro 2.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry BBpro 3",
                FilePath = basePath + "BlackBerry BBpro 3.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry BBpro 4",
                FilePath = basePath + "BlackBerry BBpro 4.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Sanguine Remix",
                FilePath = basePath + "BlackBerry SanguineRemix.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Shimmer",
                FilePath = basePath + "BlackBerry Shimmer.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Spirit 2",
                FilePath = basePath + "BlackBerry Spirit 2.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Sunrise",
                FilePath = basePath + "BlackBerry Sunrise.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Texture",
                FilePath = basePath + "BlackBerry Texture.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Urgent1",
                FilePath = basePath + "BlackBerry Urgent1.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry Urgent2",
                FilePath = basePath + "BlackBerry Urgent2.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "BlackBerry ZenSpirit 2",
                FilePath = basePath + "BlackBerry ZenSpirit 2.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Clean",
                FilePath = basePath + "Blackberry Clean.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Crisp",
                FilePath = basePath + "Blackberry Crisp.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Essential",
                FilePath = basePath + "Blackberry Essential.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Message Bright",
                FilePath = basePath + "Blackberry Message Bright.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Message Confident",
                FilePath = basePath + "Blackberry Message Confident.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Message Warm",
                FilePath = basePath + "Blackberry Message Warm.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Open",
                FilePath = basePath + "Blackberry Open.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Present",
                FilePath = basePath + "Blackberry Present.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Radiant",
                FilePath = basePath + "Blackberry Radiant.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Reminder Active",
                FilePath = basePath + "Blackberry Reminder Active.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Reminder Immiedate",
                FilePath = basePath + "Blackberry Reminder Immiedate.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Reminder Tranquil",
                FilePath = basePath + "Blackberry Reminder Tranquil.mp3",
                Groups = "Blackberry"
            });

            data.Items.Add(new SoundData
            {
                Title = "Blackberry Smooth",
                FilePath = basePath + "Blackberry Smooth.mp3",
                Groups = "Blackberry"
            });


            data.Items.Add(new SoundData
            {
                Title = "Micromax Dialing Max",
                FilePath = basePath + "Micromax Dialing Max.mp3",
                Groups = "MicroMax"
            });

            data.Items.Add(new SoundData
            {
                Title = "Micromax Dreaming",
                FilePath = basePath + "Micromax Dreaming.mp3",
                Groups = "MicroMax"
            });

            data.Items.Add(new SoundData
            {
                Title = "Micromax Funky Arabia",
                FilePath = basePath + "Micromax Funky Arabia.mp3",
                Groups = "MicroMax"
            });

            data.Items.Add(new SoundData
            {
                Title = "Micromax Gated Euro",
                FilePath = basePath + "Micromax Gated Euro.mp3",
                Groups = "MicroMax"
            });

            data.Items.Add(new SoundData
            {
                Title = "Micromax Latino Tarintino",
                FilePath = basePath + "Micromax Latino Tarintino.mp3",
                Groups = "MicroMax"
            });

            data.Items.Add(new SoundData
            {
                Title = "Micromax MidTempo Funk",
                FilePath = basePath + "Micromax MidTempo Funk.mp3",
                Groups = "MicroMax"
            });

            data.Items.Add(new SoundData
            {
                Title = "Micromax Open Arms",
                FilePath = basePath + "Micromax Open Arms.mp3",
                Groups = "MicroMax"
            });

            data.Items.Add(new SoundData
            {
                Title = "Micromax Tango In Love",
                FilePath = basePath + "Micromax Tango In Love.mp3",
                Groups = "MicroMax"
            });

            data.Items.Add(new SoundData
            {
                Title = "Micromax Those Were The Days",
                FilePath = basePath + "Micromax Those Were The Days.mp3",
                Groups = "MicroMax"
            });

            data.Items.Add(new SoundData
            {
                Title = "Oppo Find 5  1",
                FilePath = basePath + "Oppo Find 5  1.mp3",
                Groups = "Oppo Find 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Oppo Find 5  2",
                FilePath = basePath + "Oppo Find 5  2.mp3",
                Groups = "Oppo Find 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Oppo Find 5  3",
                FilePath = basePath + "Oppo Find 5  3.mp3",
                Groups = "Oppo Find 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Oppo Find 5  4",
                FilePath = basePath + "Oppo Find 5  4.mp3",
                Groups = "Oppo Find 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Oppo Find 5  5",
                FilePath = basePath + "Oppo Find 5  5.mp3",
                Groups = "Oppo Find 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Oppo Find 5  6",
                FilePath = basePath + "Oppo Find 5  6.mp3",
                Groups = "Oppo Find 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Oppo Find 5  7",
                FilePath = basePath + "Oppo Find 5  7.mp3",
                Groups = "Oppo Find 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Oppo Find 5  8",
                FilePath = basePath + "Oppo Find 5  8.mp3",
                Groups = "Oppo Find 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Oppo Find 5  9",
                FilePath = basePath + "Oppo Find 5  9.mp3",
                Groups = "Oppo Find 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Oppo Find 5  10",
                FilePath = basePath + "Oppo Find 5  10.mp3",
                Groups = "Oppo Find 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Tune 1999",
                FilePath = basePath + "Nokia Tune 1999.mp3",

                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Tune 2000",
                FilePath = basePath + "Nokia Tune 2000.mp3",

                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Tune 2002",
                FilePath = basePath + "Nokia Tune 2002.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Tune 2003",
                FilePath = basePath + "Nokia Tune 2003.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Tune 2005",
                FilePath = basePath + "Nokia Tune 2005.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Tune 2007",
                FilePath = basePath + "Nokia Tune 2007.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Tune 2010",
                FilePath = basePath + "Nokia Tune 2010.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Tune 2013",
                FilePath = basePath + "Nokia Tune 2013.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Americano",
                FilePath = basePath + "Nokia Americano.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Appointment",
                FilePath = basePath + "Nokia Appointment.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Archimedes",
                FilePath = basePath + "Nokia Archimedes.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Ball",
                FilePath = basePath + "Nokia Ball.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Diamond",
                FilePath = basePath + "Nokia Diamond.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Glass",
                FilePath = basePath + "Nokia Glass.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Hazel",
                FilePath = basePath + "Nokia Hazel.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Knock",
                FilePath = basePath + "Nokia Knock.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Minutes",
                FilePath = basePath + "Nokia Minutes.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Neo",
                FilePath = basePath + "Nokia Neo.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Pear",
                FilePath = basePath + "Nokia Pear.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Pouch",
                FilePath = basePath + "Nokia Pouch.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Reservation",
                FilePath = basePath + "Nokia Reservation.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Sauna",
                FilePath = basePath + "Nokia Sauna.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nokia Signature",
                FilePath = basePath + "Nokia Signature.mp3",
                Groups = "Nokia"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nexus 5 Rhea",
                FilePath = basePath + "Nexus 5 Rhea.mp3", 
                   Groups= "Nexus 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nexus 5 Salacia",
                FilePath = basePath + "Nexus 5 Salacia.mp3", 
                   Groups= "Nexus 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nexus 5 Tethys",
                FilePath = basePath + "Nexus 5 Tethys.mp3", 
                   Groups= "Nexus 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nexus 5 Titan",
                FilePath = basePath + "Nexus 5 Titan.mp3", 
                   Groups= "Nexus 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Adara",
                FilePath = basePath + "Cyanogen Mod  Adara.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Alya",
                FilePath = basePath + "Cyanogen Mod  Alya.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Arcturus",
                FilePath = basePath + "Cyanogen Mod  Arcturus.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Blip",
                FilePath = basePath + "Cyanogen Mod  Blip.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Capella",
                FilePath = basePath + "Cyanogen Mod  Capella.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  CetiAlpha",
                FilePath = basePath + "Cyanogen Mod  CetiAlpha.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Chime",
                FilePath = basePath + "Cyanogen Mod  Chime.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Clear",
                FilePath = basePath + "Cyanogen Mod  Clear.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Element",
                FilePath = basePath + "Cyanogen Mod  Element.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Hojus",
                FilePath = basePath + "Cyanogen Mod  Hojus.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Mira",
                FilePath = basePath + "Cyanogen Mod  Mira.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Natural",
                FilePath = basePath + "Cyanogen Mod  Natural.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Ping",
                FilePath = basePath + "Cyanogen Mod  Ping.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Pluck",
                FilePath = basePath + "Cyanogen Mod  Pluck.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Pollux",
                FilePath = basePath + "Cyanogen Mod  Pollux.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Procyon",
                FilePath = basePath + "Cyanogen Mod  Procyon.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Shaula",
                FilePath = basePath + "Cyanogen Mod  Shaula.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Spica",
                FilePath = basePath + "Cyanogen Mod  Spica.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Syrma",
                FilePath = basePath + "Cyanogen Mod  Syrma.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Talitha",
                FilePath = basePath + "Cyanogen Mod  Talitha.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Tejat",
                FilePath = basePath + "Cyanogen Mod  Tejat.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Unfold",
                FilePath = basePath + "Cyanogen Mod  Unfold.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod  Vega",
                FilePath = basePath + "Cyanogen Mod  Vega.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Aldebaran",
                FilePath = basePath + "Cyanogen Mod Aldebaran.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Altair",
                FilePath = basePath + "Cyanogen Mod Altair.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Amsterdam",
                FilePath = basePath + "Cyanogen Mod Amsterdam.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Antares",
                FilePath = basePath + "Cyanogen Mod Antares.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Antimony",
                FilePath = basePath + "Cyanogen Mod Antimony.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Argon",
                FilePath = basePath + "Cyanogen Mod Argon.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod berring",
                FilePath = basePath + "Cyanogen Mod berring.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Beryllium",
                FilePath = basePath + "Cyanogen Mod Beryllium.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Betelgeuse",
                FilePath = basePath + "Cyanogen Mod Betelgeuse.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Canopus",
                FilePath = basePath + "Cyanogen Mod Canopus.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Castor",
                FilePath = basePath + "Cyanogen Mod Castor.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Cobalt",
                FilePath = basePath + "Cyanogen Mod Cobalt.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod CyanMail",
                FilePath = basePath + "Cyanogen Mod CyanMail.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod CyanMessage",
                FilePath = basePath + "Cyanogen Mod CyanMessage.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod CyanPing",
                FilePath = basePath + "Cyanogen Mod CyanPing.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod DearDeer",
                FilePath = basePath + "Cyanogen Mod DearDeer.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Doink",
                FilePath = basePath + "Cyanogen Mod Doink.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod DontPanic",
                FilePath = basePath + "Cyanogen Mod DontPanic.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Electra",
                FilePath = basePath + "Cyanogen Mod Electra.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Fluorine",
                FilePath = basePath + "Cyanogen Mod Fluorine.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Fomalhaut",
                FilePath = basePath + "Cyanogen Mod Fomalhaut.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Gallium",
                FilePath = basePath + "Cyanogen Mod Gallium.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod glockenspiel",
                FilePath = basePath + "Cyanogen Mod glockenspiel.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Helium",
                FilePath = basePath + "Cyanogen Mod Helium.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Hello",
                FilePath = basePath + "Cyanogen Mod Hello.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Iridium",
                FilePath = basePath + "Cyanogen Mod Iridium.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Ivory",
                FilePath = basePath + "Cyanogen Mod Ivory.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Krypton",
                FilePath = basePath + "Cyanogen Mod Krypton.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod KzurbSonar",
                FilePath = basePath + "Cyanogen Mod KzurbSonar.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Laser",
                FilePath = basePath + "Cyanogen Mod Laser.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Mallet",
                FilePath = basePath + "Cyanogen Mod Mallet.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Merope",
                FilePath = basePath + "Cyanogen Mod Merope.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Modular",
                FilePath = basePath + "Cyanogen Mod Modular.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Momentum",
                FilePath = basePath + "Cyanogen Mod Momentum.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Naughty",
                FilePath = basePath + "Cyanogen Mod Naughty.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Organic",
                FilePath = basePath + "Cyanogen Mod Organic.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Palladium",
                FilePath = basePath + "Cyanogen Mod Palladium.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Polaris",
                FilePath = basePath + "Cyanogen Mod Polaris.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Pong",
                FilePath = basePath + "Cyanogen Mod Pong.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Positive",
                FilePath = basePath + "Cyanogen Mod Positive.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Proxima",
                FilePath = basePath + "Cyanogen Mod Proxima.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Rain_Drops",
                FilePath = basePath + "Cyanogen Mod Rain_Drops.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Rang",
                FilePath = basePath + "Cyanogen Mod Rang.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Regulus",
                FilePath = basePath + "Cyanogen Mod Regulus.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Rhodes",
                FilePath = basePath + "Cyanogen Mod Rhodes.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Rubidium",
                FilePath = basePath + "Cyanogen Mod Rubidium.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Selenium",
                FilePath = basePath + "Cyanogen Mod Selenium.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Sirius",
                FilePath = basePath + "Cyanogen Mod Sirius.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Stone",
                FilePath = basePath + "Cyanogen Mod Stone.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Strontium",
                FilePath = basePath + "Cyanogen Mod Strontium.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod taptastic",
                FilePath = basePath + "Cyanogen Mod taptastic.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Thallium",
                FilePath = basePath + "Cyanogen Mod Thallium.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Upsilon",
                FilePath = basePath + "Cyanogen Mod Upsilon.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Voila",
                FilePath = basePath + "Cyanogen Mod Voila.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Cyanogen Mod Xenon",
                FilePath = basePath + "Cyanogen Mod Xenon.mp3", 
                   Groups= "Cyanogen Mod"
            });

            data.Items.Add(new SoundData
            {
                Title = "Motorola Moto Moto",
                FilePath = basePath + "Motorola Moto Moto.mp3", 
                   Groups= "Motorolla"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nexus 5 Ariel",
                FilePath = basePath + "Nexus 5 Ariel.mp3", 
                   Groups= "Nexus 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nexus 5 Carme",
                FilePath = basePath + "Nexus 5 Carme.mp3", 
                   Groups= "Nexus 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nexus 5 Ceres",
                FilePath = basePath + "Nexus 5 Ceres.mp3", 
                   Groups= "Nexus 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nexus 5 Elara",
                FilePath = basePath + "Nexus 5 Elara.mp3", 
                   Groups= "Nexus 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nexus 5 Europa",
                FilePath = basePath + "Nexus 5 Europa.mp3", 
                   Groups= "Nexus 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nexus 5 Iapetus",
                FilePath = basePath + "Nexus 5 Iapetus.mp3", 
                   Groups= "Nexus 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Nexus 5 Io",
                FilePath = basePath + "Nexus 5 Io.mp3", 
                   Groups= "Nexus 5"
            });

            data.Items.Add(new SoundData
            {
                Title = "Android Beat Box",
                FilePath = basePath + "Android Beat Box.mp3", 
                   Groups= "Droid"
            });

            data.Items.Add(new SoundData
            {
                Title = "Droid",
                FilePath = basePath + "Droid.mp3", 
                   Groups= "Droid"
            });

            data.Items.Add(new SoundData
            {
                Title = "Droid X2 Alert",
                FilePath = basePath + "Droid X2 Alert.mp3", 
                   Groups= "Droid"
            });

            data.Items.Add(new SoundData
            {
                Title = "Droid F1 Missed Call",
                FilePath = basePath + "Droid F1 Missed Call.mp3", 
                   Groups= "Droid"
            });

            data.Items.Add(new SoundData
            {
                Title = "Droid F1 New MMS",
                FilePath = basePath + "Droid F1 New MMS.mp3", 
                   Groups= "Droid"
            });

            data.Items.Add(new SoundData
            {
                Title = "Droid F1 New SMS",
                FilePath = basePath + "Droid F1 New SMS.mp3", 
                   Groups= "Droid"
            });

            data.Items.Add(new SoundData
            {
                Title = "Droid On the Hunt",
                FilePath = basePath + "Droid On the Hunt.mp3", 
                   Groups= "Droid"
            });

            data.Items.Add(new SoundData
            {
                Title = "Droid Alchemy",
                FilePath = basePath + "Droid Alchemy.mp3", 
                   Groups= "Droid"
            });

            data.Items.Add(new SoundData
            {
                Title = "Droid Tada",
                FilePath = basePath + "Droid Tada.mp3", 
                   Groups= "Droid"
            });

            data.Items.Add(new SoundData
            {
                Title = "Droid Tinkerbell",
                FilePath = basePath + "Droid Tinkerbell.mp3", 
                   Groups= "Droid"
            });

            data.Items.Add(new SoundData
            {
                Title = "Droid Tweeters",
                FilePath = basePath + "Droid Tweeters.mp3", 
                   Groups= "Droid"
            });

            data.Items.Add(new SoundData
            {
                Title = "Droid Pixiedust",
                FilePath = basePath + "Droid Pixiedust.mp3", 
                   Groups= "Droid"
            });

            data.Items.Add(new SoundData
            {
                Title = "Droid Highwire",
                FilePath = basePath + "Droid Highwire.mp3", 
                   Groups= "Droid"
            });

            data.Items.Add(new SoundData
            {
                Title = "Droid Heaven",
                FilePath = basePath + "Droid Heaven.mp3", 
                   Groups= "Droid"
            });

            data.Items.Add(new SoundData
            {
                Title = "Droid Caffeine Snake",
                FilePath = basePath + "Droid Caffeine Snake.mp3", 
                   Groups= "Droid"
            });

            data.Items.Add(new SoundData
            {
                Title = "Galaxy S5 Whistle",
                FilePath = basePath + "Galaxy S5 Whistle.mp3", 
                   Groups= "Samsung Galaxy"
            });

            data.Items.Add(new SoundData
            {
                Title = "Galaxy S5 Harp",
                FilePath = basePath + "Galaxy S5 Harp.mp3", 
                   Groups= "Samsung Galaxy"
            });

            data.Items.Add(new SoundData
            {
                Title = "Galaxy S5 Bubbles",
                FilePath = basePath + "Galaxy S5 Bubbles.mp3", 
                   Groups= "Samsung Galaxy"
            });

            data.Items.Add(new SoundData
            {
                Title = "Galaxy S5 Chirps",
                FilePath = basePath + "Galaxy S5 Chirps.mp3", 
                   Groups= "Samsung Galaxy"
            });

            data.Items.Add(new SoundData
            {
                Title = "Galaxy S5 Dew Drops",
                FilePath = basePath + "Galaxy S5 Dew Drops.mp3", 
                   Groups= "Samsung Galaxy"
            });

            data.Items.Add(new SoundData
            {
                Title = "Galaxy S5 Goodnews",
                FilePath = basePath + "Galaxy S5 Goodnews.mp3", 
                   Groups= "Samsung Galaxy"
            });

            data.Items.Add(new SoundData
            {
                Title = "Galaxy S5 Harmonics",
                FilePath = basePath + "Galaxy S5 Harmonics.mp3", 
                   Groups= "Samsung Galaxy"
            });

            data.Items.Add(new SoundData
            {
                Title = "Galaxy S5 Knock",
                FilePath = basePath + "Galaxy S5 Knock.mp3", 
                   Groups= "Samsung Galaxy"
            });

            data.Items.Add(new SoundData
            {
                Title = "Galaxy S5 On Time",
                FilePath = basePath + "Galaxy S5 On Time.mp3", 
                   Groups= "Samsung Galaxy"
            });

            data.Items.Add(new SoundData
            {
                Title = "Galaxy S5 Opener",
                FilePath = basePath + "Galaxy S5 Opener.mp3", 
                   Groups= "Samsung Galaxy"
            });

            data.Items.Add(new SoundData
            {
                Title = "Galaxy S5 Postman",
                FilePath = basePath + "Galaxy S5 Postman.mp3", 
                   Groups= "Samsung Galaxy"
            });

            data.Items.Add(new SoundData
            {
                Title = "Galaxy S5 Pure Bell",
                FilePath = basePath + "Galaxy S5 Pure Bell.mp3", 
                   Groups= "Samsung Galaxy"
            });

            data.Items.Add(new SoundData
            {
                Title = "Galaxy S5 Temple Bell",
                FilePath = basePath + "Galaxy S5 Temple Bell.mp3", 
                   Groups= "Samsung Galaxy"
            });

            data.Items.Add(new SoundData
            {
                Title = "Galaxy S5 Tickety Tock",
                FilePath = basePath + "Galaxy S5 Tickety Tock.mp3", 
                   Groups= "Samsung Galaxy"
            });

            data.Items.Add(new SoundData
            {
                Title = "Galaxy S5 Sweet Favour",
                FilePath = basePath + "Galaxy S5 Sweet Favour.mp3", 
                   Groups= "Samsung Galaxy"
            });


            return data;
        }
        }


    }

