   M S B A M L   `   `   `  ����K  GNguyênChiDuyWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:NguyênChiDuyWPF.ViewModelsNguyênChiDuyWPF.ViewModels  5   	   )    #NguyênChiDuyWPF.Views.ReportWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   8vm)clr-namespace:NguyênChiDuyWPF.ViewModels     5   	     � Title$  Order Report��5   	   $	��600��6   $	��850��6+    � WindowStartupLocation$ CenterScreen=�5   	   .��5      ]� $��10q�6   .+�5	   
   �� $	��Top=�6    �� Orientation$ 
Horizontal=�6*   $��0,0,0,10q�6C   .+�5
      �� $��From:��6   $��Center=�6$   (  "System.Windows.Controls.DatePicker  5      $��5q�6;      SelectedDate 6   �� *
FromDate+6;   �� 5      $	��To:��6   $��Center=�6"     5      $��5q�69    6   �� *ToDate+69   �� 5      $��Generate��6   $
��10,0q�6R   ��6(   �� *GenerateReportCommand+6R   5      &   System.Windows.Controls.DataGrid  5   
      AutoGenerateColumns$ False��62   $	��400��6N   $��0,0,0,10q�6[   ��6   �� *Orders+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Order ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *	OrderID+6S     5      $ Customer ID��6%   $
 Auto 6Y    6:   �� *
CustomerID+6Y     5      $ Employee ID��6%   $
 Auto 6Y    6:   �� *
EmployeeID+6Y     5      $
 Date��6%   $ * 6j    63   �� *	OrderDate+	 �� StringFormat$	 
dd/MM/yyyy��6j   5      �� 5   
   $ 
Horizontal=�6   $��Right=�6.   .+�5      �� $��Total Orders: ��6   $
��Bold"�6.   �� 5      $
��10,0q�64   ��6   �� *
OrderCount+64   5      5      5      