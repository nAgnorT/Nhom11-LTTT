   M S B A M L   `   `   `  ����F  BGroup11Apps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Group11AppsGroup11Apps  5   	       Group11Apps.Login   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   %localclr-namespace:Group11Apps  5   	     � Title$  Login��5	   	   $	��450��6   $	��800��6$    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6   .��5      � -   5        ��5   
   �� 5       �� 
StartPoint$ 0.1,0&�6"    �� EndPoint$ 0.9,1&�65   .��5      �  � Color$ 	#FFE63070��6    � Offset$ 1Q�61   � 5      $ 	#FFFE8704��6   $ 0Q�61   5      .+�5   
   �� -   5        $	��390��5      $	��Top=�6    �� CornerRadius$ 	0 0 180 0��66   ���#100E175      �� 5   
   	 �� Orientation$	 
Horizontal=�6   .+�5      �� $	��350��6   .+�5      �� $��/ICON4801.png��6   $	��300��6/   $	��300��6;   $	��Top=�6H   $��30q�6`   $
��Fill=�6l   5      �� 5      $	��350��6   .+�5      �� $��20 40q�6   .+�5      �� $��
User Login��6    $��20q�62   
�������
 �� TextAlignment$
 Center=�6Q   $��38(�6h   $��Great Vibes)�6v   6�   �� 5      $	 
Horizontal=�6!   $��10q�6:   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�62   $��25��6>   $��25��6I   
�������6U   �� 5      -   5         ��Name$ txtUsername��5   "   $
��10 0q�67   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên tài khoản��6E   
�������$	��250��6�   
������� �� 
CaretBrush �	#FFD94448 �� SelectionBrush �	#FFD944486�   5      �� 5       $	 
Horizontal=�6!   $��10q�6:   .+�5!        $
 Lock=�62   $��25��6>   $��25��6I   
�������6U   G� 5"      -   5         G�Name$ txtPassword��5"   &   $
��10 0q�6;   $ Mật khẩu��6I   
�������$	��250��6�   
������� G� 
CaretBrush �	#FFD94448 G� SelectionBrush �	#FFD944486�   5#      �� 5$      $��10q�6!   $��Center=�6-   .+�5%      �� -   5         ��Name$ btnLogin��5'   R   $	��110��5%   !   $��40��6-      MaterialDesignRaisedButton#��[  69   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5&      $��2q�6H   ���#D94448���#D94448
������� � ToolTip$ Login��5'   B   $��Đăng nhập��5(   1   5)      5+      �� 5,      $��10,-50,40,10q�6!   $��Right=�67   5-      5.      �� 5/      $	��100��6   .+�50      �� -   5        $ btnExit��51   "   $��10 20q�50       & "MaterialDesignFloatingActionButton#��[ 6(   $ Close��51      ��50   d   Z� .��52        $ Close=�6.   
�������$��30��6N   $��30��6Y   53      54      55      56      57      