<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Admin.Master" AutoEventWireup="true" CodeBehind="EliminarUsuario.aspx.cs" Inherits="ProdeinWebApp.Views.Admin.EliminarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
            <div class="card" style="margin-left:200px; margin-right:200px;">
                <h3 class="card-header">Eliminar Usuario</h3>
                <div class="card-body">
                    <div class="form-group">
                            <asp:Label ID="lblNombreUsuario" for="txtNombre" runat="server" Text="Nombre"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtNombre" runat="server" type="text" name="name" data-parsley-trigger="change" required="true"  autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                                <p class="text-right">
                                     
                                    <asp:Button runat ="server" ID="btnEliminar" class="btn btn-space btn-primary" OnClick="btnEliminar_Clcik" Text="Eliminar" CausesValidation="False"/> 
                                    <asp:Button runat ="server" ID="btnCancelar" CssClass="btn btn-space btn-secondary" OnClick="btnEliminar_Clcik" Text="Cancelar" cCausesValidation="False"/>
                                </p>
                            </div>
            </div>
     </div>
</asp:Content>
