   M S B A M L   `   `   `  ���� N  JPlayerConceptDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:PlayerConceptDesign.ViewModelPlayerConceptDesign.ViewModel  9!clr-namespace:PlayerConceptDesignPlayerConceptDesign  ,    &PlayerConceptDesign.View.Menu.Settings   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     A	viewmodel+clr-namespace:PlayerConceptDesign.ViewModel     3local!clr-namespace:PlayerConceptDesign       N� Title$  Settings�� � DataContext 1   +PlayerConceptDesign.ViewModel.SetColorTheme  .��� $��10,0,0,0q�.+��� $��Settings��$��25(�$��Medium&����� *colorsTheme.ColorForeground+ �� Mode$ TwoWay=�� $��0,50,0,0q� � ColumnDefinitions �� �� $	��300 �.+��� .+��� $��Theme��$��20(�$��Medium&����� *colorsTheme.ColorForeground+$ TwoWay=��� $	��160��$��28��$��1q� �� CornerRadius$ 1��$
��Left=����	#50000000���	#50666666._�� .+��� -    ��Name$ LabelActiveTheme��$
��Dark��$��15(�$��Medium&�$��	4,-3,0,-1q����� *colorsTheme.ColorForeground+$ TwoWay=��� $9��3pack://application:,,,/Resources/Settings/arrow.png��$��Right=�$��16��$��16��$��0,5,10,0q� J� Opacity$	 0.6Q�$	��Top=��� $	��150��$��1��$��0,26,0,0q����	#60666666$	��Top=�$	 0.5���� $��0,28,0,0q� � 	Resources  �� 
TargetType	 �� Property
 �� Value �� 
TargetType �� Triggers :� RoutedEvent �� TargetProperty	 �� To g� Duration��%�  '��       �� " ��.��� 	 � ��
 �� " ��.R��� #��z��$ 1��$	 0.7Q�._�� .+��� #��z��$��0,-2,0,0q�$��15(�$��Medium&����� *colorsTheme.ColorForeground+$ TwoWay=��� #��z��$��20��$��20��$ 2��$��Right=�$	 0.7Q�$��0,0,4,0q� :� $ UIElement.MouseEnter��.[��� .���� .���� $ Background.Color� 	#50999999$ 0:0:0.1D�:� $ UIElement.MouseLeave��.[��� .���� .���� $ Background.Color� Transparent$ 0:0:0.1D�.+��� -   $	��150��$��28��
������ ���#555555$
��Dark��$��0,0,0,2q��� -   $	��150��$��28��
������ ���#CCCCCC$��Light��$��0,0,0,2q��� -   $	��150��$��28��
������ ���#999999$��Silver��$��0,0,0,2q��� -   $	��150��$��28��
������ ���#707D96$
��Blue��$��0,0,0,2q��� -   $	��150��$��28��
������ ���#837096$��Purple������ " �� :� $ UIElement.MouseEnter��.[��� .���� .��W� $ 0:0:0.5D�$ Height�	 W� To 180 W� EasingFunction .  (System.Windows.Media.Animation.PowerEase     Power$ 6Q�:� $ UIElement.MouseLeave��.[��� .���� .��W� $ 0:0:0.3D�$ Height� 28   $ 6Q��� $��Animation speed��$��20(�$��Medium&����� *colorsTheme.ColorForeground+$ TwoWay=��� $9��3Set animation speed in milliseconds from 0.1 to 0.9��$��13(�$��Medium&�$
��Left=�$	 0.6Q�$��	0,-10,0,0q����� *colorsTheme.ColorForeground+$ TwoWay=�� .+��� -    ��Name$ SliderAnimationSpeed��$	��190��$
��Left=� �� TickFrequency$
 0.01Q� �� IsSnapToTickEnabled$
 True�����#A0A0A0���#4C4C4C �� IsMoveToPointEnabled$
 True�� � Value$	 0.2Q� � Minimum$	 0.1Q� � Maximum$	 0.9Q�$��20��$��7�� �� IsPressAndHoldEnabled$ False��$��12(����� *colorsTheme.ColorForeground+$ TwoWay=����� " ��.��� 	 � ��
 �� " ��.R��� 
������  J� SnapsToDevicePixels$
 true��._�� .+���  ��Name$ TrackBackground��#��z��$ 2��$��5��$��center=�$��0,0,32,0q��� $��	0,-2,-2,0q�#��z $��32��$��Right=�#��z��]�  ]�Name$ 
PART_Track��$��0,0,32,0q� ��%o   '��       �� " ��.��� 	 � ��
 �� " ��.R��� $ 2��$	��5.0��$��0,0,-3,0q�$��center=�#��z�� ]� DecreaseRepeatButton ��   �� DecreaseLarge#��Z  ! � OverridesDefaultStyle$
! True��$��False��$|�False�����	#70ffffff" ]� IncreaseRepeatButton" �� # �� IncreaseLarge#��Z# $
! True��$��False��$|�False��
������ $ ]� Thumb$ n� % n�Name$% Thumb��$|�False��$
! True��#��z��#��z��#��z������ " n�.��� 	 � ��
 �� " n�.R��� $ ThumbBorder��#��z��$ 3��& J� BitmapEffect& F� ' F� Color$' Black��( F� 	Direction$( 1Q�) F� ShadowDepth$) 0Q�* F� Softness$
* 0.15Q�+ F� Opacity$	+ 0.7Q�, �� Triggers, P� - P� Property- �@J�IsMouseOver. P� Value$
. true��. ��� / �� 
TargetName$/ ThumbBorder��	 � ��
 �#D0D0D0�� $��Folder��$��20(�$��Medium&����� *colorsTheme.ColorForeground+$ TwoWay=��� $��Open folder with music��$��13(�$��Medium&�$	��145��$
��Left=�$	 0.6Q�$��	0,-10,0,0q����� *colorsTheme.ColorForeground+$ TwoWay=����� " �� :� $ UIElement.MouseEnter��.[��� .���� .��W� $ Opacity� 1$ 0:0:0.1D�:� $ UIElement.MouseLeave��.[��� .���� .��W� $ Opacity� 0.6$ 0:0:0.1D��� $��
Show album��$��20(�$��Medium&����� *colorsTheme.ColorForeground+$ TwoWay=��� $6��0See the cover of the artist you are listening to��$��13(�$��Medium&�$	 0.6Q�$��	0,-10,0,0q����� *colorsTheme.ColorForeground+$ TwoWay=�� .+��� -   0 ��Name$0 CheckBoxShowAlbum��$	��Off��$��80��$��20��$
��Left=�
������ ���#7777771 J� OpacityMask1 �#EEEEEE$��5,0,0,0q����� *colorsTheme.ColorForeground+$ TwoWay=����� " ��.��� 	 � ��
 �� " ��.R�� 2 �Name$2 FormCheckBox��$	 0.7Q�.+��� #��z��#��z��$	��1.5q�$	 9.5��$��45��$
��Left=��� $	 Obj��#��z1 $��15��$��15��$
��Left=�$ 10��$��3,0,0,0q��� #��z��#��z��$��
45,-3,0,-2q�, P� - �@d�	IsChecked$
. TrueY�3 N� ExitActions3 �� .���� .��t� $ 0:0:0.2D�4 �� 
TargetName$	4 Obj��$ Margin�	5 t� To5 3,0,0,06 t� EasingFunction6   $ 6Q�W� $4 FormCheckBox��$ Opacity� 0.7$ 0:0:0.2D��� $ Background.Color� Transparent$ 0:0:0.2D�7 N� EnterActions7 �� .���� .��t� $ 0:0:0.2D�$	4 Obj��$ Margin�5 27,0,0,06   $ 6Q�W� $4 FormCheckBox��$ Opacity� 1$ 0:0:0.2D��� $ Background.Color� 	#90777777$ 0:0:0.2D��� $��1��.+��� $��Application��$��20(�$��Medium&����� *colorsTheme.ColorForeground+$ TwoWay=��� $��Version 1.0��$��15(�$��Medium&�$	 0.8Q�$��0,-8,0,0q����� *colorsTheme.ColorForeground+$ TwoWay=��� $��
© Company��$��15(�$��Medium&�$	 0.8Q�$��0,-8,0,0q����� *colorsTheme.ColorForeground+$ TwoWay=��� $/��)This application was written for a course��$��13(�$��Medium&�$	 0.6Q�$��
18,-12,0,0q����� *colorsTheme.ColorForeground+$ TwoWay=��� $/��)project. All rights belong to the author.��$��13(�$��Medium&�$	 0.6Q�$��
18,-12,0,0q����� *colorsTheme.ColorForeground+$ TwoWay=��� $��	Сontacts��$��15(�$��Medium&�$	 0.8Q�$��0,-8,0,0q����� *colorsTheme.ColorForeground+$ TwoWay=��� $$��Email: dusya20032003@gmail.com��$��13(�$��Medium&�$	 0.6Q�$��
18,-12,0,0q����� *colorsTheme.ColorForeground+$ TwoWay=��� $��Telegram: @sleepysad��$��13(�$��Medium&�$	 0.6Q�$��
18,-12,0,0q����� *colorsTheme.ColorForeground+$ TwoWay=