<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ModalConfirmacion.ascx.cs" Inherits="AlimentosSantiago.Web.Wuc.ModalConfirmacion" %>
<asp:Panel ID="panelConfirmacion" runat="server" CssClass="modal fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true" id="bdefaultBtnXCerrar">×</button>
                <h4 id="bdefaultModalLabel">Confirmacion</h4>
            </div>
            <div class="modal-body">
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </div>
            <div class="modal-footer" id="bcustomFooter2">
                <asp:Button ID="Button1" runat="server" Text="Continuar" OnClick="Button1_Click" CssClass="btn btn-info" />
                <button type="button" class="btn btn-danger" data-dismiss="modal">Cancelar</button>
            </div>
        </div>
    </div>
</asp:Panel>
