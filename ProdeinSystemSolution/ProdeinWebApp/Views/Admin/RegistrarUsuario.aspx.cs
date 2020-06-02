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
    public partial class RegistrarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioController userCtrl = new UsuarioController();
                LoginController loginCtrl = new LoginController();
                var usuario = new Usuario(); /// para llenar el usuario y pasar el objeto
                var respuesta = false;

                //verfica usuario por nombre para evitar repetidos
                var loginUsuario = loginCtrl.verificarUsuario(txtNombre.Text, txtPassword.Text);

                if (!string.IsNullOrEmpty(loginUsuario._nombre)) // si existe el usuario
                {
                    Response.Write("<script language=javascript>alert('El usuario que ha ingresado no esta registrado');</script>");
                }
                else
                {
                    // se llena el objeto a registrar
                    usuario._nombre = txtNombre.Text;
                    usuario._password = txtPassword.Text;
                    usuario._rol = txtRol.Text;
                    usuario._permisos = dplPermisos.SelectedValue;
                    respuesta = userCtrl.agregarUsuario(usuario);  
                    if(respuesta)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(),"alert", "alert('El usuario ha sido registrado exitosamente');" +
                                "window.location ='Home.aspx';", true);                      
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El usuario no pudo ser registrado');" +
                               "window.location ='Home.aspx';", true);
                        //Response.Write("<script language=javascript>alert('El usuario no pudo ser registrado');</script>");
                    }                   
                }
            }
            catch (Exception ex)
            {

                Session["mensajeError"] = "Ha ocurrido un error al registrar el usuario. " + ex;
                Response.Redirect("../Error.aspx", false);
            }
        }
    }
}