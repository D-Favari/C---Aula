<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FaleConosco.aspx.cs" Inherits="FaleConosco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">




    <div class="content-wrapper padding-top-40px">

        <div class="container-col">
            <!--FORUMALÁRIO DE ENTRADA-->
            <div class="col-2 box border box-border background-grey" id="Entrada" runat="server">

                <h1>Fale Conosco</h1>
                <br />
                <br />
                SEU NOME
                <br />
                <asp:TextBox ID="Nome" runat="server"></asp:TextBox>
                EMAIL
                <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                MENSAGEM
                <br />
                <asp:TextBox ID="Mensagem" runat="server"></asp:TextBox>

                <asp:Button ID="Enviar" runat="server" onClick="Enviar_Click" Text="Enviar" />
                <br />
                <br />
            </div>
  
                <div class="col-2 background-grey">

                    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3679.6892379511087!2d-47.35033390000004!3d-22.739789199999997!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94c89bea5cdb94f9%3A0xffb368bd91ea12ae!2sFatec+Americana!5e0!3m2!1spt-BR!2sbr!4v1526565654211" width="600" height="450" frameborder="0" style="border:0" allowfullscreen></iframe>
                    
                </div>
                </div>

        
        
          </div>


</asp:Content>

