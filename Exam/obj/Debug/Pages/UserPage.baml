   M S B A M L   `   `   `  ?????  ;Exam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Exam.Pages
Exam.Pages  5          Exam.Pages.UserPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Exam.Pages     5        N? Title$  UserPage??5	       ? 	Resources 5         	AuthStyle ?? 
TargetType ?? Property ?? Value ?? 
TargetType ?? CornerRadius ??Name ?? Triggers	 P? Property
 P? Value??%l  &	        ?? 5   
   " ??6"   .?5      ??  ? ?? ?#FFFF6+   ?? 5       ? ??$ 40??6'   ?? 5       ? ??$ 40q?60   ?? 5       ? ??
 ?   ?6,   ?? 5       ? ??$ Center=?69   ?? 5       ? ??$ 20(?6)   ?? 5       ? ??$ Bahnschrift)?6+   ?? 5       ? ?? 5      ?? 5      " ??6&   .R?5      ?? $??0q?6!   #??z??5      $ 10??5      ._?5      ?? $ PART_ContentHost??6+   5      5      5        5"      P? 5#      	 ?@J?IsMouseOver
 . . ?5$      ??  ? ?? ?#AFAFAF63   5%      5'      5(      .??5)      ? .+?5*   
   &   System.Windows.Controls.DataGrid  -   5          Name$	 DGQ??5*      $	??600??6    $	??520??6,   $
??Left=?69    J? Opacity$	 0.8Q?6T      AutoGenerateColumns .     
IsReadOnly . $??
0,30,0,170q?6?      Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6%      Header$
 City??60   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   ??  ?? Path$
 city?  5-      $ 80 6%   $ Hotel??60    6?   ?? $ hotel?  5.      $ 80 6%   $ Price??60    6?   ?? $ price?  5/      $ 80 6%   $ Picture??60    6A   ?? $ picture?51      ?? 53   
   -   5         ??Name$	 Pic??53      $??Right=?6   $	??450??69   $	??Top=?6F   $	??450??6^   $??	0,61,84,0q?6j   ?? 55   
   -   5         ??Name$
 AddQ??55        RoundedButton#???  6   $	??300??6G   $??50??6S   $??Buy now??6_   $??0,0,0,30q?6q   $??Center=?6?   $??Bottom=?6?   6?   56      57      