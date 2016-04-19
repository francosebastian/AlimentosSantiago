<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="EliminarPlato.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.EliminarPlato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:FormView ID="FvPlato" runat="server" ItemType="AlimentosSantiago.Dto.Plato"
        DataKeyNames="Id" DefaultMode="ReadOnly" DeleteMethod="FvPlato_DeleteItem" SelectMethod="FvPlato_GetItem"
        RenderOuterTable="false">
        <ItemTemplate>
             <h4>Eliminar  Plato</h4>
              <asp:Label ID="lblNombre" runat="server">Nombre</asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" TextMode="SingleLine"
                            title="Ingrese Nombre del plato." placeholder="Ingrese  nombre del plato "
                            myMaxLength="60" Text='<%# BindItem.Nombre %>' /><br />
             <asp:Label ID="lblPrecio" runat="server">Precio</asp:Label>
                        <asp:TextBox ID="txtPrecio" runat="server" TextMode="SingleLine"
                            title="Ingrese Precio del plato." placeholder="Ingrese Precio del plato"
                            myMaxLength="60" Text='<%# BindItem.Precio %>' />
            <asp:Label ID="lblDescripcion" runat="server">Descripcion</asp:Label>
                        <asp:TextBox ID="txtDescripcion" runat="server" TextMode="SingleLine"
                            title="Ingrese descripcion del plato." placeholder="Ingrese  descripcion del plato"
                            myMaxLength="60" Text='<%# BindItem.Descripcion %>' />
         <asp:Label ID="lblCodigo" runat="server">Codigo</asp:Label>
                        <asp:TextBox ID="TexCodigo" runat="server" TextMode="SingleLine"
                            title="Ingrese codigo del plato." placeholder="Ingrese codigo del plato"
                            myMaxLength="60" Text='<%# BindItem.Codigo %>' />
   <asp:Label ID="lblTiemprePreparacion" runat="server">TiempoPreparacion</asp:Label>
                        <asp:TextBox ID="TextTiempoPreparacion" runat="server" TextMode="SingleLine"
                            title="Ingrese el tiempo de preparacion." placeholder="Ingrese el tiempo de preparacion"
                            myMaxLength="60" Text='<%# BindItem.TiempoPreparacion %>' />
   <asp:Label ID="lblProveedor" runat="server">IDproveedor</asp:Label>
                        <asp:TextBox ID="TextProveedorId" runat="server" TextMode="SingleLine"
                            title="Ingrese el ID del proveedor." placeholder="Ingrese el ID del proveedor"
                            myMaxLength="60" Text='<%# BindItem.ProveedorId %>' />

                 <asp:Button runat="server" Text="Eliminar" ID="btnGrabar" CommandName="Delete"/>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>