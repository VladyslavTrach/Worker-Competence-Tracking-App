   M S B A M L   `   `   `  ����N  JWorkerCompetenceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:WorkerCompetenceApp.MVVM.ViewsWorkerCompetenceApp.MVVM.Views  5   	   3    -WorkerCompetenceApp.MVVM.Views.AddProjectView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:WorkerCompetenceApp.MVVM.Views     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   $	��390��5   	   $	��360��6     � WindowStartupLocation$  CenterScreen=�5	   	    � WindowStyle$
 None=�6.    � AllowsTransparency$
 True��5
   	   
������  � 
ResizeMode$ NoResize=�6<    � 	Resources 5         BoolToVisible��%   &	        �� 5   
   6'   5      .��5      �� ���#979797 �� CornerRadius$ 15��6"   ._�5   
   � .+�5      �� $��Project Details��6   $��26(�6/   $��20 7 0 0q�6=   �� 5      
�������$ 10��6-   $	��320��6?   $	��340��6L   $��0 30 0 0q�6X   ._�5      �  � RowDefinitions 5      �� 5      $	��280 �6(   �� 5      $��80 �6(   .+�5      �� $��0��6   
�������$ 20��6B   $	��260��6T   $	��300��6a   
�������$	��0.8q�6�   ._�5      � .+�5      �� .+�5   "   �� $��Project Information��6,   $��	10 10 0 0q�6G   $��20(�6Z   �� 5!   "   $
��Name��6,   $��	10 20 0 0q�68   $��16(�6K   $��Light"�6Y   $��Center=�6l   �� 5"   "   -   5         ��Name$ NameTextBox��5"   *     TextBoxStyleDetails#���  6?   $��10 0 0 0q�6m   $��28(�6   $	��240��6�   $��Center=�6�    �� 
IsReadOnly$ False��6�   �� 5$   "   $��Description��6,   $��	10 15 0 0q�6?   $��16(�6R   $��Light"�6`   $��Center=�6s   �� 5%   "   -   5        $ DescriptionTextBox��5%   *   #���  6F   $��10 0 0 0q�6t   $��22(�6�   $	��240��6�   $	��100��6�   $��Center=�6�   $ False��6�   $��1q�6�   5&      5)      5+      �� 5.      -   5        	 ��Name$	 AddNewProjectButton��5.   ;   $��1��6   $��0 0 0 0q�6*     	AddButton#��[ 6X   $	��Top=�6�   $��Center=�6�   .��5/      �� 
 �� Orientation$
 
Horizontal=�6%   .+�50      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Plus=�64   $��Center=�6@   $��11��6[   $��11��6f   $��0 1 8 0q�6r   �� 51      $��Add New Project��6(   52      53      54      56      �� 58      -   5        $	 MinimizeButton��58      $��Right=�6J   $	��Top=�6f   $��	0 10 40 0q�6~   $��25��6�   $��25��6�   
������ 
������ .��59        $ Minus=�6(   5:      �� 5;      -   5        $	 CloseButton��5;      $��Right=�6D   $	��Top=�6`   $��	0 10 10 0q�6x   $��25��6�   $��25��6�   
������ 
������ .��5<        $ Close=�6(   5=      5>      5@      5B      