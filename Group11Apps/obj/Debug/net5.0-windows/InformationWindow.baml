   M S B A M L   `   `   `  ����F  BGroup11Apps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Group11AppsGroup11Apps  5   	   #    Group11Apps.InformationWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Group11Apps     5   	     � Title$  InformationWindow��5   	   $	��450��6#   $	��600��60    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6   .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� 
�������$��60��65   .+�5      �� $��QUẢN LÝ TÀI KHOẢN��6   
���   �$��30(�6H   $
��Bold"�6V   $��Comic Sans MS)�6h   $��Center=�6�   $��Center=�6�   5      �� 5      $��20q�6   $ 
Horizontal=�6%   .+�5      �� $��Tên Tài Khoản��6   $��20(�61   $	��200��6?   $
��Left=�6K   $��Center=�6f   �� 5      -   5         ��Name$ lblUsername��5      $�� ��61   $��20(�69   5      �� 5      $��	20,0,20,0q�6   $ 
Horizontal=�6,   .+�5      �� $��Họ và Tên��6   $��20(�6-   $	��200��6;   $
��Left=�6G   $��Center=�6b   �� 5      -   5         ��Name$ txtHoTen��5      $	��300��6,   $��30��68   $��Center=�6D   6a   5      �� 5      $��20q�6   $ 
Horizontal=�6%   .+�5      �� $��Mật Khẩu��6   $��20(�6,   $	��200��6:   $
��Left=�6F   $��Center=�6a   G� 5      -   5         G�Name$ txtPassword��5      $	��300��63   $��30��6?   $��Center=�6K   6h   5      �� 5      $��	20,0,20,0q�6   .+�5      �� $��Thay đổi Mật Khẩu��6   $��20(�65   $��Center=�6D   $��Center=�6a   5      �� 5       $��20q�6   $ 
Horizontal=�6%   .+�5!      �� $��Nhập Mật khẩu mới��6   $��20(�65   $	��200��6C   $
��Left=�6O   $��Center=�6j   G� 5"      -   5        $ txtNewPassword��5"      $	��300��66   $��30��6B   $��Center=�6N   6k   5#      �� 5$      $��20q�6   $ Vertical=�6%   .+�5%      �� -   5         ��Name$ btnLuu��5%      $��
20,0,20,10q�6)   
�������$	��500��6Q   $��40��6]   
���   �$��Lưu lại thông tin��6|   6�   �� 5&      -   5        $ btnThoat��5&      $��	20,0,20,0q�6+   
�������$	��500��6R   $��40��6^   
���   �$��
Quay lại��6}   6�   5'      5(      5)      5*      