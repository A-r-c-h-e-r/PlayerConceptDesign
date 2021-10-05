using Microsoft.Win32;
using PlayerConceptDesign.Model;
using PlayerConceptDesign.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PlayerConceptDesign.Settings;
using Localization = PlayerConceptDesign.Properties.Localization.Localization;


namespace PlayerConceptDesign.View.Menu
{
    public partial class Settings : Page
    {
        public Settings()
        {
            InitializeComponent();
            LabelActiveTheme.Content = SettingsManager.AppSettings.Theme;
            SliderAnimationSpeed.Value = SettingsManager.AppSettings.SizeCover;
            CheckBoxShowAlbum.Content = ((CheckBoxShowAlbum.IsChecked = SettingsManager.AppSettings.MenuAnimation) == true) ? "On" : "Off";
            LabelLanguage.Content = (SettingsManager.AppSettings.Language == "en-US") ? Localization.SettingsEnglish : Localization.SettingsRussian;
        }
        private void ThemeButtonClick(object sender, RoutedEventArgs e)
        {
          
            SetColorTheme.LastColorTheme = SettingsManager.AppSettings.Theme;
            SetColorTheme.SetActualTheme(SettingsManager.AppSettings.Theme = (string)(sender as Button).Name);
            //     SetColorTheme.InvertImageFromActualTheme((string)(sender as Button).Name);
            SettingsManager.AppSettings.InvertImage = ((string)(sender as Button).Name) == "Light" ? true : false;
            SettingsManager.AppSettings.Save();

            LabelActiveTheme.Content = SettingsManager.AppSettings.Theme;
          
        }

        private void LanguageButtonClick(object sender, RoutedEventArgs e)
        {
            if ((((string)(sender as Button).Content == Localization.SettingsEnglish) ? "en-US" : "ru-RU") != SettingsManager.AppSettings.Language)
            {
                SettingsManager.AppSettings.Language = ((string)(sender as Button).Content == Localization.SettingsEnglish) ? "en-US" : "ru-RU";
                SettingsManager.AppSettings.Save();

                LabelLanguage.Content = (SettingsManager.AppSettings.Language == "en-US") ? Localization.SettingsEnglish : Localization.SettingsRussian;

                System.Threading.Thread.CurrentThread.CurrentUICulture =
                    System.Globalization.CultureInfo.GetCultureInfo(SettingsManager.AppSettings.Language);
               
                 AplicationWindow.AplicationMainWindow.RefreshMainWindow();
            }
        }

        private void CheckBoxShowAlbumClick(object sender, RoutedEventArgs e)
        {
            (sender as CheckBox).Content = ((sender as CheckBox).IsChecked == true) ? Localization.SettingsOn : Localization.SettingsOff;
            SettingsManager.AppSettings.MenuAnimation = (bool)(sender as CheckBox).IsChecked;
            SettingsManager.AppSettings.SizeMenu = (SettingsManager.AppSettings.MenuAnimation == true) ? 33 : 110;
            SettingsManager.AppSettings.Save();

            var animation = new ThicknessAnimation();
            animation.To = new Thickness((SettingsManager.AppSettings.MenuAnimation == true) ? 33 : 110, 0, 0, 0);
            animation.Duration = TimeSpan.FromSeconds((SettingsManager.AppSettings.MenuAnimation == true) ? 0.2 : 0.5);
            animation.EasingFunction = new PowerEase() { Power = 6 };
            AplicationWindow.AplicationMainWindow.MainFrame.BeginAnimation(MarginProperty, animation);

            AplicationWindow.AplicationMainWindow.MenuPanel_MouseLeave(null, null);


        }
        private bool crutch = false;
        private void SliderAnimationSpeed_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            SettingsManager.AppSettings.SizeCover = (sender as Slider).Value;
            SettingsManager.AppSettings.Save();
            for (int i = 0; i < SettingsManager.AppSettings.Files.Count; i++)
            {
                Cover.sizeCover[i].Height = (sender as Slider).Value * 1.11;
                Cover.sizeCover[i].Width = (sender as Slider).Value;
            }
        }

        private void Label_MouseUp(object sender, MouseButtonEventArgs e)
        {
           
         var folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            
            System.Windows.Forms.DialogResult result = folderBrowserDialog.ShowDialog();
          
            if (result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                Files.SetDataFilesAppSettings(folderBrowserDialog.SelectedPath);

            Cover.Init();
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e) =>
            LabelFolder.Width = MainGrid.ColumnDefinitions[0].ActualWidth;

        private void SliderAnimationSpeed_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            (sender as Slider).Value += Convert.ToInt32((e.Delta > 0) ? (sender as Slider).Maximum / 30 : -(sender as Slider).Maximum / 30);
            SettingsManager.AppSettings.SizeCover = (sender as Slider).Value;
            SettingsManager.AppSettings.Save();
            for (int i = 0; i < SettingsManager.AppSettings.Files.Count; i++)
            {
                Cover.sizeCover[i].Height = (sender as Slider).Value * 1.11;
                Cover.sizeCover[i].Width = (sender as Slider).Value;
            }
        }
    }
}
