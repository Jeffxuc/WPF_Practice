   M S B A M L   `   `   `  ����L  HPr41_ItemsControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Pr41_ItemsControlPr41_ItemsControl  5   	   "    Pr41_ItemsControl.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Pr41_ItemsControl     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5
      "   Pr41_ItemsControl.MyTodoList   
myTodoList"   Pr41_ItemsControl.MyProgress  
myProgress�� 5   
   %:   &	        &	        5      6     5      6   5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6$   $��10q�64   ��6@   ��  �� Source# [  ��5      �� 5       �� 
TargetType" ��6"   .R�5       �� 
���  ��$��6q�6/    �� CornerRadius$ 30��6C   ._�5!      �� 5"      5#      ��5%      �� 5'      .R�5(      � 5)      ��5+      �� 5-       � 	Resources 5.       �� 
TargetType	 �� Property
 �� Value��%z   '��       �� 5/      " ��6    .�50      �� 	 � ��$
 14(�69   �� 51      	 � ��$
 Center=�6D   52      53      .R�54      � .+�55      A� 
�������6"   �� 56      .+�57      �� $��3,3,3,0q�6(   ��69   ��  �� Path$ TaskPriority��� 58      $��3,0,3,7q�6(   ��69   �� $ TaskName�59      5:      5;      ��5=      �� 5?      .�5@      �� 	 � ��$	
 100��66   �� 5A      	 � ��$
 5q�67    �� Triggers 5B      P� 5C       P� Property �@J�IsMouseOver P� Value . . �5D      �� 	 �@�ToolTip
 5E   %   ��  �� Self �� RelativeSource# Z $ Content.TaskDescription�5F      5H      5J      �� 5M   
   $��0��6   $��1��6$   $��10,20,10,20q�6o   ��64   �� # [ ��5N      �� 5O      .R�5P      �� 5Q      ��5S      �� 5T      .R�5U      � $��5q�6    5V      �� 5W      $��50 �6/   �� 5X      $��* �6/   �� 5Y      $��40 �6/   .+�5[      �� ��6$   �� $ ItemName�� 5\      $��1��6&    � Value 66   �� $ ProgressNum��� 5]      $��Center=�6"   $��2��6?   ��6O   �� $ ProgressNum� �� Mode$ TwoWay=�5^      5_      5a      5c      5d      