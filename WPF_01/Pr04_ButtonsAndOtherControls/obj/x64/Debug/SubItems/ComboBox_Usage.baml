   M S B A M L   `   `   `  ����W  SPr04_ButtonsAndOtherControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:Pr04_ButtonsAndOtherControls.SubItems%Pr04_ButtonsAndOtherControls.SubItems  5   	   :    4Pr04_ButtonsAndOtherControls.SubItems.ComboBox_Usage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:Pr04_ButtonsAndOtherControls.SubItems     5   	     � Title$  ComboBox Usage��5   	   $	��450��6    $	��800��6-    � 	Resources 5
      8   2Pr04_ButtonsAndOtherControls.SubItems.ComboBoxData   myComboBoxData�� 5   
   %   &	          5      6!   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� .+�5      �� -   5        $��combox1��5      #��[  6&    �� Text$ MyCustomComBox��6T    �� 
IsEditable .  �� 
IsReadOnly . 5       5!      �� 5"   
   -   5         ��Name$ 
showCurTxt��5"      $��1��6(   $��Center=�6m   ��65   ��  �� ElementName$ combox1��	 �� Path$	 SelectedItem�6m   �� 5$   
   -   5        
 ��Name$
 combox02��5$      $��1��6%   $��0��65   $	 cur��6B   $��30��6M    .  �� SelectedIndex$ 0��6k   .@�5%      �� $��01��6   �� 5&      $��02��6   �� 5'      $��03��6   �� 5(      $��04��6   5)      5+      5,      