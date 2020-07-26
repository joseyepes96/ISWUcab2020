using System;
using ProdeinWebApp.Controllers;
using ProdeinWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProdeinWebApp.Views.User.Donaciones
{
    public partial class EliminarDonaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                bool respuesta = false;
                DonacionesController donacionCtrl = new DonacionesController();
                Donacion donacion = donacionCtrl.verificarDonacion(Convert.ToInt32(txtId.Text));
                if (!string.IsNullOrEmpty(donacion._nombre))
                {
                    respuesta = donacionCtrl.eliminarDonacion(donacion);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La Donacion ha sido eliminada');", true);
                    Response.Redirect("Home.aspx", false);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La Donacion no existe');", true);
                }

            }
            catch (Exception ex)
            {
                Session["mensajeError"] = "Ha ocurrido un error al eliminar la donacion. " + ex;
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}