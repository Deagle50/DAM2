   M S B A M L   `   `   `  ����F  BWPFAnuncios, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFAnunciosWPFAnuncios  5   	       WPFAnuncios.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPFAnuncios     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         �Name$ Grid1��5	      .+�5
   
   �� $��Categorías��6   $
��Left=�6%   $��	30,36,0,0q�6@   $	��Top=�6S   $
��Bold"�6k   $��20(�6}   $��Yu Gothic UI)�6�   �� 5   
   $��Categorías��6   $
��Left=�6%   $��
574,36,0,0q�6@   $	��Top=�6T   $
��Bold"�6l   $��20(�6~   $��Yu Gothic UI)�6�   �� 5   
   -   5        $��Combo1��5      $
��Left=�6I   $��	30,78,0,0q�6d   $	��Top=�6w   $	��138��6�   $��31��6�   $��Yu Gothic UI)�6�   $
��Bold"�6�   $��18(�6�   ��6!   �� *ListaCategorias+��5      �� 5      .R�5      �� ��6    �� *Nombre+6:   5      5      �� 5   
   -   5        
�������$��3q�5   T   $
��Left=�6�   $	��263��6�   $��
568,87,0,0q�6�   $	��Top=�6  $	��182��6   � DataContext 6h   ��  �� ElementName$ Combo1�� �� Path$ SelectedItem���6�   �� *Anunciantes+��5      �� 5      .R�5      ��  �� Orientation$ Vertical=�6!   .+�5      �� $��1q�6!   
����  �5       �� 5      $ 
Horizontal=�6!   .+�5      �� $��Marca: ��6(   $
��Bold"�67   5!      �� 5"      ��6(   �� *Marca+6A   5$      �� 5%      $ 
Horizontal=�6!   .+�5&      �� $��Dirección: ��6(   $
��Bold"�6;   6P   �� 5'      ��6(   �� *	Direccion+6E   5(      �� 5)      $ 
Horizontal=�6!   .+�5*      �� $��
Telefono: ��6(   $
��Bold"�6:   6N   �� 5+      ��6(   �� *
Telefono+6D   5,      5-      5.      50      52      53      