<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

<div class="content-wrapper padding-top-40px">

        <div class="container-col">
            <!--FORUMALÁRIO DE ENTRADA-->
            <div class="col-2 box-border background-grey" runat="server">
                <asp:HiddenField />
                <h1>Formulario</h1>
                <br />
                <asp:TextBox ID="Msg" forecolor="Yellow" visible="false" runat="server"></asp:TextBox>
                <br />
                NOME
                <br />
                <asp:TextBox ID="Nome" runat="server"></asp:TextBox>
                EMAIL

                <br />
                EMAIL
                <br />
                <asp:TextBox ID="Email" runat="server"></asp:TextBox>

                SENHA
                <br />
                <asp:TextBox ID="Senha" TextMode="Password" runat="server"></asp:TextBox>

                <asp:Button ID="Entrar" runat="server" Text="Entrar" onClick="Entrar_Click"/>
                <br />
                <br />
            </div>
  
              
