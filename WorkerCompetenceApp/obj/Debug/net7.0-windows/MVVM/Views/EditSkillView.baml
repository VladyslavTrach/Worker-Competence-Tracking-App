   M S B A M L   `   `   `  ����  WorkerCompetenceApp-    'WorkerCompetenceApp.Views.EditSkillView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   
   $	��490��5   	   $	��260��6     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�6.    � AllowsTransparency$
 True��5	   	   
������  � 
ResizeMode$ NoResize=�6<   .��5      �� ���#979797 �� CornerRadius$ 15��6"   ._�5   
   � .+�5      �� $��
Edit Skill��6   $��26(�6*   $��20 7 0 0q�68   �� 5      
�������$ 10��6-   $	��420��6?   $	��240��6L   $��0 30 0 0q�6X   ._�5      �  � RowDefinitions 5      �� 5      $	��380 �6(   �� 5      $��80 �6(   .+�5      �� $��0��6   
�������$ 20��6B   $	��360��6T   $	��220��6a   
�������$	��0.8q�6�   ._�5      � .+�5      �� .+�5   "   �� $��Skill Information��6,   $��	10 10 0 0q�6E   $��20(�6X   �� 5   "   $��Category��6,   $��	10 20 0 0q�6<   $��16(�6O   $��Light"�6]   �� 5   "   -   5         ��Name$ CategoryComboBox��5   +   $��30��6E   $	��200��6Q   $	��Top=�6]   $��	10 10 0 0q�6u   $
��Left=�6�   �� 5   "   $��Position��6,   $��	10 15 0 0q�6<   $��16(�6O   $��Light"�6]   �� 5    "   -   5        $ OptionComboBox��5    +   $��30��6C   $	��200��6O   $	��Top=�6[   $��	10 10 0 0q�6s   $
��Left=�6�   �� 5"   "   $��Level��6,   $��	10 15 0 0q�69   $��16(�6L   $��Light"�6Z   �� 5#   "   -   5        $ LevelComboBox��5#   +   $��30��6B   $	��200��6N   $	��Top=�6Z   $��	10 10 0 0q�6r   $
��Left=�6�   �� 5%   "   $��Date of Acqusition��6,   $��	10 15 0 0q�6F   $��20(�6Y   $	��Top=�6g   $��Center=�6   (  "System.Windows.Controls.DatePicker  5&   "   -   5          Name$ 
DatePicker��5&   -   $��30��6A   $	��140��6M   $��	10 10 0 0q�6Y   $��18(�6l   ���#696969$��Center=�6�   5(      5*      5,      �� 5/      -   5         ��Name$ AddNewWorkerButton��5/   G   $��1��6   $	��100��6*   $��0 0 0 0q�66      	AddButton#��[  6c   $	��Top=�6�   $��Center=�6�   .��50      �� 	 �� Orientation$	 
Horizontal=�6%   .+�51      .  (MahApps.Metro.IconPacks.PackIconMaterial  
   Kind$
 Pencil=�64   $��Center=�6B   $��11��6]   $��11��6h   $��0 1 8 0q�6t   �� 52      $��
Edit Skill��6(   53      54      55      57      �� 59      -   5        $ MinimizeButton��59      $��Right=�6J   $	��Top=�6f   $��	0 10 40 0q�6~   $��25��6�   $��25��6�   
������ 
������ .��5:        $
 Minus=�6(   5;      �� 5<      -   5        $ CloseButton��5<      $��Right=�6D   $	��Top=�6`   $��	0 10 10 0q�6x   $��25��6�   $��25��6�   
������ 
������ .��5=        $
 Close=�6(   5>      5?      5A      5B      