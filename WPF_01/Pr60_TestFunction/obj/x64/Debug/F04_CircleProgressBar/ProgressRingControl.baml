   M S B A M L   `   `   `  ����L  HPr60_TestFunction, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Pr60_TestFunction.F04_CircleProgressBar'Pr60_TestFunction.F04_CircleProgressBar  5      A    ;Pr60_TestFunction.F04_CircleProgressBar.ProgressRingControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:Pr60_TestFunction.F04_CircleProgressBar     5      c _Microsoft.Expression.Drawing, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35?draw4http://schemas.microsoft.com/expression/2010/drawing  5        � 	Resources  5
         normalLight �� 	UriSource  
pressLight  
previewBtn �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%D  &	        &	 =     &	 z     7  �� 5   
   $) #./Images/play-preview-normal@3x.png?�6*   �� 5   
   $) #./Images/play-preview-select@3x.png?�6)   �� 5   
   " ��6#   .�5      ��  � ��# �   6'    5      P� 5       �@J�IsMouseOver . . �5      ��  � ��8   6/   5      5      5      .��5      � .+�5   
   %  Microsoft.Expression.Shapes.Arc  -   5          Name$ 	circleBar��5      	   
StartAngle$	 0Q�6&   
   EndAngle$
 0Q�65      ArcThickness$ 3Q�6B   $��0��6S   
���  �� �� Stretch$
 None=�5       ��5!      �� 5"       �� 
StartPoint$ 0,0.5&�6&    �� EndPoint$ 1,0.5&�69   .��5#      �  � Offset$ 0Q�6#    � Color$ #5be1d6��6.   � 5$      $ 1Q�6#   $ #3d83ff��6.   5%      5'      �� 5)   
   -   5         ��Name$ preBtn��5)      #��[ 6    $��1,1,0.5,0.3q�6E    � Triggers 5*      :� 5+       :� RoutedEvent$ Image.MouseLeftButtonDown��6   .[�5,      �� .��5-      �� .��5.      W�  �� 
TargetName$ 	circleBar��6.    �� TargetProperty$ EndAngle�6P    W� From$ 0X�5/   .   	 W� To$	 360X�67    g� FillBehavior$
 Stop=�6@    g� Duration$ 0:0:6D�6T   T� 50      $ Source�6<   $ 0:0:6D�6_   $
 Stop=�6p   ..�51   "   i�  R� Value# [ 69    R� KeyTime$ 0:0:0.1��6]   52      53      54      55      57      5<      5=      