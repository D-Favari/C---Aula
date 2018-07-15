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

// Namespaces para trabalhar com arquivos
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using AppManager;

namespace Aulas
{
    /// <summary>
    /// Interaction logic for Arquivo.xaml
    /// </summary>
    public partial class Arquivo : Window
    {

        #region INICIALIZAÇÃO

        //Janela de dialogo Abrir Arquivo
        private OpenFileDialog DialogoAbrir = null;
        //Janela de dialogo Salvar Arquivo
        private SaveFileDialog DialogoSalvar = null;
        // variavel para controlar se houve ou não edicao no texto
        // flag = true/false
        private bool flag = false;

        // variavel para indicar o caminho para salvar o arquivo
        private string caminho = "";

        // MÉTODO INICIAL DA CLASSE 
        // É EXECUTADO SEMPRE QUE A JANELA É ABERTA.
        public Arquivo()
        {
            InitializeComponent();

            DialogoAbrir = new OpenFileDialog();
            DialogoAbrir.Filter = "txt|*.txt";
            DialogoAbrir.AddExtension = true;
            // Define o método que será executado quando pressionado OK na
            // janela Abrir Arquivo
            DialogoAbrir.FileOk += AbrirArquivoOk;

            DialogoSalvar = new SaveFileDialog();
            DialogoSalvar.Filter = "txt|*.txt";
            DialogoSalvar.AddExtension = true;
            // Define o método que será executado quando pressionado OK na
            // janela Salvar Arquivo
            DialogoSalvar.FileOk += SalvarArquivoOk;

        }

        #endregion


        #region ABRIR ARQUIVO

        // Método executado quando clicar no botão abrir
        private void Abrir_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                // Obtendo um resultado do messagebox
                MessageBoxResult res = MessageBox.Show("Deseja salvar o arquivo antes de sair?", "SAIR", MessageBoxButton.YesNoCancel);
                if (res == MessageBoxResult.Yes)
                {
                    // execute o método para salvar o arquivo e sai da janela.
                    SalvaArquivo();
                }
            }
            DialogoAbrir.ShowDialog();
        }

        // lê o texto do arquivo e atribui ao controle "Conteudo"
        private void AbrirArquivoOk(Object sender, System.ComponentModel.CancelEventArgs e)
        {

            try
            {

                // throw new System.ArgumentException("Parameter cannot be null", "original");

                NomeArquivo.Text = DialogoAbrir.FileName;
                caminho = DialogoAbrir.FileName;
                FileInfo info = new FileInfo(DialogoAbrir.FileName);
                TextReader reader = null;

                Conteudo.Text = "";

                reader = info.OpenText();

                // Lê linha a linha do arquivo e colocar ao controle "Conteudo.Text"

                string line = reader.ReadLine();
                while (line != null)
                {
                    Conteudo.Text += line;
                    line = reader.ReadLine();
                }
                flag = false;
                reader.Close(); // O SISTEMA OPERACIONAL LIBERA O ARQUIVO
            } 
            catch (Exception ex)
            {

            AppExceptionsTxt appex = new AppExceptionsTxt();
               appex.PathSaveFile = "";
               appex.SaveException(ex);
               MessageBox.Show(ex.Message);
            }
                    
        }
        #endregion


        #region EDIÇÃO DO TEXTO
        private void Conteudo_TextChanged(object sender, TextChangedEventArgs e)
        {
            Salvar.IsEnabled = true;
            SalvarComo.IsEnabled = true;
            flag = true;

        }
        #endregion


        #region SALVAR ARQUIVO
        private void Salvar_Click(object sender, RoutedEventArgs e)
        {
            SalvaArquivo();
        }

        private void SalvarComo_Click(object sender, RoutedEventArgs e)
        {
            DialogoSalvar.ShowDialog();
        }

        private void SalvarArquivoOk(Object sender, System.ComponentModel.CancelEventArgs e)
        {
            caminho = DialogoSalvar.FileName;
            SalvaArquivo();
        }

        private void Fechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Obtendo um resultado do messagebox
            MessageBoxResult res = MessageBox.Show("Deseja salvar o arquivo antes de sair?", "SAIR", MessageBoxButton.YesNoCancel);
            if (res == MessageBoxResult.Cancel)
            {
                // continua sem executar nenhuma ação
                e.Cancel = true;
            }
            else if (res == MessageBoxResult.Yes)
            {
                // execute o método para salvar o arquivo e sai da janela.
                SalvaArquivo();

            }
            else
            {
                // Clicado no "No", sai da janela sem salvar o arquivo.
            }
        }

        private void SalvaArquivo()
        {
            if (caminho.Trim() == "")
            {
                DialogoSalvar.ShowDialog();
            }
            else
            {
                // SALVA OS DADOS DA EDIÇÃO "CONTEUDO.TEXT" NO ARQUIVO 
                // INDICADO NO CAMINHO.
                File.WriteAllText(caminho, Conteudo.Text, Encoding.UTF8);
                flag = false;
                Salvar.IsEnabled = false;
                SalvarComo.IsEnabled = false;
                //caminho = "";
            }
        }

        #endregion

        #region LIMPAR LOG
        private void LimparLog_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(caminho, String.Empty);

        }
        #endregion

    }
}
