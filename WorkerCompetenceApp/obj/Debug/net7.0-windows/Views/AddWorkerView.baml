   M S B A M L   `   `   `  ����  WorkerCompetenceApp-    'WorkerCompetenceApp.Views.AddWorkerView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   
   $	��390��5   	   $	��660��6     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�6.    � AllowsTransparency$
 True��5	   	   
������  � 
ResizeMode$ NoResize=�6<    � 	Resources 5         BoolToVisible��%   &	        �� 5   
   6'   5      .��5      �� ���#979797 �� CornerRadius$ 15��6"   ._�5   
   � .+�5      �� $��Worker Details��6   $��26(�6.   $��20 7 0 0q�6<   �� 5      
�������$ 10��6-   $	��320��6?   $	��640��6L   $��0 30 0 0q�6X   ._�5      �  � RowDefinitions 5      �� 5      $	��280 �6(   �� 5      $��80 �6(   .+�5      �� $��0��6   
�������$ 20��6B   $	��260��6T   $	��600��6a   
�������$	��0.8q�6�   ._�5      �  � ColumnDefinitions 5      �� 5   "   $	��350 �63   �� 5   "   $��* �63   .+�5!      �� .+�5"   "   �� $��Personal Information��6,   $��	10 10 0 0q�6H   $��20(�6[   �� 5$   "   $��	Full Name��6,   $��	10 20 0 0q�6=   $��16(�6P   $��Light"�6^   �� 5%   "   -   5         ��Name$ NameTextBox��5%   *     TextBoxStyleDetails#���  6?   $��10 0 0 0q�6m   $��22(�6   $	��180��6�   $
��Left=�6�   	 �� 
IsReadOnly$	 False��6�   �� 5'   "   $��Position��6,   $��	10 15 0 0q�6<   $��16(�6O   $��Light"�6]   �� 5(   "   -   5        $ PositionTextBox��5(   *   #���  6C   $��10 0 0 0q�6q   $��22(�6�   $	��180��6�   $
��Left=�6�   $	 False��6�   �� 5*   "   $��Specialization��6,   $��	10 15 0 0q�6B   $��16(�6U   $��Light"�6c   �� 5+   "   -   5        $ SpecializationTextBox��5+   *   #���  6I   $��10 0 0 0q�6w   $��22(�6�   $	��180��6�   $
��Left=�6�   $	 False��6�   5,      �� 5.      $��1��6)   .+�5/   "   �� $��Primary Language��6,   $��	10 55 0 0q�6D   $��16(�6W   $��Light"�6e   �� 50   "   -   5        $ LangTextBox��50   *   #���  6?   $��10 0 0 0q�6m   $��22(�6   $	��180��6�   $
��Left=�6�   $	 False��6�   �� 52   "   $��Phone Number��6,   $��	10 15 0 0q�6@   $��16(�6S   $��Light"�6a   �� 53   "   -   5        $ PhoneTextBox��53   *   #���  6@   $��10 0 0 0q�6n   $��16(�6�   $	��180��6�   $
��Left=�6�   $	 False��6�   �� 55   "   $��Email��6,   $��	10 23 0 0q�69   $��16(�6L   $��Light"�6Z   �� 56   "   -   5        $ EmailNameTextBox��56   *   #���  6D   $��10 0 0 0q�6r   $��16(�6�   $	��180��6�   $
��Left=�6�   $	 False��6�   57      58      5:      �� 5=      -   5        
 ��Name$
 AddNewWorkerButton��5=   ;   $��1��6   $��0 0 0 0q�6*     	AddButton#��[ 6W   $	��Top=�6�   $��Center=�6�   .��5>      ��  �� Orientation$ 
Horizontal=�6%   .+�5?      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Plus=�64   $��Center=�6@   $��11��6[   $��11��6f   $��0 1 8 0q�6r   �� 5@      $��Add New Worker��6(   5A      5B      5C      5E      �� 5G      -   5        $
 MinimizeButton��5G      $��Right=�6J   $	��Top=�6f   $��	0 10 40 0q�6~   $��25��6�   $��25��6�   
������ 
������ .��5H        $ Minus=�6(   5I      �� 5J      -	   5        $
 CloseButton��5J      $��Right=�6D   $	��Top=�6`   $��	0 10 10 0q�6x   $��25��6�   $��25��6�   
������ 
������ .��5K        $ Close=�6(   5L      5M      5O      5Q      