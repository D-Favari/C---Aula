using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    // String conexão com o banco de dados ADSDB.accdb
    string conexao = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
        HttpContext.Current.Server.MapPath("~/App_Data/ADSDB.accdb") + ";Persist Security Info=False;";
    // CLASSE PARA AS TRANSAÇÕES NO BANCO DE DADOS ACCESS
    AppDatabase.OleDBTransaction db = new AppDatabase.OleDBTransaction();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Entrar_Click(object sender, EventArgs e)
    {
        if (Email.Text.Trim() == "")
        {
            // exibe mensagem de erro
        }
        else
        {
            string sql = "SELECT * FROM Usuarios WHERE Email='" + Email.Text + "' AND Senha='" + Senha.Text + "'AND Status = 1;";

            db.ConnectionString = conexao;

            DataTable tb = (DataTable)db.Query(sql);
            if (tb.Rows.Count == 1)
            {
                // ENCONTROU O USUARIO NA TABELA
                Session["UsuarioID"] = tb.Rows[0]["UsuarioID"].ToString();
                Session["Nome"] = tb.Rows[0]["Nome"].ToString();

                // AUTENTICAÇÃO DO SISTEMA E LIBERAR PARA ACESSO A PASTA APP_ADMIN

                // Inicializa a classe de autenticação do usuario
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, Email.Text, DateTime.Now, DateTime.Now.AddMinutes(30), false, FormsAuthentication.FormsCookiePath);

                // Grava o ticket no cookie de autenticação
                Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket)));


                // Redireciona para a página do usuário
                Response.Redirect(FormsAuthentication.GetRedirectUrl(Email.Text, false));
            }
            else
            {
                // NÃO ENCONTROU O USUARIO NA TABELA
                // EXIBE MENSAGEM DE FALHA
            }
        }
    }
}