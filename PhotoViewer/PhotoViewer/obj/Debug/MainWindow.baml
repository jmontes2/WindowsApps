   M S B A M L   `   `   `  ����F  BPhotoViewer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PhotoViewerPhotoViewer  5   	       PhotoViewer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:PhotoViewer     5   	   -   5          �Name$  
Photograph��5   	    � Title$ 
MainWindow��5   	   $	��301��6   $	��973��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ label_Search��5
      $��Search:��6&   $
��Left=�68   $��	23,10,0,0q�6S   $	��Top=�6f   �� 5   
   -   5         ��Name$ 	button_GO��5      $	��GO!��6$   $
��Left=�62   $��
480,13,0,0q�6M   $	��Top=�6a   $��75��6y    J� RenderTransformOrigin$ 
1.107,0.45&�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid_Photo��5      $
��Left=�6+   $��	23,38,0,0q�6F   $	��Top=�6Y   $	��185��6q   $	��343��6~   6�   �� 5   
   -   5         ��Name$ image_Photo��5      $
��Left=�6%   $	��185��6@   $��
371,38,0,0q�6M   $	��Top=�6a   $	��184��6y   �� 5   
   -   5        $ 
button_Upd��5      $	��New��6%   $
��Left=�63   $��750,228,0,0q�6N   $	��Top=�6c   $��75��6{   6�   �� 5   
   -   5         ��Name$ textBox_Search��5      $
��Left=�6*   $��23��6E   $��	76,10,0,0q�6Q    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��399��6�   $ 0.133,0.478&�6�   �� 5   
   -   5        $ label_Title��5      $��Title:��6%   $
��Left=�66   $��
560,38,0,0q�6Q   $	��Top=�6e   $ 	0.5,0.615&�6}   �� 5   
   -	   5        $ label_dateTaken��5      $��Date Taken:��6)   $
��Left=�6?   $��
560,69,0,0q�6Z   $	��Top=�6n   $ -0.053,0.654&�6�   �� 5   
   -
   5        $ label_dateAdded��5      $��Date Added:��6)   $
��Left=�6?   $��560,100,0,0q�6Z   $	��Top=�6o   $ 
0.5,-0.115&�6�   �� 5   
   -   5        $ label_description��5      $��Description:��6+   $
��Left=�6B   $��560,131,0,0q�6]   $	��Top=�6r   $ 0.395,-0.269&�6�   �� 5   
   -   5        $ label_artistName��5      $��Artist Name:��6*   $
��Left=�6A   $��560,162,0,0q�6\   $	��Top=�6q   $ 0.184,0.577&�6�   �� 5   
   -   5        $ label_photoHeader��5      $��Photograph Information��6+   $
��Left=�6L   $��	641,4,0,0q�6g   $	��Top=�6z   $
��Bold"�6�   $��14(�6�   �� 5   
   -   5        $ textBox_artistName��5      $
��Left=�6.   $��23��6I   $��641,166,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��299��6�   $ 0.567,2.478&�6�   �� 5   
   -   5        $ textBox_description��5      $
��Left=�6/   $��23��6J   $��641,135,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��299��6�   �� 5   
   -   5        $ textBox_dateAdded��5      $
��Left=�6-   $��23��6H   $��641,104,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��110��6�   �� 5   
   -   5        $ textBox_dateTaken��5      $
��Left=�6-   $��23��6H   $��
641,73,0,0q�6T   $
 Wrap=�6h   $	��Top=�6|   $	��110��6�   �� 5   
   -   5        $ textBox_title��5      $
��Left=�6)   $��23��6D   $��
641,42,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��299��6�   5      5      