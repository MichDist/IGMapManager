   M S B A M L   `   `   `  ����G  CIGMapManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:IGMapManagerIGMapManager  5   	       IGMapManager.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:IGMapManager     5   	     � Title$  
MainWindow��5   	   $
��1200��6   $
��1600��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��80 �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� 
���   �$��1q�6%   $��1��69   $
��auto��6I   $��2��6W   $
��auto��6d   �� 5   
   
���   �$��1q�6%   $��1��69   $
��auto��6I   $��1��6W   $
��auto��6d   � 5   
   $��1��6   $��1��6$   $��Center=�61   .+�5      �� -   5         ��Name$ BtnZeus��5      $��80��6&   $	��120��62   .��6T   Zeus/Poseidon6c   �� 5      -   5        $ 
BtnPharaoh��5      $��80��6)   $	��120��65   .��6Z   Pharaoh/Cleopatra6m   �� 5      -   5        $ 
BtnEmperor��5      $��80��6)   $	��120��65   .��6Z   	Emperor6c   �� 5      -   5        $ BtnClose��5      $��80��6'   $	��120��63   .��6V   Close6]   5       � 5   
   -   5          �Name$ 	MainFrame��5      $��1��6#   $��2��63     � NavigationUIVisibility$ Hidden=�6@   5       5!      