   M S B A M L   `   `   `  ����N  JWorkerCompetenceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:WorkerCompetenceApp.MVVM.ViewsWorkerCompetenceApp.MVVM.Views  5   	   7    1WorkerCompetenceApp.MVVM.Views.DetailsProjectView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:WorkerCompetenceApp.MVVM.Views     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      $	��780��5	   	   $	��660��6     � WindowStartupLocation$  CenterScreen=�5
   	    � WindowStyle$
 None=�6.    � AllowsTransparency$
 True��5   	   
������  � 
ResizeMode$ NoResize=�6<   .��5      �� ���#979797 �� CornerRadius$ 15��6"   ._�5   
   � .+�5      �� $��Project Details��6   $��26(�6/   $��	20 10 0 0q�6=   �� 5      
�������$ 10��6-   $	��700��6?   $	��640��6L   $��0 40 0 0q�6X   ._�5      �  � RowDefinitions 5      �� 5      $	��140 �6(   �� 5      $	��160 �6(   �� 5      $��* �6(   .+�5      �� 
�������$ 20��65   $	��120��6G   $	��600��6T   
�������$	��0.8q�6s   ._�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �  � ColumnDefinitions 5   "   �� 5   &   $	��350 �67   �� 5   &   $	��150 �67   �� 5   &   $��* �67   .+�5    "   �� $��0��6-   $ 
Horizontal=�6=   .+�5!   &   �� -   5         ��Name$ RoundBorder��5!   -   $	��100��6B   $	��100��6N   $ 50��6[   $��	10 0 10 0q�6m   ���#123456._�5"   *   �� -   5        	 ��Name$	 CircleTextBlock��5"   4   $��Center=�6M   $��Center=�6h   $��25(�6�   
�������$��0 0 0 1q�6�   5#   '   �� 5$   &   .+�5%   *   �� -   5        
 ��Name$
 TopNameTextBox��5%   2      TextBoxStyleDetails#���   6J   $��10 8 0 0q�6x   $��22(�6�   $��Medium"�6�   5&   '   5'   #   �� 5)   "   $��1��6-   .+�5*   &   �� $��Collor��60   $��	10 10 0 0q�6>   $��16(�6Q   $��Light"�6_   �� 5+   &   -   5        $
 CollorTextBox��5+   .   #���   6E   $��10 0 0 0q�6s   $��14(�6�   $	��180��6�   $
��Left=�6�   �� 5-   &   $��Letter��60   $��	10 10 0 0q�6>   $��16(�6Q   $��Light"�6_   �� 5.   &   -   5        $
 LetterTextBox��5.   .   #���   6E   $��10 0 0 0q�6s   $��14(�6�   $	��180��6�   $
��Left=�6�   5/   #   �� 51   "   -   5         ��Name$ EditTopRowDetails��51   9   $��2��6)     EditDetailsButton#��[ 6T   $��Center=�6�   .��52   &   �� $ 
Horizontal=�61   .+�53   *   .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ Pencil=�6@   $��Center=�6N   $��13��6i   $��13��6t   $��0 1 4 0q�6�   �� 54   *   -   5        $	 EditTopTextBlock��54   4   $
��Edit��6N   55   '   56   #   57      59      5:      �� 5<      $��1��6   
�������$ 20��6B   $	��140��6T   $	��600��6a   
�������$	��0.8q�6�   ._�5=      � .+�5?      � .+�5A   "   �� .+�5B   &   �� $��Project Description��60   $��	10 10 0 0q�6K   $��20(�6^   �� 5D   &   -   5        $
 DescriptionTextBox��5D   .   #���   6J   $��	10 20 0 0q�6x   $��22(�6�   $	��580��6�   $��70��6�   $
��Left=�6�   5E   #   5F      �� 5H      -	   5        $ EditMiddleRowDetails��5H   %   #��[ 6C   $��	0 10 20 0q�6n   $	��Top=�6�   $��Right=�6�   .��5I   "   �� $ 
Horizontal=�6-   .+�5J   &     $ Pencil=�6<   $��Center=�6J   $��13��6e   $��13��6p   $��0 1 4 0q�6|   �� 5K   &   -
   5        $	 EditBottomTextBlock��5K   0   $
��Edit��6M   5L   #   5M      5N      5P      �� 5R      $��2��6   
�������$ 20��6B   $	��400��6T   $	��600��6a   
�������$	��0.8q�6�   ._�5S      �� .+�5T      �� $ 
Horizontal=�6)   .+�5U   "   �� $��Required Skills��6,   $��	10 10 0 0q�6C   $��20(�6V   �� 5V   "   -   5        $ RefreshButton��5V   6   $��2��6)     	TopButton#��[ 6M   $��0 5 0 0q�6p   $
��Left=�6�   .��5W   &     $ Refresh=�6<   $��15��6K   $��15��6V   5X   #   �� 5Y   "   -   5        $ AddNewSkillButton��5Y   )     	AddButton#��[ 6D   $��
270 10 0 0q�6�   .��5Z   &   �� $ 
Horizontal=�61   .+�5[   *     $
 Plus=�6@   $��Center=�6L   $��11��6g   $��11��6r   $��0 1 8 0q�6~   �� 5\   *   $��Add New Skill��64   5]   '   5^   #   5_      &   System.Windows.Controls.DataGrid  5b      -   5          Name$ SkillsDataGrid��5b   �     DataGridStyle1#���  6'     DataGridCellStyle1   	CellStyle# �  6P     DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6�     DataGridRowStyle1   RowStyle# �  6�   $��5��6�      Columns 5c   "   0  *System.Windows.Controls.DataGridTextColumn  5d   &   ,  &System.Windows.Controls.DataGridColumn   Header$ Id��69      
IsReadOnly$
 True��6E      CanUserResize$ False��6W      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 6m   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6x   �� *Id+4  .System.Windows.Controls.DataGridTemplateColumn  5f   &   $ Category��6=   $
 True��6O   $ * 6a   $ False��6k      CellTemplate 5g   *   �� 5h   .   .R�5i   2   �� $ 
Horizontal=�6=   .+�5k   6   �� $��Center=�6Z   ��6@   �� *
Category+6Z   5m   3   5n   /   5p   '     5r   &   $
 Name��69   $
 True��6G   $ * 6Y   $ False��6|    6c   �� *Name+6|     5s   &   $ Level��69   $
 True��6H   $ * 6Z   $ False��6~    6d   �� *Level+6~     5t   &   $ Date Of Acquisition��69   $
 True��6V   $ * 6h   $ False��6�    6r   �� *DateOfAcquisition+6�     5w   &   $ 
Operations��6=   $
 True��6Q   $
 auto 6c   $ False��6p    5x   *   �� 5y   .   .R�5z   2   �� $ 
Horizontal=�6=   .+�5{   6   �� -   5          GridEditButton#��[ 5{   =   $��5 0 0 0q�6e   .��5|   :     $ PencilOutline=�6P    	 GridButtonIcon#��[	 6e   5}   7   �� 5~   6   -   5         
 GridRemoveButton#��[
 5~   =   $��5 0 0 0q�6g   .��5   :     $ TrashCan=�6P   #��[	 6`   5�   7   5�   3   5�   /   5�   '   5�      5�      5�      5�      5�      �� 5�      -   5        $ MinimizeButton��5�      $��Right=�6J   $	��Top=�6f   $��	0 10 40 0q�6~   $��25��6�   $��25��6�   
������ 
������ .��5�        $ Minus=�6(   5�      �� 5�      -   5        $ CloseButton��5�      $��Right=�6D   $	��Top=�6`   $��	0 10 10 0q�6x   $��25��6�   $��25��6�   
������ 
������ .��5�        $ Close=�6(   5�      5�      5�      5�      