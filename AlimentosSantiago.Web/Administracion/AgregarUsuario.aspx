<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.AgregarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView ID="FvUsuario" runat="server" ItemType="AlimentosSantiago.Dto.Usuario"
        DataKeyNames="Id" DefaultMode="Insert" InsertMethod="FvUsuario_InsertItem"
        RenderOuterTable="false">
        <InsertItemTemplate>
            <h4>Nuevo Usuario</h4>
            <asp:Label ID="lblNombre" runat="server">Nombre</asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" TextMode="SingleLine"
                title="Ingrese Nombre Usuario." placeholder="Ingrese Nombre Usuario"
                myMaxLength="60" Text='<%# BindItem.Nombre %>' /><br />
            <asp:Label ID="lblApellido" runat="server">Apellido</asp:Label>
            <asp:TextBox ID="txtApellido" runat="server" TextMode="SingleLine"
                title="Ingrese apellido Usuario." placeholder="Ingrese apellido Usuario"
                myMaxLength="60" Text='<%# BindItem.Apellido %>' /><br />
            <asp:Label ID="lblTelefono1" runat="server">Telefono Fijo</asp:Label>
            <asp:TextBox ID="txtTelefono1" runat="server" TextMode="Phone"
                title="Ingrese fijo Usuario." placeholder="Ingrese telefono fijo Usuario"
                myMaxLength="60" Text='<%# BindItem.Telefono %>' /><br />
            <asp:Label ID="lblTelefono2" runat="server">Telefono Movil</asp:Label>
            <asp:TextBox ID="txtTelefono2" runat="server" TextMode="Phone"
                title="Ingrese movil Usuario." placeholder="Ingrese telefono movil Usuario"
                myMaxLength="60" Text='<%# BindItem.Telefono2 %>' /><br />
              <asp:Label ID="lblEmail" runat="server">Email</asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"
                title="Ingrese Email Usuario." placeholder="Ingrese Email Usuario"
                myMaxLength="60" Text='<%# BindItem.Email %>' /><br />
            <asp:Label ID="lblTipoUsuario" runat="server">Tipo Usuario</asp:Label>
            <asp:DropDownList ID="ddlTipoUsuario" runat="server"
                DataSourceID="efTipoUsuario" DataTextField="Nombre" DataValueField="Id" SelectedValue='<%# BindItem.TipoUsuarioId %>'
                AppendDataBoundItems="true">
                <asp:ListItem Value="" Text="Seleccionar"></asp:ListItem>
            </asp:DropDownList><br />
                 <ef:EntityDataSource ID="efTipoUsuario" runat="server"
                                                        ContextTypeName="AlimentosSantiago.Dao.OracleDbContext"
                                                        EntitySetName="TipoUsuario"
                                                        Select="it.Id,it.Nombre">
                                                    </ef:EntityDataSource>
            <asp:Label ID="lblDeshabilitado" runat="server">Deshabilitado</asp:Label>
            <asp:CheckBox ID="chbDeshabilitado" runat="server" Text="Deshabilitado" AutoPostBack="false"
                Checked="<%# BindItem.Deshabilitado %>" />
            <asp:Button runat="server" Text="Guardar" ID="btnGrabar" CommandName="Insert" />
        </InsertItemTemplate>
    </asp:FormView>
</asp:Content>
