using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ConexaoDataBase
/// </summary>
public class ConexaoDataBase
{
    private string conexao;
    private AppDatabase.OleDBTransaction db;


    /// <summary>
    /// Faz a conexão com o banco de dados
    /// </summary>
    public ConexaoDataBase()
    {
        // stromg conexão com o banco de dados ADSDB.accdb
        string conexao = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
    HttpContext.Current.Server.MapPath("~/App_Data/ADSDB.accdb") + ";Persist Security Info=False;";

    }

    /// <sumary>
    /// Retorna uma instancia da classe de transação conectada com o banco de dados
    /// </sumary>
    /// <returns></returns>
    /// 
    public AppDatabase.OleDBTransaction GetConnection()
    {
        db = new AppDatabase.OleDBTransaction();
        db.ConnectionString = conexao;
        return db;
    }


}