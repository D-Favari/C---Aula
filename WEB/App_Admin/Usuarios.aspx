<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Usuarios.aspx.cs" Inherits="App_Admin_Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

<div class="content-wrapper padding-top-40px">

        <div class="container-col">
            <!--FORUMALÁRIO DE ENTRADA-->
            <div class="col-2 box-border background-grey" id="Entrada" runat="server">

                <h1>Formulario</h1>
                <br />
                <br />
                NOME
                <br />
                <asp:TextBox ID="Nome" runat="server"></asp:TextBox>
                EMAIL
                <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                SENHA
                <br />
                <asp:TextBox ID="Senha" runat="server"></asp:TextBox>

                <asp:Button ID="Salvar" runat="server" Text="Salvar" OnClick="Salvar_Click" />
                <br />
                <br />
                <asp:Button ID="Excluir" OnClick="Excluir_Click" Enabled="false" runat="server" Text="Excluir" />
            </div>

            <div class="col-2 box-border">
                <asp:GridView ID="ListaUsuarios" AutoGenerateColumns="true" AutoGenerateSelectButton="true" CellPadding="8" HeaderStyle-BackColor="#dfdfdf" runat="server" OnSelectedIndexChanged="ListaUsuarios_SelectedIndexChanged"></asp:GridView>

            </div>
  
              
        </div>

        
        
</div>