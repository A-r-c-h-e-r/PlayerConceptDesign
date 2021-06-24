using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using PlayerConceptDesign.Settings;

namespace PlayerConceptDesign.ViewModel
{
    public static class MusicTemplate
    {
        public static Grid TemplateCover(Grid grid, BitmapImage Cover)
        {
            var CoverShadow = new Border
            {
                Background = new ImageBrush()
                {
                    ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString("pack://application:,,,/Resources/Cover/CoverShadow.png")
                },
                Opacity = 0.9,
                Margin = new Thickness(SettingsManager.AppSettings.SizeCover / 45)
            };

            var CoverSong = new Border
            {
                Width = grid.Width / 1.26,
                Height = grid.Height / 1.315,
                Margin = new Thickness(0, 0, 0, grid.Height / 7.5),
                CornerRadius = new CornerRadius(SettingsManager.AppSettings.SizeCover / 20),
                Background = new ImageBrush()
                {
                    ImageSource = Cover
                },
            };

            grid.Children.Add(CoverShadow);
            grid.Children.Add(CoverSong);
            return grid;
        }

        public static Border TemplateActiveCover(Grid grid)
        {
            return new Border
            {
                Width = grid.Width / 1.255,
                Height = grid.Height / 1.3145,
                Margin = new Thickness(0, 0, 0, grid.Height / 4.1),
                CornerRadius = new CornerRadius(SettingsManager.AppSettings.SizeCover / 20),
                Background = SetColorTheme.SGetColorHex("#90000000"),
                Opacity = 0, 
                Tag = "0"
            };
        }

        public static Border TemplateActiveCoverImagePlayPause(Border ActiveCover, string file, int index)
        {
            return new Border
            {
                CornerRadius = new CornerRadius(100),
                Width = ActiveCover.Width / 2,
                Height = ActiveCover.Height / 2,
                Opacity = 0.6,
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center,
                Background = new ImageBrush()
                {
                    ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString($"pack://application:,,,/Resources/Player/Play.png")
                },
                DataContext = file,
                Tag = index
            };
        }
        public static Border TemplateActiveCoverImagePlayPause(Border ActiveCover)
        {
            return new Border
            {
                CornerRadius = new CornerRadius(100),
                Width = ActiveCover.Width,
                Height = ActiveCover.Height,
                Opacity = 0.8,
                Margin = new Thickness(0,0,0, (SettingsManager.AppSettings.SizeCover /2 )-2.5),
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Center,
                Background = new ImageBrush()
                {
                    ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString(Player.InfoPathImage)
                }
            };
        }

        public static Border TemplateActiveCoverImageLike(Border ActiveCover, string file, int index)
        {
            string LikeStatus = "Like";
            for (int i = 0; i < SettingsManager.AppSettings.FilesLike.Count; i++)
                if (SettingsManager.AppSettings.FilesLike[i] == file) { LikeStatus = "like_active"; break; }
          
            return new Border
            {
                CornerRadius = new CornerRadius(100),
                Width = ActiveCover.Width / 6,
                Height = ActiveCover.Height / 6,
                Opacity = 0.6,
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Right,
                Background = new ImageBrush()
                {
                    ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString($"pack://application:,,,/Resources/Player/{LikeStatus}.png")
                },
                DataContext = file,
                Tag = index
            };
        }

        public static Border TemplateActiveCoverImageDelete(Border ActiveCover, string file, int index)
        {
            return new Border
            {
                CornerRadius = new CornerRadius(100),
                Width = ActiveCover.Width / 6,
                Height = ActiveCover.Height / 6,
                Opacity = 0.6,
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Right,
                Background = new ImageBrush()
                {
                    ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString($"pack://application:,,,/Resources/Player/delete.png")
                },
                DataContext = file,
                Tag = index
            };
        }

        public static Grid TemplateTile(Grid grid, Grid cover, string name)
        {
            cover.VerticalAlignment = VerticalAlignment.Top;
            double test = 0;
            if (SettingsManager.AppSettings.SizeCover <= 120) test = 4;
            else if (SettingsManager.AppSettings.SizeCover <= 130) test = 3;
            else if (SettingsManager.AppSettings.SizeCover <= 140) test = 2;
            else if (SettingsManager.AppSettings.SizeCover <= 150) test = 1;
            Label labelName = new Label
            {
                Content = name,
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(SettingsManager.AppSettings.SizeCover / 10, 0, SettingsManager.AppSettings.SizeCover / 7.9, SettingsManager.AppSettings.SizeCover / 11 - test),
                FontSize = SettingsManager.AppSettings.SizeCover / 10 + test,
                Foreground = SetColorTheme.colorsTheme.ColorForeground,
            };
            Label labelName2 = new Label
            {
                Content = "...",
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Right,
                Margin = new Thickness(0, 0, SettingsManager.AppSettings.SizeCover / 20, SettingsManager.AppSettings.SizeCover / 11 - test),
                FontSize = SettingsManager.AppSettings.SizeCover / 10 + test,
                Foreground = SetColorTheme.colorsTheme.ColorForeground,
            };

            grid.Children.Add(cover);
            grid.Children.Add(labelName);
            grid.Children.Add(labelName2);
            return grid;
        }
    }
}
