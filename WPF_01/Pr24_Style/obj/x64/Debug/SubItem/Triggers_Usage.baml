   M S B A M L   `   `   `  ����E  APr24_Style, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Pr24_Style.SubItemPr24_Style.SubItem  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   
BtnStyle01  �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value  
BtnStyle02 ]� 
Conditions �� Property �� Value  
BtnStyle03	 :� RoutedEvent
 �� TargetProperty W� From	 W� To g� Duration g� RepeatBehavior g� FillBehavior g� AutoReverse#    Pr24_Style.SubItem.PlacesData  
placesData  lsty �� Binding �� Path �� Value ^� 
Conditions �� Binding �� DataType   Pr24_Style.SubItem.MyData �� Left�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      *local clr-namespace:Pr24_Style.SubItem  5      %B  &	        &	 �     &	 �    &	 �    &	 �    (�� �    5G      *, +)�� 5      "  ��6    5   
   P� 5       � �� . . �5	      ��  � ��$ Italic$�6.   5
      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 �  ��6/   5      5      �� 5      "  ��6    5   
   ]� 5       5      �� 5       � ��$ 20(�64   �� 5       � ��$ Times New Roman)�66   ./�5      ��  � ��
 �  ��6/   5      5      �� 5      "  ��6    5    
   :� 5!      $	 Click��6   .[�5"      �� .��5#      �� .��5$      W� $
 FontSize�6*   $ 10X�6O   $ 40X�6Y   $ 0:0:2D�5%   *   $ 3x��6;   $
 Stop=�6O   5&      5'      5(      :� 5)      $	 
MouseEnter��6   .[�5*      �� .��5+      �� .��5,      W� $
 Opacity�6*   $	 1.0X�6N   $	 0.2X�6Y   $ 0:0:2D�5-   *    . $ 3x��6N   $
 Stop=�6b   5.      5/      50      52         56      6   �� 57      "  ��6    58   
   �� 59       6   �� $ CurState� On6<   .a�5;      ��  � ��
 �  ��6/   5<      ^� 5=       5>      �� 5?       6    �� $ CityName� ShangHai6B   �� 5@       6    �� $ CurState� Off6B   .0�5B      ��  � ��
 ����6/   5C      5E      �� 5G      "  6   .R�5H   
   �� $	��160��6   $��20��6   .+�5I      �� $ 0��6   $	��130��6(   $��12(�64   ��6B   �� $ CityName��� 5J      $	 130��6   $��30��6*   $��12(�65   ��6C   �� $ CurState�5K      5L      5O      