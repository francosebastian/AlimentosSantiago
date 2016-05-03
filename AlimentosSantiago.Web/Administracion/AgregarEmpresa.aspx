<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="AgregarEmpresa.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.AgregarEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView ID="FvEmpresa" runat="server" ItemType="AlimentosSantiago.Dto.Empresa"
        DataKeyNames="Id" DefaultMode="Insert" InsertMethod="FvEmpresa_InsertItem"
        RenderOuterTable="false">
          <InsertItemTemplate>
             <h4>Nueva Empresa</h4>
              <asp:Label ID="lblNombre" runat="server">Nombre</asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" TextMode="SingleLine"
                            title="Ingrese nombre de estado pedido." placeholder="Ingrese estado Pedido"
                            myMaxLength="60" Text='<%# BindItem.Nombre %>' /><br />
                          <asp:CheckBox ID="chbDesabiilitado" runat="server" Text="Deshabilitado" AutoPostBack="false"
                            Checked="<%# BindItem.Deshabilitado %>" />
                
            <asp:Button runat="server" Text="Guardar" ID="btnGrabar" CommandName="Insert"/>
        </InsertItemTemplate>
    </asp:FormView>
</asp:Content>
