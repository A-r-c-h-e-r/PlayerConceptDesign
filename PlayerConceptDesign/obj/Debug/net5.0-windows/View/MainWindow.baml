   M S B A M L   `   `   `  ����N  JPlayerConceptDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:PlayerConceptDesign.ViewModelPlayerConceptDesign.ViewModel  5   	   9!clr-namespace:PlayerConceptDesignPlayerConceptDesign  5   	   )    #PlayerConceptDesign.View.MainWindow   5   	   ` \Syncfusion.Tools.Wpf, Version=19.1500.0.63, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.Shared.WPF, Version=19.1500.0.63, Culture=neutral, PublicKeyToken=3d67ed1f87d44c894
syncfusion!http://schemas.syncfusion.com/wpf   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   A	viewmodel+clr-namespace:PlayerConceptDesign.ViewModel     5   	   3local!clr-namespace:PlayerConceptDesign     5   	   -   5          � Title$  Lite audio player��5
   	    � Icon$? 9pack://application:,,,/Resources/Icon/icon_aplication.ico��5   	   $	��600��5   	   $
��1000��6   $	��450��6#   $	��700��63    � DataContext 5      1   +PlayerConceptDesign.ViewModel.SetColorTheme  5   
   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $��50 �6    .+�5      � .+�5       � -   5          �Name$ 	MainFrame��5   +   $��	133,0,0,0q�6     � NavigationUIVisibility$ Hidden=�6>    J� Opacity$ 0Q�6^     � Source$0 *pack://application:,,,/View/Menu/Home.xaml?�6j   6�   �� 5      -   5         ��Name$ 	MenuPanel��5      $
��Left=�6,   	 �� CornerRadius$	 0,8,8,0��6�   $
 0.35Q�6�   ��6G   �� *colorsTheme.ColorMenu+
 �� Mode$
 TwoWay=���5      �� -   'PlayerConceptDesign.ApplicationSettings   Default �� Source# Z  �� Path$ SizeMenu�$
 TwoWay=�._�5      � .+�5       �� $	 0,8,8,0��6!   $	 0.5Q�68   5!      � 5"      $��3,0,0,0q�6    .+�5#      1  +Syncfusion.Windows.Tools.Controls.ButtonAdv  -   5          Name$
 Home��5#   3   $	��Top=�6A   $��0,5,0,0q�6Y   $��25��6k   $	��105��6w   &    PlayerConceptDesign.Localization   Home   Label# Z 6�      	SmallIcon$; 5pack://application:,,,/Resources/Menu/Images/home.png��6�      StyleButtonMenu#���   5$   /   6�     5%      -   5        $ Library��5%   3   $	��Top=�6D   $��0,35,0,0q�6]   $��25��6o   $	��105��6{      Library# Z 6�   $> 8pack://application:,,,/Resources/Menu/Images/library.png��6�   #���   5&   /   6�     5'      -   5        $ Playlist��5'   3   $	��Top=�6E   $��0,95,0,0q�6^   $��25��6p   $	��105��6|      Playlist# Z 6�   $? 9pack://application:,,,/Resources/Menu/Images/playlist.png��6�   #���   5(   /   $y�	Collapsed=�6�     5)      -   5        $ Likes��5)   3   $	��Top=�6B   $��0,65,0,0q�6[   $��25��6m   $	��105��6y      Likes# Z 6�   $< 6pack://application:,,,/Resources/Menu/Images/likes.png��6�   #���   5*   /   6�     5+      -   5        $ Settings��5+   3   $��Bottom=�6E   $��0,0,0,5q�6a   $��25��6r   $	��105��6~      Settings# Z 6�   $? 9pack://application:,,,/Resources/Menu/Images/settings.png��6�   #���   5,   /   6�   5-      �� 5.      -	   5        $ 
InfoBorder��5.   !   $��25��6u   $��3��6�   $	 0,3,3,0��5/      $
��Left=�64   $	��Top=�6O   ��5.   5   �� *colorsTheme.ColorInfoBorder+$
 TwoWay=���5/   h   ��  �� ElementName$ MenuHome��$ Margin�50      51      53      �� 55      $��1��6   $	 0.7Q�6c   $��0,1,0,0q�56   ^   ��55   "   �� *colorsTheme.ColorPlayerPanel+$
 TwoWay=���56      �� *)'colorsTheme.ColorPlayerPanelBorderBrush+$
 TwoWay=�._�58      � .+�59      �� -
   5         ��Name$ StackPanelPlayerInfo��59   U    �� Orientation$ 
