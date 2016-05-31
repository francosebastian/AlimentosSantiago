<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="MiEmpresa.aspx.cs" Inherits="AlimentosSantiago.Web.AdministracionEmpresa.MiEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
              <div id="heading">
                            <div class="container">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="heading-content">
                                            <h2>Mi empresa</h2>
                                            <span><a href="../MenuPrincipal.aspx">Menu</a></span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
    <div class="panel-body">
        <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Auto"></asp:ScriptManager>
        <telerik:RadGrid ID="RadGridUsuarios" DataSourceID="efUsuarios" AutoGenerateColumns="false" AllowPaging="True" AllowSorting="false"
            runat="server" AllowFilteringByColumn="false"
            HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center">
            <MasterTableView DataKeyNames="Id" CommandItemDisplay="None">
                <NoRecordsTemplate>
                    No se han encontrado registros.
                </NoRecordsTemplate>
                <Columns>
                    <telerik:GridBoundColumn DataField="Nombre" HeaderText="Nombre"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="Email" HeaderText="Tipo Usuario" ItemStyle-CssClass="text-uppercase"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="TipoUsuario.Nombre" HeaderText="Tipo Usuario" ItemStyle-CssClass="text-uppercase"></telerik:GridBoundColumn>
                    <telerik:GridHyperLinkColumn DataTextFormatString="+"
                        DataNavigateUrlFields="Id" UniqueName="modificarUsuaro" DataNavigateUrlFormatString="../Administracion/ModificarUsuario.aspx?id={0}"
                        HeaderText="Modificar" Text="Modificar" AllowFiltering="false" />
                    <telerik:GridHyperLinkColumn DataTextFormatString="+"
                        DataNavigateUrlFields="Id" UniqueName="modificarUsuaro" DataNavigateUrlFormatString="../Administracion/EliminarUsuario.aspx?id={0}"
                        HeaderText="Eliminar" Text="Eliminar" AllowFiltering="false" />
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
        <ef:EntityDataSource ID="efUsuarios" runat="server"
            ContextTypeName="AlimentosSantiago.Dao.OracleDbContext"
            EntitySetName="Usuario" Include="TipoUsuario">
        </ef:EntityDataSource>
    </div>
</asp:Content>
