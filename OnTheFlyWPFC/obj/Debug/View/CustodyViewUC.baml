   M S B A M L   `   `   `  ����G  COnTheFlyWPFC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:OnTheFlyWPFC.ViewOnTheFlyWPFC.View  5      ?$clr-namespace:OnTheFlyWPFC.ViewModelOnTheFlyWPFC.ViewModel  5	      %    OnTheFlyWPFC.View.CustodyViewUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:OnTheFlyWPFC.View     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      4	viewmodel$clr-namespace:OnTheFlyWPFC.ViewModel  5	        � 	Resources  5      #  OnTheFlyWPFC.ViewModel.Class1 
  class1  StandardBorderBrush �� Color  StandardBackgroundBrush  HoverBorderBrush  SelectedBackgroundBrush  SelectedForegroundBrush  DisabledForegroundBrush  NormalBrush  NormalBorderBrush 	 HorizontalNormalBrush 
 HorizontalNormalBorderBrush  ListBoxBackgroundBrush �� 
StartPoint �� EndPoint � Color � Offset  StandardBrush  
GlyphBrush  PressedBrush  ScrollBarLineButton �� 
TargetType �� Property �� Value	 �� 
TargetType
 �� CornerRadius �� Path �� RelativeSource �� Triggers P� Property P� Value �� 
TargetName  ScrollBarPageButton  ScrollBarThumb  VerticalScrollBar � RowDefinitions ]� DecreaseRepeatButton ]� Thumb ]� IncreaseRepeatButton  HorizontalScrollBar � ColumnDefinitions �� Triggers  FavsScrollViewer �� VerticalOffset � Value �� ScrollableHeight � Maximum �� ViewportHeight �� ViewportSize* �� #ComputedVerticalScrollBarVisibility �� Orientation �� HorizontalOffset  �� ScrollableWidth! �� ViewportWidth," �� %ComputedHorizontalScrollBarVisibility��%�  &	        &	      &	 1     &	 T     &	 r     &	 �     &	 �     &	 �     &	 �     &		     &	
 1    &	 O    &	 3    &	 �    &	 �    &	     7  7  7  7  7  &	 �    &	 -    &	 �	    7  7  7  7 	 7 
 7  7  &	 �    7  7  7  7  7  7  7  '�� �    7  7  &	 �      5   
   6   �� 5   
   $
 #888��66   �� 5   
   $ 	LightGray��6:   �� 5   
   $
 #DDD��63   �� 5   
   $ 	LightGray��6:   �� 5   
   $ White��6:   �� 5   
   $
 #888��6:   �� 5   
   $
 #888��6.   �� 5   
   $
 #888��64   �� 5   
   $ 	LightGray��68   �� 5   
   $
 #888��6>   �� 5   
   $	 0,0&�5      $ 1,0.001&�6   ��5      � � 5      $ White��6#   $	 0.0Q�61   � 5      $ White��6#   $	 0.6Q�61   � 5      $ #DDDDDD��6#   $	 1.2Q�63   5       5"      �� 5#   
   $	 0,0&�5%      $	 0,1&�6   ��5'      � � 5(      $
 #FFF��6#   $	 0.0Q�60   � 5)      $
 #CCC��6#   $	 1.0Q�60   5*      5,      �� 5-   
   $
 #444��6-   �� 5.   
   $	 0,0&�50      $	 0,1&�6   ��52      � � 53      $
 #BBB��6#   $	 0.0Q�60   � 54      $
 #EEE��6#   $	 0.1Q�60   � 55      $
 #EEE��6#   $	 0.9Q�60   � 56      $
 #FFF��6#   $	 1.0Q�60   57      59      �� 5;   
   " ��6,   .�5<      ��  � y�$ Hidden=�6+   �� 5=       �@J�SnapsToDevicePixels . 64   �� 5>       �@�OverridesDefaultStyle . 66   �� 5?       � |� .  6*   �� 5@       � �� 5A      �� 5B      "	 ��6&   .R�5C      �� $��Border��6!   $��1q�6/   $
 2��6:   8��  8�� $��1q�6�   ._�5D      F� $��Center=�6#   $��Center=�5F      8�� ��5I      �� $ Content� �� *TemplatedParent+5L       5M      P� 5N       � �� . . �5O   "   �� $ Border��6)   8   � ��5Q   !   5R      P� 5S       � {� .  . �5T   "   �� 8   � ��5V   !   5W      5Y      5[      5\      �� 5]   
   " ��6,   .�5^      ��  � y�$ Hidden=�6+   �� 5_       �@J�SnapsToDevicePixels . 64   �� 5`       �@�OverridesDefaultStyle . 66   �� 5a       � �� .  6*   �� 5b       � |� .  6*   �� 5c       � �� 5d      �� 5e      "	 ��6&   .R�5f      �� 
