   M S B A M L   `   `   `  ?????  ;Exam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Exam.Pages
Exam.Pages  5          Exam.Pages.Admin   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Exam.Pages     5        N? Title$  Admin??5	       ? 	Resources 5         	AuthStyle ?? 
TargetType ?? Property ?? Value ?? 
TargetType ?? CornerRadius ??Name ?? Triggers	 P? Property
 P? Value??%z  &	        ?? 5   
   " ??6"   .?5      ??  ? ?? ?#FFFF6+   ?? 5       ? ??$ 40??6'   ?? 5       ? ??$ 40q?60   ?? 5       ? ??
 ?   ?6,   ?? 5       ? ??$ Center=?69   ?? 5       ? ??$ 20(?6)   ?? 5       ? ??$ Bahnschrift)?6+   -   5        ?? 5       ? ?? 5      ?? 5      " ??6&   .R?5      ?? $??0q?6!   #??z??5      $ 10??5      ._?5      ?? $ PART_ContentHost??6+   5      5      5        5"      P? 5#      	 ?@J?IsMouseOver
 . . ?5$      ??  ? ?? ?#AFAFAF63   5%      5'      5(      .??5)      ? .+?5*   
   &   System.Windows.Controls.DataGrid  -   5          Name$	 DGQ??5*      $	??600??6    $	??520??6,   $
??Left=?69    J? Opacity$	 0.8Q?6T      AutoGenerateColumns .     
IsReadOnly .  $??
0,30,0,170q?6?      Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6%      Header$
 City??60   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   ??  ?? Path$
 city?  5-      $ 80 6%   $ Hotel??60    6?   ?? $ hotel?  5.      $ 80 6%   $ Price??60    6?   ?? $ price?  5/      $ 80 6%   $ Picture??60    6A   ?? $ picture?51      ?? 52   
   -   5         ??Name$
 AddQ??52        RoundedButton#???  6   $
??Save??6G   $??948,0,45,30q?6V   $??Bottom=?6k   6?   ?? 54   
   -   5         ??Name$	 Pic??54      $??Right=?6   $	??450??69   $	??Top=?6F   $	??450??6^   $??	0,61,84,0q?6j   ?? 56   
   -   5         ??Name$ TBGood??56      #???   6"   $??18,0,1012,109q?6F   $	??250??6]   $??Bottom=?6i   ?? 57   
   -   5         ??Name$ TBGood2??57      ???	#FF808080$??33,0,997,109q?6<   $??30??6R    J? IsHitTestVisible .  $	??250??58   $   $??Bottom=?60   $??20(?6K   $??Bahnschrift)?6Y   $
??City??6r   ?? 5:   
   -   5        $ TBHotel??5:      #???   6#   $??23,0,487,109q?6G   $	??250??6]   $??Bottom=?6i   ?? 5;   
   -   5        $ TBHotel2??5;      ???	#FF808080$??33,0,477,109q?6=   $??30??6S    .  $	??250??5<      $??Bottom=?6   $??20(?64   $??Bahnschrift)?6B   $??Hotel??6[   ?? 5>   
   -	   5        $ TBPrice??5>      #???   6#   $??543,0,487,109q?6G   $	??250??6^   $??Bottom=?6j   ?? 5?   
   -
   5        $ TBPrice2??5?      ???	#FF808080$??553,0,477,109q?6=   $??30??6T    .  $	??250??5@   $   $??Bottom=?60   $??20(?6K   $??Bahnschrift)?6Y   $??Price??6r   ?? 5B   
   -   5        $ 	TBPicture??5B      #???   6%   $??784,0,196,109q?6I   $	??250??6`   $??Bottom=?6l   ?? 5C   
   -   5        $ 
TBPicture2??5C      ???	#FF808080$??794,0,186,109q?6?   $??30??6V    .  $	??250??5D   $   $??Bottom=?60   $??20(?6K   $??Bahnschrift)?6Y   $??Picture??6r   5F      5G      