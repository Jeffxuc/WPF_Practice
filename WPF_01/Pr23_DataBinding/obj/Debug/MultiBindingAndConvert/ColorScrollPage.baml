   M S B A M L   `   `   `  ����K  GPr23_DataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Pr23_DataBinding.MultiBindingAndConvert'Pr23_DataBinding.MultiBindingAndConvert  5      =    7Pr23_DataBinding.MultiBindingAndConvert.ColorScrollPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:Pr23_DataBinding.MultiBindingAndConvert     5        N� Title$  Color Scroll Page��5	       � 	Resources 5      C   =Pr23_DataBinding.MultiBindingAndConvert.DoubleToByteConverter   double2byteA   ;Pr23_DataBinding.MultiBindingAndConvert.RgbToColorConverter  	rgb2color��%:   &	        &	        5   
   6&     5   
   6$   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��40* �6   �� 5      $
��Auto �6   �� 5      $	��60* �6   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6     5       �� 5!      $	��33* �6#   �� 5"      $	��33* �6#   �� 5#      $	��33* �6#   .+�5(      �� $��0��6   $��0��6!   $��	RedScroll��61   
���  ��$��Center=�6V   $��Center=�6s   �� 5)      -   5        $��srcRed��5)      
���  ��$��1��67   $��0��6D    �� Orientation$ Vertical=�6T   $��10q�6k    � SmallChange$ 1Q�6w    � LargeChange$ 10Q�5*       � Maximum$	 255Q�6)    � Minimum$ 0Q�67   |�. 6C   �� 5+      $��2��6   $��0��6!   $��Center=�6�   ��61   �� 	 �� ElementName$	 srcRed��
 �� Path$
 Value� �� Mode$ OneWay=� �� 	Converter# [  6�   �� 5.      $��0��6   $��1��6!   $��GreenScroll��61   
��� � �$��Center=�6Z   �� 5/      -   5        $��srcGreen��5/      $��1��6(   $��1��65   $	 255Q�6E   $ 0Q�6S   $ Vertical=�6_   
��� � �$��10q�50      $ 1Q�6$   $ 10Q�64   |�. 6E   �� 51      $��2��6   $��1��6!   $��Center=�6�   ��61   �� $	 srcGreen��$
 Value�$ OneWay=�# [  6�   �� 54      $��0��6   $��2��6!   $��
BlueScroll��61   
����  �$��Center=�6X   �� 55      -   5        $��srcBlue��55      $��1��6'   $��2��64   $	 255Q�6D   $ 0Q�6R   $ Vertical=�6^   
����  �$��10q�56      $ 1Q�6$   $ 10Q�64   |�. 6E   �� 57      $��2��6   $��2��6!   $��Center=�6�   ��61   �� $	 srcBlue��$
 Value�$ OneWay=�# [  6�   58      �� 5;   
   $��1��6   $��Center=�6'   $��Stretch=�6D   $��6��6`    �� ShowsPreview . 5=      �� 5@   
   $��2��6   ��5A      `� 5B       `� 	Converter# [ 6   .1�5C      �� $	 srcRed��6   $
 Value�63   $ OneWay=�6@   �� 5D      $	 srcGreen��6   $
 Value�65   $ OneWay=�6B   �� 5E      $	 srcBlue��6   $
 Value�64   $ OneWay=�6A   5F      5H      5K      5L      