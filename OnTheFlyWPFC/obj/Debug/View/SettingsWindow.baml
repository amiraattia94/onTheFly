   M S B A M L   `   `   `  ����G  COnTheFlyWPFC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:OnTheFlyWPFC.ViewOnTheFlyWPFC.View  5   	   &     OnTheFlyWPFC.View.SettingsWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:OnTheFlyWPFC.View     5   	   b ^SharpVectors.Converters.Wpf, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b532964b8548be771svgc&http://sharpvectors.codeplex.com/svgc/  5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  SettingsWindow��5
   	   $	��720��5   	   $
��1366��6   
������  � WindowStyle$
 None=�5   "    � AllowsTransparency .  � WindowState$ 	Maximized=�5   #    � WindowStartupLocation$ CenterScreen=�6;    � 
ResizeMode$ CanResizeWithGrip=�6`    � 	Resources 5   
      OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame	 O� KeyTime
 O� Value  	CloseMenu  StandardBorderBrush �� Color  StandardBackgroundBrush  HoverBorderBrush  SelectedBackgroundBrush  SelectedForegroundBrush  DisabledForegroundBrush  NormalBrush 	 NormalBorderBrush 
 HorizontalNormalBrush  HorizontalNormalBorderBrush  ListBoxBackgroundBrush �� 
StartPoint �� EndPoint � Color � Offset  StandardBrush  
GlyphBrush  PressedBrush  ScrollBarLineButton �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Path �� RelativeSource �� Triggers P� Property P� Value �� 
TargetName  ScrollBarPageButton  ScrollBarThumb  VerticalScrollBar � RowDefinitions ]� DecreaseRepeatButton ]� Thumb ]� IncreaseRepeatButton  HorizontalScrollBar � ColumnDefinitions  �� Triggers  FavsScrollViewer! �� VerticalOffset" � Value# �� ScrollableHeight$ � Maximum% �� ViewportHeight& �� ViewportSize*' �� #ComputedVerticalScrollBarVisibility( �� Orientation) �� HorizontalOffset* �� ScrollableWidth+ �� ViewportWidth,, �� %ComputedHorizontalScrollBarVisibility��%  &	        &	 �     &	 �    &	 �    &	 �    &	 �    &	     &	 +    &	 I    &		 g    &	
 �    &	 �    &	 �    &	 �    &	 X    &	 v    &	 ~    7  7 	 7  7  7  &	 8    &	 �	    &	 C    7  7  7  7 
 7  7  7  &	 S    7  7  7  7  7 	 7  7  '�� o    7  7  &	 p    �� 5      .��5      U� $ (FrameworkElement.Width)�60   $ GridMenu��6e   .\�5        $	 0��6+   $
 60Q�67     5      $	 0:0:0.5��6+   $	
 200Q�6=   5      5      �� 5      .��5      U� $ (FrameworkElement.Width)�60   $ GridMenu��6e   .\�5        $	 0��6+   $	
 200Q�67     5      $	 0:0:0.5��6+   $
 60Q�6=   5      5      �� 5      $
 #888��6:   �� 5      $ 	LightGray��6>   �� 5       $
 #DDD��67   �� 5!      $ 	LightGray��6>   �� 5"      $ White��6>   �� 5#      $
 #888��6>   �� 5$      $
 #888��62   �� 5%      $
 #888��68   �� 5&      $ 	LightGray��6<   �� 5'      $
 #888��6B   �� 5(      $	 0,0&�5*      $ 1,0.001&�6   ��5,      � � 5-      $ White��6'   $	 0.0Q�65   � 5.      $ White��6'   $	 0.6Q�65   � 5/      $ #DDDDDD��6'   $	 1.2Q�67   50      52      �� 53      $	 0,0&�55      $	 0,1&�6   ��57      � � 58      $
 #FFF��6'   $	 0.0Q�64   � 59      $
 #CCC��6'   $	 1.0Q�64   5:      5<      �� 5=      $
 #444��61   �� 5>      $	 0,0&�5@      $	 0,1&�6   ��5B      � � 5C      $
 #BBB��6'   $	 0.0Q�64   � 5D      $
 #EEE��6'   $	 0.1Q�64   � 5E      $
 #EEE��6'   $	 0.9Q�64   � 5F      $
 #FFF��6'   $	 1.0Q�64   5G      5I      �� 5K      " ��60   .�5L      ��  � y�$ Hidden=�6/   �� 5M       �@J�SnapsToDevicePixels . 68   �� 5N       �@�OverridesDefaultStyle . 6:   �� 5O       � |� .  6.   �� 5P       � �� 5Q      �� 5R      " ��6*   .R�5S      �� $��Border��6%   $��1q�63   $ 2��6>   8��  8�� $��1q�6�   ._�5T   "   F� $��Center=�6'   $��Center=�5V      8�� ��5Y      �� $ Content� �� *TemplatedParent+5\       5]      P� 5^   "    � �� . . �5_   &   �� $ Border��6-   8   � ��5a   !   5b   #   P� 5c   "    � {� .  . �5d   &   �� 8   � ��5f   !   5g   #   5i      5k      5l      �� 5m      " ��60   .�5n      ��  � y�$ Hidden=�6/   �� 5o       �@J�SnapsToDevicePixels . 68   �� 5p       �@�OverridesDefaultStyle . 6:   �� 5q       � �� .  6.   �� 5r       � |� .  6.   �� 5s       � �� 5t      �� 5u      " ��6*   .R�5v      �� 
