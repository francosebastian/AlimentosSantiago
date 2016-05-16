<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="ModificarTipoUsuario.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.ModificarTipoUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:FormView ID="FvTipoUsuario" runat="server" ItemType="AlimentosSantiago.Dto.TipoUsuario"
        DataKeyNames="Id" DefaultMode="Edit" UpdateMethod="FvTipoUsuario_UpdateItem" SelectMethod="FvTipoUsuario_GetItem"
        RenderOuterTable="false">
          <EditItemTemplate>
              <div id="heading">
                  <div class="container">
                      <div class="row">
                          <div class="col-md-12">
                              <div class="heading-content">
                                  <h2>MODIFICAR TIPO USUARIO</h2>
                                  <span><a href="../MenuPrincipal.aspx">Menu /</a><a href="VerTipoUsuario.aspx">Volver</a></span>
                              </div>
                          </div>
                      </div>
                  </div>
              </div>
              <div class="container">
                  <div class="row">
                      <div class="col-md-12">
                          <div class="heading-section">
                              <h2>Modificar Tipo de Usuario</h2>
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
                                                      <asp:Label ID="lblModificarTipoUsuario" runat="server">Modificar el Tipo de Usuario</asp:Label>
                                                      <asp:TextBox ID="txtModificarTipoUsuario" runat="server" TextMode="SingleLine"
                                                          title="Modificar Tipo de Usuario." placeholder="Modificar Tipo de Usuario"
                                                          myMaxLength="60" Text='<%# BindItem.Nombre %>' /><br />
                                                      <asp:Label ID="lblDescripcion" runat="server">Descripcion</asp:Label>
                                                      <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine"
                                                          title="Ingrese Detalle del Trabajador." placeholder="Detalle del Trabajador"
                                                          myMaxLength="60" Text='<%# BindItem.Descripcion %>' /><br />
                                                      <asp:Label ID="lblDeshabilitado" runat="server">Deshabilitado</asp:Label>
                                                      <asp:CheckBox ID="chbDeshabilitado" runat="server" AutoPostBack="false"
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

  