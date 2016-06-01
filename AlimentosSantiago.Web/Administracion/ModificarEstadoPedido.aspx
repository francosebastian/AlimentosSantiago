<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="ModificarEstadoPedido.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.ModificarEstadoPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:FormView ID="FvEstadoPedido" runat="server" ItemType="AlimentosSantiago.Dto.EstadoPedido"
        DataKeyNames="Id" DefaultMode="Edit" UpdateMethod="FvEstadoPedido_UpdateItem" SelectMethod="FvEstadoPedido_GetItem"
        RenderOuterTable="false">
         <EditItemTemplate>
             <div id="heading">
                 <div class="container">
                     <div class="row">
                         <div class="col-md-12">
                             <div class="heading-content">
                                 <h2>MODIFICAR ESTADO PEDIDO</h2>
                                 <span><a href="../MenuPrincipal.aspx">Menu /</a><a href="VerEstadoPedido.aspx">Volver</a></span>
                             </div>
                         </div>
                     </div>
                 </div>
             </div>
             <div class="container">
                 <div class="row">
                     <div class="col-md-12">
                         <div class="heading-section">
                             <h2>Modificar Estado Pedido</h2>
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
                                                     <asp:Label ID="lblModificarEstadoPedido" runat="server">Modificar Estado Pedido</asp:Label>
                                                     <asp:TextBox ID="txtModificarEstadoPedido" runat="server" TextMode="SingleLine"
                                                         title="Modificar Estado Pedido." placeholder="Modificar Estado Pedido"
                                                         MaxLength="100" Text='<%# BindItem.Nombre %>' /><br />
                                                     <asp:Label ID="lblDescripcion" runat="server">Descripcion</asp:Label>
                                                     <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine"
                                                         title="Ingrese Detalle del Pedido." placeholder="Detalle del Pedido"
                                                         MaxLength="100" Text='<%# BindItem.Descripcion %>' /><br />
                                                     <asp:Label ID="lblDeshabilitado" runat="server">Deshabilitado</asp:Label>
                                                     <asp:CheckBox ID="chbDeshabilitado" runat="server" AutoPostBack="false"
                                                         Checked="<%# BindItem.Deshabilitado %>" />
                                                     <asp:Button runat="server" Text="Guardar" ID="btnGrabar" CommandName="Insert" />
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
         </EditItemTemplate>
    </asp:FormView>
</asp:Content>




