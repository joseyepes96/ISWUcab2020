<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Home.Master" AutoEventWireup="true" CodeBehind="ModificarDonaciones.aspx.cs" Inherits="ProdeinWebApp.Views.User.Donaciones.ModificarDonaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
            <div class="card" style="margin-left:200px; margin-right:200px;">
                <h3 class="card-header">Modificar Donacion</h3>
                <div class="card-body">
                    <div class="form-group">
                        <asp:Label ID="LabelBuscar" for="txtBuscar" runat="server" Text="Buscar por Numero de ID"></asp:Label>
                        <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span> 
                        <asp:TextBox ID="txtBuscar" runat="server" type="text" name="name" data-parsley-trigger="change" 
                                     placeholder="Buscar" autocomplete="off" class="form-control">
                        </asp:TextBox>    
                        <asp:Button ID="btnBuscar" runat="server" class="btn btn-space btn-primary ml-1" Text="Buscar" OnClick="btnBuscar_Click" Width="87px" />
                        </div>
                    </div>
                       <div class="form-group">
                            <asp:Label ID="lblNombrePersonaEmpresa" for="txtNombreEmpresaPersona" runat="server" Text="Nombre"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtNombrePresonaEmpresa" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="Ingrese Nombre de la Empresa/Persona" autocomplete="off" class="form-control" Width="363px"></asp:TextBox>
                            </div>
                        </div>     
                    
                        <div class="form-group">
                            <asp:Label ID="lblRifCedula" runat="server" Text="RifCedula"></asp:Label>
                           <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fas fa-user-times"></i></span></span>
                                <asp:DropDownList ID="dplRifCedula" runat="server" style="padding:10px 50px 10px 50px; text-align: left;" class="input-group-prepend be-addon">
                                    <asp:ListItem>V</asp:ListItem>
                                    <asp:ListItem>E</asp:ListItem>
                                    <asp:ListItem>P</asp:ListItem>
                                    <asp:ListItem>J</asp:ListItem>
                                    <asp:ListItem>G</asp:ListItem>
                                </asp:DropDownList>
                          
                            </div>
                        </div>

                     <%--<Campo de texto del rif>--%>
                        <div class="form-group">
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtNumeroRifCedula" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="Ingrese Rif o Cedula" autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>  
                     <%--<----------------------->--%>

                        
                        <div class="form-group">
                            <asp:Label ID="lblFecha" for="txtFecha" runat="server" Text="Fecha"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtFecha" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="" autocomplete="off" class="form-control" Height="22px" Width="138px" TextMode="Date"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label7" runat="server" Text="tipoDonacion"></asp:Label>
                           <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fas fa-user-times"></i></span></span>
                                <asp:DropDownList ID="dplTipo" runat="server" style="padding:10px 50px 10px 50px; text-align: left;" class="input-group-prepend be-addon">
                                    <asp:ListItem>Periodica</asp:ListItem>
                                    <asp:ListItem>Unica</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    <div class="form-group">
                            <asp:Label ID="lblFormaPago" runat="server" Text="formaDePago"></asp:Label>
                           <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fas fa-user-times"></i></span></span>
                                <asp:DropDownList ID="dplPago" runat="server" style="padding:10px 50px 10px 50px; text-align: left;" class="input-group-prepend be-addon">
                                    <asp:ListItem>Debito</asp:ListItem>
                                    <asp:ListItem>Credito</asp:ListItem>
                                    <asp:ListItem>Efectivo</asp:ListItem>
                                    <asp:ListItem>Trasnferencia</asp:ListItem>
                                    <asp:ListItem>Deposito</asp:ListItem>
                                    <asp:ListItem>Pago Movil</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    <div class="form-group">
                            <asp:Label ID="lblMoneda" runat="server" Text="moneda"></asp:Label>
                           <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fas fa-user-times"></i></span></span>
                                <asp:DropDownList ID="dplMoneda" runat="server" style="padding:10px 50px 10px 50px; text-align: left;" class="input-group-prepend be-addon">
                                    <asp:ListItem>Bolivares</asp:ListItem>
                                    <asp:ListItem>Dolares</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="lblMonto" for="txtMonto" runat="server" Text="Monto"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtMonto" runat="server" type="text" name="name" data-parsley-trigger="change"  
                                     placeholder="" autocomplete="off" class="form-control" Width="363px"></asp:TextBox>
                            </div>
                        </div>                          
                <br />
                <br /> 
                        <div class="row">                            
                            <div style="margin-left:auto; margin-right:auto;">
                                <p class="text-right">
                                    <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-space btn-secondary" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="False" />                                  
                                    <asp:Button ID="btnModificar" runat="server" class="btn btn-space btn-primary" Text="Modificar" OnClick="btnModificar_Click" CausesValidation="False" OnClientClick="return confirm(&quot;¿Seguro que va a modificar a esta Persona?&quot;)"/> 
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
