   M S B A M L   `   `   `  ?????  ;Lab7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab7Lab7  5   	       Lab7.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lab7     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??* ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? -   5         ??Name$ mainTab??5      .@?5      ?? -   5         ??Name$ accountItem??5      $??Student??6+   .??5      &   System.Windows.Controls.DataGrid  -   5          Name$ StudentGrid??5         AutoGenerateColumns .     CanUserResizeColumns .     CanUserResizeRows .  $   HorizontalScrollBarVisibility$
 Auto=?6?   	   CanUserAddRows	 .  $??	0,0,0,0.4q?6?   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ ID??6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   ?? *ID+6V     5      $ Имя??6F    6-   ?? *NAME+6F     5      $  Специальность??6L    6-   ?? *
SPECIALITY+6L     5      $ Пол??6E    6-   ?? *SEX+6E     5      $ Дата рождения??6i    6-   ?? *
BIRTHDAY+ ?? StringFormat$ {0:MM/dd/yyyy}??6i     5      $ Возраст??6E    6-   ?? *AGE+6E     5      $ Курс??6H    6-   ?? *COURSE+6H     5      $ Средний балл??6J    6-   ?? *
AVGSCORE+6J   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Фото??61      CellTemplate 5      ?? 5   "   .R?5   &   ?? -   5        $??15??5   ,   $??15??67   ??6C   ?? *FOTO+6[   5    #   5"      5$      5%      ?? 5&      -   5        $ AddressItem??5&      $??Address??6+   .??5'        -   5        $ AddressGrid??5'       .   .   .  $ Disabled=?6?   	 .  $??	0,0,0,0.4q?6?   
 5(        5)       . $ ID??6V    6-   ?? *ID+6V     5*      $ ID владельца??6K    6-   ?? *	StudentID+6K     5+      $ 
Город??6F    6-   ?? *Town+6F     5,      $# Почтовый индекс??6G    6-   ?? *Index+6G     5-      $ 
Улица??6H    6-   ?? *Street+6H     5.      $ Дом??6G    6-   ?? *House+6G     5/      $ Квартира??6F    6-   ?? *Flat+6F   51      52      53      ?? 54   
   $??Center=?6   $??1??62    ?? Orientation$ 
Horizontal=?6?   .+?55      ?? -   5         ??Name$ 
saveButton??55      $??Сохранить??6)   6=   ?? 56      -   5        $ updateButton??56      $??Обновить??6+   6>   ?? 57      -	   5        $
??Auto??57   .   .??58      ?? $??resources\ArrowLeft.png??6   $??30??69   6G   59      ?? 5:      -
   5        $
??Auto??5:   /   .??5;      ?? $??resources\ArrowRight.png??6   $??30??6:   6H   5<      ?? 5=      -   5        $ deleteButton??5=      $??Удалить??6+   6=   ?? 5>      -   5        $ 	addButton??5>      $??Добавить??6(   6;   5?      5@      5A      