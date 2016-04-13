<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="EliminarUsuario.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.EliminarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:FormView ID="FvUsuario" runat="server" ItemType="AlimentosSantiago.Dto.Usuario"
        DataKeyNames="Id" DefaultMode="ReadOnly" DeleteMethod="FvUsuario_DeleteItem" SelectMethod="FvUsuario_GetItem"
        RenderOuterTable="false">
        <ItemTemplate>
             <h4>Eliminar Usuario</h4>
              <asp:Label ID="lblNombre" runat="server">Nombre</asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" TextMode="SingleLine"
                            title="Ingrese Email." placeholder="Ingrese su nombre"
                            myMaxLength="60" Text='<%# BindItem.Nombre %>' /><br />
             <asp:Label ID="lblEmail" runat="server">Email</asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"
                            title="Ingrese Email." placeholder="Ingrese su email"
                            myMaxLength="60" Text='<%# BindItem.Email %>' />
            <asp:Label ID="lblPassword" runat="server">Password</asp:Label>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"
                            title="Ingrese Password." placeholder="Ingrese su Password"
                            myMaxLength="60" Text='<%# BindItem.Password %>' />
            <asp:Button runat="server" Text="Eliminar" ID="btnGrabar" CommandName="Delete"/>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
