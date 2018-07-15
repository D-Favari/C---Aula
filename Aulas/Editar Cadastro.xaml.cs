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
using System.Data;

namespace Aulas
{
    /// <summary>
    /// Interaction logic for Editar_Cadastro.xaml
    /// </summary>
    public partial class Editar_Cadastro : Window
    {
        public Editar_Cadastro()
        {
            InitializeComponent();
            LoadClientes();
        }
        string comando;
        // String de conexão
        String conexao = "Server = 127.0.0.1; Database = Cadastro;Uid = root; Pwd =;";
        // cria uma instancia da classe de transação no banco de dados;
        AppDatabase.MySqlTransaction db = new AppDatabase.MySqlTransaction();

        // Controla a edição
        bool flag = false;
        // 


        // CARREGA O COMBOBOX COM OS CLIENTES
        private void LoadClientes()
        {
            string comando = "Select ClienteID, Nome FROM Clientes ORDER BY Nome;";

            db.ConnectionString = conexao;
            DataTable tb = (DataTable)db.Query(comando);

            Selecionar.Items.Clear();
            for (int i = 0; i <= tb.Rows.Count - 1; i++)
            {

                ComboBoxItem item = new ComboBoxItem();
                item.Content = tb.Rows[i]["Nome"].ToString();
                item.ToolTip = tb.Rows[i]["ClienteId"].ToString();
                Selecionar.Items.Add(item);
            }
            Excluir.IsEnabled = false;
        }


        private void Salvar_Click(object sender, RoutedEventArgs e)
        {
            if (Nome.Text.Trim() == "")
            {
                Mensagem.Content = "O nome deve ser digitado";
            }
            else if (Email.Text.Trim() == "")
            {
                Mensagem.Content = "O email deve ser digitado";
            }
            else
            {
                string conexao = "Server=127.0.0.1;Database=Cadastro;Uid=root;Pwd=;";
                ComboBoxItem item = (ComboBoxItem)Selecionar.SelectedItem; // NECESSÁRIO PARA PEGAR O ID DO ITEM SELECIONADO
                comando = "UPDATE clientes SET Nome ='" + Nome.Text + "',Email='" + Email.Text + "',Telefone='" + Telefone.Text + "' WHERE ClienteID = " + item.ToolTip + ";";
                // "WHERE ClienteID = " + item.ToolTip + ";"; ISSO COMPARA O ID DO BANCO DE DADOS COM O ID DO ITEM DA COMBOBOX

                db.ConnectionString = conexao;

                int m = (int)db.Query(comando);
                if (m == 0)
                {
                    MessageBox.Show("Houve uma falha na alteraçao");
                }
                else
                {
                    MessageBox.Show("Alterado com sucesso");
                }
                Limpar();
                LoadClientes();
            }
        }

        private void SelectItems()
        {
            ComboBoxItem item = (ComboBoxItem)Selecionar.SelectedItem;
            string conexao = "Server=127.0.0.1;Database=Cadastro;Uid=root;Pwd=;";
            db.ConnectionString = conexao;

            comando = "SELECT * FROM Clientes WHERE ClienteID=" + item.ToolTip + ";";
            DataTable tb = (DataTable)db.Query(comando);

            Nome.Text = tb.Rows[0]["Nome"].ToString();
            Email.Text = tb.Rows[0]["Email"].ToString();
            Telefone.Text = tb.Rows[0]["Telefone"].ToString();

            Excluir.IsEnabled = true;
            flag = false;
        }

        private void Excluir_Click(object sender, RoutedEventArgs e)
        {

            // ADICIONAR UMA CAIXA DE DIALOGO, PERGUNTANDO SE O USUÁRIO TEM CERTEZA QUE DESEJA EXCLUIR O ITEM SELECIONADO

            ComboBoxItem item = (ComboBoxItem)Selecionar.SelectedItem;
            //string conexao = "Server=127.0.0.1;Database=Cadastro;Uid=root;Pwd=;";
            db.ConnectionString = conexao;

            comando = "DELETE FROM clientes WHERE ClienteID = " + item.ToolTip + ";";

            int d = (int)db.Query(comando);
            // 3 - Executar o comando
            if (d == 0)
            {
                MessageBox.Show("Houve uma falha na exclusão");
            }
            else
            {
                MessageBox.Show("Excluido com sucesso");
            }

            Limpar();
            LoadClientes();
        }

        private void Limpar()
        {
            Selecionar.ToolTip = "";
            Nome.Text = "";
            Email.Text = "";
            Telefone.Text = "";
        }

        private void Buscar_Click(object sender, RoutedEventArgs e)
        {
            SelectItems();
        }

        private void Fechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Changed(object sender, TextChangedEventArgs e)
        {
            flag = true;
        }
    }
}