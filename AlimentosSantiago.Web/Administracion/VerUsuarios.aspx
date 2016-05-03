<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="VerUsuarios.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.VerUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel-body">
        <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Auto"></asp:ScriptManager>
        <telerik:RadGrid ID="RadGridUsuarios" DataSourceID="efUsuarios" AutoGenerateColumns="false"  AllowPaging="True" AllowSorting="false"
            runat="server" AllowFilteringByColumn="false"
            HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center">
            <MasterTableView DataKeyNames="Id" CommandItemDisplay="None">
                <NoRecordsTemplate>
                    No se han encontrado registros.
                </NoRecordsTemplate>
                <Columns>
                    <telerik:GridBoundColumn DataField="Nombre" HeaderText="Nombre" ></telerik:GridBoundColumn>
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
