﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="AlimentosSantiago.Web.Productos.Productos" %>
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
                        <div class="col-md-3 col-sm-6 mix portfolio-item Pizza">       
                            <div class="portfolio-wrapper">                
                                <div class="portfolio-thumb">
                                    <img src="../images/product1.jpg" alt="" />
                                    <div class="hover">
                                        <div class="hover-iner">
                                            <a class="fancybox" href="../images/product1_big.jpg"><img src="../images/open-icon.png" alt="" /></a>
                                            <span>Pizza</span>
                                        </div>
                                    </div>
                                </div>  
                                <div class="label-text">
                                    <h3><a href="single-post.html">Vege Pizza</a></h3>
                                    <span class="text-category">$16.00</span>
                                </div>
                            </div>          
                        </div>
                        <div class="col-md-3 col-sm-6 mix portfolio-item ginger">       
                            <div class="portfolio-wrapper">                
                                <div class="portfolio-thumb">
                                    <img src="../images/product2.jpg" alt="" />
                                    <div class="hover">
                                        <div class="hover-iner">
                                            <a class="fancybox" href="../images/product2_big.jpg"><img src="../images/open-icon.png" alt="" /></a>
                                            <span>Ginger</span>
                                        </div>
                                    </div>
                                </div>  
                                <div class="label-text">
                                    <h3><a href="single-post.html">Ginger Tea</a></h3>
                                    <span class="text-category">$24.00</span>
                                </div>
                            </div>          
                        </div>
                        <div class="col-md-3 col-sm-6 mix portfolio-item pizza">       
                            <div class="portfolio-wrapper">                
                                <div class="portfolio-thumb">
                                    <img src="../images/product3.jpg" alt="" />
                                    <div class="hover">
                                        <div class="hover-iner">
                                            <a class="fancybox" href="../images/product3_big.jpg"><img src="../images/open-icon.png" alt="" /></a>
                                            <span>Pizza</span>
                                        </div>
                                    </div>
                                </div>  
                                <div class="label-text">
                                    <h3><a href="single-post.html">Fresh Salad</a></h3>
                                    <span class="text-category">$12.00</span>
                                </div>
                            </div>          
                        </div>
                        <div class="col-md-3 col-sm-6 mix portfolio-item pasta">       
                            <div class="portfolio-wrapper">                
                                <div class="portfolio-thumb">
                                    <img src="../images/product4.jpg" alt="" />
                                    <div class="hover">
                                        <div class="hover-iner">
                                            <a class="fancybox" href="../images/product4_big.jpg"><img src="../images/open-icon.png" alt="" /></a>
                                            <span>Pasta</span>
                                        </div>
                                    </div>
                                </div>  
                                <div class="label-text">
                                    <h3><a href="single-post.html">Healthy Herbal Tea</a></h3>
                                    <span class="text-category">$8.00</span>
                                </div>
                            </div>          
                        </div>
                        <div class="col-md-3 col-sm-6 mix portfolio-item drink">       
                            <div class="portfolio-wrapper">                
                                <div class="portfolio-thumb">
                                    <img src="../images/product5.jpg" alt="" />
                                    <div class="hover">
                                        <div class="hover-iner">
                                            <a class="fancybox" href="../images/product5_big.jpg"><img src="../images/open-icon.png" alt="" /></a>
                                            <span>Drink</span>
                                        </div>
                                    </div>
                                </div>  
                                <div class="label-text">
                                    <h3><a href="single-post.html">Fruit Salad</a></h3>
                                    <span class="text-category">$12.50</span>
                                </div>
                            </div>          
                        </div>
                        <div class="col-md-3 col-sm-6 mix portfolio-item hamburger">       
                            <div class="portfolio-wrapper">                
                                <div class="portfolio-thumb">
                                    <img src="../images/product6.jpg" alt="" />
                                    <div class="hover">
                                        <div class="hover-iner">
                                            <a class="fancybox" href="../images/product6_big.jpg"><img src="../images/open-icon.png" alt="" /></a>
                                            <span>Hamburger</span>
                                        </div>
                                    </div>
                                </div>  
                                <div class="label-text">
                                    <h3><a href="single-post.html">Spicy Hamburger</a></h3>
                                    <span class="text-category">$7.50</span>
                                </div>
                            </div>          
                        </div>
                        <div class="col-md-3 col-sm-6 mix portfolio-item pizza">       
                            <div class="portfolio-wrapper">                
                                <div class="portfolio-thumb">
                                    <img src="../images/product7.jpg" alt="" />
                                    <div class="hover">
                                        <div class="hover-iner">
                                            <a class="fancybox" href="../images/product7_big.jpg"><img src="../images/open-icon.png" alt="" /></a>
                                            <span>Pizza</span>
                                        </div>
                                    </div>
                                </div>  
                                <div class="label-text">
                                    <h3><a href="single-post.html">Chocolate Cake</a></h3>
                                    <span class="text-category">$16.00</span>
                                </div>
                            </div>          
                        </div>
                        <div class="col-md-3 col-sm-6 mix portfolio-item pasta">       
                            <div class="portfolio-wrapper">                
                                <div class="portfolio-thumb">
                                    <img src="../images/product8.jpg" alt="" />
                                    <div class="hover">
                                        <div class="hover-iner">
                                            <a class="fancybox" href="../images/product8_big.jpg"><img src="../images/open-icon.png" alt="" /></a>
                                            <span>Pasta</span>
                                        </div>
                                    </div>
                                </div>  
                                <div class="label-text">
                                    <h3><a href="single-post.html">Berry Taste</a></h3>
                                    <span class="text-category">$15.00</span>
                                </div>
                            </div>          
                        </div>
                        <div class="col-md-3 col-sm-6 mix portfolio-item hamburger">       
                            <div class="portfolio-wrapper">                
                                <div class="portfolio-thumb">
                                    <img src="../images/product3.jpg" alt="" />
                                    <div class="hover">
                                        <div class="hover-iner">
                                            <a class="fancybox" href="../images/product3_big.jpg"><img src="../images/open-icon.png" alt="" /></a>
                                            <span>Hamburger</span>
                                        </div>
                                    </div>
                                </div>  
                                <div class="label-text">
                                    <h3><a href="single-post.html">Onion Grilled</a></h3>
                                    <span class="text-category">$16.00</span>
                                </div>
                            </div>          
                        </div>
                        <div class="col-md-3 col-sm-6 mix portfolio-item drink">       
                            <div class="portfolio-wrapper">                
                                <div class="portfolio-thumb">
                                    <img src="../images/product2.jpg" alt="" />
                                    <div class="hover">
                                        <div class="hover-iner">
                                            <a class="fancybox" href="../images/product2_big.jpg"><img src="../images/open-icon.png" alt="" /></a>
                                            <span>Drink</span>
                                        </div>
                                    </div>
                                </div>  
                                <div class="label-text">
                                    <h3><a href="single-post.html">Another Ginger</a></h3>
                                    <span class="text-category">$18.00</span>
                                </div>
                            </div>          
                        </div>
                        <div class="col-md-3 col-sm-6 mix portfolio-item ginger">       
                            <div class="portfolio-wrapper">                
                                <div class="portfolio-thumb">
                                    <img src="../images/product1.jpg" alt="" />
                                    <div class="hover">
                                        <div class="hover-iner">
                                            <a class="fancybox" href="../images/product1_big.jpg"><img src="../images/open-icon.png" alt="" /></a>
                                            <span>Ginger</span>
                                        </div>
                                    </div>
                                </div>  
                                <div class="label-text">
                                    <h3><a href="single-post.html">Mocha Coffee</a></h3>
                                    <span class="text-category">$16.00</span>
                                </div>
                            </div>          
                        </div>
                        <div class="col-md-3 col-sm-6 mix portfolio-item pasta">       
                            <div class="portfolio-wrapper">                
                                <div class="portfolio-thumb">
                                    <img src="../images/product6.jpg" alt="" />
                                    <div class="hover">
                                        <div class="hover-iner">
                                            <a class="fancybox" href="../images/product6_big.jpg"><img src="../images/open-icon.png" alt="" /></a>
                                            <span>Pasta</span>
                                        </div>
                                    </div>
                                </div>  
                                <div class="label-text">
                                    <h3><a href="single-post.html">Dessert Time</a></h3>
                                    <span class="text-category">$16.00</span>
                                </div>
                            </div>          
                        </div>
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

</asp:Content>
