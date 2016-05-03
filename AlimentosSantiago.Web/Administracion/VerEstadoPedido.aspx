<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="VerEstadoPedido.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.VerEstadoPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel-body">
        <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Auto"></asp:ScriptManager>
        <telerik:RadGrid ID="RadGridEstadoPedido" DataSourceID="efEstadoPedido" AutoGenerateColumns="false"  AllowPaging="True" AllowSorting="false"
            runat="server" AllowFilteringByColumn="false"
            HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center">
            <MasterTableView DataKeyNames="Id" CommandItemDisplay="None">
                <NoRecordsTemplate>
                    No se han encontrado registros.
                </NoRecordsTemplate>
                <Columns>
                    <telerik:GridBoundColumn DataField="Nombre" HeaderText="Nombre" ></telerik:GridBoundColumn>
                    <telerik:GridHyperLinkColumn DataTextFormatString="+"
                        DataNavigateUrlFields="Id" UniqueName="modificarEstadoPedido" DataNavigateUrlFormatString="../Administracion/ModificarEstadoPedido.aspx?id={0}"
                        HeaderText="Modificar" Text="Modificar" AllowFiltering="false" />
                    <telerik:GridHyperLinkColumn DataTextFormatString="+"
                        DataNavigateUrlFields="Id" UniqueName="eliminarEstadoPedido" DataNavigateUrlFormatString="../Administracion/EliminarEstadoPedido.aspx?id={0}"
                        HeaderText="Eliminar" Text="Eliminar" AllowFiltering="false" />
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
        <ef:EntityDataSource ID="efEstadoPedido" runat="server"
            ContextTypeName="AlimentosSantiago.Dao.OracleDbContext"
            EntitySetName="EstadoPedido">
        </ef:EntityDataSource>
    </div>
</asp:Content>
