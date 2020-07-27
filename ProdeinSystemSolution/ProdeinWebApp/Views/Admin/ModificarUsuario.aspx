<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Admin.Master" AutoEventWireup="true" CodeBehind="ModificarUsuario.aspx.cs" Inherits="ProdeinWebApp.Views.Admin.ModificarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <br />
        <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
            <div class="card" style="margin-left:200px; margin-right:200px;">
                <h3 class="card-header">Modificar Usuario</h3>
                <div class="card-body">
                    <div class="form-group">
                        <asp:Label ID="LabelBuscar" for="txtBuscar" runat="server" Text="Buscar"></asp:Label>
                        <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span> 
                        <asp:TextBox ID="txtBuscar" runat="server" type="text" name="name" data-parsley-trigger="change" required="true" 
                                     placeholder="Buscar" autocomplete="off" class="form-control">
                        </asp:TextBox>    
                        <asp:Button ID="btnBuscar" runat="server" class="btn btn-space btn-primary ml-1" Text="Buscar" OnClick="btnBuscar_Click" Width="87px" />
                        </div>
                    </div>
                        <div class="form-group">
                            <asp:Label ID="lblNombreUsuario" for="txtNombre" runat="server" Text="Nombre"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtNombre" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="Nombre del usuario a modificar" autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                       <div class="form-group">
                            <asp:Label ID="lblPassword" for="txtPassword" runat="server" Text="Contraseña"></asp:Label>
                           <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-lock"></i></span></span>
                                <asp:TextBox ID="txtPassword" runat="server" type="password" name="name" data-parsley-trigger="change"  
                                     placeholder="Nueva contraseña" autocomplete="off" class="form-control">
                                </asp:TextBox>       
                           </div>
                        </div>                      
                        <div class="form-group">
                            <asp:Label ID="lblConfirmarPassword" for="txtConfirmarPassword" runat="server" Text="Confirmar Contraseña"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-lock"></i></span></span>
                                <asp:TextBox ID="txtConfirmarPassword" runat="server" data-parsley-equalto="#txtPassword" type="password"  
                                    placeholder="Confirmar contraseña" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>    
                        <div class="form-group">
                            <asp:Label ID="lblRol" for="txtRol" runat="server" Text="Rol"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user-plus"></i></span></span>
                                <asp:TextBox ID="txtRol" runat="server" type="text" required="true" placeholder="User" class="form-control" ReadOnly="True">user</asp:TextBox>
                            </div>
                        </div>
                            <asp:Label ID="lblPermisos" runat="server" Text="Permisos"></asp:Label>
                    <br />
                                <asp:DropDownList ID="dplPermisos" runat="server" style="padding:10px 50px 10px 50px; text-align: left;" class="input-group-prepend be-addon">
                                    <asp:ListItem>Todos</asp:ListItem>
                                    <asp:ListItem>Consultar</asp:ListItem>
                                    <asp:ListItem>Modificar</asp:ListItem>
                                    <asp:ListItem>Agregar</asp:ListItem>
                                    <asp:ListItem>Eliminar</asp:ListItem>
                                </asp:DropDownList>
                    <br />
                        <div class="row">                            
                            <div style="margin-left:auto; margin-right:auto;">
                                <p class="text-right">
                                    <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-space btn-secondary" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="False" />                                  
                                    <asp:Button ID="btnModificar" runat="server" class="btn btn-space btn-primary" Text="Modificar" OnClick="btnModificar_Click" CausesValidation="False" OnClientClick="return confirm(&quot;¿Seguro que va a modificar a este usuario?&quot;)"/> 
                                </p>
                            </div>
                        </div>
                </div>
            </div>
        </div>
</asp:Content>
