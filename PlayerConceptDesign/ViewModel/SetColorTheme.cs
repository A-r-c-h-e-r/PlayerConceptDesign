using PlayerConceptDesign.Model;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static PlayerConceptDesign.ViewModel.AplicationWindow;

namespace PlayerConceptDesign.ViewModel
{
    public class SetColorTheme
    {
        public static string LastColorTheme { get; set; }
        public static ColorsTheme colorsTheme { get; set; }
        static SetColorTheme()
        {
            colorsTheme = new ColorsTheme();
            try { SetActualTheme(ApplicationSettings.Default.Theme); }
            catch { SetDarkTheme(); }
            
            if (ApplicationSettings.Default.Theme == "Light") 
                InvertImageFromActualTheme(ApplicationSettings.Default.Theme);

        }

        public void UpdateColorTheme(ColorsTheme newColorsTheme) =>
            colorsTheme = newColorsTheme;

        public static SolidColorBrush SGetColorHex(string color)
        {
            return (SolidColorBrush)new BrushConverter().ConvertFrom(color);
        }
        public static Color CGetColorHex(string color)
        {
            return (Color)ColorConverter.ConvertFromString(color);
        }

        public static void SetActualTheme(string nameTheme)
        {
            if (nameTheme == "Dark") SetDarkTheme();
            else if (nameTheme == "Silver") SetSilverTheme();
            else if (nameTheme == "Purple") SetPurpleTheme();
            else if (nameTheme == "Light") SetLightTheme();
            else if (nameTheme == "Blue") SetBlueTheme();

           InvertImageFromActualTheme(nameTheme);
        }

      
        public static void InvertImageFromActualTheme(string nameTheme)
        {
            if (AplicationMainWindow != null)
            {
                bool check = ((nameTheme == "Light" && nameTheme != LastColorTheme) || (nameTheme != "Light" && LastColorTheme == "Light")) ? true : false;
                AplicationMainWindow.LikeStatus.SmallIcon = InvertImage.Invert((BitmapSource)AplicationMainWindow.LikeStatus.SmallIcon, check);
                AplicationMainWindow.ButtonAdvPlayerRandom.SmallIcon = InvertImage.Invert((BitmapSource)AplicationMainWindow.ButtonAdvPlayerRandom.SmallIcon, check);
                AplicationMainWindow.ButtonAdvPlayerPrevious.SmallIcon = InvertImage.Invert((BitmapSource)AplicationMainWindow.ButtonAdvPlayerPrevious.SmallIcon, check);
                AplicationMainWindow.ButtonAdvPlayerPlayPause.SmallIcon = InvertImage.Invert((BitmapSource)AplicationMainWindow.ButtonAdvPlayerPlayPause.SmallIcon, check);
                AplicationMainWindow.ButtonAdvPlayerNext.SmallIcon = InvertImage.Invert((BitmapSource)AplicationMainWindow.ButtonAdvPlayerNext.SmallIcon, check);
                AplicationMainWindow.ButtonAdvPlayerRepeat.SmallIcon = InvertImage.Invert((BitmapSource)AplicationMainWindow.ButtonAdvPlayerRepeat.SmallIcon, check);
                AplicationMainWindow.ButtonAdvPlayerVoice.SmallIcon = InvertImage.Invert((BitmapSource)AplicationMainWindow.ButtonAdvPlayerVoice.SmallIcon, check);
                AplicationMainWindow.ButtonAdvPlayerEnlarge.SmallIcon = InvertImage.Invert((BitmapSource)AplicationMainWindow.ButtonAdvPlayerEnlarge.SmallIcon, check);
                AplicationMainWindow.ButtonAdvPlayerReduce.SmallIcon = InvertImage.Invert((BitmapSource)AplicationMainWindow.ButtonAdvPlayerReduce.SmallIcon, check);
                AplicationMainWindow.ButtonAdvPlayerPreviousEnlarge.SmallIcon = InvertImage.Invert((BitmapSource)AplicationMainWindow.ButtonAdvPlayerPreviousEnlarge.SmallIcon, check);
                AplicationMainWindow.ButtonAdvPlayerNextEnlarge.SmallIcon = InvertImage.Invert((BitmapSource)AplicationMainWindow.ButtonAdvPlayerNextEnlarge.SmallIcon, check);
                AplicationMainWindow.ButtonAdvPlayerRepeatEnlarge.SmallIcon = InvertImage.Invert((BitmapSource)AplicationMainWindow.ButtonAdvPlayerRepeatEnlarge.SmallIcon, check);
                AplicationMainWindow.ButtonAdvPlayerRandomEnlarge.SmallIcon = InvertImage.Invert((BitmapSource)AplicationMainWindow.ButtonAdvPlayerRandomEnlarge.SmallIcon, check);
            }
        }

