   M S B A M L   `   `   `  ����K  GWindowsIconMaker, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WindowsIconMakerWindowsIconMaker  5   	       WindowsIconMaker.Window1   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   8x,http://schemas.microsoft.com/winfx/2006/xaml    5   	   9windowsIconMakerclr-namespace:WindowsIconMaker    5   	     � Title$'  !Windows Icons Maker（by: bomo）��5   	   $��20(�5   	    � SizeToContent$ WidthAndHeight=�5   	   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      �� -   5        $��	grayImage��5      $	��300��5      $	��300��5      $��Uniform=�5      $��Center=�5      $	��Top=�5      �� 5      $��1��6   $��12q�6&   .+�5      �� -   5        $
��Open��5      $��
Open Image��5      $	��0,8q�5      5      �� 5       -   5        $
��Save��5       $	��0,8q�5!      $��
Save Icons��5"      5#      5$      5'      � 5*   
   $��1��6    5+      �� 5,      $��* �6    �� 5-      $
��Auto �6    .+�50      �� -   5         ��Name$ iconList��50      $��20(�6(   ��51      �� 52       �� DataType$ windowsIconMaker:IconInfo��6#   .R�53      ��  �� Orientation$ 
Horizontal=�6%   .+�54      �� $��W:��6(   �� 55      ��6(   �� *Width+�� 56      $��   H:��6(   �� 57      ��6(   �� *Height+�� 58      $��   FileName:��6(   �� 59      ��6(   �� *
FileName+5:      5<      5>      �� 5@      $��1��6   $��12q�6&   .+�5A      �� -   5         ��Name$ tbWidth��5A      $	��300��6+   $��20(�66   �� 5B      -   5        $ tbHeight��5B      $	��300��6,   $��20(�67   �� 5C      -   5        $ tbName��5C      $%��Square150x150Logo.scale-200.png��6*   $��20(�6Q   �� 5E      -   5        $	��add��5E   3   $��20(�6A   $	��0,8q�6O   5F      5G      5H      5I      