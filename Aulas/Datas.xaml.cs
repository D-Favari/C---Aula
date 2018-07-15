using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

// PARA TRABALHAR COM CULTURAS
using System.Globalization;

// Incluir o pacote que trata de multitarefas "mult-threading"
using System.Windows.Threading;


namespace Aulas
{
    /// <summary>
    /// Interaction logic for Datas.xaml
    /// </summary>
    public partial class Datas : Window
    {
        // CRIA O CRONOMETRO PARA DEFINIR O TEMPO DE EXECUÇÃO DA THREAD
        DispatcherTimer th = new DispatcherTimer();

        DispatcherTimer th1 = new DispatcherTimer();

        public Datas()
        {
            InitializeComponent();
            // Define o intervalo de tempo para a execução do método
            th.Interval = new TimeSpan(0, 0, 0, 1);
            // Define o método que será executado no evento Tick
            th.Tick += new EventHandler(AtualizaCronometro);
            th.Start();

            th1.Interval = new TimeSpan(0, 0, 0, 0, 1);
            // Define o método que será executado no evento Tick
            th1.Tick += new EventHandler(Contador);
            th1.Start();
        }

        // Método executado no intervalo de tempo definido em "Interval" para exibir a data e hora atual no controle "label"
        private void AtualizaCronometro(object sender, EventArgs e)
        {
            DataHoraAtual.Content = DateTime.Now.ToString();
        }

        // *************************************************************
        // EXERCÍCIO PARA A TURMA:
        // Crie uma outra thread que incremente um contador "c +=1" a 
        // cada milissegundo e exiba o valor de "c" num controle label.
        //
        // *************************************************************

        int c = 0;
        private void Contador(object sender, EventArgs e)
        {
            ExibeContador.Content = c += 1;
        }

        private void Calendario_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Dia.Content = Calendario.SelectedDate.Value.Day;
            // Exibe o nome da semana em inglês
            //DiaSemana.Content = Calendario.SelectedDate.Value.DayOfWeek;

            // Exibe o nome do dia da semana de acordo com a cultura instalada no sistema operacional "pt-BR"; "en-US" ...
            DiaSemana.Content = Calendario.SelectedDate.Value.ToString("dddd");

            Mes.Content = Calendario.SelectedDate.Value.Month;
            NomeMes.Content = Calendario.SelectedDate.Value.ToString("MMMM");

            DataLonga.Content = Calendario.SelectedDate.Value.ToLongDateString();


            // adiciona n dias a data selecionada
            DataMaisDias.Content = Calendario.SelectedDate.Value.AddDays(Convert.ToDouble(Dias.Text));

        }

        private void Culturas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)Culturas.SelectedItem;
            var culture = new CultureInfo(item.Content.ToString());

            DataSelecionada.Content = string.Format("{0}: {1}", item.Content.ToString(), Calendario.SelectedDate.Value.ToString(culture));
        }
    }
}
