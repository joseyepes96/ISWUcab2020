<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Home.Master" AutoEventWireup="true" CodeBehind="ConsultarDonaciones.aspx.cs" Inherits="ProdeinWebApp.Views.User.Donaciones.ConsultarDonaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
            <!-- ============================================================== -->
            <!-- data table  -->
            <!-- ============================================================== -->
            <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
                <div class="card">
                    <div class="card-header">
                        <h3 class="mb-0">Consulta de Donaciones</h3>
                        <p></p>
                    </div>
                    <div class="card-body">
                        <div class="table-responsive" id="listaDonacionesTabla" runat="server">
                                        
                        </div>
                    </div>
                </div>
                <div class="row">                            
                            <div style="margin-left:auto; margin-right:auto;">
                                <p class="text-right">
                                    <asp:Button ID="btnVolver" runat="server" CssClass="btn btn-space btn-secondary" Text="Volver" OnClick="btnVolver_Click" CausesValidation="False" />                                  
                                </p>
                            </div>
                        </div>
            </div>
            <!-- ============================================================== -->
            <!-- end data table  -->
            <!-- ============================================================== -->
        </div>     
</asp:Content>
