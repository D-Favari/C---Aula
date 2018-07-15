using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class App_Admin_Usuarios : System.Web.UI.Page
{

    // string de conexão com o banco de dados
    string conexao = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Souce=" + HttpContext.Current.Server.MapPath("~/App_data/ADSDB.accdb") + ";Persist Security Info=False;";

    // CLASSE PARA AS TRANSAÇÕES NO BANCO DE DADOS ACCESS 
    AppDatabase.OleDBTransaction db = new AppDatabase.OleDBTransaction();


    protected void Page_Load(object sender, EventArgs e)
    {
        // Carrega os usuários quando a página é chamada pela primeira vez
        if (!IsPostBack) LoadUsuarios();
    }

    protected void LoadUsuarios()
    {
        string sql = "SELECT user_id,Nome,Email FROM USUARIOS WHERE Status=1 ORDER BY Nome";

        db = new ConexaoDataBase().GetConnection();
        DataTable tb = (DataTable)db.Query(sql);
        // Carrega os dados da consulta no gridview
        ListaUsuarios.DataSouce = tb;
        ListaUsuarios.DataBind();
    }

    protected void Salvar_Click(object sender, EventArgs e)
    {
        // validação de entradas
        if (Nome.Text.Trim() == "")
        {
            // exibe a mensagem de erro
        }
        else
        {



            if (user_id.Value != "")
            {
                sql= "UPDATE USUARIOS SET Nome='"+Nome.Text+"',Email='"+Email.Text+"',Senha='"+Senha.Text + "'Date_Time_Update=Now() WHERE user_id="+user_id.Value+";";
            }
            else
            {
                string sql = "INSERT INTO Usuarios(Nome,Email,Senha,Date_Time_Insert, Data_Time_Update, Status, user_id)VALUES('" + Nome.Text + "','" + Email.Text + "','" + Senha.Text + "','" + DateTime.UtcNow.ToString() + "','" + DateTime.UtcNow.ToString() + "',1," + Session["usuario_id"].ToString() + ");";
            }

            
            // grava registro
            string sql = "INSERT INTO Usuarios(Nome,Email,Senha,Date_Time_Insert, Data_Time_Update, Status, user_id)VALUES('" + Nome.Text + "','" + Email.Text + "','" + Senha.Text + "','" + DateTime.UtcNow.ToString() + "','" + DateTime.UtcNow.ToString() + "',1," + Session["usuario_id"].ToString() + ");";

            db = new ConexaoDataBase().GetConnection();
            db.Query(sql);

        }
    }


    protected void ListaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
    {
        user_id.Value = ListaUsuarios.SelectedRow.Cells[1].Text;

        string sql = "SELECT * FROM Usuarios where user_id=" + user_id.Value + " AND Status=1;";

        db = new ConexaoDataBase().GetConnection();
        DataTable tb = (DataTable).db.Query(sql);

        // verifica se o registro foi encotrado na tabela
        if(tb.Rows.Count == 1)
        {
            Nome.Text = tb.Rows[0]["Nome"].ToString();
            Email.Text = tb.Rows[0]["Email"].ToString();
            Senha.Text = tb.Rows[0]["Senha"].ToString();
            //habilita o botao excluir
            Excluir.Enable=True
        }
        else
        {
            Msg.Text = "Usuarios não encontrado";
        }

    }


    protected void Excluir_Click(object sender, EventArgs e)
    {
       //  string sql = "UPDATE Usuarios WHERE user_id="+user_id.VALUE
    }
}