        public static void SetDarkTheme()
        {
            colorsTheme.ColorPlayerPanel = SGetColorHex("#292929");
            colorsTheme.ColorMenu = SGetColorHex("#000000");
            colorsTheme.ColorForeground = SGetColorHex("#BFBFBF");
            colorsTheme.ColorMenuForeground = SGetColorHex("#FFFFFF");
            colorsTheme.ColorInfoBorder = SGetColorHex("#C5C0FF");
            colorsTheme.ColorPlayerPanelBorderBrush = SGetColorHex("#333333");
            colorsTheme.ColorMainGradient1 = CGetColorHex("#303030");
            colorsTheme.ColorMainGradient2 = CGetColorHex("#191919");
            colorsTheme.ColorBackLight = CGetColorHex("#C5C0FF");
            colorsTheme.ColorPlayerSlider = SGetColorHex("#4C4C4C");
            colorsTheme.ColorEnlargeGradient1 = CGetColorHex("#454545");
            colorsTheme.ColorEnlargeGradient2 = CGetColorHex("#202020");
            colorsTheme.ColorForegroundHome = SGetColorHex("#B2AEDC");
        }
        public static void SetSilverTheme()
        {
            colorsTheme.ColorPlayerPanel = SGetColorHex("#5D616E");
            colorsTheme.ColorMenu = SGetColorHex("#000000");
            colorsTheme.ColorForeground = SGetColorHex("#FFFFFF");
            colorsTheme.ColorMenuForeground = SGetColorHex("#FFFFFF");
            colorsTheme.ColorInfoBorder = SGetColorHex("#7B7EFF");
            colorsTheme.ColorPlayerPanelBorderBrush = SGetColorHex("#767B8A");
            colorsTheme.ColorMainGradient1 = CGetColorHex("#A1A2C4");
            colorsTheme.ColorMainGradient2 = CGetColorHex("#474a56");
            colorsTheme.ColorBackLight = CGetColorHex("#7B7EFF");
            colorsTheme.ColorPlayerSlider = SGetColorHex("#3A3A44");
            colorsTheme.ColorEnlargeGradient1 = CGetColorHex("#A1A2C4");
            colorsTheme.ColorEnlargeGradient2 = CGetColorHex("#474a56");
            colorsTheme.ColorForegroundHome = SGetColorHex("#D0D0EF");

        }
        public static void SetPurpleTheme()
        {
            colorsTheme.ColorPlayerPanel = SGetColorHex("#595b83");
            colorsTheme.ColorMenu = SGetColorHex("#060930");
            colorsTheme.ColorForeground = SGetColorHex("#FFFFFF");
            colorsTheme.ColorMenuForeground = SGetColorHex("#FFFFFF");
            colorsTheme.ColorInfoBorder = SGetColorHex("#7B7EFF");
            colorsTheme.ColorPlayerPanelBorderBrush = SGetColorHex("#767B8A");
            colorsTheme.ColorMainGradient1 = CGetColorHex("#f4abc4");
            colorsTheme.ColorMainGradient2 = CGetColorHex("#333456");
            colorsTheme.ColorBackLight = CGetColorHex("#7B7EFF");
            colorsTheme.ColorPlayerSlider = SGetColorHex("#332C35");
            colorsTheme.ColorEnlargeGradient1 = CGetColorHex("#6C5B8B"); 
            colorsTheme.ColorEnlargeGradient2 = CGetColorHex("#333456");
            colorsTheme.ColorForegroundHome = SGetColorHex("#CDE2EE");
        }
        public static void SetLightTheme()
        {
            colorsTheme.ColorPlayerPanel = SGetColorHex("#D9DDE8");
            colorsTheme.ColorMenu = SGetColorHex("#495464");
            colorsTheme.ColorForeground = SGetColorHex("#000000");
            colorsTheme.ColorMenuForeground = SGetColorHex("#FFFFFF");
            colorsTheme.ColorInfoBorder = SGetColorHex("#ffffff");
            colorsTheme.ColorPlayerPanelBorderBrush = SGetColorHex("#C1C7DA");
            colorsTheme.ColorMainGradient1 = CGetColorHex("#F9F8FF");
            colorsTheme.ColorMainGradient2 = CGetColorHex("#bbbfca");
            colorsTheme.ColorBackLight = CGetColorHex("#A8AFFF");
            colorsTheme.ColorPlayerSlider = SGetColorHex("#4C4C4C");
            colorsTheme.ColorEnlargeGradient1 = CGetColorHex("#F9F8FF"); 
            colorsTheme.ColorEnlargeGradient2 = CGetColorHex("#AEB1BC");
        colorsTheme.ColorForegroundHome = SGetColorHex("#444450");
    }
        public static void SetBlueTheme()
        {
            colorsTheme.ColorPlayerPanel = SGetColorHex("#282C41");
            colorsTheme.ColorMenu = SGetColorHex("#101015");
            colorsTheme.ColorForeground = SGetColorHex("#BFBFBF");
            colorsTheme.ColorMenuForeground = SGetColorHex("#FFFFFF");
            colorsTheme.ColorInfoBorder = SGetColorHex("#ffffff");
            colorsTheme.ColorPlayerPanelBorderBrush = SGetColorHex("#3C4059");
            colorsTheme.ColorMainGradient1 = CGetColorHex("#b4a5a5");
            colorsTheme.ColorMainGradient2 = CGetColorHex("#3c415c");
            colorsTheme.ColorBackLight = CGetColorHex("#8E94FF");
            colorsTheme.ColorPlayerSlider = SGetColorHex("#15151C");
            colorsTheme.ColorEnlargeGradient1 = CGetColorHex("#b4a5a5"); 
            colorsTheme.ColorEnlargeGradient2 = CGetColorHex("#3c415c");
            colorsTheme.ColorForegroundHome = SGetColorHex("#C6C6E1");
        }
    }
}
