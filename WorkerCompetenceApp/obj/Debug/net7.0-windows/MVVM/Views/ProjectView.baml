   M S B A M L   `   `   `  ����N  JWorkerCompetenceApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:WorkerCompetenceApp.MVVM.ViewsWorkerCompetenceApp.MVVM.Views  5      0    *WorkerCompetenceApp.MVVM.Views.ProjectView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:WorkerCompetenceApp.MVVM.Views     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      .��5      � $��1��6   $��30 20 20 20q�6     � RowDefinitions  5   
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
   $��Projects��6   $��2��6$   $��32(�61   $��SemiBold"�6?   $��0 20 0 0q�6U   $
��Left=�5*      ���#12151867   �� 5-   
   -   5         ��Name$ RefreshButton��5-      $��2��6     	TopButton#��[ 65   $��
125 30 0 0q�6X   $
��Left=�6l   .��5.        $ Refresh=�6$   $��15��63   $��15��6>   5/      �� 50   
   -   5        $ AddNewProjectButton��50      $��2��6     	AddButton#��[ 6;   .��51      ��  �� Orientation$ 
Horizontal=�6   .+�52        $
 Plus=�6(   $��Center=�64   $��11��6O   $��11��6Z   $��0 1 8 0q�6f   �� 53      $��Add New Project��6   54      55      �� 58   
   $��1��6   $��4��6   ���#dae2ea$��	0 -1 0 10q�6A   �� 5;   
   $��List of Projects��6   $��5��6,   $��18(�69   $��SemiBold"�6G   
���   �$
��Left=�5<   /   $��Center=�6J   �� 5=   
   $$��Press on category to sort by :��6   $��5��6:   $��13(�6G   $��SemiBold"�6U   $��0 0 10 0q�6k   
���   �$��Right=�5>   /   $��Center=�6K   &   System.Windows.Controls.DataGrid  5C   
   -   5          Name$ ProjectsDataGrid��5C   �     DataGridStyle1#���  6     DataGridCellStyle1   	CellStyle# �  6<     DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6m     DataGridRowStyle1	   RowStyle#	 �  6�   $��6��6�   
   Columns
 5D      4  .System.Windows.Controls.DataGridCheckBoxColumn  5E      ,  &System.Windows.Controls.DataGridColumn   CanUserResize$ False��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6?     CheckBoxStyle11  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 6L      HeaderTemplate 5F      �� 5G      .R�5H      �� #��[ 6'   5I      5K      0  *System.Windows.Controls.DataGridTextColumn  5M         Header$ Id��6%      
IsReadOnly$
 True��61   $ False��6C   $
 auto 6Y      Binding 6f   �� *Id+4  .System.Windows.Controls.DataGridTemplateColumn  5O      $
 Name��6)   $
 True��67   $	 200 6I   $ False��6U      CellTemplate 5P      �� 5Q      .R�5R      �� $ 
Horizontal=�6)   .+�5S   "   �� $��25��6)   $��25��64    �� CornerRadius$ 50��6@   $��0 0 10 0q�6R   ��6d   �� *Collor+._�5T   &   ��  ��Name$ IconLetterTextBlock��60   $��Center=�6e   $��Center=�6�   
�������$��0 0 0 1q�6�   ��6M   �� *Letter+6�   5U   #   �� 5W   "   $��Center=�6B   ��6,   �� *Name+6B   5Y      5Z      5\        5^      $ Description��6%   $
 True��6:   $ * 6L   $ False��6v    6V   �� *Description+6v     5a      $ 
Operations��6)   $
 True��6=   $
 auto 6O   $ False��6\    5b      �� 5c      .R�5d      �� $ 
Horizontal=�6)   .+�5e   "   �� -   5          GridViewDetailButton#��[ 5e   )   $��5 0 0 0q�6W   .��5f   &     $ AccountDetails=�6<    	 GridButtonIcon#��[	 6R   5g   #   �� 5h   "   -   5         
 GridRemoveButton#��[
 5h   )   $��5 0 0 0q�6S   .��5i   &     $ TrashCan=�6<   #��[	 6L   5j   #   5l      5m      5o      5s      5{      5|      