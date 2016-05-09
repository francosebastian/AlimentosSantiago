<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="AgregarTipoPago.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.AgregarTipoPago" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:FormView ID="FvTipoPago" runat="server" ItemType="AlimentosSantiago.Dto.TipoPago"
        DataKeyNames="Id" DefaultMode="Insert" InsertMethod="FvTipoPago_InsertItem"
        RenderOuterTable="false">
          <InsertItemTemplate>
                <div class="container">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="heading-section">
                                        <h2>Tipo de Pago</h2>
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
                                                                <asp:Label ID="Label1" runat="server">Nombre Empresa</asp:Label>
                                                                <asp:TextBox ID="txtTipoDePago" runat="server" TextMode="SingleLine"
                                                                    title="Tipo de Pago." placeholder="Tipo Pago"
                                                                    myMaxLength="60" Text='<%# BindItem.Nombre %>' /><br />
                                                                <asp:Label ID="lblDeshabilitado" runat="server">Deshabilitado</asp:Label>
                                                                <asp:CheckBox ID="chbDeshabilitado" runat="server" AutoPostBack="false"
                                                                    Checked="<%# BindItem.Deshabilitado %>" />
                                                                <asp:Button runat="server" Text="Guardar" ID="Button1" CommandName="Insert" />
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
