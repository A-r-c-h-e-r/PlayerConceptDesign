   M S B A M L   `   `   `  ���� N  JPlayerConceptDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:PlayerConceptDesign.View.MenuPlayerConceptDesign.View.Menu  M+clr-namespace:PlayerConceptDesign.ViewModelPlayerConceptDesign.ViewModel  )    #PlayerConceptDesign.View.Menu.Likes   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     =local+clr-namespace:PlayerConceptDesign.View.Menu     A	viewmodel+clr-namespace:PlayerConceptDesign.ViewModel       N� Title$  Likes�� � DataContext 1   +PlayerConceptDesign.ViewModel.SetColorTheme  .��� $��	10,0,10,0q�.+�� $y�Hidden=�.+��� -    ��Name$
 Mask��$	��100��$	��100�����#000000 �� CornerRadius$ 4���� $��Likes��$��25(�$��Medium&����� *colorsTheme.ColorForeground+ �� Mode$ TwoWay=�� $��10,50,10,10q�.+�� -   $��
WarpPanel_��.+�� $	��100��$	��120�� J� Opacity$	 0.9Q�$��10q�.+��� $��10,20,10,10q�.+��� $
��Fill=� �� BitmapScalingMode$ HighQuality=�$0��*pack://application:,,,/Resources/templ.jpg�� J� OpacityMask !�  !� Visual �� 	 �� ElementName$
	 Mask��
 J� Effect
 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 14Q�   	Direction$	 270Q�   ShadowDepth$ 6Q�   RenderingBias$ Quality=�   Opacity$	 0.6Q��� .+��� $
��Fill=�$ HighQuality=�$0��*pack://application:,,,/Resources/templ.jpg�� !�  �� $
	 Mask��
   $ 8Q�$ 1Q�$ Quality=�$	 0.3Q��� $��Ruid to the big��$��Bottom=�$
��Left=�$	 0.8Q�$��0,0,0,-5q��� $��Riana��$��Bottom=�$
��Left=�$	 0.5Q�$��	0,0,0,-20q��� $	��100��$	��120��$	 0.9Q�$��10q�._�� .+��� $	��100��$	��100��$	��Top=�$ 4������  �� ImageSource$0 *pack://application:,,,/Resources/templ.jpg���� $��Ruid to the big��$��Bottom=�$
��Left=�$	 0.8Q�$��0,0,0,-5q��� $��Riana��$��Bottom=�$
��Left=�$	 0.5Q�$��	0,0,0,-20q