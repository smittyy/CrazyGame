   M S B A M L   `   `   `  ����I  ECrazyMouseGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CrazyMouseGameCrazyMouseGame  5   	       CrazyMouseGame.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:CrazyMouseGame     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowState$ 	Maximized=�5	   	    � WindowStyle$
 None=�5
   	   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5    
   �� -   5         ��Name$ 
txtDisplay��5       $��4��6&   $��0��66    �� 
IsReadOnly .  �� TextAlignment$ Center=�6U   $��Center=�6l   $��30(�6�   $��2q�6�   .��6�   
Score: 06�   �� 5"   
   -   5         ��Name$ FunkyButton��5"      $��1��6&   $��0��63   $��20(�6C   $��5��6Q   $��5��6e   
�������.��6�   Fear6�   �� 5$   
   -   5        $ Start��5$      $��0��6    $��2��6-   $��20(�6=   .��6_   Start6f   �� 5&   
   -   5        $
 Time��5&      $��0��6   $��0��6,   $��20(�6<   .��6]   1:206c   �� 5'   
   -   5        $ BetterTimer��5'      $��0��6&   $��3��63   $��20(�6C   .��6k   	Restart6t   �� 5)   
   -   5        $
 Exit��5)      $��0��6   $��1��6,   $��20(�6<   .��6]   Exit6c   �� 5+   
   -   5        	 ��Name$	 Texty��5+      $��1��6#   $��0��60   $��50(�6@   $��5��6N   $��4��6b   6u   �� 5,   
   -   5        $ Namey��5,      $��5��6!   $��0��6.   $��75(�6>   $��4��6L   $��1��6`   $ Center=�6q   $��Center=�6�   6�   �� 5-   
   -	   5        $	 Sub��5-      $��5��6   $��4��6+   $��20(�6;   .��6\   Nope 56d   5/      50      