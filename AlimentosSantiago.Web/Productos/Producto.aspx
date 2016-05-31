<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="AlimentosSantiago.Web.Productos.Producto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView ID="FvProducto" runat="server" ItemType="AlimentosSantiago.Dto.Plato"
        DataKeyNames="Id" DefaultMode="ReadOnly" SelectMethod="FvProducto_GetItem"
        RenderOuterTable="false">
        <ItemTemplate>

            <div id="heading">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="heading-content">
                                <h2><%# Eval("Nombre") %></h2>
                                <span>Home / <a href="single-post.html">Single Post</a></span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div id="product-post">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="heading-section">
                                <h2><%# Eval("Nombre") %></h2>
                                <img src="../images/under-heading.png" alt="" />
                            </div>
                        </div>
                    </div>
                    <div id="single-blog" class="page-section first-section">
                        <div class="container">
                            <div class="row">
                                <div class="product-item col-md-12">
                                    <div class="row">
                                        <div class="col-md-8">
                                            <div class="image">
                                                <div class="image-post">
                                                    <img src="<%# Eval("RutaVirtualImagen") %>" alt="">
                                                </div>
                                            </div>
                                            <div class="product-content">
                                                <div class="product-title">
                                                    <h3><%# Eval("Nombre") %></h3>
                                                    <span class="subtitle">4 comments</span>
                                                </div>
                                                <p>
                                                    <%# Eval("Descripcion")%>
                                                </p>
                                            </div>
                                            <div class="divide-line">
                                                <img src="../images/div-line.png" alt="" />
                                            </div>
                                            <div class="col-md-8">
                                                <asp:Button runat="server" Text="Agregar al pedido" class="btn btn-sm btn-default" ID="BtnAgregar" OnClick="BtnAgregar_Click" />
                                            </div>
                                        </div>
                                        <div class="col-md-3 col-md-offset-1">
                                            <div class="side-bar">
                                                <div class="news-letters">
                                                    <h4>Archives</h4>
                                                    <div class="archives-list">
                                                        <ul>
                                                            <li><a href="#"><i class="fa fa-angle-right"></i>July (12)</a></li>
                                                            <li><a href="#"><i class="fa fa-angle-right"></i>August (18)</a></li>
                                                            <li><a href="#"><i class="fa fa-angle-right"></i>September (72)</a></li>
                                                            <li><a href="#"><i class="fa fa-angle-right"></i>October (63)</a></li>
                                                            <li><a href="#"><i class="fa fa-angle-right"></i>November (48))</a></li>
                                                            <li><a href="#"><i class="fa fa-angle-right"></i>December (24)</a></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                                <div class="recent-post">
                                                    <h4>Recent Posts</h4>
                                                    <div class="posts">
                                                        <div class="recent-post">
                                                            <div class="recent-post-thumb">
                                                                <img src="images/recent-post1.jpg" alt="">
                                                            </div>
                                                            <div class="recent-post-info">
                                                                <h6><a href="#">Vestibulum molestie odio sit amet</a></h6>
                                                                <span>24 Sep 2084</span>
                                                            </div>
                                                        </div>
                                                        <div class="recent-post">
                                                            <div class="recent-post-thumb">
                                                                <img src="images/recent-post2.jpg" alt="">
                                                            </div>
                                                            <div class="recent-post-info">
                                                                <h6><a href="#">Vivamus mattis quam eget urna tincidunt</a></h6>
                                                                <span>22 Sep 2084</span>
                                                            </div>
                                                        </div>
                                                        <div class="recent-post">
                                                            <div class="recent-post-thumb">
                                                                <img src="images/recent-post3.jpg" alt="">
                                                            </div>
                                                            <div class="recent-post-info">
                                                                <h6><a href="#">Curabitur in nunc eget neque posuere</a></h6>
                                                                <span>21 Sep 2084</span>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="advertisement">
                                                    <h4>Flickr news</h4>
                                                    <div class="flickr-images">
                                                        <div class="row">
                                                            <div class="col-md-4 col-sm-2 col-xs-3">
                                                                <img src="images/flickr-image1.jpg" alt="">
                                                            </div>
                                                            <div class="col-md-4 col-sm-2 col-xs-3">
                                                                <img src="images/flickr-image2.jpg" alt="">
                                                            </div>
                                                            <div class="col-md-4 col-sm-2 col-xs-3">
                                                                <img src="images/flickr-image3.jpg" alt="">
                                                            </div>
                                                            <div class="col-md-4 col-sm-2 col-xs-3">
                                                                <img src="images/flickr-image4.jpg" alt="">
                                                            </div>
                                                            <div class="col-md-4 col-sm-2 col-xs-3">
                                                                <img src="images/flickr-image1.jpg" alt="">
                                                            </div>
                                                            <div class="col-md-4 col-sm-2 col-xs-3">
                                                                <img src="images/flickr-image2.jpg" alt="">
                                                            </div>
                                                            <div class="col-md-4 col-sm-2 col-xs-3">
                                                                <img src="images/flickr-image3.jpg" alt="">
                                                            </div>
                                                            <div class="col-md-4 col-sm-2 col-xs-3">
                                                                <img src="images/flickr-image4.jpg" alt="">
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
