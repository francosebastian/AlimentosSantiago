<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="EliminarCategoriaPlato.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.EliminarCategoriaPlato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView ID="FvCategoriaPlato" runat="server" ItemType="AlimentosSantiago.Dto.CategoriaPlato"
        DataKeyNames="Id" DefaultMode="ReadOnly" DeleteMethod="FvCategoriaPlato_DeleteItem" SelectMethod="FvCategoriaPlato_GetItem"
        RenderOuterTable="false">
        <ItemTemplate>
            <h4>Eliminar Categoria Plato</h4>
            <asp:TextBox ID="txtNombre" runat="server" TextMode="SingleLine"
                title="Ingrese nombre de estado pedido." placeholder="Ingrese categoria Plato"
                myMaxLength="60" Text='<%# BindItem.Nombre %>' /><br />
            <asp:TextBox ID="lblDescripcion" runat="server" TextMode="MultiLine"
                title="Ingrese descripcion de estado pedido." placeholder="Ingrese descripcion Plato"
                myMaxLength="60" Text='<%# BindItem.Descripcion %>' /><br />
            <asp:CheckBox ID="chbDesabiilitado" runat="server" Text="Deshabilitado" AutoPostBack="false"
                Checked="<%# BindItem.Deshabilitado %>" />
            <asp:Button runat="server" Text="Guardar" ID="btnGrabar" CommandName="Delete" />
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