���   �6%   5w      5y      5z      �� 5{      " n�6+   .�5|      ��  �@J�SnapsToDevicePixels . 68   �� 5}       �@�OverridesDefaultStyle . 6:   �� 5~       � �� .  6.   �� 5       � |� .  6.   �� 5�       � �� 5�      �� 5�      " n�6*   .R�5�      �� $ 2��5�      #��z��5�      #��z��5�      $��0q�5�      $��5��5�      $��5,0,-2,0q�5�      5�      5�      5�      �� 5�      " ��5�      .R�5�      �  5�      �� 5�      $��0��6(   �� 5�      $��0.00001* �6(   �� 5�      $��0��6(   .+�5�      �� $��3��5�      $ 2��5�      
������ 5�      �� 5�      $��0��5�      8��  $��18��5�      $��ScrollBar.LineUpCommand��5�      $��M 0 4 L 8 4 L 4 0 Z��5�      ]� 5�      $��
PART_Track��5�      $��1��5�      ��.  5�      �� 5�      8�� $��ScrollBar.PageUpCommand��5�       5�      n� 5�      8�� $��1,0,1,0q�5�      8�� 8�� 5�       5�      �� 5�      8�� $��ScrollBar.PageDownCommand��5�      5�      �� 5�      $��3��5�      8�� $��18��5�      $��ScrollBar.LineDownCommand��5�      $��M 0 0 L 4 4 L 8 0 Z��5�      5�      5�      �� 5�      " ��5�      .R�5�      �  5�      �� 5�      $��18��6+   �� 5�      $��0.00001* �6+   �� 5�      $��18��6+   .+�5�      �� $��3��5�      $ 2��5�      ���#F0F0F05�      �� 5�      $��0��5�      8��  $��18��5�      $��ScrollBar.LineLeftCommand��5�      $��M 4 0 L 4 8 L 0 4 Z��5�      ]� 5�      $��
PART_Track��5�      $��1��5�      ��.   5�      �� 5�      8�� $��ScrollBar.PageLeftCommand��5�       5�      n� 5�      8�� $��0,1,0,1q�5�      8�� 8�� 5�       5�      �� 5�      8�� $ ��ScrollBar.PageRightCommand��5�      5�      �� 5�      $��3��5�      8�� $��18��5     $ ��ScrollBar.LineRightCommand��5     $��M 0 0 L 4 4 L 0 8 Z��5     5     5     �� 5     " ��6/   .�5	     ��  �@J�SnapsToDevicePixels . 68   �� 5
      �@�OverridesDefaultStyle . 6:     5     P� 5      �@��Orientation$ 
Horizontal=�65   . �5     ��  � ��$
 Auto��62   �� 5      � ��$ 18��63   �� 5      � ��8   5     5     P� 5      �@��Orientation$ Vertical=�65   . �5     ��  � ��$ 18��62   �� 5      � ��$
 Auto��63   �� 5      � ��8  5     5     5     �� 5     " ��6-   .�5     ��  �@�OverridesDefaultStyle . 6:   �� 5      � �� 5      �� 5!     " ��6*   .R�5"     �  5#  "   �� 5$  &   $
