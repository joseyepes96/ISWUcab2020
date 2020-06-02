<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="ProdeinWebApp.Views.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
     <!-- Required meta tags -->
        <meta charset="utf-8"/>
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
        <title>Error</title>
        <!-- Bootstrap CSS -->
           <%: Styles.Render("~/bundles/css")%>       
        <style type="text/css">
            .img-fluid {
                height: 359px;
                width: 341px;
            }
        </style>
    </head>

<body>
    <script type="text/javascript">
        function confirmarSalir() {
            if (confirm("Esta seguro de salir?")) {
                return true;
            }
            else {
                return false;
            }
        }
    </script>
    <form id="formError" runat="server">
            <!-- ============================================================== -->
            <!-- main wrapper -->
            <!-- ============================================================== -->
            <div class="dashboard-main-wrapper p-0">
                <!-- ============================================================== -->
                <!-- navbar -->
                <!-- ============================================================== -->
                <nav class="navbar navbar-expand dashboard-top-header bg-white">
                    <div class="container-fluid">
                        <!-- ============================================================== -->
                        <!-- brand logo -->
                        <!-- ============================================================== -->
                        <div class="dashboard-nav-brand">
                            <asp:LinkButton ID="linkSalir" class="dashboard-logo" OnClientClick="return confirmarSalir()" runat="server" PostBackUrl="~/Views/Login.aspx" >Salir</asp:LinkButton>
                        </div>
                        <!-- ============================================================== -->
                        <!-- end brand logo -->
                        <!-- ============================================================== -->
                    </div>
                </nav>
                <!-- ============================================================== -->
                <!-- end navbar -->
                <!-- ============================================================== -->
                <!-- ============================================================== -->
                <!-- wrapper  -->
                <!-- ============================================================== -->
                <div class="bg-light text-center">
                    <div class="container">
                        <div class="row">
                            <div class="offset-xl-2 col-xl-8 offset-lg-2 col-lg-8 col-md-12 col-sm-12 col-12">
                                <div class="error-section">
                                    <img src="../Content/assets/images/Error.png" alt="" class="img-fluid"/>
                                    <div class="error-section-content">
                                        <h1 class="display-3">Ha ocurrido un error</h1>                               
                                        <p>                                     
                                            <asp:Label ID="lblMostrarError" runat="server" Text="Mensaje:"></asp:Label>
                                        </p>
                                        <br />
                                        <asp:LinkButton ID="linkHome" class="btn btn-secondary btn-lg" runat="server" OnClick="linkHome_Click">Regresar al Home</asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- ============================================================== -->
                    <!-- end wrapper -->
                    <!-- ============================================================== -->
                    <!-- ============================================================== -->
                    <!-- end footer -->
                    <!-- ============================================================== -->
                </div>
            </div>
            <!-- ============================================================== -->
            <!-- end main wrapper -->
            <!-- ============================================================== -->
            <!-- ============================================================== -->
            <!-- end main wrapper -->
            <!-- ============================================================== -->
       </form>
       <!-- Optional JavaScript -->
       <%: Scripts.Render("~/bundles/js")%>

</body>
</html>

