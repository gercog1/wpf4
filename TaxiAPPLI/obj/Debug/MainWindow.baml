   M S B A M L   `   `   `  ����D  @TaxiAPPLI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TaxiAPPLI	TaxiAPPLI  5   	       TaxiAPPLI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TaxiAPPLI     5   	     � Title$  
Order Taxi��5   	   $��477.332��6   $��663.432��6-    � 
ResizeMode$ NoResize=�6=   .��5	      � -   5         �Name$ 
myDatagrid��5	      $��0,0,3,0q�6   ��5
   
   �� 5       �� ImageSource$ 	taxi2.jpg��6    �� Opacity$ 1Q�61    j� Stretch$ UniformToFill=�6=    � ColumnDefinitions 5   
   �� 5      $
��162* �6   �� 5      $
��217* �6   .+�5   
   �� ���	#FFF4F4F5 J� Opacity$	 0.8Q�6%   $
��Left=�63   $��78��6N   $��
53,297,0,0q�6Z   
���   �$	��Top=�6}   $	��200��6�   �� 5   
   $	 0.8Q�6   ���	#FFF4F4F5$
��Left=�63   $	��182��6N   $��55.8,42,0,0q�6[   
���   �$	��Top=�6   $	��262��6�   $��1��6�   �� 5   
   -   5         ��Name$ phone��5      $�� ��6   $
��Left=�6*   $��56.8,61,0,0q�6E   $	��Top=�6Z   $��30��6r   $	��262��6~   $��1��6�   �� 5   
   -   5        $ fromp��5      $�� ��6   $
��Left=�6*   $��56.8,91,0,0q�6E   $	��Top=�6Z   $��30��6r   $	��262��6~   $��1��6�   �� 5   
   -   5        $	 top��5      $�� ��6   $
��Left=�6(   $��56.8,121,0,0q�6C   $	��Top=�6Y   $��30��6q   $	��262��6}   $��1��6�   �� 5   
   -   5        $ typep��5      $�� ��6   $
��Left=�6*   $��56.8,151,0,0q�6E   $	��Top=�6[   $��30��6s   $	��262��6   $��1��6�   �� 5   
   -   5        $ price��5      $�� ��6   $
��Left=�6*   $��56.8,181,0,0q�6E   $	��Top=�6[   $��43��6s   $	��262��6   $��1��6�   �� 5   
   $��	LVIV TAXI��6   $
��Left=�6$   $��90��6?   $��40,0,0,0q�6K   $	��Top=�6]   $	��241��6u   $��48(�6�   $
��Bold"�6�   
�������6�   � 5   
   .+�5       �� -   5        	 ��Name$	 phoneNumber��5       
 � ToolTip$
 Number format: 0XXXXXXXXX��6+    �� TextAlignment$ Center=�6O   $
��Left=�6f   $��23��6�    �� TextWrapping$
 Wrap=�6�   $��Enter phone number��6�   $	��Top=�6�   $	��152��6�   $��	76,80,0,0q�6�   
�������65  �� 5!   
   -   5        $
	 from��5!      $ Center=�6    $
��Left=�67   $��23��6R   $
 Wrap=�6^   $��Enter from point��6r   $	��Top=�6�   $	��152��6�   $��
76,125,0,0q�6�   
�������6�   �� 5"   
   -	   5        $	 to��5"      $ Center=�6   $
��Left=�65   $��23��6P   $
 Wrap=�6\   $��Enter destination point��6p   $	��Top=�6�   $	��152��6�   $��
76,170,0,0q�6�   
�������6�   �� 5#   
   -
   5         ��Name$
 type��5#      $
��Left=�6!   $��
76,215,0,0q�6<   $	��Top=�6P   $	��152��6h    �� SelectedIndex$ 0��6t   .@�5$      �� 
Standart6"   �� 5%      
Business6"   �� 5&      	Premium6!   5'      5(      �� 5)   
   -   5        $��Accept��5)      $
��Left=�6"   $��117,240,0,0q�6=   $	��Top=�6R   $��75��6j   6u   �� 5*   
   -   5         ��Name$ orderBtn��5*      $��Order��6$   $y�Hidden=�64   $��1��6H   $
��Left=�6X   $��149.8,239,0,0q�6s   $	��Top=�6�   $��75��6�   6�   �� 5+   
   $��Phone number:��6   $
��Left=�6(   $	��Top=�6C   $��	76,58,0,0q�6[   
�������6n   �� 5,   
   $��From:��6   $
��Left=�6    $	��Top=�6;   $��	76,99,0,0q�6S   
�������6f   �� 5-   
   $	��To:��6   $
��Left=�6   $	��Top=�69   $��
76,143,0,0q�6Q   
�������6e   �� 5.   
   -   5        $ warning1��5.      $�� ��6"   $
��Left=�6-   $��
53,304,0,0q�6H   $	��Top=�6\   $	��200��6t   
���  ��$��57��6�   �� 5/   
   ���	#FFF4F4F5$	 0.8Q�6%   $
��Left=�63   $��78��6N   $��88.8,297,0,0q�6Z   
���   �$	��Top=�6   $	��200��6�   $��1��6�   �� 50   
   -   5        $ 
afterOrder��50      $�� ��6$   $��1��6/   $
��Left=�6?   $��88.8,297,0,0q�6Z   $	��Top=�6p   $��78��6�   $	��165��6�   52      53      