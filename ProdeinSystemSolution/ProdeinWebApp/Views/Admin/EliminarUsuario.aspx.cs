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
    public partial class EliminarUsuario : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
    
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }


        protected void btnEliminar_Clcik(object sender, EventArgs e)
        {
            try
            {
                bool respuesta = false;
                UsuarioController userCtrl = new UsuarioController();
                Usuario usuario = userCtrl.verificarUsuario(txtNombre.Text);
                if (!string.IsNullOrEmpty(usuario._nombre))
                {
                    if (usuario._rol == "user")
                    {
                        respuesta = userCtrl.eliminarUsuario(usuario);
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El usuario ha sido eliminado');", true);
                        Response.Redirect("ConsultasUsuario.aspx", false);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El usuario no se puede eliminar un admin');", true);
                        Response.Redirect("EliminarUsuario.aspx", false);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El usuario no existe');",  true);
                }

            }
            catch (Exception ex)
            {
                Session["mensajeError"] = "Ha ocurrido un error al eliminar el usuario. " + ex;
                Response.Redirect("../Error.aspx", false);
            }
                
        }

    }


}
