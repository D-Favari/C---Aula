   M S B A M L   `   `   `  ����@  <Aulas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AulasAulas  5   	       Aulas.Datas   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Aulas     5   	     � Title$  Datas��5   	   $��558.394��6   $��564.964��6(   .��5	      � .+�5
   
   �� -   5         ��Name$ DataHoraAtual��5
      $��
Cronometro��6'   $��30,56,215,0q�6<   $	��Top=�6Q   $��20(�6i   
�������
���  ��6�   �� 5   
   -   5        $ label��5      $(��"Exemplo de Multitarefa - threading��6   $
��Left=�6L   $��	30,30,0,0q�6g   $	��Top=�6z   $	��217��6�   �� 5   
   -   5        $ ExibeContador��5      $��Contador��6'   $��Right=�6:   $��	0,58,90,0q�6V   $	��Top=�6i    J� RenderTransformOrigin$ 0.133,0.323&�6�   $��22(�6�   ���	#FF0051FF6�   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ 
Calendario��5      $
��Left=�6'   $��33,143,0,216q�6B   6s   �� 5   
   -   5        $	 Dia��5      $	��Dia��6   $��246,148,254,0q�6+   $	��Top=�6B   $��18(�6Z   �� 5   
   -   5        $	 Ano��5      $	��Ano��6   $��246,213,246,0q�6+   $	��Top=�6B   $��18(�6Z   �� 5   
   -   5        $	 Mes��5      $
��Mês��6   $��246,182,257,0q�6+   $	��Top=�6B   $��18(�6Z   �� 5   
   -   5        $ 	DiaSemana��5      $��Dia da Semana��6#   $��
0,146,92,0q�6;   $	��Top=�6O   $��Right=�6g   $��18(�6�   �� 5   
   -	   5        $ NomeMes��5      $��Nome do Mês��6!   $��
0,183,97,0q�67   $	��Top=�6K   $��Right=�6c   $��18(�6�   �� 5   
   -
   5        $ 	DataLonga��5      $��	DataLonga��6#   $��248,0,15,236q�67   $��Bottom=�6M   $��16(�6h   ���	#FF308B0E6v   �� 5   
   -   5         ��Name$
 Dias��5      $��23��6    $��253,0,260,190q�6,    �� TextWrapping$
 Wrap=�6C   $��Bottom=�6W   $��0��6r   �� 5   
   -   5        $ label1��5      $��Adicionar n dias a data��6    $��249,0,178,210q�6B   $��Bottom=�6Y   �� 5   
   -   5        $ DataMaisDias��5      $��Data mais os dias��6&   $��Right=�6B   $��
0,0,86,190q�6^   $��Bottom=�6r   $	��158��6�   �� 5   
   -   5         ��Name$ Culturas��5      $
��Left=�6%   $��
35,0,0,175q�6@   $��Bottom=�6T   $	��120��6o   .@�5      �� $��en-US��6   �� 5      $��pt-BR��6   �� 5      $��en-GB��6   �� 5      $��fr-FR��6   �� 5      $��de-DE��6   �� 5      $��ru-RU��6   �� 5      $��ja-JP��6   5      �� 5    
   -   5        $ DataSelecionada��5       $��Data Selecionada��6)   $
��Left=�6D   $��
34,0,0,139q�6_   $��Bottom=�6s   $��18(�6�   $	��196��6�   5"      5#      