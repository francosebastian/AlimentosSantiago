
<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="EliminarTipoPago.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.EliminarTipoPago" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView ID="FvTipoPago" runat="server" ItemType="AlimentosSantiago.Dto.TipoPago"
        DataKeyNames="Id" DefaultMode="ReadOnly" DeleteMethod="FvTipoPago_DeleteItem" SelectMethod="FvTipoPago_GetItem"
        RenderOuterTable="false">
          <ItemTemplate>
             <h4>Eliminar Tipo Pago</h4>
              <asp:Label ID="lblNombre" runat="server">Nombre</asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" TextMode="SingleLine"
                            title="Ingrese nombre de empresa." placeholder="Ingrese su nombre"
                            myMaxLength="60" Text='<%# BindItem.Nombre %>' /><br />
                          <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine"
                            title="Ingrese nombre de empresa." placeholder="Ingrese descripcion tipo pago"
                            myMaxLength="60" Text='<%# BindItem.Descripcion %>' /><br />
           
            <asp:Button runat="server" Text="Guardar" ID="btnGrabar" CommandName="Delete"/>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
