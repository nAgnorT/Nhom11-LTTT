   M S B A M L   `   `   `  ����F  BGroup11Apps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Group11AppsGroup11Apps  5   	       Group11Apps.LamThemWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   %localclr-namespace:Group11Apps  5   	     � Title$  LamThemWindow��5	   	   $	��600��6   $
��1000��6,    � WindowStyle$
 None=�5
   	    � WindowStartupLocation$ CenterScreen=�6   .��5      � -   5        .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $��10q�6   $��50��6%   $ 
Horizontal=�61   
�������.+�5      �� $	��120��6   .+�5      �� -   5         ��Name$ btnUser��5      $��50��6D   
���   �$��Quản trị User��6c   ��6.   Z� 5      5      �� 5      $	��150��6   .+�5      �� $��50��63   
���   �$��Quản lý làm thêm��6R   ��6   Z� 5      5      �� 5      $	��120��6   .+�5      �� $��50��63   
���   �$
��Tìm��6R   ��6   Z� 5      5      �� 5      $	��120��6   5      �� 5       $	��250��6   5"      �� 5#      $	��140��6   .+�5$      �� -   5        $ btnBack��5$      
��� E��$��50��6E   
���   �$��
Quay lại��6d   5&      5'      5(      �� 5)      $��
20,20,20,5q�6   $��50��6-   $ 
Horizontal=�69   .+�5*      �� $��
Từ ngày��6   $��18(�6+   $	��120��69   $
��Left=�6E   $��Center=�6`   �� 5+      -   5         ��Name$ 	cboTuNgay��5+       �� Text$  ��6.   $��18(�66   
���   �$��60��6W   �� 5,      -   5         ��Name$ 
txtDauCheo��5,      $��5,0,5,0q�60   $��/��6A   $��18(�6J   
���   �6X   �� 5-      -   5        $ 
cboTuThang��5-      $  ��6/   $��18(�67   
���   �$��60��6X   6c   �� 5.      -   5        $	 STT��5.      $�� ��6)   $��18(�61   $��20��6?   $y�Hidden=�6J   �� 5/      -   5        $ 	usernamee��5/      $�� ��6/   $��18(�67   $��20��6E   �� 50      -	   5        $ TuNgay��50      $�� ��6,   $��18(�64   $��20��6B   $y�Hidden=�6M   �� 51      -
   5        $ DenNgay��51      $�� ��6-   $��18(�65   $��20��6C   $y�Hidden=�6N   �� 52      $��Đến ngày��6   $��18(�6,   $	��120��6:   $
��Left=�6F   $��Center=�6a   �� 53      -   5        $ 
cboDenNgay��53      $  ��6/   $��18(�67   
���   �$��60��6X   �� 54      $��5,0,5,0q�6   $��/��6-   $��18(�66   
���   �6D   �� 55      -   5        $ cboDenThang��55      $  ��60   $��18(�68   
���   �$��60��6Y   6d   56      �� 58      $��
20,10,20,5q�6   $��50��6-   $ 
Horizontal=�69   .+�59      �� $��Người Đăng Ký��6   $��18(�61   $	��200��6?   $
��Left=�6K   $��Center=�6f   �� 5:      -   5        $ cboNguoiDangKy��5:      $	��400��63   $��18(�6?   
���   �6b   5;      �� 5<      $��
20,10,20,5q�6   $��40��6-   $ 
Horizontal=�69   .+�5=      �� $��Lý Do��6   $��18(�6)   $	��100��67   $
��Left=�6C   $	��Top=�6^   �� 5>      -   5         ��Name$ txtLyDo��5>      $	��600��6+   $��18(�67   
���   �	 �� TextWrapping$
	 Wrap=�6X   6n   5@      �� 5A      $��
20,20,20,0q�6   $��50��6.   $ 
Horizontal=�6:   .+�5B      �� -   5        $ btnThem��5B      $��
300,0,20,0q�6*   
�������$	��100��6R   $��40��6^   
���   �$��Thêm��6}   6�   �� 5C      -   5        $ btnSua��5C      $��0,0,20,0q�6)   
�������$	��100��6O   $��40��6[   
���   �$��Sửa��6z   6�   �� 5D      -   5        $ btnXoa��5D      $��0,0,20,0q�6)   
�������$	��100��6O   $��40��6[   
���   �$
��Xoá��6z   6�   5F      �� 5G      $��20,10,20,10q�6   .+�5H      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 DataGridXAML��5H      $��Center=�61   $��	10,10,0,0q�6N   $	��Top=�6a    � 	Resources 5J      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%  '        �� 5K      "  6    .�5L      ��  � ��
 ���@�6;   �� 5M       � ��$
 Bold"�6;   �� 5N       � ��$ 0,0,1,2q�6@   �� 5O       � ��
 �   �6<   �� 5P       � ��$ 16(�69   �� 5Q       � ��$	 155��66   5S      5T      5U      5V      5W      5X      5Y      