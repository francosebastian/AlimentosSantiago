<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="EliminarTipoPago.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.EliminarTipoPago" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:FormView ID="FvTipoPago" runat="server" ItemType="AlimentosSantiago.Dto.TipoPago"
        DataKeyNames="Id" DefaultMode="ReadOnly" DeleteMethod="FvTipoPago_DeleteItem" SelectMethod="FvTipoPago_GetItem"
        RenderOuterTable="false">
         <ItemTemplate>
             <div id="heading">
                 <div class="container">
                     <div class="row">
                         <div class="col-md-12">
                             <div class="heading-content">
                                 <h2>ELIMINAR TIPO DE PAGO</h2>
                                 <span><a href="../MenuPrincipal.aspx">Menu /</a><a href="VerTipoPago.aspx">Volver</a></span>
                             </div>
                         </div>
                     </div>
                 </div>
             </div>
             <div class="container">
                 <div class="row">
                     <div class="col-md-12">
                         <div class="heading-section">
                             <h2>Eliminar Tipo de Pago</h2>
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
                                                     <asp:Label ID="lbl" runat="server">Nombre Empresa</asp:Label>
                                                     <asp:TextBox ID="txtEliminarTipoDePago" runat="server" TextMode="SingleLine"
                                                         title="Eliminar Tipo de Pago." placeholder="Modificar Tipo Pago" Enabled="false"
                                                         myMaxLength="60" Text='<%# BindItem.Nombre %>' /><br />
                                                     <asp:Label ID="lblDeshabilitado" runat="server">Deshabilitado</asp:Label>
                                                     <asp:CheckBox ID="chbDeshabilitado" runat="server" AutoPostBack="false"
                                                         Checked="<%# BindItem.Deshabilitado %>" />
                                                     <asp:Button runat="server" Text="Guardar" ID="Button1" CommandName="Delete" />
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

         </ItemTemplate>
    </asp:FormView>
</asp:Content>

