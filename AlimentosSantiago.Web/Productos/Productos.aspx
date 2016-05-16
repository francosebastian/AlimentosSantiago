<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="AlimentosSantiago.Web.Productos.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div id="heading">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="heading-content">
                                <h2>Nuestros Productos</h2>
                                <span>Home / <a href="about-us.html">Productos</a></span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div id="products-post">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div id="product-heading">
                                <h2>Con hambre ?</h2>
                                <img src="../images/under-heading.png" alt="" />
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="filters col-md-12 col-xs-12">
                            <ul id="filters" class="clearfix">
                                <li><span class="filter" data-filter="all">Todos</span></li>
                                <asp:Repeater ID="rptCategoriaProductos" runat="server" DataSourceID="efCategoriaPlato">
                                    <ItemTemplate>
                                         <li><span class="filter" data-filter=".<%# Eval("nombre") %>"><%# Eval("nombre") %></span></li>
                                    </ItemTemplate>
                                </asp:Repeater> 
                            </ul>
                        </div>
                    </div>
                      <div class="row" id="Container">
                    <asp:Repeater ID="rptProductos" runat="server" DataSourceID="efPlato">
                        <ItemTemplate>                         
                                <div class="col-md-3 col-sm-6 mix portfolio-item <%# Eval("CategoriaPlato.Nombre") %>">
                                    <div class="portfolio-wrapper">
                                        <div class="portfolio-thumb">
                                            <img src=" <%# Eval("RutaVirtualImagen") %>" alt="" />
                                            <div class="hover">
                                                <div class="hover-iner">
                                                    <a class="fancybox" href="<%# Eval("RutaVirtualImagen") %>">
                                                        <img src="<%# Eval("RutaVirtualImagen") %>" alt="" /></a>
                                                    <span><%# Eval("CategoriaPlato.Nombre") %></span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="label-text">
                                            <h3><a href="single-post.html"><%# Eval("Nombre") %></a></h3>
                                            <span class="text-category">$<%# Eval("Precio") %></span>
                                        </div>
                                    </div>
                                </div>
                        </ItemTemplate>
                    </asp:Repeater>
                   </div>
                    <div class="pagination">
                        <div class="row">   
                            <div class="col-md-12">
                                <ul>
                                	<li><a href="#">Previous</a></li>
                                    <li><a href="#">1</a></li>
                                    <li><a href="#">2</a></li>
                                    <li><a href="#">3</a></li>
                                    <li><a href="#">4</a></li>
                                    <li><a href="#">Next</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>     
                </div>
            </div>
            


    
        <script src="../Scripts/vendor/jquery-1.11.0.min.js"></script>
        <script src="../Scripts/vendor/jquery.gmap3.min.js"></script>
        <script src="../Scripts/plugins.js"></script>
        <script src="../Scripts/main.js"></script>

       <ef:EntityDataSource ID="efCategoriaPlato" runat="server"
                                                        ContextTypeName="AlimentosSantiago.Dao.OracleDbContext"
                                                        EntitySetName="CategoriaPlato"
                                                        Select="it.Id,it.Nombre, it.Descripcion">
                                                    </ef:EntityDataSource>
     <ef:EntityDataSource ID="efPlato" runat="server"
                                                        ContextTypeName="AlimentosSantiago.Dao.OracleDbContext"
                                                        EntitySetName="Plato"
                                                        Include="CategoriaPlato">
                                                    </ef:EntityDataSource>
     

</asp:Content>
