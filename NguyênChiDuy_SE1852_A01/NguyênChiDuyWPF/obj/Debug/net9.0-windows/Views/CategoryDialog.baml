   M S B A M L   `   `   `  ����K  GNguyênChiDuyWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:NguyênChiDuyWPF.ViewModelsNguyênChiDuyWPF.ViewModels  5   	   +    %NguyênChiDuyWPF.Views.CategoryDialog   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   8vm)clr-namespace:NguyênChiDuyWPF.ViewModels     5   	     � Title$  Category Details��5   	   $	��300��6"   $	��450��6/    � WindowStartupLocation$ CenterOwner=�5   	    � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�6#    � DataContext 5      9   3NguyênChiDuyWPF.ViewModels.CategoryDialogViewModel  5	   
    � 	Resources 5      ��%    5      .��5      ��  �� CornerRadius$ 10��6   ���	#FF007ACC$��1q�67   ���	#FFF0F0F0 J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 0Q�6   	   Color$	 #BBBBBB��6/   
   Opacity$	
 0.5Q�6?      
BlurRadius$ 10Q�6M   ._�5   
   � $��25q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5       $��* �6#   .+�5#      �� $��Category Details��6   $��0��5$      $��24(�5%      $
��Bold"�5&      ���	#FF007ACC$��Center=�5(      $��0,0,0,20q�5)      �� 5+      $
��Name��6   $��1��6#   ���	#FF333333$��SemiBold"�6G   �� 5,      $��2��6      ModernTextBoxStyle#��[  6J   ��6#   �� *Category.CategoryName+6J   �� 5.      $��Description��6   $��3��6*   ���	#FF333333$��SemiBold"�6N   �� 5/      $��4��6   #��[  6I   ��6#   �� *Category.Description+6I   �� 51      $��6��6    �� Orientation$ 
Horizontal=�6&   $��Right=�6?   $��0,30,0,0q�6[   .+�52      �� -   5        $
��Save��52        ModernButtonStyle#��[ 6(   $��0,0,15,0q�6f   $��56��6x   �� 53      -   5        $��Cancel��53      #��[ 6*   $��58��6j   54      55      56      57      