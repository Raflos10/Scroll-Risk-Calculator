   M S B A M L   `   `   `  ���� Q  MScroll Risk Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Scroll_Risk_CalculatorScroll_Risk_Calculator  '    !Scroll_Risk_Calculator.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:Scroll_Risk_Calculator       � Title$  Scroll Risk Calculator�� � SizeToContent$ WidthAndHeight=� � WindowStartupLocation$ CenterScreen=�$	��800��$	��450��.���  � RowDefinitions �� $��* ��� $
��auto �.+��� .@��� $
��Main��.���  �� $��* ��� $
��auto �.+�� -   $
��Main��$��0�� � ColumnDefinitions �� $��* ��� $��* �.+��� $��1��$��20q�.+�	� -   $��Button_100p��$��100% Scroll��$��24(�	� -   $��
Button_70p��$��70% Dark Scroll��$��24(�	� -   $��
Button_60p��$��
60% Scroll��$��24(�	� -   $��
Button_30p��$��30% Dark Scroll��$��24(�	� -   $��
Button_10p��$��
10% Scroll��$��24(��� -   $��Button_Custom��$��Custom��$��16(�$	��100��$
��Left=�$��10,20q�� $��0�� �� $��* ��� $
��auto �.+��� $��1��$��Center=�.+��� -   $	��⊼��$��24(�$
��0,10q� � ToolTip _� .���� $ ��Move the selected item up.���� -	   $	��⊻��$��24(�$
��0,10q� _� .���� $"��Move the selected item down.���� -
   $	��⊕��$��24(�$
��0,10q� _� .���� $��Add a new scroll.���� -   $	��⎏��$��24(�$
��0,10q� _� .���� $"��Duplicate the selected item.���� -   $	��⊗��$��24(�$
��0,10q� _� .���� $��Delete the selected item.���� -   $��Scroll_Listbox��$��10q�$��0��$
��Auto=�� -   $��Results��$��1�� �� $
��auto ��� $
��auto ��� $��* ��� $
��auto ��� $
��auto ��� $��* ��� $
��auto ��� $
��auto ��� $��* �.+��� $��0��$��Perfect:��$��24(� _� .���� $3��-The chance of every single scroll succeeding.���� $��1��
���   �$��2��
������� �� RadiusX$ 4�� �� RadiusY$ 4���� -   $��Perfect_Chance_Label��$��1��$��0%��$��24(��� $��3��$��Destroy:��$��24(� _� .���� $3��-The chance of the equip item being destroyed.���� $��4��
���   �$��2��
���\\��$ 4��$ 4���� -   $��Destroy_Chance_Label��$��4��$��0%��$��24(��� $��6��$��One+:��$��24(� _� .���� $3��-The chance of at least one scroll succeeding.���� $��7��
���   �$��2��
�����_�$ 4��$ 4���� -   $��OnePlus_Chance_Label��$��7��$��0%��$��24(��� $��About��.���  �� $
��auto ��� $��* ��� $
��auto �.+��� $��10q�$��0��.+��� $X��RAll images and other content related to MapleStory are owned by Nexon Corporation.��$��Italic$��� $A��;I take no responsibility for any lost items. Scroll wisely!��$��Italic$��� $��2��$��10q�$��Created by Raflos��� $��1�� �� $��* �.+��� -    ��Name$ Quit_Button��$��0��$��Close��$��Right=�$	��150��$��10q�$��Stretch=