<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="MiDireccion.aspx.cs" Inherits="AlimentosSantiago.Web.MiCuenta.MiDireccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="http://maps.googleapis.com/maps/api/js?sensor=false"> </script>
      <script type="text/javascript">
        var markers = [
        <asp:Repeater ID="rptMarkers" runat="server">
        <ItemTemplate>
                    {
                    "title": '<%# Eval("Address") %>',
                    "lat": '<%# Eval("Latitude") %>',
                    "lng": '<%# Eval("Longitude") %>',
                    "description": '<%# Eval("Address") %>'
                }
        </ItemTemplate>
        <SeparatorTemplate>
            ,
        </SeparatorTemplate>
        </asp:Repeater>
        ];
        </script>
    <script>
        window.onload = function () {
            var map_options = {
                center: new google.maps.LatLng(markers[0].lat, markers[0].lng),
                zoom: 13,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            var infoWindow = new google.maps.InfoWindow();
            var map = new google.maps.Map(document.getElementById("googleMap"), map_options);
            for (i = 0; i < markers.length; i++) {
                var data = markers[i]
                var myLatlng = new google.maps.LatLng(data.lat, data.lng);
                var marker = new google.maps.Marker({
                    position: myLatlng,
                    map: map,
                    title: data.title
                });
                (function (marker, data) {
                    google.maps.event.addListener(marker, "click", function (e) {
                        infoWindow.setContent(data.description);
                        infoWindow.open(map, marker);
                    });
                })(marker, data);
            }
        }
    </script>
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="heading-section">
                    <h2>Mis Direcciones</h2>
                    <img src="../images/under-heading.png" alt=""/>
                </div>
            </div>
            <div class="col-md-12">
                <asp:Panel runat="server" ID="pnlMapa" Visible="false">
                    <div id="googleMap" style="height: 340px;"></div>
                </asp:Panel>
            </div>
            <div class="col-md-12">
                <asp:Label runat="server" ID="lblNombre" AssociatedControlID="txtNombre"><span class="text-danger">*</span> Nombre</asp:Label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control required"
                    title="Ingrese nombre direccion. Ej: Oficina" placeholder="Ej: Oficina"
                    MaxLength="50"></asp:TextBox>
                <asp:Label runat="server" ID="lblDireccion" AssociatedControlID="tbDireccion"><span class="text-danger">*</span> Dirección</asp:Label>
                <asp:TextBox runat="server" ID="tbDireccion" CssClass="form-control required"
                    title="Ingrese dirección. Ej: El Salto 8000" placeholder="Ej: El Salto 8000"
                    Text='algo' MaxLength="50"></asp:TextBox>
                <asp:HiddenField ID="hndLatitud" runat="Server"/>
                <asp:HiddenField ID="hndLongitud" runat="Server"/>
            </div>
              <div class="col-md-12">
                <asp:Label runat="server" ID="lblBuscar" AssociatedControlID="btnBuscar"><span class="text-danger">*</span> Buscar</asp:Label>
                <asp:Button runat="server" ID="btnBuscar" Text="Buscar Direccion" OnClick="FindCoordinates"></asp:Button>
                <asp:Panel runat="server" ID="pnlGuardar" Visible="false">
                      <asp:Label runat="server" ID="lblGuardar" AssociatedControlID="btnGuardar"><span class="text-danger">*</span> Guardar</asp:Label>
                      <asp:Button runat="server" ID="btnGuardar" Text="Guardar Direccion" OnClick="btnGuardar_Click"></asp:Button>
                </asp:Panel>
            </div>
        </div>
    </div>
</asp:Content>
