using ProdeinWebApp.Controllers;
using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProdeinWebApp.Views.User.Empresa
{
    public partial class EliminarEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                bool respuesta = false;
                EmpresasController empresaCtrl = new EmpresasController();
                Empresas empresa = empresaCtrl.verificarEmpresa(Convert.ToInt32(txtIdentificacion.Text));
                if (!string.IsNullOrEmpty(empresa._nombre))
                {
                    respuesta = empresaCtrl.eliminarEmpresa(empresa);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La empresa ha sido eliminada');", true);
                    Response.Redirect("Home.aspx", false);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La empresa no existe');", true);
                }

            }
            catch (Exception ex)
            {
                Session["mensajeError"] = "Ha ocurrido un error al eliminar la empresa. " + ex;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO DEBE HABER CAMPOS VACÍOS ');", true);
                //Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
    }
}