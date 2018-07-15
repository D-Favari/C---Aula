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

using Microsoft.Win32; // contem a janela OpenFileDialog
using System.IO; // classe para trabalhar com arquivos e pastas

namespace Aulas
{
    /// <summary>
    /// Interaction logic for Imagens.xaml
    /// </summary>
    public partial class Imagens : Window
    {

        private OpenFileDialog SelecionaImagem = null;

        public Imagens()
        {
            InitializeComponent();
            // Define o método que será executado para carregar a imagem
            // no controle Imagem.
            SelecionaImagem = new OpenFileDialog();
            SelecionaImagem.FileOk += AbrirImagem;
        }

        private void AbrirImagem(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                // le a imagem do disco no caminho selecionado em
                // "SelecionaImagem.FileName" e coloca no controle Imagem

                BitmapImage img = new BitmapImage();
                img.BeginInit();
                img.UriSource = new Uri(SelecionaImagem.FileName.ToString());
                img.EndInit();
                // atribui a imagem ao controle
                Imagem.Source = img;

                // obtem as informações da imagem
                FileInfo info = new FileInfo(SelecionaImagem.FileName.ToString());

                Informacoes.Text = "Nome: " + info.FullName + "\n";
                Informacoes.Text += "Pasta: " + info.DirectoryName + "\n";
                Informacoes.Text += "Tamanho: " + info.Length + "\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message +"\n"+ "SELECIONE SOMENTE IMAGEM");
            }
        }

        private void Abrir_Click(object sender, RoutedEventArgs e)
        {
            SelecionaImagem.Filter = "Imagens(*.jpg,*.jpeg,*.tif,*.bmp)|*.jpg;*.jpeg;*.tif;*.bmp";

            SelecionaImagem.ShowDialog();
        }


        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
