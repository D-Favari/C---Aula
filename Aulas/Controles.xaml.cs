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

namespace Aulas
{
    /// <summary>
    /// Interaction logic for Controles.xaml
    /// </summary>
    public partial class Controles : Window
    {
        public Controles()
        {
            InitializeComponent();

            Int32 x = 123456;
            Resultado.Content = Convert.ToString(x*5);
        }

        private void Entrada_TextChanged(object sender, TextChangedEventArgs e)
        {
            Resultado.Content = Entrada.Text;
        }

        private void Limpar_Click(object sender, RoutedEventArgs e)
        {
            Entrada.Text = "";
        }

        private void Vermelho_Checked(object sender, RoutedEventArgs e)
        {
            Resultado.Foreground = Brushes.Red;
        }

        private void Verde_Checked(object sender, RoutedEventArgs e)
        {
            Resultado.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0));
        }

        private void Azul_Checked(object sender, RoutedEventArgs e)
        {
            Resultado.Foreground = Azul.Foreground;
        }

        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            // fecha o formulário
            this.Close();
        }

        // Este método será executado durante o processo de fechamento da janela.
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Utilizando a caixa de mensagem do windows
            //MessageBox.Show(Resultado.Content.ToString());

            // Obtendo um resultado do messagebox
            MessageBoxResult res = MessageBox.Show("Deseja salvar o arquivo antes de sair?", "SAIR", MessageBoxButton.YesNoCancel);
            if (res == MessageBoxResult.Cancel)
            {
                ResultadoMessageBox.Content = "Continua";
                // continua sem executar nenhuma ação
                e.Cancel = true;
            }
            else if (res == MessageBoxResult.Yes)
            {
                // execute o método para salvar o arquivo e sai da janela
                // ...
            }
            else
            {
                // Sai da janela sem salvar o arquivo
            }
        }

        private void Paises_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)Paises.SelectedItem;
            Resultado.Content = item.Content;
        }
    }
}
