<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="RegistroCliente.aspx.cs" Inherits="AlimentosSantiago.Web.RegistroCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView ID="FvUsuario" runat="server" ItemType="AlimentosSantiago.Dto.Usuario"
        DataKeyNames="Id" DefaultMode="Insert" InsertMethod="FvUsuario_InsertItem" OnItemInserting="FvUsuario_ItemInserting"
        RenderOuterTable="false">
        <InsertItemTemplate>
                        <div id="heading">
                            <div class="container">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="heading-content">
                                            <h2>REGISTRO CLIENTE</h2>
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
                            <h2>Registro Cliente</h2>
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
                                                        myMaxLength="60" Text='<%# BindItem.Apellido %>' /><br />
                                                    <asp:Label ID="lblPassword" runat="server">Password</asp:Label>
                                                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"
                                                        title="Ingrese Password." placeholder="Ingrese Password"
                                                        MaxLength="30" Text='<%# BindItem.Password %>' required data-validation-required-message="Completa Este Campo" /><br />
                                                    <asp:Label ID="lblPassword2" runat="server">ReIngresar Password </asp:Label>
                                                    <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password"
                                                        title="ReIngresar Password" placeholder="ReIngresar Password"
                                                        myMaxLength="20" Text='<%# BindItem.Password %>' required data-validation-required-message="Completa Este Campo" /><br />
                                                    <asp:Label ID="lblEmail" runat="server">Email</asp:Label>
                                                    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"
                                                        title="Ingrese Email Usuario." placeholder="Ingrese Email Usuario"
                                                        myMaxLength="60" Text='<%# BindItem.Email %>' required data-validation-required-message="Completa Este Campo" /><br />
                                                    <asp:Label ID="lblEmail2" runat="server">ReIngresar Email</asp:Label>
                                                    <asp:TextBox ID="txtEmail2" runat="server" TextMode="Email"
                                                        title="ReIngrese Email Usuario." placeholder="ReIngrese Email Usuario"
                                                        myMaxLength="60" Text='<%# BindItem.Email %>' required data-validation-required-message="Completa Este Campo" /><br />
                                                     <asp:Label ID="lblTelefono" runat="server">Telefono</asp:Label>
                                                    <asp:TextBox ID="txtTelefono" runat="server" TextMode="Phone"
                                                        title="Ingrese Telefono." placeholder="Ingrese Telefono"
                                                        myMaxLength="60" Text='<%# BindItem.Telefono %>' required data-validation-required-message="Completa Este Campo" /><br />
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
