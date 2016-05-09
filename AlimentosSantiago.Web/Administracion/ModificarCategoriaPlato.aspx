﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="ModificarCategoriaPlato.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.ModificarCategoriaPlato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <asp:FormView ID="FvCategoriaPlato" runat="server" ItemType="AlimentosSantiago.Dto.CategoriaPlato"
        DataKeyNames="Id" DefaultMode="Edit" UpdateMethod="FvCategoriaPlato_UpdateItem" SelectMethod="FvCategoriaPlato_GetItem"
        RenderOuterTable="false">
          <EditItemTemplate>
             <h4>Modificar Categoria Plato</h4>
                          <asp:TextBox ID="txtNombre" runat="server" TextMode="SingleLine"
                            title="Ingrese nombre de estado pedido." placeholder="Ingrese estado Pedido"
                            myMaxLength="60" Text='<%# BindItem.Nombre %>' /><br />
                          <asp:TextBox ID="lblDescripcion" runat="server" TextMode="MultiLine"
                            title="Ingrese descripcion de estado pedido." placeholder="Ingrese estado Pedido"
                            myMaxLength="60" Text='<%# BindItem.Descripcion %>' /><br />
                          <asp:CheckBox ID="chbDesabiilitado" runat="server" Text="Deshabilitado" OnCheckedChanged="chbDesabiilitado_CheckedChanged" AutoPostBack="false"
                            Checked="<%# BindItem.Deshabilitado %>" />
            <asp:Button runat="server" Text="Guardar" ID="btnGrabar" CommandName="Update"/>
        </EditItemTemplate>
    </asp:FormView>
</asp:Content>