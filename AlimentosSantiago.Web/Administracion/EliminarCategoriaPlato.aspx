<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="EliminarCategoriaPlato.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.EliminarCategoriaPlato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView ID="FvCategoriaPlato" runat="server" ItemType="AlimentosSantiago.Dto.CategoriaPlato"
        DataKeyNames="Id" DefaultMode="ReadOnly" DeleteMethod="FvCategoriaPlato_DeleteItem" SelectMethod="FvCategoriaPlato_GetItem"
        RenderOuterTable="false">
        <ItemTemplate>
            <div id="heading">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="heading-content">
                                <h2>ELIMINAR CATEGORIA PLATO</h2>
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
                               <h2>Eliminar Categoria</h2>
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
                                                       <asp:Label ID="lblEliminarCategoria" runat="server">Eliminar Categoria</asp:Label>
                                                       <asp:TextBox ID="txtCategoria" runat="server" TextMode="SingleLine"
                                                           title="Eliminar Categoria." placeholder="Eliminar Categoria" Enabled="false"
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
