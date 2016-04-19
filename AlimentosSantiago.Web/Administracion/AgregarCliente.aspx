<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="AgregarCliente.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.AgregarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView ID="FvCliente" runat="server" ItemType="AlimentosSantiago.Dto.Cliente"
        DataKeyNames="Id" DefaultMode="Insert" InsertMethod="FvCliente_InsertItem"
        RenderOuterTable="false">

 <InsertItemTemplate>
             <h4>Nuevo Cliente</h4>
              <asp:Label ID="lblUsuario" runat="server">Usuario</asp:Label>
                        <asp:TextBox ID="txtUsuario" runat="server" TextMode="SingleLine"
                            title="Ingrese Nombre Cliente." placeholder="Ingrese  nombre Cliente "
                            myMaxLength="60" Text='<%# BindItem.Usuario %>' /><br />
             <asp:Label ID="lblSaldo" runat="server">Saldo</asp:Label>
                        <asp:TextBox ID="txtSaldo" runat="server" TextMode="SingleLine"
                            title="Ingrese Saldo del cliente." placeholder="Ingrese Saldo del cliente"
                            myMaxLength="60" Text='<%# BindItem.Saldo %>' />
            <asp:Label ID="lblEmpresaId" runat="server">Empresa</asp:Label>
                        <asp:TextBox ID="txtEmpresaId" runat="server" TextMode="SingleLine"
                            title="Ingrese ID Empresa del cliente." placeholder="Ingrese  ID Empresa del cliente"
                            myMaxLength="60" Text='<%# BindItem.EmpresaId %>' />
         <asp:Label ID="LblTelefono" runat="server">Empresa</asp:Label>
                        <asp:TextBox ID="TexTelefono" runat="server" TextMode="SingleLine"
                            title="Ingrese Telefono del cliente." placeholder="Ingrese Telefono del cliente"
                            myMaxLength="60" Text='<%# BindItem.Telefono %>' />
  
            <asp:Button runat="server" Text="Guardar" ID="btnGrabar" CommandName="Insert"/>
        </InsertItemTemplate>
    </asp:FormView>
</asp:Content>
