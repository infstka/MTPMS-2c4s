   M S B A M L   `   `   `  ?????  ;LW11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LW11LW11  5   	       LW11.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:LW11     5   	     ? Title$  Главное окно??5   	    ? WindowStartupLocation$ CenterScreen=?5	   	   $	??450??5
   	   $	??800??6   .??5      ? ???#ffff9e ? ColumnDefinitions 5   
   ?? 5      ?? 5      ?? 5      ?? 5       ? RowDefinitions 5   
   ?? 5      $??4* ?6   ?? 5      $??1* ?6   .+?5   
   ?? -   5         ??Name$ CBTable??5      $??Center=?6$   $??	32,0,26,0q?6?    ?? Text$ Products??6R    ?? SelectedValue$ Products??6b   $??1??6{   $??32??6?   $??2??6?   $??16(?6?   
???????.@?5      ?? .??6   
Students6%   ?? 5      .??6   	Addresses6&   5      ?? 5   
   $??2??6   $??43??6(   $??
44,22,10,0q?64   $
??Wrap=?6H   $??Таблица:??6\   $	??Top=?6l   $??20(?6?   $??Century Gothic)?6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dataTable??5         CanUserAddRows .  $??5??6=   $??32,48,32,21q?6Q   	   AutoGenerateColumns	 .  
???????
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5       -   5        studentIDColumn??,  &System.Windows.Controls.DataGridColumn   Header$ 	StudentID??5    >      
Visibility$ Hidden=?6o      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6?   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Q   ?? *	StudentID+6?     5!      -   5        
NameColumn??$
 Name??5!   9   $ Hidden=?6`   $ * 6t    6G   ?? *Name+6t     5"      -   5        SurnameColumn??$ Surname??5"   <   $ Hidden=?6i   $ * 6}    6M   ?? *	Surname+6}     5#      -   5        PatronymicColumn??$ 
Patronymic??5#   ?   $ Hidden=?6r   $ * 6?    6S   ?? *
Patronymic+6?     5$      -   5        SpecialityColumn??$ 
Speciality??5$   ?   $ Hidden=?6r   $ * 6?    6S   ?? *
Speciality+6?     5%      -   5        BirthdayColumn??$ Birthday??5%   =   $ Hidden=?6l   $ * 6?    6O   ?? *
Birthday+6?     5&      -	   5        CourseColumn??$ Course??5&   ;   $ Hidden=?6f   $ * 6z    6K   ?? *Course+6z     5'      -
   5        GroupColumn??$ Group??5'   :   $ Hidden=?6i   $ * 6}    6I   ?? *GroupNumber+6}     5(      -   5        GenderColumn??$ Gender??5(   ;   $ Hidden=?6f   $ * 6z    6K   ?? *Gender+6z     5)      -   5        PhoneColumn??$ Phone??5)   :   $ Hidden=?6i   $ * 6}    6I   ?? *PhoneNumber+6}     5+      -   5        IDColumn??$ 	AddressID??5+   7   $ Hidden=?6a   $ * 6u    6J   ?? *ID+6u     5,      -   5        
CityColumn??$
 City??5,   9   $ Hidden=?6`   $ * 6t    6G   ?? *City+6t     5-      -   5        IndexColumn??$ Index??5-   :   $ Hidden=?6e   $ * 6y    6I   ?? *	C_Index+6y     5.      -   5        StreetColumn??$ Street??5.   ;   $ Hidden=?6f   $ * 6z    6K   ?? *Street+6z     5/      -   5        
HomeColumn??$
 Home??5/   9   $ Hidden=?6`   $ * 6t    6G   ?? *Home+6t   51      ?? 53   
   -   5         ??Name$	 Add??53      {?.  $??Добавить??6>   $??32??6Q   $??1??6]   $	??Top=?6j   $??18(?6?   $??Century Gothic)?6?   $??	32,8,32,0q?6?   $??2??6?   
???????6?   ?? 54   
   -   5        $ Delete??54      $??Удалить??6!   $??32??6D   $??1??6P   $	??Top=?6]   $??18(?6u   $??Century Gothic)?6?   $??4??6?   $??
32,45,32,0q?6?   
???????6?   ?? 55   
   -   5        $ Change??55      {?.  $??Изменить??6D   $??32??6W   $??1??6c   $	??Top=?6p   $??18(?6?   $??Century Gothic)?6?   $??2??6?   $??
32,44,32,0q?6?   
???????6?   ?? 56   
   -   5        $ Update??56      $??Вывести??6!   $??32??6F   $??1??6R   $	??Top=?6_   $??18(?6w   $??Century Gothic)?6?   $??4??6?   $??	32,8,32,0q?6?   
???????6?   58      5:      