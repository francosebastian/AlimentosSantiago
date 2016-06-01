<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="AgregarTipoPago.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.AgregarTipoPago" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:FormView ID="FvTipoPago" runat="server" ItemType="AlimentosSantiago.Dto.TipoPago"
        DataKeyNames="Id" DefaultMode="Insert" InsertMethod="FvTipoPago_InsertItem"
        RenderOuterTable="false">
          <InsertItemTemplate>
                          <div id="heading">
                            <div class="container">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="heading-content">
                                            <h2>NUEVO TIPO DE PAGO</h2>
                                            <span><a href="../MenuPrincipal.aspx">Menu</a></span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                <div class="container">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="heading-section">
                                        <h2>Agregar Tipo de Pago</h2>
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
                                                                <asp:Label ID="lblTipoUsuario" runat="server">Ingrese el Tipo de pago</asp:Label>
                                                                <asp:TextBox ID="txtTipoUsuario" runat="server" TextMode="SingleLine"
                                                                    title="Ingrese Tipo de pago." placeholder="Ingrese Tipo de pago"
                                                                    MaxLength="100" Text='<%# BindItem.Nombre %>' required data-validation-required-message="Completa Este Campo" /><br /><br />
                                                                <asp:Label ID="lblDescripcion" runat="server">Descripcion</asp:Label>
                                                                <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine"
                                                                    title="Ingrese Detalle del tipo pago." placeholder="Detalle del tipo pago"
                                                                    MaxLength="100" Text='<%# BindItem.Descripcion %>' required data-validation-required-message="Completa Este Campo" /><br />
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
