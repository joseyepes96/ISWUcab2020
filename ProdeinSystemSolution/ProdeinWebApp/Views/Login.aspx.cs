using ProdeinWebApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProdeinWebApp.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcceder_Click(object sender, EventArgs e)
        {
           try
            {               
                LoginController loginCtrl = new LoginController();
                //verfica usuario por nombre --- falta validar la contrasenas iguales
                var loginUsuario = loginCtrl.verificarUsuario(txtUserName.Text, txtPassword.Text);

                if (!string.IsNullOrEmpty(loginUsuario._nombre)) // si existe el usuario
                {
                    Session["usuarioLogueado"] = loginUsuario; // guardo la sesion del usuario para usarlo en todo el sistema
                    Session["NombreLogin"] = loginUsuario._nombre;

                    if (loginUsuario._rol == "admin")
                    {
                        Response.Redirect("Admin/Home.aspx", false);
                    }
                    if (loginUsuario._rol == "user")
                    {
                        Response.Redirect("User/Home.aspx", false);
                    }
                }
                else
                {
                    Response.Write("<script language=javascript>alert('El usuario que ha ingresado no esta registrado');</script>");
                }
            }
            catch (Exception ex)
            {
                Session["mensajeError"] = "Ha ocurrido un error al acceder en el Login. " + ex;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO DEBE HABER CAMPOS VACÍOS ');", true);
                //Response.Redirect("Error.aspx");
            }
        }
    }
}