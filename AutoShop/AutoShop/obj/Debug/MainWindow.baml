   M S B A M L   `   `   `  ����C  ?AutoShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AutoShopAutoShop  5   	       AutoShop.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:AutoShop     5   	     � Title$  АвтоЛайн��5   	   $	��450��6   $	��800��6'    � 
ResizeMode$ NoResize=�63    � WindowStartupLocation$ CenterScreen=�6I    � Icon$ 	/logo.png��6n   .��5	      � .+�5   
   � -   5         �Name$ 
HeaderGrid��5      ���	#FF414156$��50��6:   $	��800��6F   $	��Top=�6R   .+�5      �� $��22,0,0,0q�6   $��30��6&   $��	/logo.png��62   $
��Left=�6E   �� 5      -   5         ��Name$ FIOTextBlock��5      $
��Left=�6.   $��Center=�6I   $��70,0,0,0q�6d   $
��Bold"�6v   $��14(�6�   
�������6�   �� 5      -   5         ��Name$ ShoppingCartButton��5      $��Right=�61   $��Center=�6M   $��40��6h   
�������$�� ��6�   $
��Bold"�6�   $��16(�6�   $��0,0,30,0q�6�   $��50��6�   
���   ���5      �� 5       �� ImageSource$# /5e78e6995d6421710844c727.png��6!    j� Stretch$ Uniform=�6M   5      �� 5      -   5        $ StaticButton_Head��5      $��Right=�60   $��Center=�6L   $��50��6g   $��40��6r   
�������$�� ��6�   $
��Bold"�6�   $��16(�6�   $��0,0,90,0q�6�   
���   ���5      �� 5      $ /4778417.png��6!   5      5      � 5   
   -   5        $ MainGrid��5      $	��384��6!   ���	#FF5B5B6B$��Center=�6E   $	��800��6`   $��0,50,0,0q�6l   $��Center=�6~   .+�5      �� -   5        $ OpenHimiaListButton��5      $	��Top=�62   $
