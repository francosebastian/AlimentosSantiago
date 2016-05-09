<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="ModificarTipoPago.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.ModificarTipoPago" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <asp:FormView ID="FvTipoPago" runat="server" ItemType="AlimentosSantiago.Dto.TipoPago"
        DataKeyNames="Id" DefaultMode="Edit" UpdateMethod="FvTipoPago_UpdateItem" SelectMethod="FvTipoPago_GetItem"
        RenderOuterTable="false">
          <EditItemTemplate>
             <div class="container">
    <div class="row">
        <div class="col-md-12">
            <div class="heading-section">
                <h2>Modificar Tipo de Pago</h2>
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
                                        <asp:TextBox ID="txtModificarTipoDePago" runat="server" TextMode="SingleLine"
                                            title="Modificar Tipo de Pago." placeholder="Modificar Tipo Pago"
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

        </EditItemTemplate>
    </asp:FormView>
</asp:Content>


        </InsertItemTemplate>