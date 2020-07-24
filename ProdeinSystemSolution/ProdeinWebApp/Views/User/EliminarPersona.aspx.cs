using ProdeinWebApp.Controllers;
using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProdeinWebApp.Views.Persona
{
    public partial class EliminarPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                bool respuesta = false;
                PersonaController personaCtrl = new PersonaController();
                Personas persona = personaCtrl.verificarPersona(Convert.ToInt32(txtIdentificacion.Text));
                if (!string.IsNullOrEmpty(persona._nombre))
                {
                        respuesta = personaCtrl.eliminarPersona(persona);
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('la persona ha sido eliminada');", true);
                        Response.Redirect("Home.aspx", false);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La persona no existe');", true);
                }

            }
            catch (Exception ex)
            {
                Session["mensajeError"] = "Ha ocurrido un error al eliminar la persona. " + ex;
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
    }
}