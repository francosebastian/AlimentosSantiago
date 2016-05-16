<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="VerCategoriaPlatos.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.VerCategoriaPlatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                               <div id="heading">
                            <div class="container">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="heading-content">
                                            <h2>CATEGORIA DE PLATOS</h2>
                                            <span><a href="../MenuPrincipal.aspx">Menu /</a><a href="../MenuPrincipal.aspx">Volver</a></span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
     <div class="panel-body">
        <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Auto"></asp:ScriptManager>
        <telerik:RadGrid ID="RadGridCategoriaPlato" DataSourceID="efCategoriaPlato" AutoGenerateColumns="false"  AllowPaging="True" AllowSorting="false"
            runat="server" AllowFilteringByColumn="false"
            HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center">
            <MasterTableView DataKeyNames="Id" CommandItemDisplay="None">
                <NoRecordsTemplate>
                    No se han encontrado registros.
                </NoRecordsTemplate>
                <Columns>
                    <telerik:GridBoundColumn DataField="Nombre" HeaderText="Nombre" ></telerik:GridBoundColumn>
                    <telerik:GridHyperLinkColumn DataTextFormatString="+"
                        DataNavigateUrlFields="Id" UniqueName="modificarCategoriaPlato" DataNavigateUrlFormatString="../Administracion/ModificarCategoriaPlato.aspx?id={0}"
                        HeaderText="Modificar" Text="Modificar" AllowFiltering="false" />
                    <telerik:GridHyperLinkColumn DataTextFormatString="+"
                        DataNavigateUrlFields="Id" UniqueName="EliminarCategoriaPlato" DataNavigateUrlFormatString="../Administracion/EliminarCategoriaPlato.aspx?id={0}"
                        HeaderText="Eliminar" Text="Eliminar" AllowFiltering="false" />
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
        <ef:EntityDataSource ID="efCategoriaPlato" runat="server"
            ContextTypeName="AlimentosSantiago.Dao.OracleDbContext"
            EntitySetName="CategoriaPlato">
        </ef:EntityDataSource>
    </div>
</asp:Content>
