   M S B A M L   `   `   `  ���� Y  UXceed.Wpf.DataGrid, Version=2.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4S<clr-namespace:Xceed.Wpf.DataGrid;assembly=Xceed.Wpf.DataGridXceed.Wpf.DataGrid  D @RetNaklad, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null5clr-namespace:RetNaklad.HelpersRetNaklad.Helpers 1clr-namespace:RetNaklad.ModelRetNaklad.Model 9!clr-namespace:RetNaklad.ViewModelRetNaklad.ViewModel c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity k gGalaSoft.MvvmLight.Extras.WPF45, Version=4.2.30.23246, Culture=neutral, PublicKeyToken=0e27b6f8be9b2ef7pQclr-namespace:GalaSoft.MvvmLight.Command;assembly=GalaSoft.MvvmLight.Extras.WPF45GalaSoft.MvvmLight.Command H DExtendedGrid, Version=2.0.0.12, Culture=neutral, PublicKeyToken=nulliDclr-namespace:ExtendedGrid.ExtendedGridControl;assembly=ExtendedGrid ExtendedGrid.ExtendedGridControl _?clr-namespace:ExtendedGrid.ExtendedColumn;assembly=ExtendedGridExtendedGrid.ExtendedColumn    RetNaklad.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (ignorehttp://www.ignore.com     X	 TXceed.Wpf.Toolkit, Version=2.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit 	 Gxcdg<clr-namespace:Xceed.Wpf.DataGrid;assembly=Xceed.Wpf.DataGrid 	 )hlpclr-namespace:RetNaklad.Helpers 	 )localclr-namespace:RetNaklad.Model 	 .local2!clr-namespace:RetNaklad.ViewModel 	 XiPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity 	 [cmdQclr-namespace:GalaSoft.MvvmLight.Command;assembly=GalaSoft.MvvmLight.Extras.WPF45 	 ^ExtendedGridControlDclr-namespace:ExtendedGrid.ExtendedGridControl;assembly=ExtendedGrid 	 TExtendedColumn?clr-namespace:ExtendedGrid.ExtendedColumn;assembly=ExtendedGrid 	 $	��670��  � Title$-  'Возвратная накладная�� � DataContext �� *Main+   Locator �� Source# [   � 	Resources %  RetNaklad.Model.PaymentTypeList  payments*  $RetNaklad.Helpers.ConvertItemToIndex  IndexConverter �� MergedDictionaries �� Source��  �� $ Skins/MainSkin.xaml?�%   &	       &	          .��� -    �Name$ 
LayoutRoot��.+���  �� Orientation$ Vertical=�$��5q�$
��Left=�.+��� $ 
Horizontal=�$��Center=�.+��� $1��+ВОЗВРАТНАЯ НАКЛАДНАЯ №���� $��Center=�{�.  ����  �� ElementName$
 docN��	 �� Path$
	 Text��� -   $��sp��$ 
Horizontal=�$
��Left=�.+��� $��1q�$��0 0 0 0q�
���   �._��� $ 
Horizontal=�$��5q�.+��� .+��� $#��Номер документа��$��0 0 0 0q��� $!��Дата документа���� $#��Время документа���� $	��100��$��5q�.+��� -   $
��docN��
���   �$��0 0 0 5q�$	��0.5q����� *DocN+(  "System.Windows.Controls.DatePicker  $��0 0 0 5q�
   SelectedDate
 �� *	DocDate+" 	 Xceed.Wpf.Toolkit.TimePicker  -   $��timeDoc��$��Stretch=�   Format$ Custom=�   FormatString$
 H:mm��   Value �� *	DocTime+�� $��1q�
���   �._��� $ 
Horizontal=�$��5q�$��Center=�.+��� $��0,0,10,0q�.+��� $��0,0,0,0q�$��Right=� � ToolTip$+ %Справочник филиалов���� $��10(� �� Command �� *GetBranchListCommand+.�Филиал*�� $��0,12,0,0q�$��Right=�$' !Справочник счетов���� $��10(� �� *GetAccountListCommand+.�	Счет*�� .+��� $��0 0 0 0q����� *
BranchName+ �� UpdateSourceTrigger$ PropertyChanged=��� $��0 9 0 0q����� *AccountName+�� $��	10,0,10,0q�.+��� $��0,0,0,0q�$��Right=�$) #Справочник складов���� $��10(� �� *GetStoreListCommand+.�Склад*�� $��0,12,0,0q�$��Right=�$1 +Справочник поставщиков���� $��10(� �� *GetProviderListCommand+.�Поставщик*�� .+��� $��0 0 0 0q����� *	StoreName+�� $��0 9 0 0q����� *ProviderName+�� $ 
Horizontal=�$��5q�$��Right=�.+��� $��Оплата���� -   $��comboPayment��$��85��$��Center=����� *PaymentTypeList+ �� SelectedIndex �� *PaymentType+�� $��Отсрочка��% 	 Xceed.Wpf.Toolkit.IntegerUpDown  � 	 �Xceed.Wpf.Toolkit.NumericUpDown`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Minimum$ 0X�$��Center=�, 	 &Xceed.Wpf.Toolkit.Primitives.InputBase   Text �� *PaymentDelay+�� $��дней���� $ 
Horizontal=�$��5q�.+��� $��Комментарий���� 
���   �$��1q� �� TextWrapping$
 Wrap=� �� AcceptsReturn . ���� *	Comment+&   System.Windows.Controls.DataGrid  -   $
