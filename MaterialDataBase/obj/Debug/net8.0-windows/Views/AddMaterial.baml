   M S B A M L   `   `   `  ����K  GMaterialDataBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MaterialDataBase.ViewsMaterialDataBase.Views  5   	   (    "MaterialDataBase.Views.AddMaterial   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MaterialDataBase.Views     5   	     � Title$  AddMaterialWindow��5   	   $	��147��6#   $	��259��60   .��5	      � $��75��6   $	��Top=�6    � RowDefinitions 5
   
   �� 5      $��25 �6   �� 5      $��25 �6   �� 5      $��25 �6    � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      $	��126 �6   .+�5   
   �� $��Код��6   $��0��6   $��0��6+   �� 5   
   $��Наименование��6   $��1��6'   $��0��64   �� 5   
   $��Стоимость��6   $��2��6$   $��0��61   �� 5   
   -   5         ��Name$
 Code��5      $��0��66   $��1��6C   ��6    �� *code+6C   �� 5   
   -   5        $
 Name��5      $��1��66   $��1��6C   ��6    �� *name+6C   �� 5   
   -   5        $
 Cost��5      $��2��66   $��1��6C   ��6    �� *cost+6C   �� 5   
   -   5         ��Name$	 Add��5      $��Добавить��6   $��1��6X   $
��Left=�6h   $��20��6�   $��24,35,0,-30q�6�   $��2��6�   $	��Top=�6�   $��80��6�   ��61   �� *AddMaterialCommand+6�   �� 5   
   -   5        $ Cancel��5      $��Отмена��6!   $
��Left=�6^   $��20��6y   $��20,35,0,-30q�6�   $��2��6�   $	��Top=�6�   $��80��6�   ��62   �� *CloseMaterialWinCommand+6�   5      5      