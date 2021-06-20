using NAudio.Wave;
using PlayerConceptDesign.ViewModel;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Threading;


// - // - // - // - // - // - // - // - // - // - // - // - // - // - 


//this.Resources["buttonBrush"] = new SolidColorBrush(Colors.LimeGreen);
//MessageBox.Show(settings.Theme);
//TagLib.File tagFile = TagLib.File.Create(ApplicationSettings.Default.Files[0]);
//MessageBox.Show(TagLib.File.Create(ApplicationSettings.Default.Files[0]).Tag.Subtitle);
//MessageBox.Show(Path.GetFileName(ApplicationSettings.Default.Files[5]));



//var reader = new Mp3FileReader(ApplicationSettings.Default.Files[0]);
//var waveOut = new WaveOut(); // or WaveOutEvent()
//waveOut.Init(reader);
//waveOut.Play();



// - // - // - // - // - // - // - // - // - // - // - // - // - // - 

namespace PlayerConceptDesign.View
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(ApplicationSettings.Default.Language);

            InitializeComponent();

            AplicationWindow.AplicationMainWindow = this;
            Application.Current.MainWindow = AplicationWindow.AplicationMainWindow;

            SetColorTheme.SetActualTheme(ApplicationSettings.Default.Theme);

            MainFrame.Margin = new Thickness((ApplicationSettings.Default.MenuAnimation == true) ? 33 : 115, 0, 0, 0);
            RenderOptions.SetBitmapScalingMode(this, BitmapScalingMode.Fant);

            if (Files.CheckFileFormat(Files.FileLink))
                Files.SetDataFilesAppSettings(Files.Trim(Files.FileLink, "\\"));
            else Files.SetDataFilesAppSettings(null);

        }

        public void RefreshMainWindow()
        {
            if (ApplicationSettings.Default.Theme != "Light")
                SetColorTheme.LastColorTheme = ApplicationSettings.Default.Theme;

            waveOut.Stop();

            MainWindow NewMainWindow = new MainWindow();
            NewMainWindow.Top = this.Top;
            NewMainWindow.Left = this.Left;
            NewMainWindow.MainFrame.Source = new Uri($"pack://application:,,,/{this.MainFrame.Source}");
            NewMainWindow.InfoBorder.VerticalAlignment = VerticalAlignment.Bottom;
            NewMainWindow.InfoBorder.Margin = new Thickness(0, 0, 0, 5);

            AplicationWindow.AplicationMainWindow = NewMainWindow;
            Application.Current.MainWindow = AplicationWindow.AplicationMainWindow;
            AplicationWindow.AplicationMainWindow.Show();

            this.Close();

        }

        private bool FirstWindowDeactivated = false;
        private void Window_Deactivated(object sender, EventArgs e)
        {
            if (FirstWindowDeactivated == false)
            {
                [DllImport("user32.dll")]
                static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
                keybd_event((byte)0x2B, 0, 0x0001 | 0, 0);
                FirstWindowDeactivated = true;
            }
        }

        Thickness BaseMargin;
        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri($"pack://application:,,,/View/Menu/{(sender as ButtonAdv).Name}.xaml");

            var animation = new ThicknessAnimation();
            animation.To = new Thickness(
                left: (sender as ButtonAdv).Margin.Left,
                top: ((sender as ButtonAdv).Name != "Settings") ? (sender as ButtonAdv).Margin.Top : MenuPanel.ActualHeight - 35,
                right: (sender as ButtonAdv).Margin.Right,
                bottom: (sender as ButtonAdv).Margin.Bottom
            );
            animation.Duration = TimeSpan.FromSeconds(0.2);
            animation.EasingFunction = new QuadraticEase();
            InfoBorder.BeginAnimation(MarginProperty, animation);

            if ((sender as ButtonAdv).Name == "Settings")
            {
                DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(0.2);
                timer.Tick += timer_Tick;
                timer.Start();

                void timer_Tick(object sender, EventArgs e)
                {
                    timer.Stop();
                    InfoBorder.VerticalAlignment = VerticalAlignment.Bottom;
                    InfoBorder.Margin = new Thickness(0, 0, 0, 5);
                }
            }
            else
            {
                InfoBorder.VerticalAlignment = VerticalAlignment.Top;
                InfoBorder.Margin = BaseMargin;
            }

            if (MainFrame.Source.ToString() == $"View/Menu/{(sender as ButtonAdv).Name}.xaml")
                AnimationInfoBorderHeightProperty(30);
        }

        private void AnimationInfoBorderHeightProperty(double to)
        {
            var animation = new DoubleAnimation();
            animation.To = to;
            animation.Duration = TimeSpan.FromSeconds(0.1);
            animation.EasingFunction = new QuadraticEase();
            InfoBorder.BeginAnimation(HeightProperty, animation);
        }

        private void MenuButton_MouseLeave(object sender, MouseEventArgs e) =>
         AnimationInfoBorderHeightProperty(25);

        private void MenuButton_MouseEnter(object sender, MouseEventArgs e)
        {
            if (MainFrame.Source.ToString() == $"View/Menu/{(sender as ButtonAdv).Name}.xaml")
                AnimationInfoBorderHeightProperty(30);
        }

        private void AnimationMenuPanel(double to, double opacity, double time)
        {
            var animationWidth = new DoubleAnimation();
            var animationOpacity = new DoubleAnimation();
            animationWidth.To = to;
            animationOpacity.To = opacity;
            animationWidth.Duration = TimeSpan.FromSeconds(time);
            animationOpacity.Duration = TimeSpan.FromSeconds(time);
            animationWidth.EasingFunction = new PowerEase() { Power = 6 };
            animationOpacity.EasingFunction = new QuadraticEase();
            MenuPanel.BeginAnimation(WidthProperty, animationWidth);

            MenuPanel.BeginAnimation(OpacityProperty, animationOpacity);
        }

        public void MenuPanel_MouseEnter(object sender, MouseEventArgs e) => AnimationMenuPanel(115, 0.85, 0.5);

        public void MenuPanel_MouseLeave(object sender, MouseEventArgs e) => AnimationMenuPanel(ApplicationSettings.Default.SizeMenu, 0.35, 0.2);

        private void OpasityObject(double from, double to, double time, object obj)
        {
            var animationOpacity = new DoubleAnimation();
            animationOpacity.From = from;
            animationOpacity.To = to;
            animationOpacity.Duration = TimeSpan.FromSeconds(time);
            animationOpacity.EasingFunction = new QuadraticEase();

            if (obj is ContentControl content)
                content.BeginAnimation(OpacityProperty, animationOpacity);
        }

        string source = "";
        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            if (source != MainFrame.Content.ToString())
                OpasityObject(0, 1, 0.4, MainFrame);
            source = MainFrame.Content.ToString();
        }


        private void ButtonAdvPlayerCoverLikeStatus_Click(object sender, RoutedEventArgs e)
        {
            //(sender as ButtonAdv).SmallIcon = 
        }

        private void ButtonAdvPlayerPlayPause_Click(object sender, RoutedEventArgs e)
        {

            (sender as ButtonAdv).SmallIcon = ((sender as ButtonAdv).Label != "play")
                 ? new BitmapImage(new Uri($"pack://application:,,,/Resources/Player/pause.png"))
                 : new BitmapImage(new Uri($"pack://application:,,,/Resources/Player/play.png"));

            (sender as ButtonAdv).Label = ((sender as ButtonAdv).Label == "play") ? "pause" : "play";
            if (ApplicationSettings.Default.Theme == "Light")
                (sender as ButtonAdv).SmallIcon = InvertImage.Invert((BitmapImage)(sender as ButtonAdv).SmallIcon, true);

            Player.InfoPathImage = ((sender as ButtonAdv).Label == "play") ? "pack://application:,,,/Resources/Player/pause.png" : "pack://application:,,,/Resources/Player/play.png";
            Player.Play = ((sender as ButtonAdv).Label != "play") ? false : true;
            NewSong = false;
            Play();
            InitActivePlayInfo();
           
        }

        double VoiceValue = 0;
        bool check = false;
        private void SliderPlayerVoice_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            if (SliderPlayerVoice.Value == 0) ButtonAdvPlayerVoice.SmallIcon = new BitmapImage(new Uri("pack://application:,,,/Resources/Player/voice0.png"));
            else
            {
                VoiceValue = SliderPlayerVoice.Value;

                ButtonAdvPlayerVoice.SmallIcon = new BitmapImage(new Uri($"pack://application:,,,/Resources/Player/voice{GetStationValueVoice(SliderPlayerVoice.Value)}.png"));
            }
            ApplicationSettings.Default.Voice = SliderPlayerVoice.Value;
            ApplicationSettings.Default.Save();

            if (ApplicationSettings.Default.Theme == "Light") ButtonAdvPlayerVoice.SmallIcon = InvertImage.Invert((BitmapImage)ButtonAdvPlayerVoice.SmallIcon, (check));
            waveOut.Volume = (float)SliderPlayerVoice.Value;
            check = true;
        }

        private void SliderPlayerVoice_Loaded(object sender, RoutedEventArgs e)
        {
            if (ApplicationSettings.Default.Theme == "Light") ButtonAdvPlayerVoice.SmallIcon = InvertImage.Invert((CachedBitmap)ButtonAdvPlayerVoice.SmallIcon, (SliderPlayerVoice.Value > 0) ? true : false);
        }

        private int GetStationValueVoice(double value)
        {
            if (value <= 0.33) return 1; else if (value <= 0.66) return 2; else return 3;
        }

        private void ButtonAdvPlayerVoice_Click(object sender, RoutedEventArgs e)
        {
            (sender as ButtonAdv).SmallIcon = (Files.Trim(Path.GetFileName((sender as ButtonAdv).SmallIcon.ToString()), ".") != "voice0")
                ? new BitmapImage(new Uri("pack://application:,,,/Resources/Player/voice0.png"))
                : (sender as ButtonAdv).SmallIcon = new BitmapImage(new Uri($"pack://application:,,,/Resources/Player/voice{GetStationValueVoice(SliderPlayerVoice.Value)}.png"));
            SliderPlayerVoice.Value = (Files.Trim(Path.GetFileName((sender as ButtonAdv).SmallIcon.ToString()), ".") != "voice0") ? VoiceValue : 0;
        }

        List<string> ActualPlayingMusicListLast = Player.ActualPlayingMusicList;
        private void ButtonAdvPlayerRandomRepeat_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as ButtonAdv).Effect != null)
            {
                Player.ActualPlayingMusicList = ActualPlayingMusicListLast;
                (sender as ButtonAdv).Effect = null;
                Player.PlayList = ApplicationSettings.Default.Files;
                return;
            }

            ButtonAdvPlayerRandom.Effect = ButtonAdvPlayerRepeat.Effect = null;
            (sender as ButtonAdv).Effect = EffectColorBackLight.Effect;

            ActualPlayingMusicListLast = Player.ActualPlayingMusicList;
            if ((sender as ButtonAdv).Name == "ButtonAdvPlayerRandom") Player.ActualPlayingMusicList = Player.MixNameFile(ApplicationSettings.Default.Files);
            Player.Repeat = ((sender as ButtonAdv).Name == "ButtonAdvPlayerRepeat") ? true : false;

        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            BorderEnlarge.Margin = new Thickness(this.ActualWidth / 10, this.ActualHeight / 10, this.ActualWidth / 10, this.ActualHeight / 10);
            BorderEnlarge.CornerRadius = new CornerRadius(((this.ActualWidth + this.ActualHeight) / 2) / 80);
            // BorderTest.Width = BorderEnlarge.ActualWidth / 3;
            // BorderTest.Height = BorderEnlarge.ActualHeight / 3;
            //ViewboxPlayerEnlarge.Margin = new Thickness(ActualWidth/10, 20, 20, 60);

        }

        private void AnimationOpacityEnlarge(double from, double to, UIElement uIElement, double time)
        {
            var animationOpacity = new DoubleAnimation();
            animationOpacity.From = from;
            animationOpacity.To = to;
            animationOpacity.Duration = TimeSpan.FromSeconds(time);
            animationOpacity.EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseOut };
            uIElement.BeginAnimation(OpacityProperty, animationOpacity);
        }
        private void AnimationMarginEnlarge(Thickness from, Thickness to, UIElement uIElement, double time)
        {
            var animation = new ThicknessAnimation();
            animation.From = from;
            animation.To = to;
            animation.Duration = TimeSpan.FromSeconds(time);
            animation.EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseOut };
            uIElement.BeginAnimation(MarginProperty, animation);
        }


        private void ButtonAdvPlayerEnlarge_Click(object sender, RoutedEventArgs e)
        {

            if (((sender as ButtonAdv).Label == "enlarge"))
            {
                GridEnlarge.Visibility = Visibility.Visible;
                AnimationOpacityEnlarge(0, 0, BorderEnlarge, 0);
                AnimationOpacityEnlarge(0, 0, ViewboxPlayerEnlarge, 0);
                Async();
                async void Async()
                {
                    await Task.Run(() =>
                    {
                        Thread.Sleep(100);
                        this.Dispatcher.Invoke(() =>
                        {
                            AnimationMarginEnlarge(new Thickness(this.ActualWidth, this.ActualHeight, this.ActualWidth, this.ActualHeight),
                                                   new Thickness(this.ActualWidth / 10, this.ActualHeight / 10, this.ActualWidth / 10, this.ActualHeight / 10), BorderEnlarge, 0.6);
                            AnimationOpacityEnlarge(0, 1, BorderEnlarge, 0.6);
                        });
                        Thread.Sleep(600);
                        this.Dispatcher.Invoke(() =>
                        {
                            AnimationOpacityEnlarge(0, 1, ViewboxPlayerEnlarge, 0.4);
                        });
                    });
                }
            }
            else
            {

                Async();
                async void Async()
                {
                    await Task.Run(() =>
                    {
                        Thread.Sleep(200);
                        this.Dispatcher.Invoke(() =>
                        {
                            GridEnlarge.Visibility = Visibility.Hidden;
                        });
                    });
                }

            }
            AnimationOpacityEnlarge(((sender as ButtonAdv).Label == "enlarge") ? 0 : 1, ((sender as ButtonAdv).Label == "enlarge") ? 1 : 0, GridEnlarge, 0.2);

        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape && GridEnlarge.Visibility == Visibility.Visible)
            {
                AnimationOpacityEnlarge(1, 0, GridEnlarge, 0.2);
                Async();
                async void Async()
                {
                    await Task.Run(() =>
                    {
                        Thread.Sleep(200);
                        this.Dispatcher.Invoke(() =>
                        {
                            GridEnlarge.Visibility = Visibility.Hidden;
                        });
                    });
                }
            }
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            LabelNameSong.MaxWidth = this.ActualWidth / 4;
            LabelSubtitleSong.MaxWidth = this.ActualWidth / 4;
        }

        DispatcherTimer timer;

        public void Init(Border border, List<string> ActualPlayingMusicList)
        {
            StackPanelPlayerInfo.Visibility = Visibility.Visible;
            BorderImagePlayerCover.Background = new ImageBrush()
            {
                ImageSource = ApplicationSettings.Default.Cover[(int)border.Tag]
            };
            ImageAudio.ImageSource = ApplicationSettings.Default.Cover[(int)border.Tag];

            string NameSong = Files.Trim(System.IO.Path.GetFileName(border.DataContext.ToString()), ".");
            LabelNameSong.Content = Files.Trim(NameSong, "-");
            LabelSubtitleSong.Content = Files.TrimBack(NameSong, "-");

            if (LabelNameSong.Content.ToString().Length < 2 || LabelSubtitleSong.Content.ToString().Length < 2)
            {
                LabelNameSong.Content = NameSong;
                LabelSubtitleSong.Content = "";
            }
            bool check = false;
            for (int i = 0; i < ApplicationSettings.Default.FilesLike.Count; i++)
                if (ApplicationSettings.Default.FilesLike[i] == border.DataContext.ToString()) { check = true; break; }
            LikeStatus.SmallIcon = (ImageSource)new ImageSourceConverter().ConvertFromString((check) ? "pack://application:,,,/Resources/Player/like_active.png" : "pack://application:,,,/Resources/Player/Like.png");


            ButtonAdvPlayerPlayPause.SmallIcon = (border.Background as ImageBrush).ImageSource;
            ButtonAdvPlayerPlayPause.SmallIcon = InvertImage.Invert((BitmapSource)ButtonAdvPlayerPlayPause.SmallIcon, (ApplicationSettings.Default.Theme == "Light") ? true : false);

            NewSong = (Player.ActualPlayingMusic != border.DataContext.ToString() || Player.ActualPlayingMusic == null) ? true : false;
            Player.ActualPlayingMusic = border.DataContext.ToString();
            Player.ActualPlayingMusicList = ActualPlayingMusicList;
            Player.ActualPlayingMusicIndex = (int)border.Tag;
          Player.HomeLast.Insert(0,Player.ActualPlayingMusic);


         //   Player.InfoPathImage = (Player.Play) ? "pack://application:,,,/Resources/Player/pause.png" : "pack://application:,,,/Resources/Player/play.png";
            waveOut.Pause();
            Play();
            InitActivePlayInfo();

        }

        bool NewSong = true;
        Mp3FileReader reader;
        private WaveOut waveOut = new WaveOut();
        public void Play()
        {

            waveOut.Pause();
            if (NewSong)
            {
                reader = new Mp3FileReader(Player.ActualPlayingMusicList[Player.ActualPlayingMusicIndex]);

                timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(0.4);
                timer.Tick += timer_Tick;
            }

            if (reader != null)
            {
                waveOut.Init(reader);


                if (Player.Play)
                {
                    waveOut.Play();
                    timer.Start();
                }
                else
                {
                    waveOut.Pause();
                    timer.Stop();
                }

                BorderImagePlayerCover.Background = new ImageBrush()
                {
                    ImageSource = Files.GetCoverFile(Player.ActualPlayingMusicList[Player.ActualPlayingMusicIndex])
                };
                ImageAudio.ImageSource = Files.GetCoverFile(Player.ActualPlayingMusicList[Player.ActualPlayingMusicIndex]);

                string NameSong = Files.Trim(System.IO.Path.GetFileName(Player.ActualPlayingMusicList[Player.ActualPlayingMusicIndex]), ".");
                LabelNameSong.Content = Files.Trim(NameSong, "-");
                LabelSubtitleSong.Content = Files.TrimBack(NameSong, "-");

                if (LabelNameSong.Content.ToString().Length < 2 || LabelSubtitleSong.Content.ToString().Length < 2)
                {
                    LabelNameSong.Content = NameSong;
                    LabelSubtitleSong.Content = "";
                }

                bool check = false;
                for (int i = 0; i < ApplicationSettings.Default.FilesLike.Count; i++)
                    if (ApplicationSettings.Default.FilesLike[i] == Player.ActualPlayingMusicList[Player.ActualPlayingMusicIndex]) { check = true; break; }
                LikeStatus.SmallIcon = (ImageSource)new ImageSourceConverter().ConvertFromString((check) ? "pack://application:,,,/Resources/Player/like_active.png" : "pack://application:,,,/Resources/Player/Like.png");
                LikeStatus.SmallIcon = InvertImage.Invert((BitmapSource)LikeStatus.SmallIcon, (ApplicationSettings.Default.Theme == "Light") ? true : false);
            }
        }

        private void ButtonAdvPlayerPreviousNext_Click(object sender, RoutedEventArgs e)
        {
            if (Player.ActualPlayingMusicList?.Count > 0)
            {
                NewSong = true;

                if ((sender as ButtonAdv).Label == "next")
                    Player.ActualPlayingMusicIndex = (Player.ActualPlayingMusicIndex + 1 < Player.ActualPlayingMusicList.Count) ? Player.ActualPlayingMusicIndex + 1 : 0;

                else
                    Player.ActualPlayingMusicIndex = (Player.ActualPlayingMusicList.Count > 0 & Player.ActualPlayingMusicIndex > 0) ? Player.ActualPlayingMusicIndex - 1 : Player.ActualPlayingMusicList.Count - 1;
                Play();

                InitActivePlayInfo();
                Player.HomeLast.Insert(0,Player.ActualPlayingMusic);
            }
        }

        private void InitActivePlayInfo()
        {
            if (Player.ActualPlayingMusicList?.Count > 0)
            {
                for (int i = 0; i < Player.ActualPlayingMusicList.Count; i++)
                {
                    var ActualSong_ = AplicationWindow.WrapPanelLibrary[Player.NameFrameIndex].Children[i];
                    var activeCover_ = (ActualSong_ as Grid).Children[3];
                    if ((ActualSong_ as Grid).Children.Count == 5)
                    {
                        (ActualSong_ as Grid).Children.RemoveAt(4);
                        (ActualSong_ as Grid).Children[3].MouseEnter -= ActualSong_MouseEnter;
                        (ActualSong_ as Grid).Children[3].MouseLeave -= ActualSong_MouseLeave;
                    }
                      (((activeCover_ as Border).Child as Grid).Children[0] as Border).Background = new ImageBrush()
                      {
                          ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString($"pack://application:,,,/Resources/Player/Play.png")
                      };
                }
                //  MessageBox.Show(waveOut.PlaybackState.ToString());
                var ActualSong = AplicationWindow.WrapPanelLibrary[Player.NameFrameIndex].Children[Player.ActualPlayingMusicIndex];
                var activeCover = (ActualSong as Grid).Children[3];
                (ActualSong as Grid).Children.Add(MusicTemplate.TemplateActiveCoverImagePlayPause((((activeCover as Border).Child as Grid).Children[0] as Border)));

                (ActualSong as Grid).Children[3].MouseEnter += ActualSong_MouseEnter;
                (ActualSong as Grid).Children[3].MouseLeave += ActualSong_MouseLeave;
                (((activeCover as Border).Child as Grid).Children[0] as Border).Background = new ImageBrush()
                {
                    ImageSource = (ImageSource)new ImageSourceConverter().ConvertFromString($"pack://application:,,,/Resources/Player/{((waveOut.PlaybackState.ToString() == "Playing") ? "Pause" : "Play")}.png")
                };
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

        private void ActualSong_MouseEnter(object sender, RoutedEventArgs e)
        {
          
            var ActualSong = AplicationWindow.WrapPanelLibrary[Player.NameFrameIndex].Children[Player.ActualPlayingMusicIndex];
            (ActualSong as Grid).Children[4].Visibility = Visibility.Hidden;
        }
        private void ActualSong_MouseLeave(object sender, RoutedEventArgs e)
        {
         
            var ActualSong = AplicationWindow.WrapPanelLibrary[Player.NameFrameIndex].Children[Player.ActualPlayingMusicIndex];
            (ActualSong as Grid).Children[4].Visibility = Visibility.Visible;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SliderPlayer.Minimum = 0;
            SliderPlayer.Maximum = reader.TotalTime.TotalSeconds;
            SliderPlayer.Value = reader.CurrentTime.TotalSeconds; //!
            LabelPlayerTimeLeft.Content = TimeSpan.FromSeconds(reader.CurrentTime.TotalSeconds).ToString(@"mm\:ss");
            LabelPlayerTimeRight.Content = TimeSpan.FromSeconds(reader.TotalTime.TotalSeconds - reader.CurrentTime.TotalSeconds).ToString(@"mm\:ss");
            if (SliderPlayer.Value == reader.TotalTime.TotalSeconds)
            {
                SliderPlayer.Value = 0;
                NewSong = true;
                Player.ActualPlayingMusicIndex = (Player.ActualPlayingMusicIndex + 1 < Player.ActualPlayingMusicList.Count) ? Player.ActualPlayingMusicIndex + 1 : 0;
                Play();
                InitActivePlayInfo();
            }

        }

        private void SliderPlayer_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (reader != null)
            {
                SliderPlayer.Minimum = 0;
                SliderPlayer.Maximum = reader.TotalTime.TotalSeconds;
             
                LabelPlayerTimeLeft.Content = TimeSpan.FromSeconds(reader.CurrentTime.TotalSeconds).ToString(@"mm\:ss");
                LabelPlayerTimeRight.Content = TimeSpan.FromSeconds(reader.TotalTime.TotalSeconds - reader.CurrentTime.TotalSeconds).ToString(@"mm\:ss");
                reader.CurrentTime = TimeSpan.FromSeconds(SliderPlayer.Value);
            }
        }

        private void SliderPlayerVoice_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
          
            (sender as Slider).Value += (e.Delta > 0) ? (sender as Slider).Maximum / 30 : -(sender as Slider).Maximum / 30;
        }
    }
}