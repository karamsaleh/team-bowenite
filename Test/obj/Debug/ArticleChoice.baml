   M S B A M L   `   `   `  ����?  ;Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Test.PropertiesTest.Properties  5   	       Test.ArticleChoice   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   /localclr-namespace:Test.Properties     5   	     � Title$  ArticleChoice��5   	   $	��336��6   $	��420��6,    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   
�������$��4q�5
   	   
������� � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5      " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��
 ��  �6+   �� 5       � ��
 �����6,   �� 5       � ��$ 2q�60   5      5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   
   .��5   
   � $��	-5,5,5,-5q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��
dgArticles��5      $
��Left=�5      $	��204��5      $	��Top=�5      $	��402��5       $
��Auto=�5!      $
��Auto=�5"      $��10,0,0,0q�6C   	   AlternatingRowBackground
	 �����5%      �� 5&   
   -   5        $��Choose��5&      $��331,209,0,82q�5'      5(      �� 5)   
   $��Change��6   $��10,209,321,82q�5*      �� 5+   
   -   5        $��Close��5+      $��331,281,0,10q�5,      5-      �� 5.   
   -   5        $��Add new��5.      $��162,209,169,36q�5/       51        52      54      �� 55   
   $��Delete��6   $��10,281,321,10q�56      �� 57   
   -   5        $��ArticleDetails��57      $	��182��6(   $��	10,22,0,0q�65   $	��Top=�6H   $y�	Collapsed=�58      .@�59      � $	��159��6   $	��384��6    .+�5:      �� $
��Name��6   $��
0,0,165,88q�6(   �� 5;      -   5        $��tbArticleName��5;      
 �� 
IsReadOnly
 . $��19��6A   $��NameOfTheArticle��6M   $y�Visible=�6e    J� RenderTransformOrigin$ 0,0.429&�6z   $��102,0,105,140q�6�   �� 5<      $��Quantity��6   $��0,21,165,69q�6,   �� 5=      -   5        $��
tbQuantity��5=      $��102,19,105,118q�6,   �� 5?      $��
Sell Price��6   $��0,76,158,64q�6.   �� 5@      -   5        $��tbSellPrice��5@      $
��5.00��6-   $��102,76,105,64q�69   �� 5A      $��	Discount%��6   $��0,95,158,45q�6-   �� 5B      -	   5        $��
tbDiscount��5B      $
��5.00��6,   $��102,95,105,45q�68   �� 5C      -
   5        $��btnAdd��5C      $	��Add��6'   $��0,129,284,0q�65   6J   �� 5D      -   5        $��Cancel��5D      $��276,129,8,0q�6*   6?   �� 5E      $��CheckBox��6   $
��Left=�6.   $��19��6I   $��
357,76,0,0q�6U   $	��Top=�6i   $��17��6�   $ 0.039,1.053&�6�   �� 5F      $
��Left=�6   $��20��67   $��
293,75,0,0q�6C   $
��Wrap=�6W   $��
Incl. VAT?��6k   $	��Top=�6}   $��52��6�   5G      5H      5J      5K      