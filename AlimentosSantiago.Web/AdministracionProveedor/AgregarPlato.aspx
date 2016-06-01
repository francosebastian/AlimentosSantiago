<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="AgregarPlato.aspx.cs" Inherits="AlimentosSantiago.Web.AdministracionProveedor.AgregarPlato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView ID="FvPlato" runat="server" ItemType="AlimentosSantiago.Dto.Plato"
        DataKeyNames="Id" DefaultMode="Insert" InsertMethod="FvPlato_InsertItem"
        RenderOuterTable="false">
        <InsertItemTemplate>
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="heading-section">
                            <h2>Nuevo Plato</h2>
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
                                                        myMaxLength="60" Text='<%# BindItem.Nombre %>' /><br />
                                                    <asp:Label ID="lblDescripcion" runat="server">Descripcion</asp:Label>
                                                    <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine"
                                                        title="Ingrese Descripcion Plato." placeholder="Ingrese Descripcion Plato"
                                                        myMaxLength="60" Text='<%# BindItem.Descripcion %>' /><br />
                                                    <asp:Label ID="lblFotografia" runat="server">Fotografia</asp:Label>
                                                    <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />
                                                    <telerik:RadAsyncUpload runat="server" ID="AsyncUpload1" RenderMode="Auto"
                                                        AllowedFileExtensions=".jpg,.png" Localization-Select="Abrir" Skin="Bootstrap" MultipleFileSelection="Disabled" />
                                                    <asp:Label ID="lblPrecio" runat="server">Precio</asp:Label>
                                                    <asp:TextBox ID="txtPrecio" runat="server" TextMode="Number"
                                                        title="Ingrese Descripcion Plato." placeholder="Ingrese Precio Plato"
                                                        myMaxLength="60" Text='<%# BindItem.Precio %>' /><br />
                                                    <asp:Label ID="lblPrecioPromocion" runat="server">Precio</asp:Label>
                                                    <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"
                                                        title="Ingrese Descripcion Plato." placeholder="Ingrese Precio Promocion"
                                                        myMaxLength="60" Text='<%# BindItem.PrecioPromocion %>' /><br />
                                                    <asp:Label ID="Label1" runat="server">Promocion Activa</asp:Label>
                                                    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="false"
                                                        Checked="<%# BindItem.PromocionActiva %>" />
                                                    <asp:Label ID="lblCategoriaPlato" runat="server">Categoria Plato</asp:Label>
                                                    <asp:DropDownList ID="ddlCategoriaPlato" runat="server"
                                                        DataSourceID="efCategoriaPlato" DataTextField="Nombre" DataValueField="Id" SelectedValue='<%# BindItem.CategoriaPlatoId %>'
                                                        AppendDataBoundItems="true">
                                                        <asp:ListItem Value="" Text="Seleccionar"></asp:ListItem>
                                                    </asp:DropDownList><br />
                                                    <ef:EntityDataSource ID="efCategoriaPlato" runat="server"
                                                        ContextTypeName="AlimentosSantiago.Dao.OracleDbContext"
                                                        EntitySetName="CategoriaPlato"
                                                        Select="it.Id,it.Nombre">
                                                    </ef:EntityDataSource>                                                   
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
            </div>
        </InsertItemTemplate>
    </asp:FormView>
</asp:Content>
