   M S B A M L   `   `   `  ����B  >NoteMAN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:NoteMANNoteMAN  5   	       NoteMAN.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:NoteMAN     5   	   -   5          �Name$
  home��5   	    � Title$ 
MainWindow��5   	   $	��650��6   $	��942��6)    � WindowStartupLocation$ CenterScreen=�65    � 
ResizeMode$ NoResize=�6Z    � WindowStyle$
 None=�6p   
������  � AllowsTransparency$
 True��5	   "   .��5      ��  �� CornerRadius$ 8��6   ���#F3F3F3._�5   
   � .+�5      �� $ 8��6   $��1��6&   $��10q�63   ._�5      � .+�5      �� -   5         ��Name$ 
ActivePage��5       $��55��64   $	��160��6@    �� Padding$ 5,5,0,0q�6L   $��30(�6^   $��
220,20,0,0q�6l   $��
ActivePage��6�   $��Normal"�6�   $��Normal$�6�   ��6�   Z� 6�    � 5      -   5        	  �Name$	 pageView��5      $�� ��6.   $
��Left=�69   $	��530��6T   $��
215,10,0,0q�6a   $	��Top=�6u   $	��685��6�   
  � NavigationUIVisibility$
 Hidden=�6�   $��1,1,1,1q�6�   5      5      �� 5      $ 	8,0, 0, 8��6   $	��198��6.   $
��Left=�6:   ���	#FF807D7D$��0,0,1,0q�6m   ._�5      � .+�5      �� $	��198��6!   $��Center=�6-   .+�5      �� $
��auto��6%   $��99��62    �� Orientation$ 
Horizontal=�6>   $��Stretch=�6W   $��RightToLeft=�6u   .+�5      �� $��NoteMAN��6(   $��24(�67   $��	0 30 0 30q�6E    �� TextAlignment$ Center=�6X   $	��115��6o   �� 5      $��/icons8-note-64.png��6$   $
��Left=�6A   $��86��6\   $��86��6h   $	��Top=�6s   5      �� 5      $��	0 20 0 20q�6%   .+�5      �� -   5         ��Name$ rdhome��5   %   $��20(�65   $��Center=�6C   $��10,0,0,0q�6e   $	��150��6x    � UseLayoutRounding$
 True��6�    J� SnapsToDevicePixels$
 True��6�   ��6�   Z� ��6�   Z� .��5   "   �  � Orientation$ Vertical=�6,   .+�5   &   �� $"��/outline_home_black_48dp.png��6,   $��Stretch=�6R   $��Uniform=�6p   $��80��6�   $��80��6�   �� 5   &   -   5        $ 	homeLabel��5   0   $
��Home��6C   $
��Left=�6O   $��Center=�6j   $��10,0,0,0q�6�   $ Center=�6�   5    #   5!      �� 5"      -   5        $ rdadd��5"   %   $��20(�64   $��Center=�6B   $��10,0,0,0q�6d   $	��150��6w   $
 True��6�   $
 True��6�   ��6�   Z� ��6�   Z� .��5#   "   � $ Vertical=�6,   .+�5$   &   �� $&�� /outline_note_add_black_48dp.png��6,   $��Stretch=�6V   $��Uniform=�6t   $��80��6�   $��80��6�   �� 5%   &   -   5        $ addNoteLabel��5%   0   $��Add Note��6F   $��Center=�6V   $��Center=�6s   $��96��6�   $ Center=�6�   5&   #   5'      �� 5(      -   5        $ rdsets��5(   %   $��20(�65   $��Center=�6C   $��10,0,0,0q�6e   $	��150��6x   $
 True��6�   $
 True��6�   ��6�   Z� ��6�   Z� .��5)   "   � $ Vertical=�6,   .+�5*   &   �� $&�� /outline_settings_black_48dp.png��6,   $��Stretch=�6V   $��Uniform=�6t   $��80��6�   $��80��6�   �� 5+   &   -	   5        $ settingsLabel��5+   0   $��Settings��6G   $��Center=�6W   $��Center=�6t   $��81��6�   $ Center=�6�   5,   #   5-      5.      5/      50      51      �� 52      $ 8��6   $��Right=�6&   $	��Top=�6B   ._�53      �� $ 
Horizontal=�6   $��RightToLeft=�66   $��29��6R   $��80��6^   .+�54      �� $ 0 8 0 0��6   $��40��64   ._�55      �� -
   5        $ 	close_btn��55   !   $��×��64   $��20(�6@   
������ $��0,0,0,0q�6~   $��29��6�   ��6g   Z� 6�   56      �� 58      -   5        $ minimize_btn��58      $��-��63   $��20(�6?   $��40��6M   
������ $��0,0,0,0q�6�   ��6q   Z� 6�   59      5:      5;      5<      5=      