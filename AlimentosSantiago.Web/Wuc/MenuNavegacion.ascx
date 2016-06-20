<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuNavegacion.ascx.cs" Inherits="AlimentosSantiago.Web.Wuc.MenuNavegacion" %>
<nav class="navbar navbar-default" role="navigation" runat="server" id="navBar">
    <!-- El logotipo y el icono que despliega el menú se agrupan
       para mostrarlos mejor en los dispositivos móviles -->
    <div class="navbar-header">
        <button type="button" class="navbar-toggle" data-toggle="collapse"
            data-target=".navbar-ex1-collapse">
            <span class="sr-only">Desplegar navegación</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
        </button>
        <a id="lnkLogin" runat="server" class="navbar-brand" href="../Login.aspx" visible="false">Login</a>
        <a id="lnkUsuario" runat="server" class="navbar-brand" href="../Home.aspx" visible="false"><asp:Label ID="lblUserName" runat="server"/></a>

    </div>
    <div class="collapse navbar-collapse navbar-ex1-collapse">
        <ul class="nav navbar-nav">

            <li class="dropdown" runat="server" id="navAdministracion" visible="false">
                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Administracion <b class="caret"></b>
                </a>
                <ul class="dropdown-menu">
                    <li><a href="../Administracion/AgregarUsuario.aspx">Agregar usuario</a></li>
                    <li><a href="../Administracion/AgregarTipoUsuario.aspx">Agregar Tipo Usuario</a></li>
                    <li><a href="../Administracion/AgregarPlato.aspx">Agregar Plato</a></li>
                    <li><a href="../Administracion/AgregarEmpresa.aspx">Agregar Empresa</a></li>
                    <li><a href="../Administracion/AgregarCategoriaPlato.aspx">Agregar Categoria plato</a></li>
                    <li><a href="../Administracion/AgregarEstadoPedido.aspx">Agregar Estado Pedido</a></li>
                    <li><a href="../Administracion/AgregarTipoPago.aspx">Agregar TipoPago</a></li>

                    <li class="divider"></li>
                    <li><a href="../Administracion/VerUsuarios.aspx">Ver Usuarios</a></li>
                    <li><a href="../Administracion/VerTipoUsuario.aspx">Ver Tipo Usuarios</a></li>
                    <li><a href="../Administracion/VerPlato.aspx">Ver Platos</a></li>
                    <li><a href="../Administracion/VerEmpresas.aspx">Ver Empresas</a></li>
                    <li><a href="../Administracion/VerCategoriaPlatos.aspx">Ver Categoria platos</a></li>
                    <li><a href="../Administracion/VerEstadoPedido.aspx">Ver Estados Pedidos</a></li>
                    <li><a href="../Administracion/VerTipoPago.aspx">Ver TipoPagos</a></li>
                    <li class="divider"></li>
                    <li><a href="../CerrarSession.aspx">Cerrar Session</a></li>
                </ul>
            </li>



            <li class="dropdown"  runat="server" id="navAdministradorEmpresa"  visible="false">
                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Administracion Empresas <b class="caret"></b>
                </a>
                <ul class="dropdown-menu">
                    <li><a href="../AdministracionEmpresa/AgregarTrabajador.aspx">Agregar Trabajador</a></li>
                    <li class="divider"></li>
                    <li><a href="../AdministracionEmpresa/CargarSaldo.aspx">Cargar Saldo</a></li>
                    <li class="divider"></li>
                    <li><a href="../AdministracionEmpresa/MiEmpresa.aspx">Mi Empresa</a></li>
                    <li class="divider"></li>
                    <li><a href="../CerrarSession.aspx">Cerrar Session</a></li>
                </ul>
            </li>

             <li class="dropdown"  runat="server" id="navCliente"  visible="false">
                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Cliente<b class="caret"></b>
                </a>
                <ul class="dropdown-menu">
                    <li><a href="../MiCuenta/MisDirecciones.aspx">Administrar Direcciones</a></li>
                    <li class="divider"></li>
                    <li><a href="../Pedidos/VerPedidos.aspx">VerPedidos</a></li>
                    <li class="divider"></li>
                    <li><a href="../MiCuenta/CambiarPassword.aspx">Cambiar Contraseña</a></li>
                    <li class="divider"></li>
                    <li><a href="../CerrarSession.aspx">Cerrar Session</a></li>
                </ul>
            </li>
             <li class="dropdown"  runat="server" id="navRepartidor"  visible="false">
                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Repartidor<b class="caret"></b>
                </a>
                <ul class="dropdown-menu">
                    <li><a href="../Repartidor/MisRutas.aspx">Ver Rutas</a></li>
                          <li class="divider"></li>
                    <li><a href="../CerrarSession.aspx">Cerrar Session</a></li>
                </ul>
            </li>
               <li class="dropdown"  runat="server" id="navEncargadoPedido"  visible="false">
                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Repartidor<b class="caret"></b>
                </a>
                <ul class="dropdown-menu">
                    <li><a href="../AdministracionEncargadoPedido/VerPedidos.aspx">Ver Pedidos</a></li>
                          <li class="divider"></li>
                    <li><a href="../CerrarSession.aspx">Cerrar Session</a></li>
                </ul>
            </li>


        <li class="dropdown"  runat="server" id="navAdministracionProveedor"  visible="false">
            <a href="#" class="dropdown-toggle" data-toggle="dropdown">Administracion Proveedor <b class="caret"></b>
            </a>
            <ul class="dropdown-menu">
                <li><a href="../AdministracionProveedor/AgregarPlato.aspx">Agregar Plato</a></li>
                <li class="divider"></li>
                <li><a href="../AdministracionProveedor/VerPlatos.aspx">Ver Platos</a></li>
                     <li class="divider"></li>
                <li><a href="../AdministracionProveedor/VerPedidos.aspx">Ver Pedidos</a></li>
                      <li class="divider"></li>
                    <li><a href="../CerrarSession.aspx">Cerrar Session</a></li>
            </ul>
        </li>
        </ul>
        <ul class="nav navbar-nav navbar-right">
            <li>
                <div class="cart-info">
                    <i class="fa fa-shopping-cart"></i>
                    (<a href="../Pedidos/NuevoPedido.aspx"><asp:Literal runat="server" ID="countCarro"/></a>) en tu carro (<a href="../Pedidos/NuevoPedido.aspx">$<asp:Literal runat="server" ID="totalCarro"/></a>)
                </div>
            </li>
        </ul>
    </div>
</nav>
