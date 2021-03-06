﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="ModificarCategoriaPlato.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.ModificarCategoriaPlato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <asp:FormView ID="FvCategoriaPlato" runat="server" ItemType="AlimentosSantiago.Dto.CategoriaPlato"
        DataKeyNames="Id" DefaultMode="Edit" UpdateMethod="FvCategoriaPlato_UpdateItem" SelectMethod="FvCategoriaPlato_GetItem"
        RenderOuterTable="false">
           <EditItemTemplate>
               <div id="heading">
                   <div class="container">
                       <div class="row">
                           <div class="col-md-12">
                               <div class="heading-content">
                                   <h2>MODIFICAR CATEGORIA PLATOS</h2>
                                   <span><a href="../MenuPrincipal.aspx">Menu /</a><a href="VerCategoriaPlatos.aspx">Volver</a></span>
                               </div>
                           </div>
                       </div>
                   </div>
               </div>
               <div class="container">
                   <div class="row">
                       <div class="col-md-12">
                           <div class="heading-section">
                               <h2>Modificar Categoria de Platos</h2>
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
                                                       <asp:Label ID="lblCategoriaPlato" runat="server" required autofocus>Categoria Plato a Modificar </asp:Label>
                                                       <asp:TextBox ID="txtCategoriaPlato" runat="server" TextMode="SingleLine"
                                                           title="Ingrese Nueva Categoria" placeholder="Ingrese nueva Categoria de Platos"
                                                           MaxLength="100" Text='<%# BindItem.Nombre %>' /><br />
                                                       <asp:Label ID="Label1" runat="server">Descripcion</asp:Label>
                                                       <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine"
                                                           title="Ingrese Detalle de la Categoria." placeholder="Detalle de la Categoria"
                                                           MaxLength="100" Text='<%# BindItem.Descripcion %>' /><br />
                                                       <asp:Label ID="lblDeshabilitado" runat="server">Deshabilitado</asp:Label>
                                                       <asp:CheckBox ID="chbDeshabilitado" runat="server" AutoPostBack="false"
                                                           Checked="<%# BindItem.Deshabilitado %>" />
                                                       <asp:Button runat="server" Text="Guardar" ID="btnGuardar" CommandName="Update" />
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
