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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Aulas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Aulas.Controles();
            w.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Window w = new Aulas.Imagens();
            w.ShowDialog();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Window w = new Aulas.Datas();
            w.ShowDialog();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Window w = new Aulas.Arquivo();
            w.ShowDialog();

        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Window w = new Aulas.CadastroDB();
            w.ShowDialog();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Window w = new Aulas.Editar_Cadastro();

            w.ShowDialog();
        }
    }
}