��Left=�6J   $��	25,38,0,0q�6e   ���	#FF24252F$��90��6�   $��20��6�   $��Автохимия��6�   
�������$��11(�6�   $	��Top=�6�   	 � 	Resources	 5      
 �� 
TargetType �� Property �� Value��%^   '��       �� 5      "
 ��6   .�5      ��  �@��CornerRadius$ 5��69   5      5      5       �� 5!      -   5        $ OpenAccessoriesListButton��5!      $	��Top=�68   $
��Left=�6P   $��
115,38,0,0q�6k   ���	#FF24252F$��90��6�   $��20��6�   $��Аксессуары��6�   
�������$��11(�6�   $	��Top=�6�   	 5"      ��%^   '��       �� 5#      "
 ��6   .�5$      ��  �@��CornerRadius$ 5��69   5%      5&      5'      �� 5(      -   5        $ OpenAutoLampsButton��5(      $	��Top=�62   $
��Left=�6J   $��
205,38,0,0q�6e   ���	#FF24252F$��90��6�   $��20��6�   $��Автолампы��6�   
�������$��11(�6�   $	��Top=�6�   	 5)      ��%^   '��       �� 5*      "
 ��6   .�5+      ��  �@��CornerRadius$ 5��69   5,      5-      5.      �� 5/      -	   5        $ OpenToolsListButton��5/      $	��Top=�62   $
��Left=�6J   $��
295,38,0,0q�6e   ���	#FF24252F$��90��6�   $��20��6�   $��Инструменты��6�   
�������$��11(�6�   $	��Top=�6�   	 50      ��%^   '��       �� 51      "
 ��6   .�52      ��  �@��CornerRadius$ 5��69   53      54      55      �� 56      -
   5        $ OrderListButton��56      $	��Top=�6.   $��Right=�6F   $��	0,38,25,0q�6b   ���	#FF24252F$��90��6�   $��20��6�   $��Заказы��6�   
�������$��11(�6�   $	��Top=�6�   	 57      ��%^   '��       �� 58      "
 ��6   .�59      ��  �@��CornerRadius$ 5��69   5:      5;      5<      �� 5=      -   5         ��Name$ AutoHimiaList��5=      $��Bottom=�6-   $��Center=�6H   $��0,0,0,30q�6e   $	��750��6w   $	��300��6�   ���	#FF24252F��5>      �� 5?      .R�5@      �  � RowDefinitions 5A      �� 5B   "   62   �� 5C   "   62   �� 5D   "   62   �� 5E   "   62   �� 5F   "   62   �� 5G   "   62   �� 5H   "   62   .+�5J      �� $ 	NameBlock��6E   $��0��6X   $
��Bold"�6e   $��Century Gothic)�6w   $��18(�6�   
���������6(   �� *nameProduct+6�   �� 5K      $ mFNameBlock��6g   $��1��6|   $
��Bold"�6�   $��Century Gothic)�6�   $��14(�6�   
���������6(   �� *IDManufacturer+ �� StringFormat$ Поставщик: {0}��6�   �� 5L      $ QuantityBlock��6b   $��2��6y   $
��Bold"�6�   $��Century Gothic)�6�   $��14(�6�   
���������6(   �� *
quantity+$ Количество: {0}��6�   �� 5M      $ 	PathBlock��6`   $��3��6s   $
��Bold"�6�   $��Century Gothic)�6�   $��18(�6�   
���������6(   �� *Price+$  Цена: {0} рублей��6�   �� 5N       ��Name$ 
QntyHimBox��6'   -   5        $	��200��5N   ;   $��4��6G   ���	#FF24252F$
��Left=�6k   6�   �� 5O      $ AHToShopCartButton��6%   -   5        $	��200��5O   A   $��5��6M   $
��Bold"�6Z   $��Century Gothic)�6l   $��18(�6�   
����������	#FF24252F$��В корзину��6�   $
��Left=�6�   6  �� 5P      $ nullText��67   $	��200��6(   $��6��6I   $
��Bold"�6V   $��Century Gothic)�6h   $��18(�6�   
�������6�   5Q      5R      5T      �� 5U      -   5        $ 	AcessList��5U      $��Bottom=�6)   $��Center=�6D   $��0,0,0,30q�6a   $	��750��6s   $	��300��6   ���	#FF24252F$y�Hidden=�6�   ��5V      �� 5W      .R�5X      �  5Y      �� 5Z   "   62   �� 5[   "   62   �� 5\   "   62   �� 5]   "   62   �� 5^   "   62   �� 5_   "   62   �� 5`   "   62   .+�5b      �� $ 	NameBlock��6E   $��0��6X   $
��Bold"�6e   $��Century Gothic)�6w   $��18(�6�   
���������6(   �� *nameProduct+6�   �� 5c      $ mFNameBlock��6g   $��1��6|   $
��Bold"�6�   $��Century Gothic)�6�   $��14(�6�   
���������6(   �� *IDManufacturer+$ Поставщик: {0}��6�   �� 5d      $ QuantityBlock��6b   $��2��6y   $
��Bold"�6�   $��Century Gothic)�6�   $��14(�6�   
���������6(   �� *
quantity+$ Количество: {0}��6�   �� 5e      $ 	PathBlock��6`   $��3��6s   $
��Bold"�6�   $��Century Gothic)�6�   $��18(�6�   
���������6(   �� *Price+$  Цена: {0} рублей��6�   �� 5f      $ 
QntyHimBox��6'   -   5        $	��200��5f   ;   $��4��6G   ���	#FF24252F$
��Left=�6k   6�   �� 5g      $ AHToShopCartButton��6%   -   5        $	��200��5g   A   $��5��6M   $
��Bold"�6Z   $��Century Gothic)�6l   $��18(�6�   
����������	#FF24252F$��В корзину��6�   $
��Left=�6�   6  �� 5h      $ nullText��67   $	��200��6(   $��6��6I   $
��Bold"�6V   $��Century Gothic)�6h   $��18(�6�   
�������6�   5i      5j      5l      �� 5m      -   5        $ AutolampsList��5m      $��Bottom=�6-   $��Center=�6H   $��0,0,0,30q�6e   $	��750��6w   $	��300��6�   ���	#FF24252F$y�Hidden=�6�   ��5n      �� 5o      .R�5p      �  5q      �� 5r   "   62   �� 5s   "   62   �� 5t   "   62   �� 5u   "   62   �� 5v   "   62   �� 5w   "   62   �� 5x   "   62   .+�5z      �� $ 	NameBlock��6E   $��0��6X   $
��Bold"�6e   $��Century Gothic)�6w   $��18(�6�   
���������6(   �� *nameProduct+6�   �� 5{      $ mFNameBlock��6g   $��1��6|   $
��Bold"�6�   $��Century Gothic)�6�   $��14(�6�   
���������6(   �� *IDManufacturer+$ Поставщик: {0}��6�   �� 5|      $ QuantityBlock��6b   $��2��6y   $
��Bold"�6�   $��Century Gothic)�6�   $��14(�6�   
���������6(   �� *
quantity+$ Количество: {0}��6�   �� 5}      $ 	PathBlock��6`   $��3��6s   $
��Bold"�6�   $��Century Gothic)�6�   $��18(�6�   
���������6(   �� *Price+$  Цена: {0} рублей��6�   �� 5~      $ 
QntyHimBox��6'   -   5        $	��200��5~   ;   $��4��6G   ���	#FF24252F$
��Left=�6k   6�   �� 5      $ AHToShopCartButton��6%   -   5        $	��200��5   A   $��5��6M   $
��Bold"�6Z   $��Century Gothic)�6l   $��18(�6�   
����������	#FF24252F$��В корзину��6�   $
��Left=�6�   6  �� 5�      $ nullText��67   $	��200��6(   $��6��6I   $
��Bold"�6V   $��Century Gothic)�6h   $��18(�6�   
�������6�   5�      5�      5�      �� 5�      -   5        $ 	ToolsList��5�      $��Bottom=�6)   $��Center=�6D   $��0,0,0,30q�6a   $	��750��6s   $	��300��6   ���	#FF24252F$y�Hidden=�6�   ��5�      �� 5�      .R�5�      �  5�      �� 5�   "   62   �� 5�   "   62   �� 5�   "   62   �� 5�   "   62   �� 5�   "   62   �� 5�   "   62   �� 5�   "   62   .+�5�      �� $ 	NameBlock��6E   $��0��6X   $
��Bold"�6e   $��Century Gothic)�6w   $��18(�6�   
���������6(   �� *nameProduct+6�   �� 5�      $ mFNameBlock��6g   $��1��6|   $
��Bold"�6�   $��Century Gothic)�6�   $��14(�6�   
���������6(   �� *IDManufacturer+$ Поставщик: {0}��6�   �� 5�      $ QuantityBlock��6b   $��2��6y   $
��Bold"�6�   $��Century Gothic)�6�   $��14(�6�   
���������6(   �� *
quantity+$ Количество: {0}��6�   �� 5�      $ 	PathBlock��6`   $��3��6s   $
��Bold"�6�   $��Century Gothic)�6�   $��18(�6�   
���������6(   �� *Price+$  Цена: {0} рублей��6�   �� 5�      $ 
QntyHimBox��6'   -   5        $	��200��5�   ;   $��4��6G   ���	#FF24252F$
��Left=�6k   6�   �� 5�      $ AHToShopCartButton��6%   -   5        $	��200��5�   A   $��5��6M   $
��Bold"�6Z   $��Century Gothic)�6l   $��18(�6�   
����������	#FF24252F$��В корзину��6�   $
��Left=�6�   6  �� 5�      $ nullText��67   $	��200��6(   $��6��6I   $
��Bold"�6V   $��Century Gothic)�6h   $��18(�6�   
�������6�   5�      5�      5�      �� 5�      -   5        $ 
OrdersList��5�      $��Bottom=�6*   $��Center=�6E   $��0,0,0,30q�6b   $	��750��6t   $	��300��6�   ���	#FF24252F$y�Hidden=�6�   ��5�      �� 5�      .R�5�      �  5�      �� 5�   "   62   �� 5�   "   62   �� 5�   "   62   �� 5�   "   62   �� 5�   "   62   �� 5�   "   62   �� 5�   "   62   .+�5�      �� $ IDBlock��6X   $��0��6i   $
��Bold"�6v   $��Century Gothic)�6�   $��18(�6�   
���������6(   �� *ID+$ Клиент: {0}��6�   �� 5�      $ FPriceBlock��6g   $��1��6|   $
��Bold"�6�   $��Century Gothic)�6�   $��14(�6�   
���������6(   �� *FinallyPrice+$  Цена: {0} рублей��6�   �� 5�      $ datestartBlock��6h   $��2��6�   $
��Bold"�6�   $��Century Gothic)�6�   $��14(�6�   
���������6(   �� *	dateStart+$( "Дата оформления: {0}��6�   �� 5�      $ 	discBlock��6o   $��3��6�   $
��Bold"�6�   $��Century Gothic)�6�   $��18(�6�   
���������6(   �� *discription+$1 +Комментарии к заказу: {0}��6�   �� 5�      $ AboutOrderButton��6%   -   5        $	��200��5�   ?   $��5��6K   $
��Bold"�6X   $��Century Gothic)�6j   $��18(�6�   
����������	#FF24252F$��Подробнее��6�   $
��Left=�6�   6  �� 5�      $ nullText��67   $	��200��6(   $��6��6I   $
��Bold"�6V   $��Century Gothic)�6h   $��18(�6�   
�������6�   5�      5�      5�      5�      � 5�   
   -   5        $ ShoppingCartGrid��5�      $��Right=�6)   $	��Top=�6E   $	��300��6]   $	��200��6i   $��0,50,0,0q�6v   ���	#FF414156$y�Hidden=�6�   .+�5�      �� $
��Left=�6   $	��Top=�6/   $��5,5,0,0q�6G   $��Корзина��6X   $
��Bold"�6j   
�������$��18(�6�   6�   �� 5�      -   5        $ SCLabel��5�      $	��Top=�6)   $
��Wrap=�6A   $
��Left=�6U   $��5,45,0,0q�6p   $	��280��6�   $	��115��6�   6�   �� 5�      -   5        $ DoOrderButton��5�      ���	#FF24252F
�������$��Bottom=�6V   $
��Left=�6q   $��5,0,0,5q�6�   $	��150��6�   $��30��6�   $!��Оформить заказ��6�   $
��Bold"�6�   6�   5�      � 5�   
   -   5        $ 	LoginGrid��5�      ���	#FF5B5B6B$y�Hidden=�69   .+�5�      �� $��Center=�6   $��Center=�61   $��	0,0,0,150q�6L   
�������$��
Логин��6r   $
��Bold"�6�   $��20(�6�   �� 5�      -   5         ��Name$ 	LoginText��5�      $��Center=�6)   $��Center=�6F   $��0,0,0,70q�6a   $	��200��6s   $��30��6   6�   �� 5�      $��Center=�6   $��Center=�61   
�������$��Пароль��6_   $
��Bold"�6p   $��20(�6�   $��0,0,0,0q�6�   G� 5�      -   5         G�Name$ PasswordText��5�      $��Center=�60   $��Center=�6M   $	��200��6h   $��30��6t   $��0,80,0,0q�6�   �� 5�      -   5        $ LoginButton��5�      $��Center=�6*   $��Center=�6G   ���	#FF24252F
�������$
��Bold"�6�   $��14(�6�   $��
Войти��6�   $��	0,170,0,0q�6�   $	��100��6�   $��30��6�   6  5�      � 5�   
   -    5        $ StatGrid��5�      $	��384��6!   ���	#FF5B5B6B$	��800��6E   $��0,50,0,0q�6Q   $y�Hidden=�6c   .+�5�      �� -!   5        $ AllSaleText��5�      $
��Left=�6-   $	��Top=�6H   $
��Bold"�6`   $��20(�6r   $*��$Всего продано (Руб.):��6�   
�������$��	30,30,0,0q�6�   6�   �� 5�      -"   5        $ TodaySaleText��5�      $
��Left=�6/   $	��Top=�6J   $
��Bold"�6b   $��20(�6t   $.��(Продано сегодня (Руб.):��6�   
�������$��	30,80,0,0q�6�   6�   �� 5�      -#   5        $ CountProductText��5�      $
��Left=�62   $	��Top=�6M   $
��Bold"�6e   $��20(�6w   $=��7Общая стоимость товаров (Руб.):��6�   
�������$��
30,130,0,0q�6�   6�   �� 5�      -$   5        $ OkupText��5�      $
��Left=�6*   $	��Top=�6E   $
��Bold"�6]   $��20(�6o   $=��7Общая стоимость товаров (Руб.):��6}   
�������$��
30,180,0,0q�6�   6�   �� 5�      -%   5        $ 
WordButton��5�      $
��Left=�6)   $	��Top=�6D   $��
30,300,0,0q�6\   $	��200��6p   $��40��6|   $ ��Вывести в ворд��6�   $
��Bold"�6�   $��16(�6�   ���	#FF24252F
�������6  5�      5�      5�      