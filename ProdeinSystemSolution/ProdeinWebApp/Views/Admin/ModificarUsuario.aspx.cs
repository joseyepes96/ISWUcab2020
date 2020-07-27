using ProdeinWebApp.Controllers;
using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProdeinWebApp.Views.Admin
{
    public partial class ModificarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioController userCtrl = new UsuarioController();
                LoginController loginCtrl = new LoginController();
                bool respuesta = false;
                Usuario usuario = userCtrl.verificarUsuario(txtNombre.Text);
                if (!string.IsNullOrEmpty(usuario._nombre))
                {
                    if (!loginCtrl.validarCampoUsuario(txtNombre.Text))          //Valida que cumpla el formato NombreApellido
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El nombre del usuario no corresponde al formato NombreApellido');", true);
                    else
                    {
                        if (txtPassword.Text.Equals(txtConfirmarPassword.Text))       //Si las contraseñas son iguales
                        {
                            usuario._nombre = txtNombre.Text;
                            usuario._password = txtPassword.Text;
                            usuario._rol = txtRol.Text;
                            usuario._permisos = dplPermisos.SelectedValue;
                            respuesta = userCtrl.modificarUsuario(usuario);
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El usuario ha sido modificado');" +
                                     "window.location ='ModificarUsuario.aspx';", true);
                        }
                        else
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Las contraseñas no son iguales');", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El usuario no existe');", true);
                }
            }
            catch(Exception ex)
            {
                Session["mensajeError"] = "Ha ocurrido un error al modificar el usuario. " + ex;
                Response.Redirect("Error.aspx", false);
            }
           // Response.Redirect("ConsultasUsuario.aspx", false);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioController userCtrl = new UsuarioController();
                Usuario usuario = userCtrl.verificarUsuario(txtBuscar.Text);
                if (!string.IsNullOrEmpty(usuario._nombre))
                {
                    txtNombre.Text = usuario._nombre;
                    txtPassword.Text = usuario._password;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El usuario no existe');", true);
                }
            }
            catch (Exception ex)
            {
                Session["mensajeError"] = "Ha ocurrido un error al buscar el usuario. " + ex;
                Response.Redirect("../Error.aspx", false);
            }
        }
    }
}