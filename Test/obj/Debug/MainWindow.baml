   M S B A M L   `   `   `  ����?  ;Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TestTest  5   	       Test.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   !myclr-namespace:Test     5   	   -   5        $��MW��5   	     � Title$  
MainWindow��5   	    � WindowState$ 	Maximized=�5   	    � 	Resources 5       �� 
TargetType �� Property �� Value��%z   '��       �� 5	   
   " ��6   .�5
      ��  � ��
 �����6+   �� 5       � ��
 ��  �6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��60 �6   �� 5      �� 5      $��20 �6   .+�5   
   o� $��0��6   .@�5      m� $��_Operations��6   .@�5      m� $��_Sell��6    m� InputGestureText$ Alt + S��6*   m� 5      $
��_Buy��6   $ Alt + B��6)   m� 5      $��_Filter��6   $ Alt + F��6,   m� 5      $��_Exit��6   $ Alt + E��6*   5      m� 5      $��_Help��6   5      �� 5    
   -   5        $��Buttons��5       $��1��5!       �� Orientation$ 
Horizontal=�5"      
�������	 J� Effect	 5$      3  -System.Windows.Media.Effects.DropShadowEffect  5%      .+�5'      �� -   5        $��60��5'      $��50��5(      $��	10,0,20,0q�5)      $
��Sell��5*      	 5,        5-      5/      �� 50      -   5        $��60��50      $��50��51      $��Purchase��52      $��0, 0, 20, 0q�53      	 55        56      58      �� 59      -   5        $��60��5:      $��50��5;      $��Filter��5<      $��0,5,20,5q�5=      	 5?        5@      5B      �� 5C      -   5        $��60��5C      $��50��5D      $
��Exit��5E      $	��0,5q�5F   "   	 5G        5H      5J      5K      �� 5L   
   -   5        $��	WorkStack��5L      $��2��5M      .+�5N      �� -   5        $��bkgImg��5N      $%��pack://siteoforigin:,,,/img.jpg��5O      $y�	Collapsed=�5P      
 J� Opacity$	
 0.5Q�5Q         Test.Buy  5R      -	   5          Name$	 Buy��5R      $y�	Collapsed=�5S       K� ZIndex$ 1��5T         	Test.Sell  5U      -
   5          Name$
 Sell��5U      $��Stretch=�5V      $��Stretch=�5W      $y�	Collapsed=�5X      $ 2��5Y         Test.Filter  5Z      -   5          Name$ Filter��5Z      $��Stretch=�5[      $��Stretch=�5\      $y�	Collapsed=�5]      $ 3��5^      5_      �� 5a   
   $��3��6   
�������6!   5b      5c      