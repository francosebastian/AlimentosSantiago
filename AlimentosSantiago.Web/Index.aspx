<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AlimentosSantiago.Web.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div id="slider">
        <div class="flexslider">
            <ul class="slides">
                <li>
                    <div class="slider-caption">
                        <h1>Colaciones</h1>
                        <p>
                            Variedad en colaciones, puedes elegir entre frutas, lácteos , frutos secos o pan.
                            <br/>
                            <br/>
                            Colaciones "El Comilon"
                        </p>
                        <a href="single-post.html">Comprar Ahora</a>
                    </div>
                    <img src="images/slide1.jpg" alt="" />
                </li>
                <li>
                    <div class="slider-caption">
                        <h1>Menus</h1>
                        <p>
                            Ve nuestra lista de menu y sorprendete con la gran variedad de comida que tenemos disponible para ti
                            <br/>
                            <br/>
                            Aprovecha de Nuestras Grandes OFERTAS en Menus
                        </p>
                        <a href="single-post.html">More Details</a>
                    </div>
                    <img src="images/slide2.jpg" alt="" />
                </li>
                <li>
                    <div class="slider-caption">
                        <h1>Comidas saludables</h1>
                        <p>
                            sorprendete con nuestra variedad de comidas saludables 
                            <br/>
                            <br/>
                            Alimentos sin gluten, Alimentos con reducido contenido en grasa, colesterol y ácidos grasos saturados
                        </p>
                        <a href="single-post.html">Get Ready</a>
                    </div>
                    <img src="images/slide3.jpg" alt="" />
                </li>
            </ul>
        </div>
    </div>


    <div id="services">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="heading-section">
                        <h2>Free Website Templates</h2>
                        <img src="images/under-heading.png" alt=""/>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-3 col-sm-6">
                    <div class="service-item">
                        <div class="icon">
                            <i class="fa fa-pencil"></i>
                        </div>
                        <h4>Hace un pedido</h4>
                        <p>Realiza un pedido y sorprendete con la gran calidad que ofrece El Comilon.</p>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6">
                    <div class="service-item">
                        <div class="icon">
                            <i class="fa fa-bullhorn"></i>
                        </div>
                        <h4>Promociones</h4>
                        <p>Descubre las ofertas y promociones especiales que tiene "El comilon" para ti.</p>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6">
                    <div class="service-item">
                        <div class="icon">
                            <i class="fa fa-bell"></i>
                        </div>
                        <h4>Listo para servir</h4>
                        <p>Disfruta Nuestra gran variedad de Productos listos para servir o llevar</p>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6">
                    <div class="service-item">
                        <div class="icon">
                            <i class="fa fa-heart"></i>
                        </div>
                        <h4>Satisfaccion</h4>
                        <p>Evaluanos, tu opinion es importante para nosotros.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>





    <div id="latest-blog">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="heading-section">
                        <h2>Ultimas entradas</h2>
                        <img src="images/under-heading.png" alt="" />
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4 col-sm-6">
                    <div class="blog-post">
                        <div class="blog-thumb">
                            <img src="images/blogpost1.jpg" alt="" />
                        </div>
                        <div class="blog-content">
                            <div class="content-show">
                                <h4><a href="single-post.html">Sandwich</a></h4>
                                <span>29 Sep 2084</span>
                            </div>
                            <div class="content-hide">
                                <p>Sed egestas tincidunt mollis. Suspendisse rhoncus vitae enim et faucibus. Ut dignissim nec arcu nec hendrerit. Sed arcu odio, sagittis vel diam in, malesuada malesuada risus. Aenean a sem leo. Nam ultricies dolor et mi tempor, non pulvinar felis sollicitudin.</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-4 col-sm-6">
                    <div class="blog-post">
                        <div class="blog-thumb">
                            <img src="images/blogpost2.jpg" alt="" />
                        </div>
                        <div class="blog-content">
                            <div class="content-show">
                                <h4><a href="single-post.html">Nuevo sabor</a></h4>
                                <span>LOMITO</span>
                            </div>
                            <div class="content-hide">
                                <p>
                                    El sándwich es siempre la mejor opción para comer rápido y sin complicaciones. Pan: Frica
                                        Carne: lomo de cerdo
Chucrut
Salsa americana
Tomate
Mayonesa
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-4 col-sm-6">
                    <div class="blog-post">
                        <div class="blog-thumb">
                            <img src="images/blogpost3.jpg" alt="" />
                        </div>
                        <div class="blog-content">
                            <div class="content-show">
                                <h4><a href="single-post.html">Pizza italiana</a></h4>
                                <span>Individual/Mediana/Familiar</span>
                            </div>
                            <div class="content-hide">
                                <p>Ingredientes: Salsa - Carne - champiñones - cebolla - pimientos verdes - aceitunas verdes - aceitunas maduras - Quesos </p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-4 col-sm-6">
                    <div class="blog-post">
                        <div class="blog-thumb">
                            <img src="images/blogpost4.jpg" alt="" />
                        </div>
                        <div class="blog-content">
                            <div class="content-show">
                                <h4><a href="single-post.html">Comida saludable</a></h4>
                                <span>Una ensalada verde que te dejará satisfecho</span>
                            </div>
                            <div class="content-hide">
                                <p>Si piensas que las ensaladas son para los conejos, aún no has encontrado la correcta. Ingredientes:Espinaca - champiñones - cebolla - pimientos verdes - aceitunas verdes </p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-4 col-sm-6">
                    <div class="blog-post">
                        <div class="blog-thumb">
                            <img src="images/blogpost5.jpg" alt="" />
                        </div>
                        <div class="blog-content">
                            <div class="content-show">
                                <h4><a href="single-post.html">Un gran desayuno</a></h4>
                                <span>Desayuno COMILON</span>
                            </div>
                            <div class="content-hide">
                                <p>El desayuno podemos considerarlo como una de las comidas más importantes de las que realizamos a lo largo del día. Ingredientes: Cereal - Te o Cafe - Zumo de naranja natural - Frutas</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-4 col-sm-6">
                    <div class="blog-post">
                        <div class="blog-thumb">
                            <img src="images/blogpost6.jpg" alt="" />
                        </div>
                        <div class="blog-content">
                            <div class="content-show">
                                <h4><a href="single-post.html">Jugo Fresco de fruta</a></h4>
                                <span>Zumos Saludables</span>
                            </div>
                            <div class="content-hide">
                                <p>Zumos Naturales de Naranja - Tomate - Piña - Manzana - Zanahoria.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div id="testimonails">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="heading-section">
                        <h2>Que dicen nuestros clientes</h2>
                        <img src="images/under-heading.png" alt="">
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-8 col-md-offset-2">
                    <div class="testimonails-slider">
                        <ul class="slides">
                            <li>
                                <div class="testimonails-content">
                                    <p>Todo muy rico y el pedido llegó dentro del horario indicado como siempre..</p>
                                    <h6>Jennifer - <a href="#">Chief Designer</a></h6>
                                </div>
                            </li>
                            <li>
                                <div class="testimonails-content">
                                    <p>o bueno: llegó antes de lo estipulado. Lo malo: estaba apenas tibio todo, papas, empanadas y twisters, y estos últimos, demasiado secos..</p>
                                    <h6>Laureen - <a href="#">Marketing Executive</a></h6>
                                </div>
                            </li>
                            <li>
                                <div class="testimonails-content">
                                    <p>todo bien, lo que me molesto fue que el repartidor me pidiera propina.</p>
                                    <h6>Tanya - <a href="#">Creative Director</a></h6>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
