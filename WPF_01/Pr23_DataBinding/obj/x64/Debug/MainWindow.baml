   M S B A M L   `   `   `  ����K  GPr23_DataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Pr23_DataBindingPr23_DataBinding  5   	   !    Pr23_DataBinding.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Pr23_DataBinding     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� -   5        $��scroll��5       �� Orientation$ 
Horizontal=�6"    � Maximum$	 100Q�6;    � Minimum$ 0Q�6I    � SmallChange$ 5Q�6U   $��24q�6e   $��0��6q   �� 5   
   -   5        $��scroll02��5      $ 
Horizontal=�6$   $	 100Q�6=   $ 0Q�6K   $ 5Q�6W   $��24q�6g   $��1��6s   �� 5   
   -   5        $��showScrollVal��5   U   $��Center=�6   $��0��6-   $��Bottom=�6:   ��6j   ��  �� ElementName$ scroll�� �� Path$ Value��� 5   
   -   5        $
��lb02��5      $��1��6   $��Center=�6)   $��Bottom=�6F   �� 5   
   -   5        $��scroll03��5      $ 
Horizontal=�6$   $	 100Q�6=   $ 0Q�6K   $��24q�6W   $��2��6c    � Value 6p   �� $
 lb03��$ Content�	 �� Mode$	 TwoWay=��� 5   
   -   5        $
��lb03��5      $��Center=�6   $��Bottom=�69   $��60��6T   $��2��6a   5      5      