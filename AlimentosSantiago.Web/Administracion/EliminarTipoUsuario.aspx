<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="EliminarTipoUsuario.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.EliminarTipoUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <asp:FormView ID="FvTipoUsuario" runat="server" ItemType="AlimentosSantiago.Dto.TipoUsuario"
        DataKeyNames="Id" DefaultMode="ReadOnly" DeleteMethod="FvTipoUsuario_DeleteItem" SelectMethod="FvTipoUsuario_GetItem"
        RenderOuterTable="false">       
          <ItemTemplate>
                  <div class="container">
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="heading-section">
                                        <h2>Eliminar Tipo de Usuario</h2>
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
                                                                <asp:Label ID="lblEliminarTipoUsuario" runat="server">Eliminar el Tipo de Usuario</asp:Label>
                                                                <asp:TextBox ID="txtEliminarTipoUsuario" runat="server" TextMode="SingleLine"
                                                                    title="Eliminar Tipo de Usuario." placeholder="Eliminar Tipo de Usuario" Enabled="false"
                                                                    myMaxLength="60" Text='<%# BindItem.Nombre %>' /><br />
                                                                <asp:Label ID="lblDescripcion" runat="server">Descripcion</asp:Label>
                                                                <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine"
                                                                    title="Eliminar Detalle del Usuario." placeholder="Detalle del Usuario" Enabled="false"
                                                                    myMaxLength="60" Text='<%# BindItem.Descripcion %>' /><br />
                                                                <asp:Label ID="lblDeshabilitado" runat="server">Deshabilitado</asp:Label>
                                                                <asp:CheckBox ID="chbDeshabilitado" runat="server" AutoPostBack="false"
                                                                    Checked="<%# BindItem.Deshabilitado %>" />
                                                                <asp:Button runat="server" Text="Guardar" ID="btnGrabar" CommandName="Delete" />
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
        </ItemTemplate>
    </asp:FormView>
</asp:Content>


