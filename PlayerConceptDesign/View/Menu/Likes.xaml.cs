using PlayerConceptDesign.ViewModel;
using System;
using System.Collections.Generic;
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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PlayerConceptDesign.View.Menu
{
    public partial class Likes : Page
    {
        public Likes()
        {
            InitializeComponent();
            RenderOptions.SetBitmapScalingMode(this, BitmapScalingMode.Fant);
            try
            {
                GenerationFiles();
            }
            catch { }
        }

        List<BitmapImage> CoverFilesLike = new List<BitmapImage>();
        List<string> NameFilesLike = new List<string>();
        private void GenerationFiles()
        {

            for (int i = 0; i < ApplicationSettings.Default.FilesLike.Count; i++)
            {
                CoverFilesLike.Add(Files.GetCoverFile(ApplicationSettings.Default.FilesLike[i]));
                NameFilesLike.Add(Files.GetNameFile(ApplicationSettings.Default.FilesLike[i]));

                Binding bindingHeight = new Binding(), bindingWidth = new Binding();
                bindingHeight.Source = bindingWidth.Source = Cover.sizeCover[i];
                bindingHeight.Path = new PropertyPath("Height");
                bindingWidth.Path = new PropertyPath("Width");
                bindingHeight.Mode = bindingWidth.Mode = BindingMode.TwoWay;
                bindingHeight.UpdateSourceTrigger = bindingWidth.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;

                Grid gridCover = new Grid(), gridMusic = new Grid();

                BindingOperations.SetBinding(gridCover, WidthProperty, bindingWidth);
                BindingOperations.SetBinding(gridCover, HeightProperty, bindingWidth);

                BindingOperations.SetBinding(gridMusic, WidthProperty, bindingWidth);
                BindingOperations.SetBinding(gridMusic, HeightProperty, bindingHeight);

                gridCover = MusicTemplate.TemplateCover(gridCover, CoverFilesLike[i]);
                gridMusic = MusicTemplate.TemplateTile(gridMusic, gridCover, NameFilesLike[i]);

                var activeCover = MusicTemplate.TemplateActiveCover(gridCover);
                activeCover.MouseEnter += ActiveCover_MouseEnter;
                activeCover.MouseLeave += ActiveCover_MouseLeave;

                var imagePlayPause = MusicTemplate.TemplateActiveCoverImagePlayPause(activeCover, ApplicationSettings.Default.FilesLike[i], i);                   
                imagePlayPause.MouseEnter += ImagePlayPauseDelete_MouseEnter;
                imagePlayPause.MouseLeave += ImagePlayPauseDelete_MouseLeave;
                imagePlayPause.MouseUp += ImagePlayPause_MouseEnter;

                if (Player.LastImagePlayPause?.DataContext?.ToString() == ApplicationSettings.Default.FilesLike[i])
                {
                    imagePlayPause.Background = Player.LastImagePlayPause.Background;
                    Player.LastImagePlayPause = imagePlayPause;
                }

                var imageDelete = MusicTemplate.TemplateActiveCoverImageDelete(activeCover, ApplicationSettings.Default.FilesLike[i], i);
                imageDelete.MouseEnter += ImagePlayPauseDelete_MouseEnter;
                imageDelete.MouseLeave += ImagePlayPauseDelete_MouseLeave;
                imageDelete.MouseUp += ImageDelete_MouseEnter;

                var GridActiveCover = new Grid();
                GridActiveCover.Children.Add(imagePlayPause);
                GridActiveCover.Children.Add(imageDelete);

                activeCover.Child = GridActiveCover;
                gridMusic.Children.Add(activeCover);
                WarpPanelLikes.Children.Add(gridMusic);
                Player.NameFrameIndex = 1;
                AplicationWindow.SetWrapPanelLibrary(ref WarpPanelLikes, 1);
            }
        }

        private void AnimationOpacity(UIElement uIElement, double to, double time)
        {
            var animationOpacity = new DoubleAnimation();
            animationOpacity.To = to;
            animationOpacity.Duration = TimeSpan.FromSeconds(time);
            animationOpacity.EasingFunction = new QuadraticEase();
            uIElement.BeginAnimation(OpacityProperty, animationOpacity);
        }

        private void ActiveCover_MouseEnter(object sender, RoutedEventArgs e) => AnimationOpacity((sender as Border), 1, 0.13);
        private void ActiveCover_MouseLeave(object sender, RoutedEventArgs e) => AnimationOpacity((sender as Border), 0, 0.27);

        private void ImagePlayPauseDelete_MouseEnter(object sender, RoutedEventArgs e) => AnimationOpacity((sender as Border), 1, 0.13);
        private void ImagePlayPauseDelete_MouseLeave(object sender, RoutedEventArgs e) => AnimationOpacity((sender as Border), 0.6, 0.27);

        private void ImagePlayPause_MouseEnter(object sender, RoutedEventArgs e)
        {
            if (Player.LastImagePlayPause != null && Player.LastImagePlayPause != (sender as Border))
                Player.LastImagePlayPause.Background = new ImageBrush() { ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString("pack://application:,,,/Resources/Player/Play.png") };
            if (Player.LastImagePlayPause != (sender as Border)) Player.LastImagePlayPause = (sender as Border);

            (sender as Border).Background = new ImageBrush()
            {
                ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString((Files.Trim(System.IO.Path.GetFileName(((sender as Border).Background as ImageBrush).ImageSource.ToString()), ".") == "Play")
                 ? "pack://application:,,,/Resources/Player/Pause.png" : "pack://application:,,,/Resources/Player/Play.png")
            };

            AplicationWindow.AplicationMainWindow.StackPanelPlayerInfo.Visibility = Visibility.Visible;
            AplicationWindow.AplicationMainWindow.BorderImagePlayerCover.Background = new ImageBrush()
            {
                ImageSource = CoverFilesLike[(int)(sender as Border).Tag]
            };

            Player.Play = (Files.Trim(System.IO.Path.GetFileName(((sender as Border).Background as ImageBrush).ImageSource.ToString()), ".") == "Play") ? false : true;
            AplicationWindow.AplicationMainWindow.Init((sender as Border), ApplicationSettings.Default.FilesLike);
        }

        private void ImageDelete_MouseEnter(object sender, RoutedEventArgs e)
        {
            ApplicationSettings.Default.FilesLike.Remove((sender as Border).DataContext.ToString());
            ApplicationSettings.Default.Save();
            this.NavigationService.Refresh();
        }

    }
}
