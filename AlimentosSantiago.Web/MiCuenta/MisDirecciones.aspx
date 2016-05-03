<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="MisDirecciones.aspx.cs" Inherits="AlimentosSantiago.Web.MiCuenta.MisDirecciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="http://maps.googleapis.com/maps/api/js?key=AIzaSyDY0kkJiTPVd2U7aTOAwhc9ySH6oHxOIYM&amp;sensor=false"> </script>
    <script>

        var map;

        function initialize() {
            var map_options = {
                center: new google.maps.LatLng(16.8496189, 96.1288854),
                zoom: 15,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            var map = new google.maps.Map(document.getElementById("googleMap"), map_options);
        }

        google.maps.event.addDomListener(window, 'load', initialize);
        google.maps.event.addDomListener(window, "resize", function () {
            var center = map.getCenter();
            google.maps.event.trigger(map, "resize");
            map.setCenter(center);
        });
    </script>
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="heading-section">
                    <h2>Mis Direcciones</h2>
                    <img src="../images/under-heading.png" alt="">
                </div>
            </div>
             <div class="col-md-12">
                <div id="googleMap" style="height: 340px;"></div>
            </div>
        </div>
    </div>

</asp:Content>
