<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="VerRuta.aspx.cs" Inherits="AlimentosSantiago.Web.Repartidor.VerRuta" %>
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
    <script type="text/javascript">
        window.onload = function () {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(success);
            } else {
                alert("Geo Location is not supported on your current browser!");
            }
           

        }

        function success(position){
            var latitude = position.coords.latitude;
            var longitude = position.coords.longitude;
            var pointA = new google.maps.LatLng(latitude, longitude),
             pointB = new google.maps.LatLng(markers[0].lat, markers[0].lng),
             myOptions = {
                 center:   google.maps.LatLng(markers[0].lat, markers[0].lng),
                 zoom: 13,
                 mapTypeId: google.maps.MapTypeId.ROADMAP
             },
             map = new google.maps.Map(document.getElementById('googleMap'), myOptions),
             // Instantiate a directions service.
             directionsService = new google.maps.DirectionsService,
             directionsDisplay = new google.maps.DirectionsRenderer({
                 map: map
             });

            // get route from A to B
            calculateAndDisplayRoute(directionsService, directionsDisplay, pointA, pointB);
        }


        function calculateAndDisplayRoute(directionsService, directionsDisplay, pointA, pointB) {
            directionsService.route({
                origin: pointA,
                destination: pointB,
                travelMode: google.maps.TravelMode.DRIVING
            }, function (response, status) {
                if (status == google.maps.DirectionsStatus.OK) {
                    directionsDisplay.setDirections(response);
                } else {
                    window.alert('Directions request failed due to ' + status);
                }
            });
        }

    </script>

    
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="heading-section">
                    <h2>Ver Ruta</h2>
                    <img src="../images/under-heading.png" alt=""/>
                </div>
            </div>
            <div class="col-md-12">
                <asp:Panel runat="server" ID="pnlMapa">
                    <div id="googleMap" style="height: 340px;"></div>
                </asp:Panel>
            </div>
        </div>
           
        </div>
</asp:Content>