��Auto �67   �� 5%  &    5'  "   �� 5(  &   �� 5)  &   $
��Auto �64   .+�5,  "   �� $��1��69   �� 5.  "   $��PART_VerticalScrollBar��6,   #" z! 50     #$ z# 51     #& z% 52     #y�z' 53     �� 54  "   $��PART_HorizontalScrollBar��6,   $( 
Horizontal=�56     $��1��58     $��1��5:     #" z) 5<     #$ z* 5=     #& z+ 5>     #y�z, 5?     5A     5B     5D     5E     5G     - � Triggers- 5I  
   :� 5J     . :� RoutedEvent$. ButtonBase.Click��6   / :� 
SourceName$/ ButtonOpenMenu��6:   .[�5K     �� #��[  6"   5L     :� 5M     $. ButtonBase.Click��6   $/ ButtonCloseMenu��6:   .[�5N     �� #��[ 6"   5O     .��5R  
   �� ���	#FFEFF3FA$��0q�6(   $ 10��6<   ._�5S     � .+�5U     �� -   5        0 ��Name$0 lblMenuename��5U     $��الإعدادات��6.   $��Noto Kufi Arabic)�6B   $
��23.5(�6`   ���#8C9AB6$��Right=�6�   $��
0,80,100,0q�6�   $	��Top=�6�   �� 5X     $��0q�6   $ 7��6-   $��30,150,90,30q�6>   ._�5Y     ]� -   5        1 ]�Name$1 MainUC��5Y      5\     5]     � 5`     $��60��6   $	��Top=�6#   2 J� Effect2 5a     3  -System.Windows.Media.Effects.DropShadowEffect  5b     3   
BlurRadius$3 1Q�6+   4   ShadowDepth$4 1Q�6:   5   Color$5 	#FFACACAC��6J   .+�5d     �� -   5        $ 7,7,0,0��5d     ��5e     �� 5f     $ 0.5,1&�62   $ 0.5,0&�6C   6 �� RelativeTransform6 5g  "   V� 5h  &   .~�5i  *   �� 7 �� CenterY$	7 0.5Q�69   8 �� CenterX$	8 0.5Q�6G   �� 5j  *   9 �� CenterY$	9 0.5Q�68   : �� CenterX$	: 0.5Q�6F   �� 5k  *   ; �� Angle$	; 270Q�6:   < �� CenterY$	< 0.5Q�6F   = �� CenterX$	= 0.5Q�6T   T� 5l  *   5m  '   .��5o  "   � $ 	#FF1246B0��6/   � 5p  "   $ 	#FF0F6AB8��6/   $ 0.996Q�6A   5q     5s     A� 5v     $��RightToLeft=�6"   .+�5x     �� > �� Orientation$> 
Horizontal=�6%   .+�5z     �� $��4,0,0,0q�6$   $��Right=�65   $��على��6L   $��Right=�6Z   $��Center=�5{     $��Ara Hamah AlThawra)�64   $��25(�6T   
���2͚�$��Center=�6{   $��Center=�6�   �� 5|     $��	-7,0,10,0q�6$   $��Right=�67   $��الطاير��6N   $��Right=�6_   $��Center=�5}     $��Ara Hamah AlThawra)�64   $��25(�6T   
�������$��Center=�6u   $��Center=�6�   �� 5�     -   5        $��btnMain��5�  %   ���	#FF53A8F6$��0q�6K   $��63��6_   $��Center=�6k   $��Right=�6�   $��Light"�6�   ��6�   Z� .��5�  "   A� $��RightToLeft=�6.   .+�5�  &   �� $> 
Horizontal=�61   .+�5�  *   �� $#��Images\icons\ic_dashboard.png��60   $��17��6W   $��17��6c   $��0,0,5,0q�6n   �� 5�  *   $��12(�64   
�������$��Noto Kufi Arabic)�6U   $��الرئيسية��6s   5�  '   5�  #   5�     �� 5�     -   5        ? ��Name$? btnPOS��5�  %   
������ $��0q�6O   $��63��6c   $��Center=�6o   $��Right=�6�   $��Light"�6�   ��6�   Z� .��5�  "   A� $��RightToLeft=�6.   .+�5�  &   �� $> 
Horizontal=�61   .+�5�  *   �� $��Images\icons\ic_sales.png��60   $��17��6S   $��17��6_   $��0,0,5,0q�6j   �� 5�  *   $��12(�64   
�������$��Noto Kufi Arabic)�6U   $��نقطة البيع��6s   5�  '   5�  #   5�     �� 5�     -   5        $? 	btnBranch��5�  %   
������ $��0q�6Q   $��63��6e   $��Center=�6q   $��Right=�6�   $��Light"�6�   ��6�   Z� .��5�  "   A� $��RightToLeft=�6.   .+�5�  &   �� $> 
Horizontal=�61   .+�5�  *   �� $ ��Images\icons\ic_branch.png��60   $��17��6T   $��17��6`   $��0,0,5,0q�6k   �� 5�  *   $��12(�64   
�������$��Noto Kufi Arabic)�6U   $��الفروع��6s   5�  '   5�  #   5�     �� 5�     -   5        $? btnCustomer��5�  %   
������ $��0q�6S   $��63��6g   $��Center=�6s   $��Right=�6�   $��Light"�6�   ��6�   Z� .��5�  "   A� $��RightToLeft=�6.   .+�5�  &   �� $> 
Horizontal=�61   .+�5�  *   �� $��Images\icons\ic_jobs.png��60   $��17��6R   $��17��6^   $��0,0,5,0q�6i   �� 5�  *   $��12(�64   
�������$��Noto Kufi Arabic)�6U   $��الزبائن��6s   5�  '   5�  #   5�     �� 5�     -   5        $? btnHR��5�  %   
������ $��0q�6M   $��63��6a   $��Center=�6m   $��Right=�6�   $��Light"�6�   ��6�   Z� .��5�  "   A� $��RightToLeft=�6.   .+�5�  &   �� $> 
Horizontal=�61   .+�5�  *   �� $��Images\icons\ic_hr.png��60   $��17��6P   $��17��6\   $��0,0,5,0q�6g   �� 5�  *   $��12(�64   
�������$��Noto Kufi Arabic)�6U   $#��الموارد البشرية��6s   5�  '   5�  #   5�     �� 5�     -	   5        $? 
btnCustody��5�  %   
������ $��0q�6R   $��63��6f   $��Center=�6r   $��Right=�6�   $��Light"�6�   ��6�   Z� .��5�  "   A� $��RightToLeft=�6.   .+�5�  &   �� $> 
Horizontal=�61   .+�5�  *   �� $#��Images/Icons/ic_contracts.png��60   $��17��6W   $��17��6c   $��0,0,5,0q�6n   �� 5�  *   $��12(�64   
�������$��Noto Kufi Arabic)�6U   $��العهود��6s   5�  '   5�  #   5�     �� 5�     -
   5        $? 
btnFinance��5�  %   
������ $��0q�6R   $��63��6f   $��Center=�6r   $��Right=�6�   $��Light"�6�   ��6�   Z� .��5�  "   A� $��RightToLeft=�6.   .+�5�  &   �� $> 
Horizontal=�61   .+�5�  *   �� $$��Images/Icons/ic_accounting.png��60   $��17��6X   $��17��6d   $��0,0,5,0q�6o   �� 5�  *   $��12(�64   
�������$��Noto Kufi Arabic)�6U   $��المالية��6s   5�  '   5�  #   5�     �� 5�     -   5        $? btnDelivery��5�  %   
������ $��0q�6S   $��63��6g   $��Center=�6s   $��Right=�6�   $��Light"�6�   ��6�   Z� .��5�  "   A� $��RightToLeft=�6.   .+�5�  &   �� $> 
Horizontal=�61   .+�5�  *   �� $"��Images/Icons/ic_delivery.png��60   $��17��6V   $��17��6b   $��0,0,5,0q�6m   �� 5�  *   $��12(�64   
�������$��Noto Kufi Arabic)�6U   $��
توصيل��6s   5�  '   5�  #   5�     �� 5�     -   5        $? 
btnReports��5�  %   
������ $��0q�6R   $��63��6f   $��Center=�6r   $��Right=�6�   $��Light"�6�   ��6�   Z� .��5�  "   A� $��RightToLeft=�6.   .+�5�  &   �� $> 
Horizontal=�61   .+�5�  *   �� $!��Images/Icons/ic_reports.png��60   $��17��6U   $��17��6a   $��0,0,5,0q�6l   �� 5�  *   $��12(�64   
�������$��Noto Kufi Arabic)�6U   $��التقارير��6s   5�  '   5�  #   5�     5�     5�     A� 5�     .+�5�     �� $> 
Horizontal=�6%   $
��Left=�6>   .+�5�     �� $> 
Horizontal=�6)   .+�5�  "   �� -   5        $��btnCloseForm��5�  )   
������ $��10,0,0,0q�6W   $��63��6i   $��Center=�6v   $��Right=�6�   $��Light"�6�   ��6�   Z� .��5�  &   A� $��RightToLeft=�62   .+�5�  *   �� $> 
Horizontal=�65   .+�5�  .   �� $��Images\icons\ic_close.png��64   $��15��6W   $��15��6c   5�  +   5�  '   5�  #   �� 5�  "   -   5        $��
btnMaxForm��5�  *   
������ $��63��6U   $��Center=�6b   $��Center=�6}   $��Light"�6�   ��6�   Z� .��5�  &   A� $��RightToLeft=�62   .+�5�  *   �� $> 
Horizontal=�65   .+�5�  .   �� $"��Images\icons\ic_maximize.png��64   $��15��6Z   $��15��6f   5�  +   5�  '   5�  #   �� 5�  "   -   5        $��
btnMinForm��5�  )   
������ $��63��6T   $��Center=�6a   $��Center=�6|   $��Light"�6�   ��6�   Z� .��5�  &   A� $��RightToLeft=�62   .+�5�  *   �� $> 
Horizontal=�65   .+�5�  .   �� $"��Images\icons\ic_minimize.png��64   $��15��6Z   $��15��6f   5�  +   5�  '   5�  #   '  !MaterialDesignThemes.Wpf.PopupBox  5�  "   @   PlacementMode$@ BottomAndAlignCentres=�6:   
�������$��0,0,0,0q�6s   A   PopupContent.A 5�  &   �� .+�5�  *   �� -   5        $��btnSettings��5�  E   $��الإعدادات��61   6X   �� 5�  *   -   5        $��	btnLogout��5�  H   $��تسجيل الخروج��61   6Y   5�  '   5�  #   5�     5�     5�     5�     A� 5�     -   5        B A�Name$B GridMenu��5�  :   $��RightToLeft=�6   $��60��6L   $��Right=�6W   
�������$��0,60,0,0q�6�   2 5�       5�     $3 2Q�6+   $4 1Q�6:   $5 	#FFAEAEAE��6J   .+�5�     �� .+�5�     A� $��60��6&   
���2͚�C J� RenderTransformOrigin$C 0.5,0.5&�6K   $��RightToLeft=�6k   z�5�     V� 5�  "   .~�5�  &   �� �� 5�  &   �� 5   &   T� 5  &   5  #   .+�5     �� -   5        $? ButtonOpenMenu��5  %   $��60��6=   $��60��6I   $��Right=�6T   $	��Top=�6p    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6�   
���������6�   Z� ��6�   Z� .��5  "   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]D   Kind$
D Menu=�6:   $��25��6F   $��25��6Q   5     �� 5     -   5        $? ButtonCloseMenu��5  %   $y�	Collapsed=�6>   $��60��6U   $��60��6a   $��Right=�6l   $	��Top=�6�   #��[ 6�   
���������6�   Z� ��6�   Z� .��5  "     $D 
ArrowRight=�6:   $��25��6L   $��25��6W   5	     5
     �� 5     -   5        E ��Name$E ListViewMenu��5  #   ���	#FF0F6AB8$��Disabled=�6P   .@�5     �� -   5        F ��Name$F 	ItemUsers��5  +   $��60��6>   .��5  "   �� $> 
Horizontal=�6-   .+�5  "     $D AccountCircleOutline=�6:   $��25��6V   $��25��6b   $��10q�6m   �� 5  &   $��المستخدمين��60   $��Center=�6B   $��20 10q�6]   5  #   5     �� 5     -   5        $F ItemUserRoles��5  '   $��60��6>   .��5     �� $> 
Horizontal=�6)   .+�5  "     $D AccountGroupOutline=�6:   $��25��6U   $��25��6a   $��10q�6l   �� 5  "   $*��$الأدوار و الصلاحيات��6,   $��Center=�6G   $��20 10q�6b   5     5     �� 5     -   5        $F ItemJobDscription��5  '   $��60��6B   .��5     �� $> 
Horizontal=�6)   .+�5  "     $
D Work=�6:   $��25��6F   $��25��6R   $��10q�6]   �� 5  "   $��الوظائف��6,   $��Center=�6;   $��20 10q�6V   5     5     5     5      5!     5"     5#     5$     