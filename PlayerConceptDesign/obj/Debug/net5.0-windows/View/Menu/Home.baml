   M S B A M L   `   `   `  ����N  JPlayerConceptDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:PlayerConceptDesign.ViewModelPlayerConceptDesign.ViewModel  5      9!clr-namespace:PlayerConceptDesignPlayerConceptDesign  5      (    "PlayerConceptDesign.View.Menu.Home   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      A	viewmodel+clr-namespace:PlayerConceptDesign.ViewModel     5      3local!clr-namespace:PlayerConceptDesign     5        N� Title$
  Home��5
       � DataContext 5      1   +PlayerConceptDesign.ViewModel.SetColorTheme  5   
   .��5      � $��	10,0,10,0q�6   .+�5   
   �� &    PlayerConceptDesign.Localization   Home#��Z 6   $��25(�6=   $��Medium&�6K   ��6`   �� *colorsTheme.ColorForeground+ �� Mode$ TwoWay=�� 5   
   $��20,50,20,20q�6    � RowDefinitions 5      �� 5      $��* �6    $	��230��6+   �� 5      $
��Auto �6    $	��300��6.   .+�5      � $��0��6   $	��600��6     � ColumnDefinitions 5      �� 5      $��6* �6'   �� 5      $��4* �6'   $	��445��62   .+�5      ��    HomePopular#��Z 6   $��27(�6L   $��Medium&�6Z    J� Opacity$
 0.75Q�6�   ��6o   �� *colorsTheme.ColorForeground+$ TwoWay=�6�   � 5      $��	0,60,0,20q�6    5      �� 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      .+�5%      �� $��10,5,0,5q�6   $��0��6/    �� CornerRadius$	 0.4��6<   $��1��6O   $	 0.4Q�6�   $
��Left=�6�   ��6Y   �� *!colorsTheme.ColorForegroundHome+$ TwoWay=�6�   �� 5&      $��10,5,0,5q�6   $��1��6/   $	 0.4��6<   $��1��6P   $	 0.4Q�6�   $
��Left=�6�   ��6Z   �� *!colorsTheme.ColorForegroundHome+$ TwoWay=�6�   �� 5'      $��10,5,0,5q�6   $��2��6/   $	 0.4��6<   $��1��6P   $	 0.4Q�6�   $
��Left=�6�   ��6Z   �� *!colorsTheme.ColorForegroundHome+$ TwoWay=�6�   �� 5(      $��10,5,0,5q�6   $��3��6/   $	 0.4��6<   $��1��6P   $	 0.4Q�6�   $
��Left=�6�   ��6Z   �� *!colorsTheme.ColorForegroundHome+$ TwoWay=�6�   �� 5)      $��
10,5,0,2.5q�6   $��4��61   $	 0.4��6>   $��1��6R   $	 0.4Q�6�   $
��Left=�6�   ��6\   �� *!colorsTheme.ColorForegroundHome+$ TwoWay=�6�   �� 5+      $��
6.5,-4,0,0q�6   $��0��61   $��8��6>   $��8��6H   $ 10��5,      $
��Left=�6.   $	��Top=�6I   ��5+   S   �� *!colorsTheme.ColorForegroundHome+$ TwoWay=�5-      �� 5.      $��
6.5,-4,0,0q�6   $��1��61   $��8��6>   $��8��6H   $ 10��5/      $
��Left=�6.   $	��Top=�6I   ��5.   S   �� *!colorsTheme.ColorForegroundHome+$ TwoWay=�5/   I   �� 50      $��
6.5,-4,0,0q�6   $��2��61   $��8��6>   $��8��6H   $ 10��51      $
��Left=�6.   $	��Top=�6I   ��50   S   �� *!colorsTheme.ColorForegroundHome+$ TwoWay=�51   I   �� 52      $��
6.5,-4,0,0q�6   $��3��61   $��8��6>   $��8��6H   $ 10��53      $
��Left=�6.   $	��Top=�6I   ��52   S   �� *!colorsTheme.ColorForegroundHome+$ TwoWay=�53   I   �� 54      $��
6.5,-4,0,0q�6   $��4��61   $��8��6>   $��8��6H   $ 10��55      $
��Left=�6.   $	��Top=�6I   ��54   S   �� *!colorsTheme.ColorForegroundHome+$ TwoWay=�55   I   �� 56      $��
6.5,0,0,-6q�6   $��4��61   $��8��6>   $��8��6H   $ 10��57      $
��Left=�6.   $��Bottom=�6I   ��56   S   �� *!colorsTheme.ColorForegroundHome+$ TwoWay=�57   I   � 58      -   5        	 �Name$	 Grid1��58      $
��Auto��6+   $��	30,0,30,0q�69   �� 5:      $��0��6!   
 �� Orientation$
 
