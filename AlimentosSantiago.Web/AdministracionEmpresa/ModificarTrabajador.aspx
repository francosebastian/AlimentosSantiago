﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="ModificarTrabajador.aspx.cs" Inherits="AlimentosSantiago.Web.AdministracionEmpresa.ModificarTrabajador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView ID="FvUsuario" runat="server" ItemType="AlimentosSantiago.Dto.Usuario"
        DataKeyNames="Id" DefaultMode="Edit" SelectMethod="FvUsuario_GetItem" UpdateMethod="FvUsuario_UpdateItem"
        RenderOuterTable="false">
        <EditItemTemplate>
                        <div id="heading">
                            <div class="container">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="heading-content">
                                            <h2>EDITAR USUARIO TRABAJADOR</h2>
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
                            <h2>Agregar Trabajador</h2>
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
                                                    <asp:Label ID="lblNombre" runat="server">Nombre</asp:Label>
                                                    <asp:TextBox ID="txtNombre" runat="server" TextMode="SingleLine"
                                                        title="Ingrese Nombre Usuario." placeholder="Ingrese Nombre Usuario"
                                                        myMaxLength="60" Text='<%# BindItem.Nombre %>' required data-validation-required-message="Completa Este Campo" /><br />
                                                    <asp:Label ID="lblApellido" runat="server">Apellido</asp:Label>
                                                    <asp:TextBox ID="txtApellido" runat="server" TextMode="SingleLine"
                                                        title="Ingrese apellido Usuario." placeholder="Ingrese apellido Usuario"
                                                        myMaxLength="60" Text='<%# BindItem.Apellido %>' required data-validation-required-message="Completa Este Campo" /><br />
                                                    <asp:Label ID="lblTelefono1" runat="server">Telefono Fijo</asp:Label>
                                                    <asp:TextBox ID="txtTelefono1" runat="server" TextMode="Phone"
                                                        title="Ingrese fijo Usuario." placeholder="Ingrese telefono fijo Usuario"
                                                        myMaxLength="60" Text='<%# BindItem.Telefono %>' required data-validation-required-message="Completa Este Campo" /><br />
                                                    <asp:Label ID="lblTelefono2" runat="server">Telefono Movil</asp:Label>
                                                    <asp:TextBox ID="txtTelefono2" runat="server" TextMode="Phone"
                                                        title="Ingrese movil Usuario." placeholder="Ingrese telefono movil Usuario"
                                                        myMaxLength="60" Text='<%# BindItem.Telefono2 %>' required data-validation-required-message="Completa Este Campo" /><br />
                                                    <asp:Label ID="lblEmail" runat="server">Email</asp:Label>
                                                    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"
                                                        title="Ingrese Email Usuario." placeholder="Ingrese Email Usuario"
                                                        myMaxLength="60" Text='<%# BindItem.Email %>' required data-validation-required-message="Completa Este Campo" /><br />
                                                    <asp:Label ID="lblDeshabilitado" runat="server">Deshabilitado</asp:Label>
                                                    <asp:CheckBox ID="chbDeshabilitado" runat="server" Text="Deshabilitado" AutoPostBack="false"
                                                        Checked="<%# BindItem.Deshabilitado %>" />
                                                    <asp:Button runat="server" Text="Guardar" ID="btnGrabar" CommandName="Update" />
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
