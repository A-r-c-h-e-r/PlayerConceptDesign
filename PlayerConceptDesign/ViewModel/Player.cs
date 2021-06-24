using System;
using System.Collections.Generic;
using System.Windows.Controls;
using PlayerConceptDesign.Settings;

namespace PlayerConceptDesign.ViewModel
{
    public static class Player
    {
        public static List<string> PlayList { get; set; }
        public static bool Repeat { get; set; }
        public static Border LastImagePlayPause { get; set; }
        public static string ActualPlayingMusic { get; set; }
        public static int ActualPlayingMusicIndex { get; set; }
        public static List<string> ActualPlayingMusicList { get; set; }
        public static bool Play { get; set; } = false;
        public static string InfoPathImage { get; set; } = "pack://application:,,,/Resources/Player/Play.png";
        public static int NameFrameIndex { get; set; }
        public static List<string>HomePopular { get; set; }
        public static List<string> HomeLast { get; set; } = new List<string>();

        static Player()
        {
            PlayList = SettingsManager.AppSettings.Files;
            Repeat = false;
            HomePopular = Player.MixNameFile(SettingsManager.AppSettings.Files);
        }

        public static List<string> MixNameFile(List<string> Files)
        {
            List<string> MixedFiles = new List<string>();

            List<int> FilesIndex = new List<int>();
            for (int i = 0; i < Files.Count; i++)
                FilesIndex.Add(i);

            Random random = new Random();
            for (int i = 0; i < Files.Count; i++)
            {
                int rand = random.Next(FilesIndex.Count);
                MixedFiles.Add(Files[FilesIndex[rand]]);
                FilesIndex.RemoveAt(rand);
            }

            return MixedFiles;
        }

    }
}
