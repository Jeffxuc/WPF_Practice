   M S B A M L   `   `   `  ����I  EPr30_Animation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Pr30_Animation.SubItemPr30_Animation.SubItem  5      .    (Pr30_Animation.SubItem.ColorRadioButtons   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Pr30_Animation.SubItem     5      -   5        $��pg��5	   !     N� Title$  ColorRadioButtons��6    � 	Resources 5       �� 
TargetType �� Property �� Value��%v   '	�       �� 5   
   " 	�6   .�5      ��  � ��$ 10q�6'   �� 5       � ��$ 20(�6)   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   $��Center=�62   #��� ��5      .+�5       �� -   5        $
��lb01��5    "   $��30(�6   $��20q�6.   .��6:   Hello This is just a Label 016Y   	� 5!      $	��Red��6    � Triggers 5"      :� 5#       :� RoutedEvent$ RadioButton.Checked��6#   .[�5$      �� .��5%      �� .��5&   "   �� 	 �� 
TargetName$
	 lb01��61   
 �� TargetProperty$0
 *(Label.Background).(SolidColorBrush.Color)�6O   	 �� To$	 RedX�6�    g� Duration$ 0:0:1D�6�   5'      5(      5)      5+      5,      �� 5/   
   -   5         ��Name$ btn01��5/      $��1��6    $��	animation��60   $��10q�6D   $��30(�6P   $	��Top=�6^   $��Center=�6v   �� 50   
   -   5         ��Name$
 rect��50      $��1��6"   $	��260��62   $��80��6>   $��Bottom=�6J   
�������$
��10,5q�6r   �� 53   
   -   5         ��Name$ lb��53      $��1��6   $��0��6)   
�������$��10q�6P    54      :� 55      $ Label.MouseDown��6   .[�56      �� .��58      �� $0
 *(Label.Background).(SolidColorBrush.Color)�6%    g� RepeatBehavior$ Forever��6b   .��59      ��  �� From$
 BlueX�6-   $	 RedX�69   $ 0:0:1D�6B    g� AutoReverse . 6S   �� 5:       g� 	BeginTime$ 0:0:2X�6-   $ #000000X�6?   $ YellowX�6N   $ 0:0:2D�6Z    . 6k   5;      5<      5=      5?      5A      5E      