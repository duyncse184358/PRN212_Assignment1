   M S B A M L   `   `   `  ����K  GNguyênChiDuyWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:NguyênChiDuyWPF.ViewModelsNguyênChiDuyWPF.ViewModels  5   	   *    $NguyênChiDuyWPF.Views.ProductWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   8vm)clr-namespace:NguyênChiDuyWPF.ViewModels     5   	     � Title$  Product Management��5   	   $	��500��6$   $	��850��61    � WindowStartupLocation$ CenterScreen=�5   	   .��5      ]� $��10q�6   .+�5	   
   �� $	��Top=�6    �� Orientation$ 
Horizontal=�6*   $��0,0,0,10q�6C   .+�5
      �� $	��300��6   $��0,0,10,0q�6A   ��6"   �� *SearchKeyword+6A   �� 5      $��Search��6   $��0,0,10,0q�6H   ��6&   �� *SearchCommand+6H   �� 5      $	��Add��6   $��0,0,10,0q�6B   ��6#   �� *
AddCommand+6B   �� 5      $
��Edit��6   $��0,0,10,0q�6D   ��6$   �� *EditCommand+6D   �� 5      $��Delete��6   ��6&   �� *DeleteCommand+5      &   System.Windows.Controls.DataGrid  5   
      AutoGenerateColumns$ False��5      $	��350��6/   ��5      �� *
Products+ �� SelectedItem 5      �� *SelectedProduct+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *	ProductID+6O     5      $
 Name��6%   $ * 6S    63   �� *ProductName+6S     5      $ Category ID��6%   $
 Auto 6Y    6:   �� *
CategoryID+6Y     5      $ Price��6%   $
 Auto 6R    64   �� *	UnitPrice+6R     5      $ In Stock��6%   $
 Auto 6X    67   �� *UnitsInStock+6X   5      5      5      