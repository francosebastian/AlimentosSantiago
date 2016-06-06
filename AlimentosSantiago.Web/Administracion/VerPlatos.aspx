  <%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="VerUsuarios.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.VerUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <div id="heading">
                            <div class="container">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="heading-content">
                                            <h2>PLATOS</h2>
                                            <span><a href="../MenuPrincipal.aspx">Menu</a></span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
    <div class="panel-body">
        <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Auto"></asp:ScriptManager>
        <telerik:RadGrid ID="RadGridPlatos" DataSourceID="efPlatos" AutoGenerateColumns="false" AllowPaging="True" AllowSorting="false"
            runat="server" AllowFilteringByColumn="false"
            HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center">
            <MasterTableView DataKeyNames="Id" CommandItemDisplay="None">
                <NoRecordsTemplate>
                    No se han encontrado registros.
                </NoRecordsTemplate>
                <Columns>
                    <telerik:GridBoundColumn DataField="Nombre" HeaderText="Nombre"></telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="CategoriaPlato.Nombre" HeaderText="Categoria" ItemStyle-CssClass="text-uppercase"></telerik:GridBoundColumn>
    
                    <telerik:GridHyperLinkColumn DataTextFormatString="+"
                        DataNavigateUrlFields="Id" UniqueName="modificarPlato" DataNavigateUrlFormatString="../Administracion/ModificarPlato.aspx?id={0}"
                        HeaderText="Modificar" Text="Modificar" AllowFiltering="false" />
                    <telerik:GridHyperLinkColumn DataTextFormatString="+"
                        DataNavigateUrlFields="Id" UniqueName="modificarPlato" DataNavigateUrlFormatString="../Administracion/EliminarPlato.aspx?id={0}"
                        HeaderText="Eliminar" Text="Eliminar" AllowFiltering="false" />
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
        <ef:EntityDataSource ID="efPlatos" runat="server"
            ContextTypeName="AlimentosSantiago.Dao.OracleDbContext"
            EntitySetName="Plato" Where="it.Eliminado = false">
        </ef:EntityDataSource>
    </div>
</asp:Content>
