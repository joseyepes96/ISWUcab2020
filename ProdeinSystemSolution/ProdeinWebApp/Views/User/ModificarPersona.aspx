<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Home.Master" AutoEventWireup="true" CodeBehind="ModificarPersona.aspx.cs" Inherits="ProdeinWebApp.Views.Persona.ModificarPersona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
        <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
            <div class="card" style="margin-left:200px; margin-right:200px;">
                <h3 class="card-header">Modificar Persona</h3>
                <div class="card-body">
                    <div class="form-group">
                        <asp:Label ID="LabelBuscar" for="txtBuscar" runat="server" Text="Buscar Numero de identificacion"></asp:Label>
                        <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span> 
                        <asp:TextBox ID="txtBuscar" runat="server" type="text" name="name" data-parsley-trigger="change" 
                                     placeholder="Buscar" autocomplete="off" class="form-control">
                        </asp:TextBox>    
                        <asp:Button ID="btnBuscar" runat="server" class="btn btn-space btn-primary ml-1" Text="Buscar" OnClick="btnBuscar_Click" Width="87px" />
                        </div>
                    </div>
                        <div class="form-group">
                            <asp:Label ID="lblTipoDocumento" for="txtTipo" runat="server" Text="Tipo"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtTipo" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="Tipo de Documento" autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                    <div class="form-group">
                            <asp:Label ID="lblIdentificacion" for="txtIdentificacion" runat="server" Text="Numero de identificacion"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtIdentificacion" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="Numero de Identificacion" autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                    <div class="form-group">
                            <asp:Label ID="lblNombre" for="txtNombre" runat="server" Text="Nombre/Razon Social"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtNombre" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                      autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                            <asp:Label ID="lblSexo" runat="server" Text="Sexo"></asp:Label>
                    <br />
                                <asp:DropDownList ID="dplSexo" runat="server" style="padding:10px 50px 10px 50px; text-align: left;" class="input-group-prepend be-addon">
                                    <asp:ListItem>Masculino</asp:ListItem>
                                    <asp:ListItem>Femenino</asp:ListItem>
                                </asp:DropDownList>
                    <br />
                    <div class="form-group">
                            <asp:Label ID="lblEstadoCivil" for="txtEstCivil" runat="server" Text="Estado Civil"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtEstCivil" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                      autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                    <div class="form-group">
                            <asp:Label ID="lblEdad" for="txtEdad" runat="server" Text="Edad"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtEdad" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                      autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                    <div class="form-group">
                            <asp:Label ID="lblProfesion" for="txtProfesion" runat="server" Text="Profesion"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtProfesion" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                      autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                    <div class="form-group">
                            <asp:Label ID="lblCorreo" for="txtCorreo" runat="server" Text="Correo"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtCorreo" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                      autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                    <div class="form-group">
                            <asp:Label ID="lblDireccion" for="txtDireccion" runat="server" Text="Direccion"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtDireccion" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                      autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                    <div class="form-group">
                            <asp:Label ID="lblPais" for="txtPais" runat="server" Text="Pais"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtPais" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                      autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                    <div class="form-group">
                            <asp:Label ID="lblEstado" for="txtEstado" runat="server" Text="Estado"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtEstado" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                      autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                    <div class="form-group">
                            <asp:Label ID="lblZonaPostal" for="txtZonaPostal" runat="server" Text="Zona Postal"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtZonaPostal" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                      autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                    <div class="form-group">
                            <asp:Label ID="lblTlf1" for="txtTlf1" runat="server" Text="Telefono 1"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtTlf1" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                      autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                    <div class="form-group">
                            <asp:Label ID="lblTlf2" for="txtTlf2" runat="server" Text="Telefono 2"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtTlf2" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                      autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                    <br /> 
                        <div class="row">                            
                            <div style="margin-left:auto; margin-right:auto;">
                                <p class="text-right">
                                    <asp:Button ID="btnModificar" runat="server" class="btn btn-space btn-primary" Text="Modificar" OnClick="btnModificar_Click" CausesValidation="False" OnClientClick="return confirm(&quot;¿Seguro que va a modificar a esta Persona?&quot;)"/> 
                                    <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-space btn-secondary" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="False" />                                  
                                </p>
                            </div>
                        </div>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </div>
            </div>
        </div>
</asp:Content>
