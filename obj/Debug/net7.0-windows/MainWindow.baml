   M S B A M L   `   `   `  ����N  JProjectEulerDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ProjectEulerDesktopProjectEulerDesktop  5   	   $    ProjectEulerDesktop.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ProjectEulerDesktop     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
      �� -   5         ��Name$ cbxEulerProblems��5
      $
��Left=�6'   $��
201,61,0,0q�6B   $	��Top=�6V   $	��339��6n    �� SelectedIndex$ 0��6z   .@�5      �� $%��Problem 1 - Multiples of 3 or 5��6   �� 5      $(��"Problem 2 - Even Fibonacci Numbers��6   �� 5      $&�� Problem 3 - Largest Prime Factor��6   �� 5      $(��"Problem 4 - Max 6-digit Palindrome��6   �� 5      $#��Problem 5 - Smallest Multiple��6   5      �� 5      -   5         ��Name$ lblEulerProblems��5   
   $��Euler Problems��6$   $
��Left=�6=   $��
201,23,0,0q�6X   $	��Top=�6l   $	��199��6�   �� 5      -   5         ��Name$ btnShowSolution��5      $��Show Solution��6$   $
��Left=�6<   $��	313,0,0,0q�6W   $��Center=�6j    �� 	IsDefault$
 True��6�   $��87��6�   6�   �� 5      -   5        $ lblSolution��5   
   $��Problem # - Solution��6   $
��Left=�6>   $��240,135,0,0q�6Y   $	��Top=�6n   $��29��6�   $	��205��6�   �� 5      -   5         ��Name$ txtbxProblemValue��5      $
��Left=�6'   $��
617,62,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $	��100��6j   $	��Top=�6u   $	��120��6�   �� 5      -   5        $ lblProblemValue��5   
   $��Problem Value��6#   $
��Left=�6;   $��
617,31,0,0q�6V   $	��Top=�6j   $	��100��6�    J� RenderTransformOrigin$ 1.828,-0.689&�6�   5      5      