<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="AgregarPlato.aspx.cs" Inherits="AlimentosSantiago.Web.Administracion.AgregarPlato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView ID="FvPlato" runat="server" ItemType="AlimentosSantiago.Dto.Plato"
        DataKeyNames="Id" DefaultMode="Insert" InsertMethod="FvPlato_InsertItem"
        RenderOuterTable="false">
    <ItemTemplate>

    </ItemTemplate>
</asp:FormView>
</asp:Content>
