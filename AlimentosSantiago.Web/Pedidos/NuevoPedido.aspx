<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="NuevoPedido.aspx.cs" Inherits="AlimentosSantiago.Web.Pedidos.NuevoPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="heading">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="heading-content">
                        <h2>Nuevo Pedido</h2>
                        <span><a href="../Index.aspx">Volver al Home</a></span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="heading-section">
                    <h2>Carrito de compras</h2>
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
                                            <asp:GridView runat="server" ID="gvShoppingCart" AutoGenerateColumns="false" EmptyDataText="No hay nada en tu pedido." GridLines="None" Width="100%" CellPadding="5" ShowFooter="true" DataKeyNames="PlatoId" OnRowDataBound="gvShoppingCart_RowDataBound" OnRowCommand="gvShoppingCart_RowCommand" databind>
                                                <HeaderStyle HorizontalAlign="Left" BackColor="#3D7169" ForeColor="#FFFFFF" />
                                                <FooterStyle HorizontalAlign="Right" BackColor="#6C6B66" ForeColor="#FFFFFF" />
                                                <AlternatingRowStyle BackColor="#F8F8F8" />
                                                <Columns>
                                                    <asp:BoundField DataField="Nombre" HeaderText="Detalle" />
                                                    <asp:TemplateField HeaderText="Cantidad">
                                                        <ItemTemplate>
                                                            <asp:TextBox runat="server" ID="txtQuantity" Columns="5" Text='<%# Eval("Cantidad") %>'></asp:TextBox><br />
                                                            <asp:LinkButton runat="server" ID="btnRemove" Text="Eliminar" CommandName="Remove" CommandArgument='<%# Eval("PlatoId") %>' Style="font-size: 12px;"></asp:LinkButton>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="PrecioUnitario" HeaderText="Precio" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" />
                                                    <asp:BoundField HeaderText="SubTotal" ItemStyle-HorizontalAlign="Right" HeaderStyle-HorizontalAlign="Right" />
                                                </Columns>
                                            </asp:GridView>
                                            <asp:Button runat="server" ID="btnUpdateCart" Text="Actualizar carro" OnClick="btnUpdateCart_Click" />
                                        </div>
                                        <asp:Panel ID="pnlOrden" runat="server" Visible="false">
                                                <div class="name col-md-12">
                                            <asp:Label runat="server" ID="lblTipoPago" Text="Tipo de pago" />
                                            <asp:DropDownList ID="ddlTipoPago" runat="server"
                                                DataSourceID="efTipoPago" CssClass="form-control" DataTextField="Nombre" DataValueField="Id"
                                                AppendDataBoundItems="true">
                                                <asp:ListItem Value="" Text="Seleccionar"></asp:ListItem>
                                            </asp:DropDownList><br />
                                            <ef:EntityDataSource ID="efTipoPago" runat="server"
                                                ContextTypeName="AlimentosSantiago.Dao.OracleDbContext"
                                                EntitySetName="TipoPago"
                                                Select="it.Id,it.Nombre">
                                            </ef:EntityDataSource>
                                        </div>
                                        <div class="name col-md-12">
                                            <asp:Label runat="server" ID="lblDireccionUsuario" Text="Direccion Pedido" />
                                            <asp:DropDownList ID="ddlDireccionUsuario" runat="server"
                                                DataSourceID="efDireccionUsuario" CssClass="form-control" DataTextField="Nombre" DataValueField="Id"
                                                AppendDataBoundItems="true">
                                                <asp:ListItem Value="" Text="Seleccionar"></asp:ListItem>
                                            </asp:DropDownList><br />
                                            <ef:EntityDataSource ID="efDireccionUsuario" runat="server"
                                                ContextTypeName="AlimentosSantiago.Dao.OracleDbContext"
                                                EntitySetName="DireccionUsuario"
                                                Select="it.Id,it.Nombre" Where="it.Eliminado = false and it.UsuarioId = @IdUsuario">
                                                <WhereParameters>
                                                    <asp:Parameter Name="IdUsuario" Type="Int32" />
                                                </WhereParameters>
                                            </ef:EntityDataSource>
                                        </div>
                                        <div class="name col-md-12">
                                            <asp:Label runat="server" ID="lblPedido" Text="Confirmar Pedido" />
                                            <asp:Button runat="server" ID="btnPedido" Text="Hacer Pedido" OnClick="btnPedido_Click" />
                                        </div>
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
</asp:Content>
