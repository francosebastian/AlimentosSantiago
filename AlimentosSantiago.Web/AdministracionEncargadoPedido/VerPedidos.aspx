<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="VerPedidos.aspx.cs" Inherits="AlimentosSantiago.Web.AdministracionEncargadoPedido.VerPedidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel-body">
        <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release"></asp:ScriptManager>
        <telerik:RadGrid ID="RadGridPedidos" AutoGenerateColumns="false" DataSourceID="efPedidos"
            runat="server" HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center">
            <MasterTableView DataKeyNames="Id" CommandItemDisplay="None">
                <NoRecordsTemplate>
                    No se han encontrado registros.
                </NoRecordsTemplate>
                <Columns>
                    <telerik:GridBoundColumn DataField="Id" HeaderText="Id Pedido" ItemStyle-CssClass="text-uppercase"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="Fecha" HeaderText="Fecha" ItemStyle-CssClass="text-uppercase"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="EstadoPedido.Nombre" HeaderText="Estado" UniqueName="EstadoPedido" ItemStyle-CssClass="text-uppercase"></telerik:GridBoundColumn>
                    <telerik:GridHyperLinkColumn DataTextFormatString="+" DataNavigateUrlFields="Id" UniqueName="VerPedido"
                        DataNavigateUrlFormatString="../AdministracionEncargadoPedido/VerPedido.aspx?id={0}"
                        HeaderText="Ver Pedido" Text="+" AllowFiltering="false" />
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
        <ef:EntityDataSource ID="efPedidos" runat="server"
            ContextTypeName="AlimentosSantiago.Dao.OracleDbContext"
            EntitySetName="PedidoMenu" Include="LogsPedidoMenu, EstadoPedido" Where="it.Eliminado = false and it.EstadoPedidoId = @IdEstadoPedido">
            <WhereParameters>
                <asp:Parameter Name="IdEstadoPedido" Type="Int32" />
            </WhereParameters>
        </ef:EntityDataSource>
    </div>
</asp:Content>
