   M S B A M L   `   `   `  ����J  FIgorWojcik10.05, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:IgorWojcik10._05IgorWojcik10._05  5   	   !    IgorWojcik10._05.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:IgorWojcik10._05     5   	     � Title$  Menadżer Biblioteki��5   	   $	��450��6%   $	��800��62    � 	Resources 5	         ButtonStyle �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%�  &	        �� 5
   
   " ��6$   .�5      ��  � ��
 ��ح�6+   �� 5       � ��
 ��  �6+   �� 5       � ��$ 2q�60   �� 5       � ��
 ��  �6,   �� 5       � ��$ 5q�6(   �� 5       � ��$ 5q�6'   �� 5       �@�Cursor$
 Hand��6'    5      P� 5       �@J�IsMouseOver$
 True��61   . �5      ��  � ��
 �����63   5      P� 5       � ��$
 True��6/   . �5      ��  � ��
 �����63   5      5      5      .��5      �� .+�5   
   o� $	��Top=�6   .@�5      m� $��_Plik��6   .@�5      m� -   5        $��_Zamknij��5      6-   5       m� 5!      $��
_Książki��6   .@�5"      m� -   5        $��_Dodaj nową książkę��5"      68   m� 5#      -   5        $ ��_Usuń wybraną książkę��5#      6:   5$      5%      �� 5&   
   -   5         ��Name$ FilterTextBox��5&      $	��200��6)   $��20��65   $��Filtruj po tytule...��6A   6�   �� 5'   
   -   5        $��Szczegóły książki��5'      #��[  6K   &   System.Windows.Controls.DataGrid  5(   
   -   5        	  Name$	 dataGridKsiazki��5(      
   AutoGenerateColumns$
 False��6,   $��10q�6H      
IsReadOnly$ False��6T      Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ Tytuł��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Tytul+  5+      $ Autor��6%    64   �� *Autor+  5,      $ Rok Wydania��6%    6:   �� *
RokWydania+  5-      $ Gatunek��6%    66   �� *	Gatunek+5/      �� 50   
   $��Bottom=�6   .@�51      �� $��Center=�6   .��52      �� $��© 2024 - Igor Wojcik��6   53      54      55      56      