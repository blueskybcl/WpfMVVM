   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WpfApplication1.PropertiesWpfApplication1.Properties  5   	   1clr-namespace:WpfApplication1WpfApplication1  5   	   !    WpfApplication1.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8res(clr-namespace:WpfApplication1.Properties     5   	   /localclr-namespace:WpfApplication1     5   	     � Title$  LoginWindow��5
   	   $	��300��6   $	��300��6*    � DataContext 5	   	   �� *Login+   Locator �� Source# [  .��5      �  � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��60 �6   .+�5   
   �� $��0��6   $��0��6$   *   $WpfApplication1.Properties.Resources   UserName#��Z 61     TextBlockStyle#��[ 6Z   6�   �� 5   
   $��1��6   $��0��6"     TextBoxStyle#��[ 6U   ��6/   �� *
UserName+ �� Mode$ TwoWay=�6}   �� 5   
   $��0��6   $��1��6$      UserPwd#��Z 61   #��[ 6Y   6�   �� 5   
   $��1��6   $��1��6"   #��[ 6T   ��6/   �� *	UserPwd+$ TwoWay=�6|   �� 5   
   $��0��6   $��2��6%   $��2��62    �� Orientation$ 
Horizontal=�6F   $��Center=�6_   .+�5      �� 	   Login#��Z	 6   ��6>   �� *LoginCommand+6a   �� 5      
   Cancel#��Z
 6   ��6?   �� *CancelCommand+6c   5      5      5      