   M S B A M L   `   `   `  ����F  BGroup11Apps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Group11AppsGroup11Apps  5   	       Group11Apps.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   %localclr-namespace:Group11Apps  5   	     � Title$  
MainWindow��5	   	   $	��500��6   $	��800��6)    � WindowStyle$
 None=�65    � WindowStartupLocation$ CenterScreen=�6H   .��5
      � -   5        .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��10,0,0,0q�6   $	��140��6+   
������$ Vertical=�6O   .+�5      �� $	��100��6   .+�5      �� $��30(�6    $
��Bold"�6.   
���   �$
��Wrap=�6S    �� TextAlignment$ Center=�6g   $
��USER��6~   �� 5      -   5         ��Name$ lblUsername��5       $��22(�65   $
��Bold"�6C   
���   �$
��Wrap=�6h   $ Center=�6|   $�� ��6�   5      �� 5      $��50��6   .+�5      �� $��50��6      MaterialDesignRaisedButton#��[  6*   
������
�������
���   �$
��Home��5      5      5      �� 5      $��50��6   .+�5      �� -   5         ��Name$ btnTaiKhoan��5      $��50��63   #��[  6?   
������
�������
���   �$��Tài Khoản��5      5      5      �� 5       $��50��6   .+�5!      �� -   5        $ btnAdmin��5!      $��50��60   #��[  6<   
������
�������
���   �$��Quản trị��5$      5%      5&      �� 5'      $	��170��6   5)      �� 5*      $��50��6   .+�5+      �� -   5        $��50��5+      #��[  6*   
���""��
���""��
���   �$��Đăng xuất��5.      5/      51      53      �� 54      $	��650��6   $ Vertical=�6%   ��55      �� 56       �� 
StartPoint$ 0.1,0&�6*    �� EndPoint$ 0.9,1&�6=   .��57      � 	 � Color$	 	#FFE63070��6'   
 � Offset$
 1Q�69   � 58      $	 	#FFFE8704��6'   $
 0Q�69   59      .+�5<      �� $��65��6   $��Right=�6)   .+�5=      �� -   5        $ btnExit��5>   "   $��	0,10,10,0q�5=       & "MaterialDesignFloatingActionButton#��[ 60    � ToolTip$ Close��5>      ��5=   l   Z� .��5?      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�62   
�������$��30��6R   $��30��6]   5@      5A      �� 5B      $��10,0,0,0q�6   $��85(�6.   $
��Bold"�6<   
�������$
��Wrap=�6a   $��WELCOME��6u   �� 5C      -   5        $ lblHoTen��5C      $��0,0,60,0q�6.   $��Right=�6@   $��50(�6\   $
��Bold"�6j   
�������$
��Wrap=�6�   $�� ��6�   5E      5F      5G      5H      