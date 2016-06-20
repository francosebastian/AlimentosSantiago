<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="VerPedido.aspx.cs" Inherits="AlimentosSantiago.Web.Pedidos.VerPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="heading-section">
                            <h2>Ver Pedido</h2>
                            <img src="../images/under-heading.png" alt="" />
                        </div>
                    </div>
                </div>
                <div id="contact-us">
                    <div class="container">
                        <div class="row">
                            <div class="product-item col-md-12">
                                <div class="row">
                                    <div class="col-md-8">
                                        <div class="message-form">
                                            <div class="row">
                                                <div class="name col-md-12">
                                                    <asp:Label ID="lblFecha" runat="server">Fecha Pedido</asp:Label>
                                                    <asp:TextBox ID="txtFecha" runat="server" TextMode="SingleLine"
                                                        title="Ingrese Nombre Usuario." placeholder="Ingrese Nombre Usuario"
                                                        myMaxLength="60"  required data-validation-required-message="Completa Este Campo" /><br />
                                                    <asp:Label ID="lblEstadoPedido" runat="server">Estado Pedido</asp:Label>
                                                    <asp:TextBox ID="txtEstadoPedido" runat="server" TextMode="SingleLine"
                                                        title="Ingrese Nombre Usuario." placeholder="Ingrese Nombre Usuario"
                                                        myMaxLength="60"  required data-validation-required-message="Completa Este Campo" /><br />
                                                    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release"></asp:ScriptManager>
                                                    <asp:Label ID="lblDetalle" runat="server">Detalle Pedido</asp:Label>
                                                    <telerik:RadGrid ID="RadGridPedidos" AutoGenerateColumns="false"
                                                        runat="server" HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center">
                                                        <MasterTableView DataKeyNames="Id" CommandItemDisplay="None">
                                                            <NoRecordsTemplate>
                                                                No se han encontrado registros.
                                                            </NoRecordsTemplate>
                                                            <Columns>
                                                                <telerik:GridBoundColumn DataField="Nombre" HeaderText="Nombre Producto" ItemStyle-CssClass="text-uppercase"></telerik:GridBoundColumn>
                                                                <telerik:GridBoundColumn DataField="Cantidad" HeaderText="Cantidad" ItemStyle-CssClass="text-uppercase"></telerik:GridBoundColumn>
                                                                <telerik:GridBoundColumn DataField="PrecioUnitario" HeaderText="Precio" UniqueName="Precio" ItemStyle-CssClass="text-uppercase"></telerik:GridBoundColumn>
                                                            </Columns>
                                                        </MasterTableView>
                                                    </telerik:RadGrid>
                                                       <asp:Panel runat="server" Visible="false" ID="pnlProcesar">
                                                            <asp:Label ID="lblCambiarEstado" runat="server">Procesar Pedido</asp:Label>
                                                            <asp:Button ID="btnCambiarEstado" runat="server" OnClick="btnCambiarEstado_Click" Text="Finalizar Pedido" />
                                                       </asp:Panel>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
          
</asp:Content>
