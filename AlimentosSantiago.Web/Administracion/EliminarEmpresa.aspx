<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="EliminarEmpresa.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.EliminarEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <asp:FormView ID="FvEmpresa" runat="server" ItemType="AlimentosSantiago.Dto.Empresa"
        DataKeyNames="Id" DefaultMode="ReadOnly" DeleteMethod="FvEmpresa_DeleteItem" SelectMethod="FvEmpresa_GetItem"
        RenderOuterTable="false">
        <ItemTemplate>
            <h4>Eliminar Empresa</h4>
            <asp:TextBox ID="txtNombre" runat="server" TextMode="SingleLine"
                title="Ingrese nombre de estado pedido." placeholder="Ingrese categoria Plato"
                myMaxLength="60" Text='<%# BindItem.Nombre %>' /><br />
            <asp:CheckBox ID="chbDesabiilitado" runat="server" Text="Deshabilitado" AutoPostBack="false"
                Checked="<%# BindItem.Deshabilitado %>" />
            <asp:Button runat="server" Text="Guardar" ID="btnGrabar" CommandName="Delete" />
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
