   M S B A M L   `   `   `  ����F  BDesktopTodo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:DesktopTodo.ViewsDesktopTodo.Views  5      ?$clr-namespace:DesktopTodo.ConvertersDesktopTodo.Converters  5      $    DesktopTodo.Views.TodoListPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962af bMaterialDesignThemes.MahApps, Version=0.1.7.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962a<md1http://materialdesigninxaml.net/winfx/xaml/themes   5      -localclr-namespace:DesktopTodo.Views   5      7
converters$clr-namespace:DesktopTodo.Converters   5        � DataContext  5	      �� *TodoListViewModel+   ViewModelLocator �� Source# [   � 	Resources 5      2  ,DesktopTodo.Converters.StringCutterConverter  StringCutter��%   &	         5   
   6+   5      .��5      � .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��Center=�6   $��Center=�5      .��5      � .+�5      �� ��6   �� *	TodoTasks+��5      �� 5      .R�5      ��  ��Name$ 
TodoBorder��5   %    �� Padding$ 8q�5   %   $��0 0 0 1q�5   %     MaterialDesignDivider#���  5   %   ._�5   "   �  � ColumnDefinitions 5   &   �� 5   *   $��* �6;   �� 5   *   $��* �6;   .+�5   &   d� $��Center=�63    ) %MaterialDesignActionLightToggleButton#��[ 5!   3    d� 	IsChecked 5    3   �� *IsCompleted+��5"   3   �� *Code+�� 5#   &   $��8 0 0 0q�61   $��1��5$   1   .+�5%   *   �� $
��Bold"�5&   4   ��5%   4   �� *Name+5&   4   �� 5'   *    �� Orientation$ 
Horizontal=�65   .+�5(   .   �� ��68   �� *Description+ �� 	Converter# [ 	 �� ConverterParameter$	 20���� 5)   .   $��12(�68   
��������� 5*   2   �66   �� *Start+
 �� StringFormat$
 
dd.MM.yyyy�� �� 5+   2   $�-��66    �� 5,   2   �66   �� *End+$
 
dd.MM.yyyy��5-   /   5.   +   5/   '   50   #   51       �� Triggers 52      �� 53   "    �� Value$
 True��54   .    �� Binding 53   .   �� *
IsSelected+.a�55   &   ��  �� 
TargetName$ 
TodoBorder��56   -     MaterialDesignSelection �� Value# �  57   -    �� Property � ��58   #   5:      5<      5=      5>      5?      5@      