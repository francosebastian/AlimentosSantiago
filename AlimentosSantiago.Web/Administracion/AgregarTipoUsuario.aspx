<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="AgregarTipoUsuario.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.AgregarTipoUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:FormView ID="FvTipoUsuario" runat="server" ItemType="AlimentosSantiago.Dto.TipoUsuario"
        DataKeyNames="Id" DefaultMode="Insert" InsertMethod="FvTipoUsuario_InsertItem"
        RenderOuterTable="false">
          <InsertItemTemplate>
             <h4>Nueva Estado Pedido</h4>
              <asp:Label ID="lblNombre" runat="server">Nombre</asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" TextMode="SingleLine"
                            title="Ingrese tipo Usuario." placeholder="Ingrese Tipo Usuario"
                            myMaxLength="60" Text='<%# BindItem.Nombre %>' /><br />
                          <asp:TextBox ID="lblDescripcion" runat="server" TextMode="MultiLine"
                            title="Ingrese descripcion de tipo Usuario." placeholder="Ingrese tipo Usuario"
                            myMaxLength="60" Text='<%# BindItem.Descripcion %>' /><br />
                          <asp:CheckBox ID="chbDesabiilitado" runat="server" Text="Deshabilitado" AutoPostBack="false"
                            Checked="<%# BindItem.Deshabilitado %>" />
            <asp:Button runat="server" Text="Guardar" ID="btnGrabar" CommandName="Insert"/>
        </InsertItemTemplate>
    </asp:FormView>
</asp:Content>
