<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Admin.Master" AutoEventWireup="true" CodeBehind="ConsultasUsuario.aspx.cs" Inherits="ProdeinWebApp.Views.Admin.ConsultasUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
        <div class="row">
            <!-- ============================================================== -->
            <!-- data table  -->
            <!-- ============================================================== -->
            <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
                <div class="card">
                    <div class="card-header">
                        <h3 class="mb-0">Consulta de Usuarios</h3>
                        <p></p>
                    </div>
                    <div class="card-body">
                        <div class="table-responsive" id="listaUsuariosTabla" runat="server">
                                        
                        </div>
                    </div>
                </div>
            </div>
            <!-- ============================================================== -->
            <!-- end data table  -->
            <!-- ============================================================== -->
        </div>               
</asp:Content>