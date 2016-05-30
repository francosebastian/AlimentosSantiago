<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="AgregarPlato.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.AgregarPlato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />
           <asp:FormView ID="FvPlato" runat="server" ItemType="AlimentosSantiago.Dto.Plato"
            DataKeyNames="Id" DefaultMode="Insert" InsertMethod="FvPlato_InsertItem"
            RenderOuterTable="false">
            <InsertItemTemplate>
                            <div id="heading">
                            <div class="container">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="heading-content">
                                            <h2>NUEVO PLATO</h2>
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
                                <h2>Agregar Nuevo Plato</h2>
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
                                                            title="Ingrese Nombre Plato." placeholder="Ingrese Nombre Plato"
                                                            myMaxLength="60" Text='<%# BindItem.Nombre %>' required data-validation-required-message="Completa Este Camp.o" /><br /><br />
                                                        <asp:Label ID="lblDescripcion" runat="server">Descripcion</asp:Label>
                                                        <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine"
                                                            title="Ingrese Descripcion Plato." placeholder="Ingrese Descripcion Plato"
                                                            myMaxLength="60" Text='<%# BindItem.Descripcion %>' required data-validation-required-message="Completa Este Camp.o" /><br />
                                                        <asp:Label ID="lblFotografia" runat="server">Fotografia</asp:Label>
                                                             
                                                        <telerik:RadAsyncUpload runat="server" ID="rauFoto" RenderMode="Auto"
                                                         AllowedFileExtensions=".jpg,.png"  Localization-Select="Examinar" Skin="Bootstrap" MultipleFileSelection="Disabled"/><br/>
                                                        <asp:Label ID="lblPrecio" runat="server">Precio </asp:Label>
                                                        <asp:TextBox ID="txtPrecio" runat="server" TextMode="Number"
                                                            title="Ingrese Descripcion Plato." placeholder="Ingrese Precio Plato"
                                                            myMaxLength="60" Text='<%# BindItem.Precio %>' required data-validation-required-message="Completa Este Campo" /> <br /><br/>
                                                        <asp:Label ID="lblPrecioPromocion" runat="server">Precio con Promocion</asp:Label>
                                                        <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"
                                                            title="Ingrese Descripcion Plato." placeholder="Ingrese Precio Promocion"
                                                            myMaxLength="60" Text='<%# BindItem.PrecioPromocion %>' required data-validation-required-message="Completa Este Campo" /><br /><br />
                                                         <asp:Label ID="lblCategoriaPlato" runat="server">Categoria Plato</asp:Label>
                                                        <asp:DropDownList ID="ddlTipoUsuario" runat="server"
                                                            DataSourceID="efCategoriaPlato" DataTextField="Nombre" DataValueField="Id" SelectedValue='<%# BindItem.CategoriaPlatoId %>'
                                                            AppendDataBoundItems="true">
                                                            <asp:ListItem Value="" Text="Seleccionar"></asp:ListItem>
                                                        </asp:DropDownList><br />
                                                         <asp:Label ID="lblProveedor" runat="server">Proveedor</asp:Label>
                                                        <asp:DropDownList ID="ddlProveedor" runat="server"
                                                            DataSourceID="efProveedor" DataTextField="Nombre" DataValueField="Id" SelectedValue='<%# BindItem.ProveedorId %>'
                                                            AppendDataBoundItems="true">
                                                            <asp:ListItem Value="" Text="Seleccionar"></asp:ListItem>
                                                        </asp:DropDownList><br />
                                                        <asp:Label ID="Label1" runat="server">Promocion Activa</asp:Label>
                                                        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="false"
                                                            Checked="<%# BindItem.PromocionActiva %>" />
                                                       
                         
                                                        <ef:EntityDataSource ID="efCategoriaPlato" runat="server"
                                                            ContextTypeName="AlimentosSantiago.Dao.OracleDbContext"
                                                            EntitySetName="CategoriaPlato"
                                                            Select="it.Id,it.Nombre">
                                                        </ef:EntityDataSource>
                                                          <ef:EntityDataSource ID="efProveedor" runat="server"
                                                            ContextTypeName="AlimentosSantiago.Dao.OracleDbContext"
                                                            EntitySetName="Usuario"
                                                            Select="it.Id,it.Nombre" Where="it.TipoUsuarioId = 3">
                                                        </ef:EntityDataSource>
                                                        <asp:Label ID="lblDeshabilitado" runat="server">Deshabilitado</asp:Label>
                                                        <asp:CheckBox ID="chbDeshabilitado" runat="server"  AutoPostBack="false"
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
                </div>
            </InsertItemTemplate>
        </asp:FormView>
</asp:Content>