���   �6!   5g      5i      5j      �� 5k   
   " n�6'   .�5l      ��  �@J�SnapsToDevicePixels . 64   �� 5m       �@�OverridesDefaultStyle . 66   �� 5n       � �� .  6*   �� 5o       � |� .  6*   �� 5p       � �� 5q      �� 5r      "	 n�6&   .R�5s      �� $
 2��5t      #��z��5v      #��z��5w      $��0q�5x      $��5��5y      $��5,0,-2,0q�5z      5{      5}      5~      �� 5�   
   "	 ��5�      .R�5�      �  5�      �� 5�      $��0��6$   �� 5�      $��0.00001* �6$   �� 5�      $��0��6$   .+�5�      �� $��3��5�      $
 2��5�      
������ 5�      �� 5�      $��0��5�      8��  $��18��5�      $��ScrollBar.LineUpCommand��5�      $��M 0 4 L 8 4 L 4 0 Z��5�      ]� 5�      $��
PART_Track��5�      $��1��5�      ��.  5�      �� 5�      8�� $��ScrollBar.PageUpCommand��5�       5�      n� 5�      8�� $��1,0,1,0q�5�      8�� 8�� 5�       5�      �� 5�      8�� $��ScrollBar.PageDownCommand��5�      5�      �� 5�      $��3��5�      8�� $��18��5�      $��ScrollBar.LineDownCommand��5�      $��M 0 0 L 4 4 L 8 0 Z��5�      5�      5�      �� 5�   
   "	 ��5�      .R�5�      �  5�      �� 5�      $��18��6'   �� 5�      $��0.00001* �6'   �� 5�      $��18��6'   .+�5�      �� $��3��5�      $
 2��5�      ���#F0F0F05�      �� 5�      $��0��5�      8��  $��18��5�      $��ScrollBar.LineLeftCommand��5�      $��M 4 0 L 4 8 L 0 4 Z��5�      ]� 5�      $��
PART_Track��5�      $��1��5�      ��.   5�      �� 5�      8�� $��ScrollBar.PageLeftCommand��5�       5�      n� 5�      8�� $��0,1,0,1q�5�      8�� 8�� 5�       5�      �� 5�      8�� $ ��ScrollBar.PageRightCommand��5�      5�      �� 5�      $��3��5�      8�� $��18��5�      $ ��ScrollBar.LineRightCommand��5�      $��M 0 0 L 4 4 L 0 8 Z��5�      5�      5�      �� 5�   
   " ��6+   .�5�      ��  �@J�SnapsToDevicePixels . 64   �� 5�       �@�OverridesDefaultStyle . 66    5�      P� 5�       �@��Orientation$ 
Horizontal=�61   . �5�      ��  � ��$
 Auto��6.   �� 5�       � ��$ 18��6/   �� 5�       � ��8   5     5     P� 5      �@��Orientation$ Vertical=�61   . �5     ��  � ��$ 18��6.   �� 5      � ��$
 Auto��6/   �� 5      � ��8  5     5	     5     �� 5  
   " ��6)   .�5     ��  �@�OverridesDefaultStyle . 66   �� 5      � �� 5     �� 5     "	 ��6&   .R�5     �  5     �� 5  "   $
