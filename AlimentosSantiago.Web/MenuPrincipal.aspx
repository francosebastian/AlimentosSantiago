<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="AlimentosSantiago.Web.MenuPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <InsertItemTemplate>
                         <div class="container">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="heading-section">
                                        <h2>MENU PRINCIPAL ADMINISTRATIVO</h2>
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
                                                                <center>
                                                          <h3>    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Administracion/AgregarCategoriaPlato.aspx">AGREGAR CATEGORIA</asp:HyperLink><br/>
                                                              <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Administracion/AgregarEmpresa.aspx">AGREGAR EMPRESA</asp:HyperLink><br/>
                                                              <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Administracion/AgregarEstadoPedido.aspx">AGREGAR ESTADO PEDIDO</asp:HyperLink> <br/>                                                             
                                                              <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Administracion/AgregarPlato.aspx">AGREGAR PLATO</asp:HyperLink><br/>
                                                              <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Administracion/AgregarTipoPago.aspx">AGREGAR TIPO DE PAGO</asp:HyperLink><br/>
                                                              <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Administracion/AgregarTipoUsuario.aspx">AGREGAR TIPO USUARIO</asp:HyperLink><br/>
                                                              <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/Administracion/AgregarUsuario.aspx">AGREGAR USUARIO</asp:HyperLink><br/>
                                                              </h3>
                                                                          </center>

                         
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



</asp:Content>