Horizontal=�6.   $��
0,-13,0,13q�6G   ��6[   ��  �� ElementName$ Grid1�� �� Path$ ActualWidth�.+�5;      �� -   5        $��Label0��5;       $
��Left=�6P   $	��Top=�6k   $��14(�6�   $��Medium&�5<       ��65   �� *!colorsTheme.ColorForegroundHome+$ TwoWay=�5>      �� 5?      $��1��6!   $
 
Horizontal=�6.   $��
0,-13,0,13q�6G   ��6[   �� $ Grid1��$ ActualWidth�.+�5@      �� -   5        $��Label1��5@       $
��Left=�6P   $	��Top=�6k   $��14(�6�   $��Medium&�5A       ��65   �� *!colorsTheme.ColorForegroundHome+$ TwoWay=�5C      �� 5D      $��2��6!   $
 
Horizontal=�6.   $��
0,-13,0,13q�6G   ��6[   �� $ Grid1��$ ActualWidth�.+�5E      �� -   5        $��Label2��5E       $
��Left=�6P   $	��Top=�6k   $��14(�6�   $��Medium&�5F       ��65   �� *!colorsTheme.ColorForegroundHome+$ TwoWay=�5H      �� 5I      $��3��6!   $
 
Horizontal=�6.   $��
0,-13,0,13q�6G   ��6[   �� $ Grid1��$ ActualWidth�.+�5J      �� -   5        $��Label3��5J       $
��Left=�6N   $	��Top=�6i   $��14(�6�   $��Medium&�5K       ��65   �� *!colorsTheme.ColorForegroundHome+$ TwoWay=�5N      �� 5O      $��4��6!   $
 
Horizontal=�6.   $��
0,-13,0,13q�6G   ��6[   �� $ Grid1��$ ActualWidth�.+�5P      �� -   5        $��Label4��5P       $
��Left=�6O   $	��Top=�6j   $��14(�6�   $��Medium&�5Q       ��65   �� *!colorsTheme.ColorForegroundHome+$ TwoWay=�5S      �� 5T      $��5��6!   $
 
Horizontal=�6.   $��
0,-13,0,13q�6G   ��6[   �� $ Grid1��$ ActualWidth�.+�5U      �� -   5        $��Label5��5U       $
��Left=�6N   $	��Top=�6i   $��14(�6�   $��Medium&�5V       ��65   �� *!colorsTheme.ColorForegroundHome+$ TwoWay=�5X      5Z      �� 5[      $��1��6   $	 0.3Q�6c   $ 5��6q   $��	0,-40,0,0q�6�   ��6)   �� *colorsTheme.ColorMenu+$ TwoWay=�6�   � 5\      $��1��6   $��	5,-45,5,5q�6(   .+�5]       � -   5          �Name$ LibraryFrame��5]   (   $��10q�6     � NavigationUIVisibility$ Hidden=�6>     � Source$3 -pack://application:,,,/View/Menu/Library.xaml?�6^   5^      5`      � 5a      -	   5        $��Grid_��5a   /   $��1��6   $
 0.75Q�6    $y�	Collapsed=�6<   .+�5b      ��    HomeTheLast#��Z 6   $��20(�6L   $��Medium&�6Z   $��	0,-40,0,0q�6�   ��6o   �� *colorsTheme.ColorForeground+$ TwoWay=�6�   � 5c      -
   5         �Name$ WarpPanelLikes��5c       � Orientation$ 
Horizontal=�64   $��5q�6M   5e      5f      5g      5i      5j      