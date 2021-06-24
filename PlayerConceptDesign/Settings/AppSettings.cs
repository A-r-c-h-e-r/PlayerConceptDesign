using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using RIS.Settings;
using RIS.Settings.Ini;
using Environment = RIS.Environment;

namespace PlayerConceptDesign.Settings
{
    public class AppSettings : IniSettings
    {
        private const string SettingsFileName = "AppSettings.config";

        [SettingCategory("Localization")]
        public string Language { get; set; }
        [SettingCategory("Window")]
        public double WindowPositionX { get; set; }
        public double WindowPositionY { get; set; }
        public int WindowState { get; set; }
        public double WindowWidth { get; set; }
        public double WindowHeight { get; set; }
        [SettingCategory("App")]
        public string Theme { get; set; }
        public bool MenuAnimation { get; set; }
        public double SizeCover { get; set; }
        public double SizeMenu { get; set; }
        public string Folder { get; set; }
        public List<string> Files { get; set; }
        public List<string> Name { get; set; }
        public double Voice { get; set; }
        public bool InvertImage { get; set; }
        public List<string> FilesLike { get; set; }
        [SettingCategory("Log")]
        public int LogRetentionDaysPeriod { get; set; }

        public AppSettings()
            : base(Path.Combine(Environment.ExecProcessDirectoryName, SettingsFileName))
        {
            Language = "en-US";

            WindowPositionX = SystemParameters.PrimaryScreenWidth / 2.0;
            WindowPositionY = SystemParameters.PrimaryScreenHeight / 2.0;
            WindowState = (int)System.Windows.WindowState.Normal;
            WindowWidth = 1000;
            WindowHeight = 600;

            Theme = "Dark";
            MenuAnimation = true;
            SizeCover = 100;
            SizeMenu = 33;
            Folder = string.Empty;
            Files = new List<string>();
            Name = new List<string>();
            Voice = 100;
            InvertImage = false;
            FilesLike = new List<string>();

            LogRetentionDaysPeriod = 7;

            Load();
        }
    }
}
