   M S B A M L   `   `   `  ����N  JWorkerCompetenceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:WorkerCompetenceApp.MVVM.ViewsWorkerCompetenceApp.MVVM.Views  5      7    1WorkerCompetenceApp.MVVM.Views.WorkerDataGridView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      :local,clr-namespace:WorkerCompetenceApp.MVVM.Views   5      .��5      � $��1��6   $��30 20 20 20q�6     � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $��0 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   � $	��300��6   $
��Left=�6   .+�5      �� $
��20 0q�6   $��Center=�6&   ���#b0b9c6 K� ZIndex$ 1��5       $��Search Here��61   �� 5      -   5         ��Name$ 	txtSearch��5         TextBoxSearch#��[  6)   .  (MahApps.Metro.IconPacks.PackIconMaterial  5          Kind$ Magnify=�6$   $��15��63   $��15��6>   $��Center=�6J   $��0 0 15 0q�5!   ,   ���#b0b9c6$��Right=�6S   5#      �� 5)   
   $��Workers��6   $��2��6#   $��32(�60   $��SemiBold"�6>   $��0 20 0 0q�6T   $
��Left=�5*      ���#12151867   �� 5/   
   -   5         ��Name$ RefreshButton��5/      $��2��6     	TopButton#��[ 65   $��
125 30 0 0q�6X   $
��Left=�6l   .��50        $ Refresh=�6$   $��15��63   $��15��6>   51      �� 52   
   -   5        $ AddNewWorkerButton��52      $��2��6     	AddButton#��[ 6:   .��53      ��  �� Orientation$ 
Horizontal=�6   .+�54        $
 Plus=�6(   $��Center=�64   $��11��6O   $��11��6Z   $��0 1 8 0q�6f   �� 55      $��Add New Worker��6   56      57      �� 5:   
   $��1��6   $��4��6   ���#dae2ea$��	0 -1 0 10q�6A   �� 5=   
   $��Company Staff��6   $��5��6)   $��18(�66   $��SemiBold"�6D   
���   �$
��Left=�5>   /   $��Center=�6J   �� 5?   
   $$��Press on category to sort by :��6   $��5��6:   $��13(�6G   $��SemiBold"�6U   $��0 0 10 0q�6k   
���   �$��Right=�5@   /   $��Center=�6K   &   System.Windows.Controls.DataGrid  5E   
   -   5          Name$ MembersDataGrid��5E   �     DataGridStyle1#���  6     DataGridCellStyle1   	CellStyle# �  6<     DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6m     DataGridRowStyle1	   RowStyle#	 �  6�   $��6��6�   
   Columns
 5F      4  .System.Windows.Controls.DataGridCheckBoxColumn  5G      ,  &System.Windows.Controls.DataGridColumn   CanUserResize$ False��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6?     CheckBoxStyle11  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 6L      HeaderTemplate 5H      �� 5I      .R�5J      �� #��[ 6'   5K      5M      0  *System.Windows.Controls.DataGridTextColumn  5O         Header$ Id��6%      
IsReadOnly$
 True��61   $ False��6C   $
 auto 6Y      Binding 6f   �� *Id+4  .System.Windows.Controls.DataGridTemplateColumn  5Q      $ 	Full Name��6)   $
 True��6<   $	 180 6N   $ False��6Z      CellTemplate 5R      �� 5S      .R�5T      �� $ 
Horizontal=�6)   .+�5U   "   �� $��25��6)   $��25��64    �� CornerRadius$ 50��6@   $��0 0 10 0q�6R   ��6d   �� *Collor+._�5V   &   ��  ��Name$ IconLetterTextBlock��60   $��Center=�6e   $��Center=�6�   
�������$��0 0 0 1q�6�   ��6M   �� *Letter+6�   5W   #   �� 5Y   "   $��Center=�6F   ��6,   �� *
FullName+6F   5[      5\      5^        5`      $ Position��6%   $
 True��67   $ * 6I   $ False��6p    6S   �� *
Position+6p     5a      $ Specialization��6%   $
 True��6=   $ * 6O   $ False��6|    6Y   �� *Specialization+6|     5b      $ Language��6%   $
 True��67   $ * 6I   $ False��6p    6S   �� *
Language+6p     5e      $ 
Operations��6)   $
 True��6=   $
 auto 6O   $ False��6\    5f      �� 5g      .R�5h      �� $ 
Horizontal=�6)   .+�5i   "   �� -   5          GridAddSkillButton#��[ 5i   )   .��5j   &     $ PlusBox=�6<    	 GridButtonIcon#��[	 6K   5k   #   �� 5l   "   -   5         
 GridViewDetailButton#��[
 5l   )   $��5 0 0 0q�6W   .��5m   &     $ AccountDetails=�6<   #��[	 6R   5n   #   �� 5o   "   -   5          GridRemoveButton#��[ 5o   )   $��5 0 0 0q�6S   .��5p   &     $ TrashCan=�6<   #��[	 6L   5q   #   5s      5t      5v      5y      5�      5�      