   M S B A M L   `   `   `  ����G  COnTheFlyWPFC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:OnTheFlyWPFC.ViewOnTheFlyWPFC.View  5   	   6    0OnTheFlyWPFC.View.HRJobDescriptionEditMiniWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   1localclr-namespace:OnTheFlyWPFC.View     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   6sys,http://schemas.microsoft.com/winfx/2009/xaml  5
   	   
������   � WindowStyle$
  None=�5   "    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   #   $	��500��5   	   $	��350��6    � 
ResizeMode$ NoResize=�6"   .��5      A� $��RightToLeft=�6   .+�5   
   �� $��0q�6   
������� �� CornerRadius$ 8��68   $	��450��6I   $	��300��6V    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#      ShadowDepth$ 1Q�63      Color$ 	#FFACACAC��6C   ._�5      � 	 � RowDefinitions	 5      �� 5      $��65 �6$   �� 5      .+�5      � $��65��6   $	��Top=�6#   $��0��6;    5        5      $ 1Q�6+   $ 1Q�6:   $ 	#FFACACAC��6J   .+�5      A� $��LeftToRight=�6"   .+�5      �� 
 �� Orientation$
 
Horizontal=�6%   .+�5       �� -   5        $��btnCloseForm��5    %   
������ $��Center=�6S   $��Right=�6n   $��65��6�   $��Light"�6�   ��6�   Z� .��5!   "   A� $��RightToLeft=�6.   .+�5"   &   �� $
 
Horizontal=�61   .+�5#   *   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ Close=�6B   $��20��6O   $��20��6Z   ���#8C9AB66f   5$   '   5%   #   5&      5'      5(      5)      � 5*      $��1��6   	 5+      �� 5,      .+�51      � 	 52      �� 53      $��65 �6,   �� 54      $
��178* �6,    � ColumnDefinitions 57      �� 58      $��30 �6/   �� 59      $
��150* �6/   �� 5:      $��30 �6/   .+�5<      �� $��تعديل الوظيفة��6    $��Noto Kufi Arabic)�68   $��18(�6V   ���#768295$��Center=�6y   $��Center=�6�   $��1��6�   $��44��6�   $��0q�6�   �� 5>      -   5        $��
StkEditJob��5>   %   $��1��67   $��1��6D   .+�5?      �� $��40��6%   $��0,0,0,15q�61   ._�5@   "   �� -   5        $��
txtJobName��5@   *   $��Stretch=�6V   $��16(�6r   ���#768295��6<   �� *
job_name+6�   5A      �� 5C      $��40��6%   $��0,0,0,15q�61   ._�5D   "   �� -   5        $��txtBasicSalary��5D   *   $��Stretch=�6^   $��16(�6z   ���#768295��6@   �� *basic_salary+6�   5E      �� 5F      $��40��6%   $��0,0,0,15q�61   ._�5G   "   �� -   5        $��txtWorkingHoursPerMonth��5G   *   $��Stretch=�6q   $��16(�6�   ���#768295��6I   �� *working_days_per_month+6�   5H      �� 5M      $��40��6%   $��
55,20,55,0q�61   ._�5N   "   �� $��40��6)   
������ $ 20��6O   $��2��6b   ���#2C99F5$��0,0,0,0q�6�   ._�5O   &   �� -   5        $��
btnEditJob��5O   �   
������ $��40��6F   $��0q�6R   $��Center=�6g   $��Light"�6�   ��6�   Z� .��5P   *   A� $��RightToLeft=�66   .+�5Q   .   �� $
 
Horizontal=�69   .+�5R   2   �� $��15(�6<   
�������$��Noto Kufi Arabic)�6]   $��تعديل الوظيفة��6{   $��0,0,0,0q�6�   5T   /   5U   +   5V   '   5W   #   5X      5Z      �� 5\      $��1��6%   $��3��62   .+�5]      �� $��40��6%   $��0,0,0,15q�61   5_      �� 5`      $��40��6%   $��0,0,0,15q�61   5b      �� 5c      $��40��6%   $��0,0,0,15q�61   5e      �� 5f      $��40��6%   $��0,0,0,15q�61   5h      5j      5p      5t      5w      5x      5y      