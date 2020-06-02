<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProdeinWebApp.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
     <!-- Required meta tags -->
        <meta charset="utf-8"/>
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
        <title>Login</title>
        <!-- Bootstrap CSS -->
           <%: Styles.Render("~/bundles/css")%>       
        <style>
        html,
        body {
            height: 100%;
        }

        body {
            display: -ms-flexbox;
            display: flex;
            -ms-flex-align: center;
            align-items: center;
            padding-top: 40px;
            padding-bottom: 40px;
        }
        </style>
    </head>

<body>
  
        <!-- ============================================================== -->
        <!-- login page  -->
        <!-- ============================================================== -->
        <div class="splash-container">
            <div class="card ">
                <div class="card-header text-center">
                    <span class="splash-description" style="font-size:20px;">Login</span>
                </div>
                <div class="card-body">
                    <form id="formLogin" runat="server">
                        <div class="form-group">
                            <asp:TextBox ID="txtUserName" runat="server" class="form-control form-control-lg" type="text" placeholder="Usuario" required="true" autocomplete="off"></asp:TextBox>                           
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtPassword" runat="server" class="form-control form-control-lg" type="password" placeholder="Contraseña" required="true"></asp:TextBox>
                        </div> 
                        <asp:Button ID="btnAcceder" runat="server" Text="Acceder" class="btn btn-primary btn-lg btn-block" OnClick="btnAcceder_Click" />                     
                    </form>
                </div>
            </div>
        </div>
        <!-- ============================================================== -->
        <!-- end login page  -->
        <!-- ============================================================== -->
        <!-- Optional JavaScript -->
       <%: Scripts.Render("~/bundles/js")%>

</body>
</html>
