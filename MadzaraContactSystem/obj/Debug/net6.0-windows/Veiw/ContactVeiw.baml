   M S B A M L   `   `   `  ????O  KMadzaraContactSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:MadzaraContactSystem.VeiwMadzaraContactSystem.Veiw  5      +    %MadzaraContactSystem.Veiw.ContactVeiw   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:MadzaraContactSystem.Veiw     5      $
??1112??5   #   .??5	      ? $??0,0,10,0q?6     ? ColumnDefinitions  5
   
   ?? 5      $??1* ?6   ?? 5      $??3* ?6    .+?5   
   ?? $
??Wrap=?6   $??Madzara's Contact Book??6(   $??
86,0,0,413q?6F   $
??Bold"?6Z   $??22(?6l   $
??Left=?6z   $	??313??6?   $??1??6?   ?? 5   
   $
??Wrap=?6   $
??Name??6(   $??29,-124,70,367q?64   $??18(?6L   $??60??6Z   ?? 5   
   $
??Wrap=?6   $??Email??6(   $??29,206,70,225q?65   $??18(?6L   ?? 5   
   $
??Wrap=?6   $??Tell Number??6(   $??29,110,70,301q?6;   $??18(?6R   $??60??6`   ?? 5   
   $
??Wrap=?6   $??D.O.B??6(   $??29,418,70,153q?65   $??18(?6L   ?? 5   
   $
??Wrap=?6   $??29,406,70,225q?6F   $??18(?6]   ??6(   ??  ?? Path$ Message?6]   ?? 5   
    ?? TextWrapping$
 Wrap=?6   $??1??6_   $??60,-124,59,367q?6o   $??60??6?   ??6&   ?? $ CurrentContact.Name? ?? Mode$ TwoWay=?6?   ?? 5   
   $
 Wrap=?6   $??1??6`   $??60,-109,59,225q?6p   $??60??6?   ??6&   ?? $ CurrentContact.Email?$ TwoWay=?6?   ?? 5   
   $
 Wrap=?6   $??1??6c   $??60,109,59,301q?6s   $??60??6?   ??6&   ?? $ CurrentContact.TNumber?$ TwoWay=?6?   ?? 5   
   $
 Wrap=?6   $??1??6_   $??60,309,59,301q?6o   $??60??6?   ??6&   ?? $ CurrentContact.Dob?$ TwoWay=?6?   ?? 5   
   $??1??6   $??60,311,179,98q?6%    ?? Orientation$ 
Horizontal=?6<   .+?5      ?? $	??Add??6   $??76??6#   $??5,0,5,0q?6.   $??30??6@   ??6O   ?? $ SaveCommand??? 5      $??Udate??6   $??76??6&   $??5,0,5,0q?61   $??30??6B   ??6Q   ?? $ UpdateCommand??? 5      $??Delete??6   $??76??6&   $??5,0,5,0q?61   $??30??6B   ??6R   ?? $ DeleteCommand??? 5      $??Search??6   $??76??6&   $??5,0,5,0q?61   $??30??6B   ??6Q   ?? $ SearchCommand?5      &   System.Windows.Controls.DataGrid  5!   
   -   5        $??
dgContacts??5!      $??2??6%   $??220,557,282,0q?69      AutoGenerateColumns$ False??6P   ??6l   ?? $ ContactsList?$ TwoWay=?   Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 63   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6@   ?? $
 Name?6`     5%      $ Number??6%   $
 auto 65   	 6B   ?? $ TNumber?6e     5&      $ Email??6%   $
 auto 64   	 6A   ?? $ Email?6b     5'      $ Date Of Birth??6%   $
 auto 6<   	 6I   ?? $	 Dob?6h   5)      5-      5.      