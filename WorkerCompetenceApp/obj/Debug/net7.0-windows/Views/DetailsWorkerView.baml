   M S B A M L   `   `   `  ����N  JWorkerCompetenceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WorkerCompetenceApp.ViewsWorkerCompetenceApp.Views  5   	   1    +WorkerCompetenceApp.Views.DetailsWorkerView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:WorkerCompetenceApp.Views     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      $	��780��5   	   $	��660��6     � WindowStartupLocation$  CenterScreen=�5	   	    � WindowStyle$
 None=�6.    � AllowsTransparency$
 True��5
   	   
������  � 
ResizeMode$ NoResize=�6<   .��5      �� ���#979797 �� CornerRadius$ 15��6"   ._�5   
   � .+�5      �� $��Worker Details��6   $��26(�6.   $��	20 10 0 0q�6<   �� 5      
�������$ 10��6-   $	��700��6?   $	��640��6L   $��0 40 0 0q�6X   ._�5      �  � RowDefinitions 5      �� 5      $	��140 �6(   �� 5      $	��280 �6(   �� 5      $	��270 �6(   .+�5      �� 
�������$ 20��65   $	��120��6G   $	��600��6T   
�������$	��0.8q�6s   ._�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �  � ColumnDefinitions 5   "   �� 5   &   $	��500 �67   �� 5   &   $��* �67   .+�5   "   �� $��0��6-   $ 
Horizontal=�6=   .+�5   &   �� -   5         ��Name$ RoundBorder��5   -   $	��100��6B   $	��100��6N   $ 50��6[   $��	10 0 10 0q�6m   ���#123456._�5    *   �� -   5        	 ��Name$	 CircleTextBlock��5    4   $��Center=�6M   $��Center=�6h   $��25(�6�   
�������$��0 0 0 1q�6�   5!   '   �� 5"   &   .+�5#   *   �� -   5        
 ��Name$
 TopNameTextBox��5#   2      TextBoxStyleDetails#���   6J   $��10 8 0 0q�6x   $��22(�6�   $��Medium"�6�   �� 5$   *   -   5        $
 TopPositionTextBox��5$   2   #���   6N   $��	10 10 0 0q�6|   $��22(�6�   $��Medium"�6�   ���#6969696�   �� 5%   *   -   5        $
 TopLangTextBox��5%   2   #���   6J   $��10 5 0 0q�6x   $��22(�6�   $��Normal"�6�   ���#6969696�   5&   '   5'   #   �� 5)   "   -   5         ��Name$ EditTopRowDetails��5)   9   $��1��6)     EditDetailsButton#��[ 6T   $��Center=�6�   .��5*   &   �� $ 
Horizontal=�61   .+�5+   *   .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ Pencil=�6@   $��Center=�6N   $��13��6i   $��13��6t   $��0 1 4 0q�6�   �� 5,   *   -   5        $	 EditTextblock��5,   4   $
��Edit��6K   5-   '   5.   #   5/      51      52      �� 54      $��1��6   
�������$ 20��6B   $	��260��6T   $	��600��6a   
�������$	��0.8q�6�   ._�55      �  56      �� 57   "   $	��500 �63   �� 58   "   $��* �63   .+�5;      �  5<   "   �� 5=   &   $	��300 �67   �� 5>   &   $��* �67   .+�5@   "   �� .+�5A   &   �� $��Personal Information��60   $��	10 10 0 0q�6L   $��20(�6_   �� 5C   &   $��	Full Name��60   $��	10 20 0 0q�6A   $��16(�6T   $��Light"�6b   �� 5D   &   -   5        $
 NameTextBox��5D   .   #���   6C   $��10 0 0 0q�6q   $��22(�6�   $	��180��6�   $
��Left=�6�   �� 5F   &   $��Position��60   $��	10 15 0 0q�6@   $��16(�6S   $��Light"�6a   �� 5G   &   -	   5        $
 PositionTextBox��5G   .   #���   6G   $��10 0 0 0q�6u   $��22(�6�   $	��180��6�   $
��Left=�6�   �� 5I   &   $��Specialization��60   $��	10 15 0 0q�6F   $��16(�6Y   $��Light"�6g   �� 5J   &   -
   5        $
 SpecializationTextBox��5J   .   #���   6M   $��10 0 0 0q�6{   $��22(�6�   $	��180��6�   $
��Left=�6�   5K   #   �� 5M   "   $��1��6-   .+�5O   &   �� $��Phone Number��60   $��	10 55 0 0q�6D   $��16(�6W   $��Light"�6e   �� 5P   &   -   5        $
 PhoneTextBox��5P   .   #���   6D   $��10 0 0 0q�6r   $��14(�6�   $	��180��6�   $
��Left=�6�   �� 5R   &   $��Email��60   $��	10 10 0 0q�6=   $��16(�6P   $��Light"�6^   �� 5S   &   -   5        $
 EmailNameTextBox��5S   .   #���   6H   $��10 0 0 0q�6v   $��14(�6�   $	��180��6�   $
��Left=�6�   �� 5U   &   $��Collor��60   $��	10 10 0 0q�6>   $��16(�6Q   $��Light"�6_   �� 5V   &   -   5        $
 CollorTextBox��5V   .   #���   6E   $��10 0 0 0q�6s   $��14(�6�   $	��180��6�   $
��Left=�6�   �� 5X   &   $��Letter��60   $��	10 10 0 0q�6>   $��16(�6Q   $��Light"�6_   �� 5Y   &   -   5        $
 LetterTextBox��5Y   .   #���   6E   $��10 0 0 0q�6s   $��14(�6�   $	��180��6�   $
��Left=�6�   5Z   #   5[      �� 5]      -   5        $ EditMiddleRowDetails��5]   5   $��1��6%   #��[ 6S   $��0 10 0 0q�6~   $	��Top=�6�   $
��Left=�6�   .��5^   "   �� $ 
Horizontal=�6-   .+�5_   &     $ Pencil=�6<   $��Center=�6J   $��13��6e   $��13��6p   $��0 1 4 0q�6|   �� 5`   &   $
��Edit��60   5a   #   5b      5c      5e      �� 5g      $��2��6   
�������$ 20��6B   $	��250��6T   $	��600��6a   
�������$	��0.8q�6�   ._�5h      &   System.Windows.Controls.DataGrid  -   5          Name$ SkillsDataGrid��5h   �     DataGridStyle1#���  6#     DataGridCellStyle1   	CellStyle# �  6L     DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6}     DataGridRowStyle1   RowStyle# �  6�   $��5��6�      Columns 5i      0  *System.Windows.Controls.DataGridTextColumn  5j   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Id��65      
IsReadOnly$
 True��6A      CanUserResize$ False��6S      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6i   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6t   �� *Id+4  .System.Windows.Controls.DataGridTemplateColumn  5l   "   $ Category��69   $
 True��6K   $ * 6]   $ False��6g      CellTemplate 5m   &   �� 5n   *   .R�5o   .   �� $ 
