<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="CargarSaldo.aspx.cs" Inherits="AlimentosSantiago.Web.AdministracionEmpresa.CargarSaldo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Carga de Saldo</h1> 
        <p>Para cargar saldos en carga masiva debera solicitar la plantilla a alimentos santiago.
                            <br><br>alimentossantiago@gmail.com</p>
        <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />
                <telerik:RadAsyncUpload runat="server" ID="AsyncUpload1" RenderMode="Auto"
                AllowedFileExtensions=".xls,.xlsx"  Localization-Select="Abrir" Skin="Bootstrap" MultipleFileSelection="Disabled"/>
        <asp:Button runat="server" ID="btnCargaMasiva" Text="Cargar" OnClick="btnCargaMasiva_Click"/>
</asp:Content>
