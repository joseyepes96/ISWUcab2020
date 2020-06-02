<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Admin.Master" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="ProdeinWebApp.Views.Admin.RegistrarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <!-- basic form -->
        <!-- ============================================================== -->
    <br />
        <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
            <div class="card" style="margin-left:200px; margin-right:200px;">
                <h3 class="card-header">Registrar Usuario</h3>
                <div class="card-body">
                    <%--<form id="basicform" runat="server" data-parsley-validate="">--%>
                        <div class="form-group">
                            <asp:Label ID="lblNombreUsuario" for="txtNombre" runat="server" Text="Nombre Apellido"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtNombre" runat="server" type="text" name="name" data-parsley-trigger="change" required="true" 
                                     placeholder="Ingrese su NombreApellido para el sistema" autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                       <div class="form-group">
                            <asp:Label ID="lblPassword" for="txtPassword" runat="server" Text="Contraseña"></asp:Label>
                           <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-lock"></i></span></span>
                                <asp:TextBox ID="txtPassword" runat="server" type="password" name="name" data-parsley-trigger="change" required="true" 
                                     placeholder="Ingrese su contraseña" autocomplete="off" class="form-control">
                                </asp:TextBox>       
                           </div>
                        </div>                      
                        <div class="form-group">
                            <asp:Label ID="lblConfirmarPassword" for="txtConfirmarPassword" runat="server" Text="Confirmar Contraseña"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-lock"></i></span></span>
                                <asp:TextBox ID="txtConfirmarPassword" runat="server" data-parsley-equalto="#txtPassword" type="password" required="true" 
                                    placeholder="Ingrese nuevamente su contraseña" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblRol" for="txtRol" runat="server" Text="Rol"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user-plus"></i></span></span>
                                <asp:TextBox ID="txtRol" runat="server" type="text" required="true" placeholder="User" class="form-control" ReadOnly="True">user</asp:TextBox>
                            </div>
                        </div>
                        
                        <div class="form-group">
                            <asp:Label ID="lblPermisos" runat="server" Text="Permisos"></asp:Label>
                           <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fas fa-user-times"></i></span></span>
                                <asp:DropDownList ID="dplPermisos" runat="server" style="padding:10px 50px 10px 50px; text-align: left;" class="input-group-prepend be-addon">
                                    <asp:ListItem>Todos</asp:ListItem>
                                    <asp:ListItem>Consultar</asp:ListItem>
                                    <asp:ListItem>Modificar</asp:ListItem>
                                    <asp:ListItem>Agregar</asp:ListItem>
                                    <asp:ListItem>Eliminar</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    <br />
                    <br />
                        <div class="row">                            
                            <div style="margin-left:auto; margin-right:auto;">
                                <p class="text-right">
                                    <asp:Button ID="btnRegistrar" runat="server" class="btn btn-space btn-primary" Text="Registrar" OnClick="btnRegistrar_Click" /> 
                                    <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-space btn-secondary" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="False" />                                  
                                </p>
                            </div>
                        </div>
                    <%--</form>--%>
                </div>
            </div>
        </div>
        <!-- ============================================================== -->
        <!-- end basic form -->
        <!-- ============================================================== -->

</asp:Content>