Horizontal=�6!   $
��Left=�6:   $y�Hidden=�6s   .+�5:      �� -   5        $ BorderImagePlayerCover��5:   !   
���   �$	 5��6T   $��40��6e   $��40��6p   $��10,0,0,0q�6|    J� Effect 5;      3  -System.Windows.Media.Effects.DropShadowEffect  5<   "      
BlurRadius$ 10Q�63      ShadowDepth$ 0Q�6C      Opacity$	 0.6Q�6S   5>      �� 5?      $��0,2,0,0q�6%   .+�5A   "   �� -   5         ��Name$ LabelNameSong��5A   (   $��Center=�6?   $��5,0,0,0q�6Z   $��LabelNameSong��6k   $��14(�6�   ��6�   �� *colorsTheme.ColorForeground+$
 TwoWay=�6�   �� 5C      -   5        $ LabelSubtitleSong��5C   $   $��Center=�6?   $��	5,-10,0,0q�6Z   $��LabelSubtitleSong��6m   $��11(�6�   $	 0.6Q�6�   ��6�   �� *colorsTheme.ColorForeground+$
 TwoWay=�6�   5D        5E      -   5        $ 
LikeStatus��5E   /   $ unlike��6C   $��15��6S   $��15��6^     StyleButtonAdvPlayer#��[ 6j   $��	10,0,40,0q�5F   +   $6 0pack://application:,,,/Resources/Player/like.png��6>   $
 0.65Q�6{   6�   5H      � 5J       � ColumnDefinitions 5K      �� 5L      $��3* �6/   ��6:   �� $ StackPanelPlayerInfo��$ ActualWidth��� 5M      $��4* �6/   �� 5N      $��3* �6/   .+�5Q      �� $��1��6%   $��0,4,0,0q�65   $	��Top=�6F   $��Center=�6^   $ 
Horizontal=�6{   .+�5U        -   5        $ EffectColorBackLight��5U   3   $��0��6Q   $��0��6\   $y�	Collapsed=�6f    5V   "     5W   &   $ 1Q�67   $ 0Q�6F   $ 1Q�6�      Color 6V   �� *colorsTheme.ColorBackLight+$
 TwoWay=�6�   5Y        5\      -   5        $ ButtonAdvPlayerRandom��5\   3   $��12��6T   $��12��6_   $ random��6k   #��[ 6z   $8 2pack://application:,,,/Resources/Player/random.png��5]   ,   $
 0.65Q�6k   $��0,0,12,0q�6z   6�     5`      -   5        $ ButtonAdvPlayerPrevious��5`   3   $��15��6V   $��15��6a   $ previous��6m   #��[ 6~   $: 4pack://application:,,,/Resources/Player/previous.png��5a   ,   $
 0.65Q�6m   6|     5c      -   5        $ ButtonAdvPlayerPlayPause��5c   3   $��	20,0,20,0q�6U   $
 play��6h   $��25��6v   $��25��6�   #��[ 6�   $6 0pack://application:,,,/Resources/Player/play.png��5d   ,   $
 0.65Q�6i   6x     5f      -   5        $ ButtonAdvPlayerNext��5f   3   $��15��6R   $��15��6]   $
 next��6i   #��[ 6v   $6 0pack://application:,,,/Resources/Player/next.png��5g   ,   $
 0.65Q�6i   6x     5i      -   5        $ ButtonAdvPlayerRepeat��5i   3   $��12��6T   $��12��6_   $ repeat��6k   #��[ 6z   $8 2pack://application:,,,/Resources/Player/repeat.png��5j   ,   $
 0.65Q�6k   $��12,0,0,0q�6z   6�   5l      �� 5n      -   5        $ LabelPlayerTimeLeft��5n       $��00:00��6=   $��11(�6�   $	 0.6Q�5o      $��Bottom=�6*   $��Right=�6F   $��0,0,0,2q�6b   ��5n   M   �� *colorsTheme.ColorForeground+$
 TwoWay=�5o   b   �� 5p      -   5        $ LabelPlayerTimeRight��5p       $��00:00��6>   $��11(�6�   $	 0.6Q�5q      $��Bottom=�6*   $
��Left=�6F   $��0,0,0,2q�6a   $��2��6r   ��5p   N   �� *colorsTheme.ColorForeground+$
 TwoWay=�5q   r   � 5s      $��1��6   .+�5t      �� -   5          ��Name$  SliderPlayer��5t   %   ! �� TickFrequency$
! 0.01Q�6;   " �� IsSnapToTickEnabled$
" True��6P   $��20��6l   $��Bottom=�6x   ���#A0A0A0# �� IsMoveToPointEnabled$
# True��5v      $ � Value$$ 0Q�69   % � Minimum$% 0Q�6C   & � Maximum$
& 3.42Q�6O   ' �� IsPressAndHoldEnabled$' False��6^   $��0,0,0,4q�6�     StyleSliderPlayer#��[ 6�   ��5u   3   �� *colorsTheme.ColorPlayerSlider+$
 TwoWay=���6u   �� *colorsTheme.ColorForeground+$
 TwoWay=�5v   �   5y      � 5z      $��2��6   $��40,0,0,0q�6/    5{      �� 5|   "   $��2* �63   �� 5}   "   $��8* �63   $	��200��6>   .+�5�      � $��1��6#   .+�5�   "     -   5        $ ButtonAdvPlayerVoice��5�   7   $ voice0��6U   $
��Left=�6d   $��17��6�   $��17��6�   #��[ 6�   $��0,0,10,0q�5�   +   $8 2pack://application:,,,/Resources/Player/voice0.png��6=   $
 0.65Q�6|   6�   �� 5�   "   -   5        $  SliderPlayerVoice��5�   )   $% 0Q�6D   $& 1Q�6P   $! 0.001Q�6�   $��Center=�6�   $' False��5�   %   $
" True��6K   $��7��6f   $��14��6t   $
# True��6�   $��	20,0,30,0q�5�   %   ���#A0A0A0  StyleSlider#��[ 6�   $ 5�   \   �� # Z $ Voice�$
 TwoWay=���5�   N   �� *colorsTheme.ColorPlayerSlider+$
 TwoWay=�6    5�   "   -   5        $ ButtonAdvPlayerEnlarge��5�   7   $ enlarge��6W   $��Right=�6g   $��15��6�   $��15��6�   #��[ 6�   $��0,0,10,0q�5�   +   $9 3pack://application:,,,/Resources/Player/enlarge.png��6=   $
 0.65Q�6}   6�   5�      5�      5�      5�      5�      ��5�      
� 5�      ( 
� RadiusX$	( 0.8Q�6&   ) 
� RadiusY$	) 0.6Q�64   * 
� GradientOrigin$* 0.5,-0.6&�6B   .��5�      � + � Offset$	+ 0.3Q�6a   , � Color, 6#   �� * colorsTheme.ColorMainGradient1+$
 TwoWay=�6a   � 5�      $	+ 0.8Q�6a   , 6#   �� * colorsTheme.ColorMainGradient2+$
 TwoWay=�6a   5�      5�      � 5�   
   -   5        - �Name$- GridEnlarge��5�      $y�Hidden=�6C   .+�5�      � 
���   �$
 0.85Q�6&   �� 5�      -   5        $ BorderEnlarge��5�      $	 10��6.   $��100,60,100,60q�6@   ._�5�      � .+�5�        -   5        $ ButtonAdvPlayerReduce��5�   +   $ reduce��6J   $��Right=�6Y   $	��Top=�6u   $��17��6�   $��17��6�   #��[ 6�   $��	0,15,15,0q�5�   +   $8 2pack://application:,,,/Resources/Player/reduce.png��6>   $
 0.65Q�6}   6�   � 5�      .+�5�      (� -   5        . (�Name$. ViewboxPlayerEnlarge��5�   "   $	��500��6A   $��
0,20,10,90q�6Q   .��5�      � .+�5�   "   �� / �� RadiusX$/ 10��6,   0 �� RadiusY$0 10��69   $	��150��6F   $	��150��6R   $��0,0,0,20q�6_   ��5�   &   �� 5�   *   -   5        
ImageAudio��5�   6   1 J� BitmapEffect1 5�   &   F� 5�   *   2 F� 	Direction$2 0Q�6A   3 F� ShadowDepth$3 0Q�6O   5�   #     5�   "   -    5        $" ButtonAdvPlayerRandomEnlarge��5�   7   $��12��6_   $��12��6j   $ random��6v   #��[ 6�   $��Bottom=�6�   $8 2pack://application:,,,/Resources/Player/random.png��5�   ,   $
 0.65Q�6�   $��
0,0,110,-1q�6�    6l   �� $ ButtonAdvPlayerRandom��$ Effect�6�     5�   "   -!   5        $$ ButtonAdvPlayerPreviousEnlarge��5�   7   $��15��6a   $��15��6l   $ previous��6x   #��[ 6�   $��Bottom=�6�   $: 4pack://application:,,,/Resources/Player/previous.png��5�   ,   $
 0.65Q�6m   $��	0,0,60,-3q�6|   6�     5�   "   -"   5        $% ButtonAdvPlayerPlayPauseEnlarge��5�   7   $��0,0,0,-8q�6`   $
 play��6r   $��25��6�   $��25��6�   #��[ 6�   $��Bottom=�6�   $
 0.65Q�5�   w    6,   �� $ ButtonAdvPlayerPlayPause��$ 	SmallIcon�6�     5�   "   -#   5        $  ButtonAdvPlayerNextEnlarge��5�   7   $��15��6]   $��15��6h   $
 next��6t   #��[ 6�   $��Bottom=�6�   $6 0pack://application:,,,/Resources/Player/next.png��5�   ,   $
 0.65Q�6i   $��	60,0,0,-3q�6x   6�     5�   "   -$   5        $" ButtonAdvPlayerRepeatEnlarge��5�   7   $��12��6�   $��12��6�   $ repeat��6�   #��[ 6�   $��Bottom=�6�   $8 2pack://application:,,,/Resources/Player/repeat.png��5�   ,   $
 0.65Q�6k   $��
110,0,0,-1q�6z    5�   ^   �� $ ButtonAdvPlayerRepeat��$ Effect�5�   �   5�      5�      5�      �� 5�      $ 
Horizontal=�6!   $��Bottom=�6:   $��0,0,0,45q�6U   $��Center=�6g   .+�5�      �� $��21(�6�   $	 0.7Q�6�   ��6    �� $ LabelNameSong��$ Content���6]   �� *colorsTheme.ColorForeground+$
 TwoWay=�6�   �� 5�      $��20(�6�   $	 0.5Q�6�   $��0,3,0,0q�6�   ��6    �� $ LabelSubtitleSong��$ Content���6a   �� *colorsTheme.ColorForeground+$
 TwoWay=�6�   5�      �� 5�      $��35��6^   $��20,10,20,10q�6j   $��Bottom=�6   $	 10��6�   $
 10.3Q�6�   ��6   �� *colorsTheme.ColorPlayerPanel+$
 TwoWay=� 5�        5�      $ 4Q�6/   $ 9Q�6?   4   	Direction$
4 3151Q�6N   $	 0.5Q�6_   5�      � 5�      $��35��6   $��Bottom=�6'   $��20,10,20,10q�6B    5�      �� 5�      $
��7.5* �6/   �� 5�      $
��2.5* �6/   $	��200��6<   .+�5�      � $��	10,0,10,0q�6   .+�5�      �� -%   5        $! LabelPlayerTimeLeftEnlarget��5�   $   $��11(�6�   $	 0.6Q�5�      $��Center=�6*   $��Right=�6F   ��5�   I   �� $ LabelPlayerTimeLeft��$ Content���6�   �� *colorsTheme.ColorForeground+$
 TwoWay=�5�   F   �� 5�      -&   5        $! LabelPlayerTimeRightEnlarge��5�   $   $��11(�6�   $	 0.6Q�5�      $��Center=�6*   $
��Left=�6F   ��5�   I   �� $ LabelPlayerTimeRight��$ Content���6�   �� *colorsTheme.ColorForeground+$
 TwoWay=�5�   F   �� 5�      -'   5        $  SliderPlayerEnlarge��5�   %   $
! 0.01Q�6D   $
" True��6Y   $��20��6u   $��Center=�6�   $��	35,0,35,0q�6�   ���#A0A0A0$
# True��5�      $' False��5�   `   #��[ 6�   ��5�   3   �� *colorsTheme.ColorPlayerSlider+$
 TwoWay=���6u   �� *colorsTheme.ColorForeground+$
 TwoWay=�$ 5�   9   �� $ SliderPlayer��$ Value�% 6p   �� $ SliderPlayer��$ Minimum�& 5�   %   �� $ SliderPlayer��$ Maximum�6�   5�      � 5�      $��	10,0,10,0q�6   $��1��62   .+�5�        -(   5        $" ButtonAdvPlayerVoiceEnlarget��5�   3   $ voice0��6Y   $
��Left=�6h   $��17��6�   $��17��6�   #��[ 6�   $��0,0,10,0q�5�   +   $
 0.65Q�6�    6=   �� $ ButtonAdvPlayerVoice��$ 	SmallIcon�6�   �� 5�      -)   5        $  SliderPlayerVoiceEnlarget��5�   %   $% 0Q�6H   $& 1Q�6T   $! 0.001Q�6�   $��Center=�6�   $' False��5�   %   $
" True��6K   $��7��6f   $��14��6t   $
# True��6�   $��20,0,0,0q�5�   %   ���#A0A0A0#��[ 6�   $ 5�   `   �� $ SliderPlayerVoice��$ Value���5�   M   �� *colorsTheme.ColorPlayerSlider+$
 TwoWay=�6�   5�      5�      5�      ��5�      
� 5�      $	( 0.8Q�6*   $	) 0.6Q�68   $* 0.5,-0.6&�6F   .��5�      � $	+ 0.3Q�6h   , 6'   �� *#!colorsTheme.ColorEnlargeGradient1+$
 TwoWay=�6h   � 5�      $	+ 0.8Q�6h   , 6'   �� *#!colorsTheme.ColorEnlargeGradient2+$
 TwoWay=�6h   5�      5�      5�      5�      5�      