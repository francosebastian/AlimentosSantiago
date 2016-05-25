<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AlimentosSantiago.Web.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div id="heading">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="heading-content">
                                <h2>LOGIN</h2>
                                <span>Home / <a href="about-us.html">Productos</a></span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

 <div class="container" style="margin-top:30px">
     <div class="row">
           <div class="col-md-12">
                        <div class="heading-section">
                            <h2>Login</h2>
                            <img src="../images/under-heading.png" alt="" />
                        </div>
                    </div>
         
<div class="col-md-4">
    <div class="panel panel-default">
  <div class="panel-heading"><h3 class="panel-title"><strong>Sign In </strong></h3></div>
  <div class="panel-body">
   <form role="form">
  <div class="form-group">
   
           <asp:Label ID="Username" runat="server">Nombre de Usuario</asp:Label>
                                                    <asp:TextBox ID="TextBox1" runat="server" TextMode="SingleLine"
                                                        title="Ingresar Nombre Usuario." placeholder="Ingresar Nombre Usuario"
                                                        myMaxLength="60" /><br />
  
  </div>
  <div class="form-group">
     
     
         <asp:Label ID="Password" runat="server" >Contraseña    <a href="/sessions/forgot_password">(Olvido la Contraseña?)</a </asp:Label>
                                                    <asp:TextBox ID="TextBox2" runat="server" TextMode="SingleLine"
                                                        title="Ingresar Contraseña." placeholder="Ingresar Contraseña "
                                                        myMaxLength="60" /><br />


   
  </div>
  <button type="submit" class="btn btn-sm btn-default">Sign in</button>
</form>
  </div>
</div>
</div>
         </div>
     </div>
   
</asp:Content>

