   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFWPF  5   	   'clr-namespace:WPF.Models
WPF.Models  5   	       WPF.SecondWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:WPF     5   	   *modelclr-namespace:WPF.Models     5   	     � Title$  SecondWindow��5	   	   $	��450��6   $	��800��6+    � DataContext 5
      &    WPF.Models.SecondWindowViewModel  5   
   .��5      �� .+�5   
   �� -   5        $��label1��5   4   $"��Új karbantartás felvétele��6   64   �� 5   
   $��Szerelő neve:��6   �� 5   
   -   5        $	��cb1��5      �� 5   
   $��Megrendelő neve:��6   �� 5   
   -   5        $	��cb2��5      �� 5   
   $��Karbantartás dátuma:��6   &   System.Windows.Controls.Calendar  5   
   -   5        $��	calendar1��5      �� 5   
   $��Munka ideje órákban:��6   �� 5   
   -   5        $	��cb3��5      �� 5   
   -   5        $
��btn1��5   "   $��Küldés��6   6.   5      5      