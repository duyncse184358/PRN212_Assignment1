   M S B A M L   `   `   `  ����K  GNguyênChiDuyWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:NguyênChiDuyWPF.ViewModelsNguyênChiDuyWPF.ViewModels  5   	   (    "NguyênChiDuyWPF.Views.OrderWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   8vm)clr-namespace:NguyênChiDuyWPF.ViewModels     5   	     � Title$  Create Order��5   	   $	��650��6   $	��900��6+    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         RightAlignedText �� 
TargetType �� Property �� Value��%c   &	        �� 5	   
   " ��6)   .�5
      ��  �@��TextAlignment$ Right=�6.   5      5      .��5      � $��15q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $��0��6   
�������$��1q�66    �� CornerRadius$ 5��6J   	 �� Padding$	 10q�6[   $��0,0,0,10q�6h   ._�5      �� 
 �� Orientation$
 
Horizontal=�6   $��Center=�62   .+�5      �� $��	Customer:��6   $��SemiBold"�6,   $��Center=�6B   �� 5      $	��250��6    �� DisplayMemberPath$ CompanyName��5   E   $��	10,0,30,0q�6e   ��5   '   �� *	Customers+ �� SelectedItem 5      �� *SelectedCustomer+6e   �� 5      $��Order Date:��6   $��SemiBold"�6.   $��Center=�6D   �� 5       $��Center=�6X   $��14(�6s   
���OO/���6   �� *	OrderDate+ �� StringFormat$ dd/MM/yyyy HH:mm��6�   5!      5"      �� 5$   
   $��1��6   $��Add Product to Order��6    $��0,0,0,15q�6>   ��5%      �� 5&      .R�5'      �� 
�������$��1q�65   $ 5��6I   $	 5,0,5,0q�6Z   $��	-5,0,-5,0q�6l   ._�5(      �� $��SemiBold"�65   $��14(�6K   ��6$   �� 6K   5)      5*      .��5,      �� $
 
Horizontal=�6   $��10q�62   $��Center=�6>   .+�5-      �� $	��300��6   $ ProductName��5.   D   $��0,0,20,0q�6d   $��Center=�5/      $��14(�6=   ��5-   '   �� *
Products+ 5.      �� *SelectedProduct+5/   =   �� 51      $	��100��6   $��0,0,10,0q�6@   $��Center=�52      $��Center=�6<   $��14(�6`    � ToolTip$ Enter quantity (e.g., 5)��53      ��51   &   �� *
Quantity+53      �� 55      $	��100��6   $��0,0,20,0q�6@   $��Center=�56      $��Center=�6<   $��14(�6`   $( "Enter discount (e.g., 0.1 for 10%)��57      ��55   &   �� *
Discount+57      �� 59      $��Add Product��6   $
��10,5q�6U   $��SemiBold"�6d   ��6/   �� *AddProductCommand+6d   5:      5;      &   System.Windows.Controls.DataGrid  5=   
   $��2��6      AutoGenerateColumns$ False��6E      CanUserAddRows$ False��5>         CanUserDeleteRows$ False��6*      
IsReadOnly$
 True��6D   
�������$��1q�5?   +      SelectionMode$ Single=�6?   ��5=       �� *OrderDetails+   Columns 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn   Header$ Product��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *ProductName+6V     5B      $	 Qty��6%   $
 Auto 6O      ElementStyle# [  6\    62   �� *
Quantity+6\     5C      $ Price��6%   $
 Auto 6b   # [  6o    64   �� *	UnitPrice+$ C��6o     5D      $ Discount��6%   $
 Auto 6e   # [  6r    67   �� *
Discount+$ P0��6r     5E      $ Total��6%   $
 Auto 6^   # [  6k    64   �� *Total+$ C��6k   5G      �� 5I   
   $��3��6   $
 
Horizontal=�6"   $��Right=�6;   $��0,15,0,0q�6W   $��Center=�6i   .+�5J      �� $��Total Amount: ��6   $��18(�6.   $
��Bold"�6<   $��Center=�6N   ���	#FF3333336i   �� 5K      $��22(�6E   $
��Bold"�6S   $
��10,0q�6e   $��Center=�6s   ���	#FF007ACC��6   �� *TotalAmount+$ C��6�   �� 5L      $��
Save Order��6   $��20,10q�6O   $��16(�6_   $
��Bold"�6m   $��20,0,0,0q�6   ��6*   �� *SaveOrderCommand+6   5M      5N      5P      