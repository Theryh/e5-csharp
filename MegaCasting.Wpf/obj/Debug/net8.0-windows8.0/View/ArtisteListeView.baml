   M S B A M L   `   `   `  ����J  FMegaCasting.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MegaCasting.Wpf.ViewMegaCasting.Wpf.View  5      *    $MegaCasting.Wpf.View.ArtisteListView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:MegaCasting.Wpf.View     5      .��5	      � .+�5
   
   �� $��Artiste��6   &   System.Windows.Controls.DataGrid  5   
       AutoGenerateColumns$  False��64   ��6   �� *
Artistes+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Metier��6%      
IsReadOnly$
 True��6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Metier.LibelleMetier+6^     5      $	 Nom��6%   $
 True��6J    62   �� *Nom+6J     5      $ Prenom��6%   $
 True��6P    65   �� *Prenom+6P     5      $	 Age��6%   $
 True��6J    62   �� *Age+6J   5      5      5      