   M S B A M L   `   `   `  ����L  HPr60_TestFunction, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Pr60_TestFunction.F02_ShowImagePr60_TestFunction.F02_ShowImage  5      2    ,Pr60_TestFunction.F02_ShowImage.ShowGifImage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:Pr60_TestFunction.F02_ShowImage     5      U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5        N� Title$  ShowGifImage��5
       N� ShowsNavigationUI .  .��5      � -   5         �Name$ mainGrid��5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $
��10 0q�6   "  WpfAnimatedGif.ImageBehavior   AnimatedSource$$ ./GifImg/theme_2_animation.gif��6   �� 5   
   $
��10 0q�6   $��1��6   $$ ./GifImg/theme_2_animation.gif��6+      RepeatBehavior$ Forever��5         AnimationSpeedRatio$	 3.0X�6;   � 5   
   -   5        $��grid20��5      $��2��6   $��0��6*   
���   �$��10,20q�6M   �� 5   
   $��2��6   $��1��6"   .+�5      �� -   5        $��inputTxt��5      $��1��6&   $��20(�6/   $��10q�6=    �� TextAlignment$ Center=�6I   �� 5       -   5        $��btnOn��5       $��OnlyPlayOnce��6"   $��10,10q�69   $��25(�6H   6V   5!      � 5"   
   -   5        $��grid22��5"      $��2��6   $��2��6*   
���   �$��10,20q�6M   �� 5#   
   -   5        $��btn23��5#      $��2��6   $��3��6+   $��playMultiGif��6;   $��25(�6R   $��Center=�6`   $��10q�6{   6�   � 5$   
   -   5        $��grid30��5$      $��3��6   $��0��6*   
���   �$��10,20q�6M   �� 5%   
   -   5        $��btn31��5%      $��3��6   $��1��6+   $��switchGifPng��6;   $��25(�6R   $��Center=�6`   $��10q�6{   6�   �� 5'   
   -	   5        	 ��Name$
	 tsxt��5'      $��3��6"   $��2��6/   $��10q�6?   $	��105��6K   $��20(�6W   $��CharacterEllipsis=�6e   hello just test the5)      � 5+   
   -
   5        $	 gif��5+      $��0��6   $��3��6)   $��10q�69   
���   �6E   � 5,   
   $��1��6   $��3��6   .+�5-      �� 
 �� Orientation$
 
Horizontal=�6   $��Center=�62   .+�5.      �� -   5         ��Name$ btns1��5.      $��s1��6(   65   �� 5/      -   5        $ btns2��5/      $��s2��6(   65   �� 50      -   5        $ btns3��50      $��s3��6(   65   d� 51      -   5         d�Name$
 tbtn��51      $��	toggleBtn��6-   6k   	� 52      -   5         	�Name$ radioBtn��52      $��radioBt��60   6t   53      55      56      57      