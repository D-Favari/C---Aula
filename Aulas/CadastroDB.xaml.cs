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
    /// Interaction logic for CadastroDB.xaml
    /// </summary>
    public partial class CadastroDB : Window
    {
        public CadastroDB()
        {
            InitializeComponent();
        }

        private void Gravar_Click(object sender, RoutedEventArgs e)
        {
            // VALIDAR OS CAMPOS DIGITADOS;

            if (Nome.Text.Trim() == "")
            {

                Mensagem.Content = "O nome deve ser digitado";
                //MessageBox.Show("O nome deve ser digitado"); 

            }
            else if (Email.Text.Trim() == "")
            {
                Mensagem.Content = "O email deve ser digitado";

            }
            else
            {
                /******************************************************************************
                 *
                 * PROCESSA A GRAVAÇÃO DO REGISTRO NO BANCO DE DADOS
                 * PASSO 1: DEFINE A STRING DE CONEXÃO COM O BANCO DE DADOS 
                 * Referência: https://www.connectionstrings.com/mysql/
                 * 
                 * Server=myServerAddress;Database=myDataBase;
                   Uid=myUsername;Pwd=myPassword;
                 * mServerAddress: endereço do servidor
                 * myDataBase: nome do banco de dados
                 * Uid: Nome do usuário (localhost)
                 * Pws: Senha do usuário (nenhuma)
                 * 
                 *  
                 * 
                 * PASSO 2: Define a string de comando SQL;
                 * PASSO 3: Conecta ao banco de dados
                 * PASSO 4: Envia a string com o comando SQL;
                 * PASSO 5: Obtém i rsultado da da consulta:
                 *          Resultado para um DataTable se o comando SELECT
                 *          ou Verifica o número de linhas afetadas se INSERT,
                 *          UPDATE ou DELETE.
                 * 
                 ******************************************************************************/

                // PASSO 1: 
                String conexao = "Server = 127.0.0.1; Database = Cadastro;Uid = root; Pwd =;";

                // PASSO 2:
                string comando = "INSERT INTO Clientes(nome,email,telefone) VALUES ('" + Nome.Text + "','" + Email.Text + "','" + Telefone.Text + "');";
                // O ClienteID não é adicionado na linha acima pois é um auto incremento, o próprio banco
                // de dados se encarregará de adicioná-lo

                // PASSO 3:
                // cria uma instancia da classe de transação no banco de dados;
                AppDatabase.MySqlTransaction db = new AppDatabase.MySqlTransaction();
                // conexão
                db.ConnectionString = conexao;

                // PASSO 4:
                int n = (int)db.Query(comando); // Caso ocorrá algum erro, o mesmo será apontado aqui, 
                // pois essa é a linha que executará o comando no banco de dados. É provavel que o erro esteja no PASSO 2, entretanto.

                if(n == 0)
                {
                    MessageBox.Show("Houve uma falha na gravação.");
                }else
                {
                    MessageBox.Show("Registro gravado com sucesso.");
                }

            }



        }

            private void Fechar_Click(object sender, RoutedEventArgs e)
            {
                this.Close();
            }

        }


    }

