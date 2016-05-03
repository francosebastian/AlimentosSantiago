<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="VerPedidos.aspx.cs" Inherits="AlimentosSantiago.Web.Pedidos.VerPedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="panel-body">
                    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release"></asp:ScriptManager>
                    <telerik:RadGrid ID="RadGridPedidos" DataSourceID="efPedidos" AutoGenerateColumns="false"
                        runat="server" HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center">
                        <MasterTableView DataKeyNames="Id" CommandItemDisplay="None">
                            <NoRecordsTemplate>
                                No se han encontrado registros.
                            </NoRecordsTemplate>
                            <Columns>
                                <telerik:GridBoundColumn DataField="Cliente.Nombre" HeaderText="Usuario" ItemStyle-CssClass="text-uppercase"></telerik:GridBoundColumn>
                            </Columns>
                        </MasterTableView>
                    </telerik:RadGrid>
                    <ef:EntityDataSource ID="efPedidos" runat="server"
                        ContextTypeName="AlimentosSantiago.Dao.OracleDbContext"
                        EntitySetName="PedidoMenu"
                        Include="Cliente">
                    </ef:EntityDataSource>
      </div>
</asp:Content>
