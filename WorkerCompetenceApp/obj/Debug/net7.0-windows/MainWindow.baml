   M S B A M L   `   `   `  ����N  JWorkerCompetenceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:WorkerCompetenceApp.MVVM.ViewModel"WorkerCompetenceApp.MVVM.ViewModel  5   	   $    WorkerCompetenceApp.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   B	viewModel0clr-namespace:WorkerCompetenceApp.MVVM.ViewModel   5   	   $	��720��5   	   $
��1080��6     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�6.    � AllowsTransparency$
 True��5   	   
������  � DataContext 5
      6  0WorkerCompetenceApp.MVVM.ViewModel.MainViewModel  5   
    � 	Resources 5         BoolToVisible��%   &	        �� 5   
   6'   5      .��5      �� -   5         ��Name$ 
MainBorder��5      
������� �� CornerRadius$ 30��69   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      $��* �6#   .+�5      � .+�5      �  � RowDefinitions 5      �� 5       $
��Auto �6(   �� 5!      $��* �6(   .+�5%      �� $��
20 28 0 35q�6     	TopButton#��[ 61   .��5&      .  (MahApps.Metro.IconPacks.PackIconMaterial  	   Kind$		 Cog=�60   $��15��6;   $��15��6F   5'      �� 5)      $��1��6   ���#623ed0$ 	0 50 0 30��6?   ._�5*      ]� .+�5,      �� $��80��6%   $��80��60   
�������$	 100��6O   $	��Top=�5-   !   $
��Left=�66   $��
20 -30 0 0q�6Q   ._�5.   "   A� ��5/   &   �� 50   *   
 �� ImageSource$o
 iC:\Users\vlad0\source\repos\C#\WorkerCompetenceApp\WorkerCompetenceApp\WorkerCompetenceApp\Resource\4.png��65   52   #   53      �� 56      $��IT Technologies��6(   
�������$��22(�6R   $��SemiBold"�6`   $	��Top=�57   $    �� TextAlignment$ Center=�69   $��	5 25 0 10q�6P   �� 5;      $��
10 0 10 10q�6(   $	��Top=�6<   $	��0.8��6Q   
�������6^   �� 5>      $	��Top=�6)   .+�5?   "   ��   
MenuButton#��[ 6)   ��6M   �� *WorkerDataGridCommand+.��5@   &   ��  �� Orientation$ 
Horizontal=�61   .+�5A   *     $	 HomeVariant=�6@     MenuButtonIcon#��[ 6S   �� 5B   *   $��Workers Dashboard��64   5C   '   5D   #   5E      �� 5G      $	��Top=�6)   .+�5H   "   �� #��[ 6)   ��6M   �� *ProjectCommand+.��5I   &   �� $ 
Horizontal=�61   .+�5J   *     $	 CalendarClock=�6@   #��[ 6U   �� 5K   *   $��Project Managment��64   5L   '   5M   #   5N      �� 5b      $��Bottom=�6)   $��Bottom=�6A   $
��15 0q�6\   .+�5c   "   �� #��[ 6)   .��5d   &   �� $ 
Horizontal=�61   .+�5e   *     $	 Logout=�6@   #��[ 6N   �� 5f   *   $��Logout��64   5g   '   5h   #   5i      5k      5l      5m      5q      � 5s      $��1��6    5t      �� 5u      $��50 �6$   �� 5v      .+�5y      �� -   5         ��Name$ MinimizeButton��5y      $��Right=�6N   $	��Top=�6j   $��	0 10 70 0q�6�   $��25��6�   $��25��6�   
������ 
������ .��5z        $	 WindowMinimize=�6,   5{      �� 5|      -   5        $ WindowButton��5|      $��Right=�6J   $	��Top=�6f   $��	0 10 40 0q�6~   $��25��6�   $��25��6�   
������ 
������ .��5}        $	 WindowRestore=�6,   5~      �� 5      -   5        $ CloseButton��5      $��Right=�6H   $	��Top=�6d   $��	0 10 10 0q�6|   $��25��6�   $��25��6�   
������ 
������ .��5�        $	 WindowClose=�6,   5�      �� 5�      $��1��6!   ��6.   �� *CurrentView+5�      5�      5     5     5     