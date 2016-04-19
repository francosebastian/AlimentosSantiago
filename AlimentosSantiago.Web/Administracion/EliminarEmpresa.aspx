<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="EliminarEmpresa.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.EliminarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:FormView ID="FvEmpresa" runat="server" ItemType="AlimentosSantiago.Dto.Empresa"
        DataKeyNames="Id" DefaultMode="ReadOnly" DeleteMethod="" SelectMethod=""
        RenderOuterTable="false">
        <ItemTemplate>

              <h4>Eliminar Empresa</h4>
              <asp:Label ID="lblNombre" runat="server">Nombre</asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" TextMode="SingleLine"
                            title="Ingrese nombre de empresa." placeholder="Ingrese su nombre"
                            myMaxLength="60" Text='<%# BindItem.Nombre %>' /><br />
              <asp:Button runat="server" Text="Eliminar" ID="btnGrabar" CommandName="Delete"/>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
  