   M S B A M L   `   `   `  ����I  EDCT_CryptoCoin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DCT_CryptoCoinDCT_CryptoCoin  5      %    DCT_CryptoCoin.View.PageDetails   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7dct_cryptocoinclr-namespace:DCT_CryptoCoin     5        N� Title$  PageDetails��5	      .��5      � 
�������$
��auto��6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      .+�5   
   �� -   5        $��0��5      $	��<--��6   $��5q�6B   $
��Left=�6N   $	��Top=�6i   $��	10,10,0,0q�6�   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      .+�5"      �� $��
10,10,0,10q�6   $��0��6.   .@�5#      �� $��
Asset Id: ��6   �� 5$      ��6   �� *SelectedAsset.asset_id+5%      �� 5&      $��	0,10,0,10q�6   $��1��6-   .@�5'      �� $��Name: ��6   �� 5(      ��6   �� *SelectedAsset.name+5)      �� 5*      $��	0,10,0,10q�6   $��2��6-   .@�5+      �� $��Price: ��6   �� 5,      ��6   �� *SelectedAsset.price+5-      �� 5.      $��	0,10,0,10q�6   $��3��6-   .@�5/      �� $��volume_24h: ��6   �� 50      ��6   �� *SelectedAsset.volume_24h+51      �� 52      $��	0,10,0,10q�6   $��4��6-   .@�53      �� $��change_1h: ��6   �� 54      ��6   �� *SelectedAsset.change_1h+55      �� 56      $��	0,10,0,10q�6   $��5��6-   .@�57      �� $��change_24h: ��6   �� 58      ��6   �� *SelectedAsset.change_24h+59      �� 5:      $��
0,10,10,10q�6   $��6��6.   .@�5;      �� $��change_7d: ��6   �� 5<      ��6   �� *SelectedAsset.change_7d+5=      5@      �� 5C   
   -   5        $��2��5C      $��	10,0,10,0q�6   $!��Load markets for this asset��6E   &   System.Windows.Controls.DataGrid  5E   
   -   5        $��	MarketsDG��5E   '   $��
10,0,10,10q�6   $��3��68      
IsReadOnly$
 True��6e      AutoGenerateColumns$ False��6w   $y�Hidden=�6�   ��6E   �� *	markets+   Columns 5F      0  *System.Windows.Controls.DataGridTextColumn  5G      ,  &System.Windows.Controls.DataGridColumn   Header$ Markets��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *exchange_id+5I      5K      5M      