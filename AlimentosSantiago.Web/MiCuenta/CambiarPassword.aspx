<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="CambiarPassword.aspx.cs" Inherits="AlimentosSantiago.Web.MiCuenta.CambiarPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div id="heading">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="heading-content">
                                <h2>Cambio de Password</h2>
                                <span><a href="../Home.aspx">Volver</a></span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="heading-section">
                            <h2>Cambio de password</h2>
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
                                                    <asp:Label ID="lblPasswordActual" runat="server">Ingrese Password actual </asp:Label>
                                                    <asp:TextBox ID="txtPasswordActual" runat="server" TextMode="Password"
                                                        title="Ingrese Password actual" placeholder="Ingrese Password actual"
                                                        MaxLength="60" required data-validation-required-message="Completa Este Campo" /><br />
                                                     <asp:Label ID="lblPasswordNuevo" runat="server">Ingrese Nuevo Password</asp:Label>
                                                    <asp:TextBox ID="txtPasswordNuevo" runat="server" TextMode="Password"
                                                        title="Ingrese Password actual" placeholder="Ingrese Password actual"
                                                        MaxLength="60" required data-validation-required-message="Completa Este Campo" /><br /> 
                                                     <asp:Label ID="lblPassowordNuevo2" runat="server">Reingrese Nuevo Password </asp:Label>
                                                    <asp:TextBox ID="txtpasswordNuevo2" runat="server" TextMode="Password"
                                                        title="Ingrese Password actual" placeholder="Ingrese Password actual"
                                                        MaxLength="60" required data-validation-required-message="Completa Este Campo" /><br />   
                                                    <asp:Button runat="server" Text="Guardar" ID="btnCambiarPassword" OnClick="btnCambiarPassword_Click" />
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
</asp:Content>