��grid��   SelectionUnit$
 Cell=�   HeadersVisibility$ Column=�   AlternatingRowBackground
 �����   CanUserAddRows .     AutoGenerateColumns .  ���� *ProductItemViewModelList+   Columns 0	  *System.Windows.Controls.DataGridTextColumn	  ,
  &System.Windows.Controls.DataGridColumn 
  Header$ N�� 
  
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� 	Converter# [ 5  /System.Windows.Controls.DataGridHyperlinkColumn  $ Наименование�� .   
  Width5  /System.Windows.Controls.DataGridLengthConverter$  *  �� $
	 Name�	  $
 Ед�� .  �� $	 UnitType�	  $ Кол-во�� �� $	 
UnitAmount�	  $# Возвратная цена�� �� $	 Price�	  $ 
Сумма�� .  �� $	 Summa�.  (System.Windows.Interactivity.Interaction!   Triggers! /  )System.Windows.Interactivity.EventTrigger  "   	EventName$" SelectedCellsChanged��.  (System.Windows.Interactivity.TriggerBase#   Actions.# /  )GalaSoft.MvvmLight.Command.EventToCommand  $   PassEventArgsToCommand$ . %   Command% �� & �� Mode$& OneWay=�$	 SelectedCellCommand�' � ContextMenu' �� .@�m� $��Добавить��( m� Command( �� *AddProductCommand+) m� Icon) �� $��Images/Add.png��m� $��Удалить��( �� *DeleteProductCommand+) �� $��Images/Delete.png��m� $��Карточка��( �� *OpenProductCommand+) �� $��Images/Card file.png���� $ 
Horizontal=�$��5q�$��Right=�.+��� $��
ИТОГО���� $��Center=�{�.  ���� *
TotalPrice+� $��5q�* � ColumnDefinitions* �� $��* ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$'��!Документ Проведен��+ d� 	IsChecked+ �� *
IsPosted+�� $��1��$��0,0,10,0q���  �� *SaveRetNakladCommand+.�Сохранить�� $��2��$��0,0,10,0q���  �� *PrintRetNakladCommand+.�Печать�� $��3��$��0,0,10,0q���  �� *CloseCommand+, �� CommandParameter, �� - �� RelativeSource- �� *FindAncestor+. �� AncestorType". �.�Закрыть