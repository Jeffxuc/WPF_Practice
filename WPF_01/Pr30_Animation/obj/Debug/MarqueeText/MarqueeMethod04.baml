   M S B A M L   `   `   `  ����I  EPr30_Animation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Pr30_Animation.MarqueeTextPr30_Animation.MarqueeText  5      0    *Pr30_Animation.MarqueeText.MarqueeMethod04   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Pr30_Animation.MarqueeText     5        N� Title$  MarqueeMethod04��5	       N� ShowsNavigationUI .   � 	Resources 5      4   .Pr30_Animation.MarqueeText.PositiveToNegativce   getOpposite�� 5   
   %   &	          5      6(   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $	��300 �6   .+�5   
   �� -   5        $��cav00��5      $��0��6   $��0��6+   
�������$��10q�6R   $	��300��6^   }�. .+�5      �� -   5        $
��tb00��5       �� Left$ 20��6$   
 �� Top$ 0��65   $��Center=�6D   $��Times New Roman)�6a   $��30(�6~   $*��$this is just a test for you.Thanks !��6�    � Triggers 5      :� 5        :� RoutedEvent$ TextBlock.Loaded��6#   .[�5!      �� .��5"      �� .��5#   "   W� 	 �� TargetProperty$	 (Canvas.Left)�62   
 g� Duration$
 0:0:6D�5$   2    g� RepeatBehavior$ Forever��6C   	 W� To 5#   \   ��  �� ElementName$
 tb00�� �� Path$ ActualWidth� �� 	Converter# [  5$   C   5%      5&      5'      5)      ��5+      �� 5,      $
 tb00��6   $ ActualHeight�6-   5.      50      51      