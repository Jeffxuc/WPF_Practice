   M S B A M L   `   `   `  ����I  EPr30_Animation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Pr30_Animation.SubItemPr30_Animation.SubItem  5      (    "Pr30_Animation.SubItem.ShakeButton   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Pr30_Animation.SubItem     5        N� Title$  ShakeButton��5	      .��5      ��  � 	Resources 5   
    �� 
TargetType �� Property �� Value �� Triggers :� RoutedEvent �� TargetProperty W� From		 W� To
 g� Duration g� AutoReverse g� RepeatBehavior g� FillBehavior��%  '��       �� 5      " ��6   .�5      ��  � ��$ Center=�68   �� 5       � ��$ 12q�6+   �� 5       � ��$ 20(�6-   �� 5       �@J�RenderTransformOrigin$ 0.5 0.5&�6:   �� 5       � z� 5      �� 5      5       5      :� 5      $ Button.Click��6#   .[�5      �� .��5      �� $ RenderTransform.Angle�6)   .��5   "   W� $	 -20X�62   $	 5X�6=   $
 0:0:0.2D�6D    . $ 3x��5   E   $
 Stop=�6Y   5      5      5       5"      5#      .+�5&   
   �� .��6   	Button 016   �� 5'   
   .��6   	Button 026   �� 5(   
   .��6   	Button 036   �� 5)   
   .��6   	Button 046   �� 5*   
   .��6   	Button 056   �� 5+   
   .��6   	Button 066   5-      5.      