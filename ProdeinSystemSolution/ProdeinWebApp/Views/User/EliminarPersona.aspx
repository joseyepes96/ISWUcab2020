<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Home.Master" AutoEventWireup="true" CodeBehind="EliminarPersona.aspx.cs" Inherits="ProdeinWebApp.Views.Persona.EliminarPersona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
            <div class="card" style="margin-left:200px; margin-right:200px;">
                <h3 class="card-header">Eliminar Persona</h3>
                <div class="card-body">
                    <div class="form-group">
                            <asp:Label ID="lblIdentificacionPersona" for="txtNombre" runat="server" Text="Numero de identificacion"></asp:Label>
                            <div class="input-group mb-3"><span class="input-group-prepend"><span class="input-group-text"><i class="fa fa-user"></i></span></span>
                                <asp:TextBox ID="txtIdentificacion" runat="server" type="text" name="name" data-parsley-trigger="change"   autocomplete="off" class="form-control">
                                </asp:TextBox>
                            </div>
                        </div>
                                <p class="text-right">
                                     
                                    <asp:Button runat ="server" ID="btnCancelar" CssClass="btn btn-space btn-secondary" OnClick="btnCancelar_Click" Text="Cancelar" cCausesValidation="False"/>
                                     
                                    <asp:Button runat ="server" ID="btnEliminar" class="btn btn-space btn-primary" OnClick="btnEliminar_Click" Text="Eliminar" CausesValidation="False" OnClientClick="return confirm(&quot;¿Seguro que va a eliminar a esta Persona?&quot;)"/> 
                                </p>
                            </div>
            </div>
     </div>
</asp:Content>
