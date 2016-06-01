<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="EliminarEmpresa.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.EliminarEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <asp:FormView ID="FvEmpresa" runat="server" ItemType="AlimentosSantiago.Dto.Empresa"
        DataKeyNames="Id" DefaultMode="ReadOnly" DeleteMethod="FvEmpresa_DeleteItem" SelectMethod="FvEmpresa_GetItem"
        RenderOuterTable="false">
           <ItemTemplate>
               <div id="heading">
                   <div class="container">
                       <div class="row">
                           <div class="col-md-12">
                               <div class="heading-content">
                                   <h2>ELIMINAR EMPRESA</h2>
                                   <span><a href="../MenuPrincipal.aspx">Menu /</a><a href="VerEmpresas.aspx">Volver</a></span>
                               </div>
                           </div>
                       </div>
                   </div>
               </div>
               <div class="container">
                   <div class="row">
                       <div class="col-md-12">
                           <div class="heading-section">
                               <h2>Eliminar Empresa</h2>
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
                                                       <asp:Label ID="lblEliminarEmpresa" runat="server">Eliminar Empresa</asp:Label>
                                                       <asp:TextBox ID="txtEmpresa" runat="server" TextMode="SingleLine"
                                                           title="Eliminar Empresa." placeholder="Empresa" Enabled="false"
                                                           MaxLength="100" Text='<%# BindItem.Nombre %>' /><br />
                                                       <asp:Label ID="lblDeshabilitado" runat="server">Deshabilitado</asp:Label>
                                                       <asp:CheckBox ID="chbDeshabilitado" runat="server" AutoPostBack="false"
                                                           Checked="<%# BindItem.Deshabilitado %>" />
                                                       <asp:Button runat="server" Text="Guardar" ID="btnGuardar" CommandName="Delete" />
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

