<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="AgregarEmpresa.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.AgregarEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   <asp:FormView ID="FvEmpresa" runat="server" ItemType="AlimentosSantiago.Dto.Empresa"
   DataKeyNames="Id" DefaultMode="Insert" InsertMethod="FvEmpresa_InsertItem"
   RenderOuterTable="false">
       <InsertItemTemplate>
           <div id="heading">
               <div class="container">
                   <div class="row">
                       <div class="col-md-12">
                           <div class="heading-content">
                               <h2>NUEVA EMPRESA</h2>
                               <span><a href="../MenuPrincipal.aspx">Volver</a></span>
                           </div>
                       </div>
                   </div>
               </div>
           </div>
           <div class="container">
               <div class="row">
                   <div class="col-md-12">
                       <div class="heading-section">
                           <h2>Agregar Empresa</h2>
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
                                                   <asp:Label ID="lblNombre" runat="server">Nombre Empresa</asp:Label>
                                                   <asp:TextBox ID="txtEmpresa" runat="server" TextMode="SingleLine"
                                                       title="Ingrese Nueva Empresa." placeholder="Empresa"
                                                       myMaxLength="60" Text='<%# BindItem.Nombre %>' required data-validation-required-message="Completa Este Camp.o" /><br /><br />
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
       </InsertItemTemplate>
            </asp:FormView>
</asp:Content>

   