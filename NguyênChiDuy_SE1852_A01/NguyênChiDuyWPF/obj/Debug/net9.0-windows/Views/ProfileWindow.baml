   M S B A M L   `   `   `  ����K  GNguyênChiDuyWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:NguyênChiDuyWPF.ViewModelsNguyênChiDuyWPF.ViewModels  5   	   *    $NguyênChiDuyWPF.Views.ProfileWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   8vm)clr-namespace:NguyênChiDuyWPF.ViewModels     5   	     � Title$  
My Profile��5   	   $	��400��6   $	��400��6)    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      2   ,NguyênChiDuyWPF.ViewModels.ProfileViewModel  5	   
   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Company Name��6   $��0��6'   �� 5   
   $��1��6   ��6   �� *Customer.CompanyName+�� 5   
   $��2��6   $��Contact Name��6   �� 5   
   $��3��6   ��6   �� *Customer.ContactName+�� 5   
   $��4��6   $��Phone��6   �� 5   
   $��5��6   ��6   �� *Customer.Phone+�� 5    
   $��6��6   $��Address��6   �� 5!   
   $��6��6   $��	0,0,0,135q�6A   ��6   �� *Customer.Address+6A   �� 5#   
   $��6��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   $��	0,150,0,0q�6W   $	��254��6j   .+�5$      �� $
��Save��6   $	��112��6$   $��0,0,10,0q�60   $��62��6b   ��6B   �� *SaveCommand+6b   �� 5%      -   5        $��Close��5%      $	��112��6%   61   5&      5'      5(      