using PlayerConceptDesign.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace PlayerConceptDesign.View.Menu
{
    public partial class Library : Page
    {
        public Library()
        {
            InitializeComponent();
            RenderOptions.SetBitmapScalingMode(this, BitmapScalingMode.Fant);
            GenerationFiles();
            
        }

        private void GenerationFiles()
        {
            for (int i = 0; i < ApplicationSettings.Default.Files.Count; i++)
            {
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

                gridCover = MusicTemplate.TemplateCover(gridCover, ApplicationSettings.Default.Cover[i]);
                gridMusic = MusicTemplate.TemplateTile(gridMusic, gridCover, ApplicationSettings.Default.Name[i]);

                var activeCover = MusicTemplate.TemplateActiveCover(gridCover);
                activeCover.MouseEnter += ActiveCover_MouseEnter;
                activeCover.MouseLeave += ActiveCover_MouseLeave;

                var imagePlayPause = MusicTemplate.TemplateActiveCoverImagePlayPause(activeCover, ApplicationSettings.Default.Files[i], i);
                imagePlayPause.MouseEnter += ImagePlayPauseLike_MouseEnter;
                imagePlayPause.MouseLeave += ImagePlayPauseLike_MouseLeave;
                imagePlayPause.MouseUp += ImagePlayPause_MouseEnter;
             

                if (Player.LastImagePlayPause?.DataContext?.ToString() == ApplicationSettings.Default.Files[i])
                {
                    imagePlayPause.Background = Player.LastImagePlayPause.Background;
                    Player.LastImagePlayPause = imagePlayPause;
                }

                var imageLike = MusicTemplate.TemplateActiveCoverImageLike(activeCover, ApplicationSettings.Default.Files[i], i);
                imageLike.MouseEnter += ImagePlayPauseLike_MouseEnter;
                imageLike.MouseLeave += ImagePlayPauseLike_MouseLeave;
                imageLike.MouseUp += ImageLike_MouseEnter;

                var GridActiveCover = new Grid();
                GridActiveCover.Children.Add(imagePlayPause);
                GridActiveCover.Children.Add(imageLike);

                activeCover.Child = GridActiveCover;
                gridMusic.Children.Add(activeCover);
                
                WarpPanelLibrary.Children.Add(gridMusic);
                Player.NameFrameIndex = 0;
                AplicationWindow.SetWrapPanelLibrary( ref WarpPanelLibrary, 0);
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
        private void ActiveCover_MouseLeave(object sender, RoutedEventArgs e) => AnimationOpacity((sender as Border), Convert.ToDouble( (sender as Border).Tag), 0.27);

        private void ImagePlayPauseLike_MouseEnter(object sender, RoutedEventArgs e) => AnimationOpacity((sender as Border), 1, 0.13);
        private void ImagePlayPauseLike_MouseLeave(object sender, RoutedEventArgs e) => AnimationOpacity((sender as Border), 0.6, 0.27);

        


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
            Player.Play = (Files.Trim(System.IO.Path.GetFileName(((sender as Border).Background as ImageBrush).ImageSource.ToString()), ".") == "Play") ? false : true;


            AplicationWindow.AplicationMainWindow.Init((sender as Border), ApplicationSettings.Default.Files);
        }

        private void ImageLike_MouseEnter(object sender, RoutedEventArgs e)
        {
            (sender as Border).Background = new ImageBrush()
            {
                ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString((Files.Trim(System.IO.Path.GetFileName(((sender as Border).Background as ImageBrush).ImageSource.ToString()), ".") == "Like")
                ? "pack://application:,,,/Resources/Player/like_active.png" : "pack://application:,,,/Resources/Player/Like.png")
            };

            if (Files.Trim(System.IO.Path.GetFileName(((sender as Border).Background as ImageBrush).ImageSource.ToString()), ".") != "Like")
            {
                for (int i = 0; i < ApplicationSettings.Default.FilesLike.Count; i++)
                    if (ApplicationSettings.Default.FilesLike[i] == (sender as Border).DataContext.ToString()) return;
                ApplicationSettings.Default.FilesLike.Insert(0, (sender as Border).DataContext.ToString());
            }
            else
            {
                for (int i = 0; i < ApplicationSettings.Default.FilesLike.Count; i++)
                    if (ApplicationSettings.Default.FilesLike[i] == (sender as Border).DataContext.ToString())
                        ApplicationSettings.Default.FilesLike.RemoveAt(i);
            }
            ApplicationSettings.Default.Save();
        }

    }
}
