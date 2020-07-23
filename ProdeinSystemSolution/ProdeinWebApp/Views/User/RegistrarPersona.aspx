<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Home.Master" AutoEventWireup="true" CodeBehind="RegistrarPersona.aspx.cs" Inherits="ProdeinWebApp.Views.User.Persona.RegistrarPersona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <!-- basic form -->
        <!-- ============================================================== -->
    <br />
        <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
            <div class="card" style="margin-left:200px; margin-right:200px;">
                <h3 class="card-header">Registrar Persona</h3>
                <div class="card-body">
                    <%--<form id="basicform" runat="server" data-parsley-validate="">--%>
                        <div class="form-group">
                            <asp:Label ID="lblNombrePersona" for="txtNombre" runat="server" Text="Nombre o Razón Social"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtNombre" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="Ingrese su Nombre y Apellido " autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>     
                    
                        <div class="form-group">
                            <asp:Label ID="lblCedulaRif" runat="server" Text="Cédula o Rif"></asp:Label>
                           <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fas fa-user-times"></i></span></span>
                                <asp:DropDownList ID="dplCedula" runat="server" style="padding:10px 50px 10px 50px; text-align: left;" class="input-group-prepend be-addon">
                                    <asp:ListItem>V</asp:ListItem>
                                    <asp:ListItem>E</asp:ListItem>
                                    <asp:ListItem>P</asp:ListItem>
                                    <asp:ListItem>J</asp:ListItem>
                                    <asp:ListItem>G</asp:ListItem>
                                </asp:DropDownList>
                          
                            </div>
                        </div>

                     <%--<Campo de texto de la cedula o rif>--%>
                        <div class="form-group">
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtCedula" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="Ingrese su cédula o rif" autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>  
                    
                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="Sexo"></asp:Label>
                           <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fas fa-user-times"></i></span></span>
                                <asp:DropDownList ID="dplSexo" runat="server" style="padding:10px 50px 10px 50px; text-align: left;" class="input-group-prepend be-addon">
                                    <asp:ListItem>M</asp:ListItem>
                                    <asp:ListItem>F</asp:ListItem>
                                </asp:DropDownList>       
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label3" runat="server" Text="Estado Civil"></asp:Label>
                           <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fas fa-user-times"></i></span></span>
                                <asp:DropDownList ID="dplEstadoCivil" runat="server" style="padding:10px 50px 10px 50px; text-align: left;" class="input-group-prepend be-addon">
                                    <asp:ListItem>Soltero</asp:ListItem>
                                    <asp:ListItem>Casado</asp:ListItem>
                                    <asp:ListItem>Viudo</asp:ListItem>
                                    <asp:ListItem>Divorciado</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label4" for="txtEdad" runat="server" Text="Edad"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtEdad" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="Edad" autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                    
                        <div class="form-group">
                            <asp:Label ID="Label1" for="txtProfesion" runat="server" Text="Profesión"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtProfesion" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="" autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>

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
                                    <asp:Button ID="btnRegistrar" runat="server" class="btn btn-space btn-primary" Text="Registrar" OnClick="btnRegistrar_Click" /> 
                                    <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-space btn-secondary" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="False" />                                  
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
