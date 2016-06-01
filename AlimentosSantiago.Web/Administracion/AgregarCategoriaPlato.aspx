<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="AgregarCategoriaPlato.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.AgregarCategoriaPlato" %><asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<%@ Register Src="~/Wuc/ModalConfirmacion.ascx" TagPrefix="Pulse" TagName="wucModalConfirmar" %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView ID="FvCategoriaPlato" runat="server" ItemType="AlimentosSantiago.Dto.CategoriaPlato"
        DataKeyNames="Id" DefaultMode="Insert" InsertMethod="FvCategoriaPlato_InsertItem" OnItemInserting="FvCategoriaPlato_ItemInserting"
        RenderOuterTable="false">
        <InsertItemTemplate>
            <div id="heading">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="heading-content">
                                <h2>NUEVA CATEGORIA DE PLATO</h2>
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
                            <h2>Agregar Nueva Categoria de Platos</h2>
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
                                                    <asp:Label ID="lblCategoriaPlato" runat="server">Ingrese Categoria de Plato </asp:Label>
                                                    <asp:TextBox ID="txtCategoriaPlato" runat="server" TextMode="SingleLine"
                                                        title="Ingrese Nueva Categoria" placeholder="Ingrese nueva Categoria de Platos"
                                                        MaxLength="60" Text='<%# BindItem.Nombre %>' required data-validation-required-message="Completa Este Camp.o" /><br />
                                                    <br />
                                                    <asp:Label ID="Label1" runat="server">Descripcion</asp:Label>
                                                    <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine"
                                                        title="Ingrese Detalle de la Categoria." placeholder="Detalle de la Categoria"
                                                        myMaxLength="60" Text='<%# BindItem.Descripcion %>' required data-validation-required-message="Completa Este Campo." /><br />
                                                    <asp:Label ID="lblDeshabilitado" runat="server">Deshabilitado</asp:Label>
                                                    <asp:CheckBox ID="chbDeshabilitado" runat="server" AutoPostBack="false"
                                                        Checked="<%# BindItem.Deshabilitado %>" />
                                                    <asp:Button runat="server" Text="Guardar" ID="Button1" CommandName="Insert"/>
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
     <Pulse:wucModalConfirmar ID="wucModalConfirmarAceptarFlujo" runat="server" OnConfirmar="wucModalConfirmarAceptarFlujo_Confirmar" /> 
</asp:Content>
