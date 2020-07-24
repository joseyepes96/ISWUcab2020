<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Home.Master" AutoEventWireup="true" CodeBehind="RegistrarEmpresa.aspx.cs" Inherits="ProdeinWebApp.Views.User.Empresa.RegistrarEmpresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <!-- basic form -->
        <!-- ============================================================== -->
    <br />
        <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
            <div class="card" style="margin-left:200px; margin-right:200px;">
                <h3 class="card-header">Registrar Empresa</h3>
                <div class="card-body">
                    <%--<form id="basicform" runat="server" data-parsley-validate="">--%>
                        <div class="form-group">
                            <asp:Label ID="lblNombreEmpresa" for="txtNombreEmpresa" runat="server" Text="Razón Social"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtNombreEmpresa" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="Ingrese su Nombre de la Empresa u Organización " autocomplete="off" class="form-control" Width="363px"></asp:TextBox>
                            </div>
                        </div>     
                    
                        <div class="form-group">
                            <asp:Label ID="lblRif" runat="server" Text="Rif"></asp:Label>
                           <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fas fa-user-times"></i></span></span>
                                <asp:DropDownList ID="dplRif" runat="server" style="padding:10px 50px 10px 50px; text-align: left;" class="input-group-prepend be-addon">
                                    <asp:ListItem>J</asp:ListItem>
                                    <asp:ListItem>G</asp:ListItem>
                                </asp:DropDownList>
                          
                            </div>
                        </div>

                     <%--<Campo de texto del rif>--%>
                        <div class="form-group">
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtNumeroRif" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="Ingrese el Rif" autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>  
                     <%--<----------------------->--%>

                        
                        <div class="form-group">
                            <asp:Label ID="Label5" for="txtCorreo" runat="server" Text="Correo"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtCorreo" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="Correo" autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                        
                        <div class="form-group">
                            <asp:Label ID="Label6" for="txtDireccion" runat="server" Text="Dirección"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtDireccion" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="" autocomplete="off" class="form-control" Height="87px" Width="361px"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label7" runat="server" Text="País"></asp:Label>
                           <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fas fa-user-times"></i></span></span>
                                <asp:DropDownList ID="dplPais" runat="server" style="padding:10px 50px 10px 50px; text-align: left;" class="input-group-prepend be-addon">
                                    <asp:ListItem>Bolivia</asp:ListItem>
                                    <asp:ListItem>Colombia</asp:ListItem>
                                    <asp:ListItem>Ecuador</asp:ListItem>
                                    <asp:ListItem>Estados Unidos</asp:ListItem>
                                    <asp:ListItem>España</asp:ListItem>
                                    <asp:ListItem>Perú</asp:ListItem>
                                    <asp:ListItem>Venezuela</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label8" for="txtEstado" runat="server" Text="Estado/Departamento/Provincia"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtEstado" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="" autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label9" for="txtZonaPostal" runat="server" Text="Zona Postal"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtZonaPostal" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="" autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>

                        
                        <div class="form-group">
                            <asp:Label ID="Label10" for="txtTelefono1" runat="server" Text="Telefóno 1"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtTelefono1" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="" autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                        
                        <div class="form-group">
                            <asp:Label ID="Label11" for="txtTelefono2" runat="server" Text="Telefóno 2"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtTelefono2" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="" autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                        
                <br />
                <br />
                 
                        <div class="row">                            
                            <div style="margin-left:auto; margin-right:auto;">
                                <p class="text-right">
                                    <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-space btn-secondary" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="False" />                                  
                                    <asp:Button ID="btnRegistrar" runat="server" class="btn btn-space btn-primary" Text="Registrar" OnClick="btnRegistrar_Click" /> 
                                </p>
                            </div>
                        </div>
                    <br />
                    <br />
                    <%--</form>--%>
                </div>
            </div>
            <br />
            <br />
        </div>
        <!-- ============================================================== -->
        <!-- end basic form -->
        <!-- ============================================================== -->
</asp:Content>
