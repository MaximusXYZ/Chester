   M S B A M L   `   `   `  ���� B  >Chester, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ChesterChester      Chester.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     _ [ICSharpCode.AvalonEdit, Version=6.0.1.278, Culture=neutral, PublicKeyToken=9cc39be672370310?
avalonedit.http://icsharpcode.net/sharpdevelop/avalonedit  !localclr-namespace:Chester  -     � Title$  Chester - MainWindow��$	��320��$	��600��$	��320��$	��600�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ 	CanResize=�
������  � AllowsTransparency .  � Topmost .  � WindowStyle$
 None=� J� Opacity$ 1Q�'  !System.Windows.Shell.WindowChrome   WindowChrome      ResizeBorderThickness$ 	0,0,15,15q�	   CaptionHeight$	 0Q�.���� 
 �� Padding$
 5q�._�� .+��� -    ��Name$ 
Background�����#181818
������ $��0q� �� CornerRadius$ 5��$��0q�._�� .+��� -   $	 Top�����#161616
������ $��0q�$ 5,5,0,0��$	��Top=�$��30��$
��Auto��._�� .+��� -    ��Name$ ExitBtn��$��10��$��10�����#FF605C
������ $��0q�   	MacButton#��[  $��Center=�$
��Left=�$��8,0,0,0q��� -   $ MinimizeBtn��$��10��$��10�����#FFBD44
������ $��0q�#��[  $��Center=�$
��Left=�$��24,0,0,0q��� -   $ MaximizeBtn��$��10��$��10�����#00CA4E
������ $��0q�#��[  $��Center=�$
��Left=�$��42,0,0,0q�� $��0,30,0,0q�.+��� -   $ 
ExecuteBtn��$��30��$��30�����#161616���#181818$��0q�$��13(�$��Segoe MDL2 Assets)�$	����$
��Left=�$	��Top=�$��5q� 
 Button#��[ �� -   $ ClearBtn��$��30��$��30�����#161616���#181818$��0q�$��13(�$��Segoe MDL2 Assets)�$	����$
��Left=�$	��Top=�$��5,40,5,5q�#��[ �� -	   $ OpenBtn��$��30��$��30�����#161616���#181818$��0q�$��13(�$��Segoe MDL2 Assets)�$	����$
��Left=�$	��Top=�$��5,75,5,5q�#��[ �� -
   $ SaveBtn��$��30��$��30�����#161616���#181818$��0q�$��13(�$��Segoe MDL2 Assets)�$	����$
��Left=�$	��Top=�$��	5,110,5,5q�#��[ �� -   $ 	AttachBtn��$��30��$��30�����#161616���#181818$��0q�$��13(�$��Segoe MDL2 Assets)�$	����$
��Left=�$��Bottom=�$��5,5,5,5q�#��[ �� -   $ SettingsBtn��$��30��$��30�����#161616���#181818$��0q�$��13(�$��Segoe MDL2 Assets)�$	����$
��Left=�$��Bottom=�$��5,5,5,40q�#��[ '  !ICSharpCode.AvalonEdit.TextEditor  -     Name$ 	LuaEditor��$��Consolas)�
����������#161616   SyntaxHighlightingM  GICSharpCode.AvalonEdit.Highlighting.HighlightingDefinitionTypeConverter$	 Lua    ShowLineNumbers . ���#181818$��0q�$��
40,5,130,5q�$   HorizontalScrollBarVisibility$ Disabled=�"   VerticalScrollBarVisibility$ Disabled=�   Text. ����  �� 	Resources  �� 
TargetType �� Property �� Value��%9   '��       �� " ��.���  �@��CornerRadius$ 5��. �� -    ��Name$ 
ScriptList�����#161616���#181818$��0q�$��40,5,5,5q�$��Right=�$	��120��$
��Auto������  ��%9   '��       �� " ��.���  �@��CornerRadius$ 5��