   M S B A M L   `   `   `  ����K  GNguyênChiDuyWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:NguyênChiDuyWPF.ViewModelsNguyênChiDuyWPF.ViewModels  5   	   +    %NguyênChiDuyWPF.Views.EmployeeDialog   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   8vm)clr-namespace:NguyênChiDuyWPF.ViewModels     5   	     � Title$  Employee Details��5   	   $	��350��6"   $	��400��6/    � WindowStartupLocation$ CenterOwner=�5   	    � DataContext 5      9   3NguyênChiDuyWPF.ViewModels.EmployeeDialogViewModel  5   
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
   $��1��6   ��6   �� *Employee.Name+�� 5   
   $��Username��6   $��2��6#   �� 5   
   $��3��6   ��6   �� *Employee.UserName+�� 5   
   $��Password��6   $��4��6#   �� 5   
   $��5��6   ��6   �� *Employee.Password+�� 5   
   $��	Job Title��6   $��6��6$   $��	0,0,0,121q�61   �� 5   
   $��6��6   $��	0,46,0,55q�6B   ��6   �� *Employee.JobTitle+6B   �� 5!   
   $��6��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   $��	0,112,0,0q�6W   $	��207��6j   .+�5"      �� -   5        $
��Save��5"      $��85��6$   $��0,0,10,0q�6/   $��36��6T   �� 5#      -   5        $��Cancel��5#      $��83��6&   $��36��6F   5$      5%      5&      