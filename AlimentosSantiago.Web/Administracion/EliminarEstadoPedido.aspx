<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="EliminarEstadoPedido.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.EliminarEstadoPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:FormView ID="FvEstadoPedido" runat="server" ItemType="AlimentosSantiago.Dto.EstadoPedido"
        DataKeyNames="Id" DefaultMode="ReadOnly" DeleteMethod="FvEstadoPedido_DeleteItem" SelectMethod="FvEstadoPedido_GetItem"
        RenderOuterTable="false">
          <ItemTemplate>
             <h4>Eliminar Estado Pedido</h4>
                   <h4>Modificar Estado Pedido</h4>
                          <asp:TextBox ID="txtNombre" runat="server" TextMode="SingleLine"
                            title="Ingrese nombre de estado pedido." placeholder="Ingrese estado Pedido"
                            myMaxLength="60" Text='<%# BindItem.Nombre %>' /><br />
                          <asp:TextBox ID="lblDescripcion" runat="server" TextMode="MultiLine"
                            title="Ingrese descripcion de estado pedido." placeholder="Ingrese estado Pedido"
                            myMaxLength="60" Text='<%# BindItem.Descripcion %>' /><br />
                          <asp:CheckBox ID="chbDesabiilitado" runat="server" Text="Deshabilitado" OnCheckedChanged="chbDesabiilitado_CheckedChanged" AutoPostBack="false"
                            Checked="<%# BindItem.Deshabilitado %>" />
            <asp:Button runat="server" Text="Guardar" ID="btnGrabar" CommandName="Delete"/>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
