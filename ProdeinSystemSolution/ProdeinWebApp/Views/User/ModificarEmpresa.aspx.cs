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
    public partial class ModificarEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpresasController empresaCtrl = new EmpresasController();
                bool respuesta = false;
                Empresas empresa = empresaCtrl.verificarEmpresa(Convert.ToInt32(txtIdentificacion.Text));
                if (!string.IsNullOrEmpty(empresa._nombre))
                {
                    empresa._rif = dplRif.Text;
                    empresa._numeroRif = Convert.ToInt32(txtIdentificacion.Text);
                    empresa._nombre = txtNombre.Text;
                    empresa._correo = txtCorreo.Text;
                    empresa._direccion = txtDireccion.Text;
                    empresa._pais = dplPais.Text;
                    empresa._estado = txtEstado.Text;
                    empresa._zonaPostal = Convert.ToInt32(txtZonaPostal.Text);
                    empresa._telf1 = Convert.ToInt32(txtTlf1.Text);
                    empresa._telf2 = Convert.ToInt32(txtTlf2.Text);
                    respuesta = empresaCtrl.modificarEmpresa(empresa);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La persona se ha Modificado');", true);
                    
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La persona no existe');", true);
                }
            }
            catch (Exception ex)
            {
                Session["mensajeError"] = "Ha ocurrido un error al modificar la empresa. " + ex;
                Response.Redirect("Error.aspx", false);
            }

            Response.Redirect("Home.aspx", false);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpresasController empresaCtrl = new EmpresasController();
                Empresas empresa = empresaCtrl.verificarEmpresa(Convert.ToInt32(txtBuscar.Text));
                if (!string.IsNullOrEmpty(empresa._nombre))
                {
                    txtIdentificacion.Text = Convert.ToString(empresa._numeroRif);
                    txtNombre.Text = empresa._nombre;
                    txtCorreo.Text = empresa._correo;
                    txtDireccion.Text = empresa._direccion;
                    txtEstado.Text = empresa._estado;
                    txtZonaPostal.Text = Convert.ToString(empresa._zonaPostal);
                    txtTlf1.Text = Convert.ToString(empresa._telf1);
                    txtTlf2.Text = Convert.ToString(empresa._telf2);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La empresa no existe');", true);
                }
            }
            catch (Exception ex)
            {
                Session["mensajeError"] = "Ha ocurrido un error al buscar la empresa. " + ex;
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}