   M S B A M L   `   `   `  ����K  GNguyênChiDuyWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:NguyênChiDuyWPF.ViewModelsNguyênChiDuyWPF.ViewModels  5   	   *    $NguyênChiDuyWPF.Views.ProductDialog   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   8vm)clr-namespace:NguyênChiDuyWPF.ViewModels     5   	     � Title$  Product Detail��5   	   $	��350��6    $	��400��6-    � WindowStartupLocation$ CenterOwner=�5   	    � DataContext 5      8   2NguyênChiDuyWPF.ViewModels.ProductDialogViewModel  5   
   .��5
      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $
��Name��6   $��0��6   �� 5   
   $��1��6   ��6   �� *Product.ProductName+�� 5   
   $��Category ID��6   $��2��6&   �� 5   
   $��3��6   ��6   �� *Product.CategoryID+�� 5   
   $��Price��6   $��4��6    �� 5   
   $��5��6   ��6   �� *Product.UnitPrice+�� 5   
   $��Units In Stock��6   $��6��6)   �� 5   
   $��7��6   ��6   �� *Product.UnitsInStock+�� 5!   
   $��8��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   $��0,10,0,0q�6W   .+�5"      �� -   5        $
��Save��5"      $��80��6$   $��0,0,10,0q�6/   6A   �� 5#      -   5        $��Cancel��5#      $��80��6&   61   5$      5%      5&      