   M S B A M L   `   `   `  ����R  NBugBounty.DevelopersApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BugBounty.DevelopersAppBugBounty.DevelopersApp  5   	   M+clr-namespace:BugBounty.DevelopersApp.ViewsBugBounty.DevelopersApp.Views  5   	   W0clr-namespace:BugBounty.DevelopersApp.ViewModels"BugBounty.DevelopersApp.ViewModels  5   	   (    "BugBounty.DevelopersApp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:BugBounty.DevelopersApp     5   	   =views+clr-namespace:BugBounty.DevelopersApp.Views     5   	   G
viewModels0clr-namespace:BugBounty.DevelopersApp.ViewModels     5   	     � Title$  
MainWindow��5
   	   $	��500��6   $	��800��6)    � 	Resources 5       �� DataType5   /BugBounty.DevelopersApp.ViewModels.BugViewModel/   )BugBounty.DevelopersApp.Views.BugGridView6   0BugBounty.DevelopersApp.ViewModels.FormViewModel0   *BugBounty.DevelopersApp.Views.BugEntryForm   BoolToVisCon��%�   (��       5      *, +)(�� 2     5      *, +)&	  d     �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   6'   5      .��5      � $
��Auto��6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��15 �6   .+�5#   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   
�������.+�5$      �� $��/Images/BugLogo.png��6   $��50��61   $��50��6=   �� 5%      $��	BugBounty��6   $��20(�6)   �� 5&      $��Version 1.0��6   $��5)�6+   5'      � 5*   
   $��1��6    � ColumnDefinitions 5+      �� 5,      �� 5-      �� 5.      .+�51      �� $��5 5 5 5q�6   .@�52      �� .��6   Team6'   53      �� 55      $��Active Bugs��6   $��1��6+   $��5 5 5 5q�6;   �� 57      $��Resolved Bugs��6   $��2��6-   $��5 5 5 5q�6=   59      �� 5<   
   $ 
Horizontal=�6   $��2��6.   .+�5>      �� $��5,0,5,5q�6   ��6&   �� *AddNewBugCommand+��6K   �� *FormViewModel+.��5?      �� $ 
Horizontal=�6   .+�5@      �� $��/Images/add.png��6   $��18��65   �� 5A      $	��Add��6    $��5,0,5,0q�6+   5B      5C      �� 5E      $��5,0,5,5q�6   .��5F      �� $ 
Horizontal=�6   .+�5G      �� $��/Images/remove.jpg��6   $��18��68   �� 5H      $��Remove��6    $��5,0,5,0q�6.   5I      5J      �� 5L      $��5,0,5,5q�6   y�6&   �� *IsFormViewSelected+ �� 	Converter# [  ��5M      �� *CloseFormViewCommand+��6>   �� *BugViewModel+.��5N      �� $ 
Horizontal=�6   .+�5O      �� $��/Images/remove.jpg��6   $��18��68   �� 5P      $��Close��6    $��5,0,5,0q�6-   5Q      5R      5S      �� 5V   
   $��3��6   ��6&   �� *SelectedViewModel+�� 5X   
   $ 
Horizontal=�6   $��3,5,3,3q�6.   $��4��6?   y�5Y      �� *IsFormViewSelected+# [  .+�5[      �� $
��Save��6   $��0 0 5 0q�6$   $��50��65   �� 5\      $��Cancel��6   $��5 0 5 0q�6&   $��50��67   5]      �� 5_   
   $��(c) BugCorp 2022��6   $��5��6,   5a      5c      