��Auto �63   �� 5  "    5     �� 5  "   �� 5  "   $
��Auto �60   .+�5     �� $��1��65   �� 5     $��PART_VerticalScrollBar��6(   # z 5      # z 5!     # z 5"     #y�z 5#     �� 5$     $��PART_HorizontalScrollBar��6(   $ 
Horizontal=�5&     $��1��5(     $��1��5*     # z 5,     # z  5-     # z! 5.     #y�z" 5/     51     52     54     55     57     .��5:     A� $��RightToLeft=�6   .+�5;  
   �� $��0q�6   
�������$
 7��68   # J� Effect# 5<     3  -System.Windows.Media.Effects.DropShadowEffect  5=     $   
BlurRadius$$ 5Q�6#   %   ShadowDepth$% 1Q�62   &   Color$& 	#FFACACAC��6B   ._�5?     �  5@     �� 5A     $��30 �6'   �� 5B     $
��338* �6'   �� 5C     $��50 �6'   �� 5D     $
��449* �6'   �� 5E     $��30 �6'    5G     �� 5H     $��30 �6$   �� 5I     $	��50* �6$   �� 5J     $	��40* �6$   �� 5K     $
��500* �6$   �� 5L     $��30 �6$   .+�5N     �� ' �� Orientation$' 
Horizontal=�6   $��1��66   $��1��6C   .+�5O     �� $��قائمة العهود ��6   $��Noto Kufi Arabic)�64   $��18(�6R   ���#8C9AB6$��00,0,0,0q�6u   $��Center=�6�   5P     �� 5R     $' 
Horizontal=�6   $��1��66   $��2��6F   .+�5S     �� $��الحالة : ��6   $��Noto Kufi Arabic)�60   $��16(�6N   ���#8C9AB6$��0q�6q   $
��Left=�6|   �� 5T     $��50��6   $��	10,0,10,0q�6-   $��16(�6@   ���#8C9AB66e   5U     �� 5W     $' 
Horizontal=�6   $��3��66   $��2��6F   $��Right=�6S   .+�5X     �� $ ��رقم الفاتورة : ��6   $��Noto Kufi Arabic)�66   $��16(�6T   ���#8C9AB6$��0q�6w   $
��Left=�6�   �� 5Y     $	��200��6   $��Center=�6*   $��16(�6E   ���#8C9AB66S   �� 5Z     -   5        $��btnSearchCustody��5Z  �   
������ $��0q�66   $��Center=�6K   $��Light"�6g   ��6z   Z� .��5[     '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]](   Kind$( Search=�62   $��Center=�6@   $��30��6[   $��30��6g   ���#8C9AB66r   5\     5]     A� 5`     $��1��6   $��3��6.   $��3��6;   $	��Top=�6O   ) � DataContext#) [  6g   .+�5a     �� .+�5b     �� $��0,0,0,0q�6F   $	��400��6W   ��6#   �� *	ItemsTest+* �� View* 5c     �� 5d  "   .P�5e  &   �� $��اسم المستلم��65   + �� Width$	+ 120��6J   , �� DisplayMemberBinding, 6V   �� *A+�� 5f  &   $��اسم المسلم��65   $	+ 120��6I   , 6U   �� *A+�� 5g  &   $��رقم الفاتورة��65   $	+ 100��6K   , 6W   �� *B+�� 5h  &   $��القيمة ��65   $+ 90��6F   , 6Q   �� *C+�� 5i  &   $��الحالة ��65   $+ 90��6F   , 6Q   �� *C+�� 5k  &   $�� ��65   $+ 40��6?   , 6J   �� *C+�� 5l  &   $�� ��65   $+ 40��6?   , 6J   �� *C+5m  #   5o     5r     5t     5z     5}     5~     5     