Horizontal=�69   .+�5q   2   �� $��Center=�6V   ��6<   �� *
Category+6V   5s   /   5t   +   5v   #     5x   "   $
 Name��65   $
 True��6C   $ * 6U   $ False��6x    6_   �� *Name+6x     5y   "   $ Level��65   $
 True��6D   $ * 6V   $ False��6z    6`   �� *Level+6z     5z   "   $ Date Of Acquisition��65   $
 True��6R   $ * 6d   $ False��6�    6n   �� *DateOfAcquisition+6�     5}   "   $ 
Operations��69   $
 True��6M   $
 auto 6_   $ False��6l    5~   &   �� 5   *   .R�5�   .   �� $ 
Horizontal=�69   .+�5�   2   �� -   5          GridEditButton#��[ 5�   9   $��5 0 0 0q�6a   .��5�   6     $ PencilOutline=�6L     GridButtonIcon#��[ 6a   5�   3   �� 5�   2   -   5          GridRemoveButton#��[ 5�   9   $��5 0 0 0q�6c   .��5�   6     $ TrashCan=�6L   #��[ 6\   5�   3   5�   /   5�   +   5�   #   5�      5�      5�      5�      �� 5�      -   5        $ MinimizeButton��5�      $��Right=�6J   $	��Top=�6f   $��	0 10 40 0q�6~   $��25��6�   $��25��6�   
������ 
������ .��5�        $ Minus=�6(   5�      �� 5�      -   5        $ CloseButton��5�      $��Right=�6D   $	��Top=�6`   $��	0 10 10 0q�6x   $��25��6�   $��25��6�   
������ 
������ .��5�        $ Close=�6(   5�      5�      5�      5�      