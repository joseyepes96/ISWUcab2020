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
    public partial class RegistrarDonaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaController personaCtrl = new PersonaController();
                EmpresasController empresaCtrl = new EmpresasController();
                if (personaCtrl.validarCampoNumerico(txtBuscar.Text)) { 
                    Personas persona = personaCtrl.verificarPersona(Convert.ToInt32(txtBuscar.Text));
                    Empresas empresa = empresaCtrl.verificarEmpresa(Convert.ToInt32(txtBuscar.Text));
                if (!string.IsNullOrEmpty(persona._nombre))
                {
                    txtNombrePresonaEmpresa.Text = persona._nombre;
                    txtTipoDocumento.Text = persona._cedulaRif;
                    txtNumeroRifCedula.Text = Convert.ToString(persona._numeroCedulaRif);
                    }
                else if (!string.IsNullOrEmpty(empresa._nombre))
                {
                    txtNombrePresonaEmpresa.Text = empresa._nombre;
                    txtTipoDocumento.Text = empresa._nombre;
                    txtNumeroRifCedula.Text = Convert.ToString(empresa._numeroRif);
                    }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La persona  o la empresa no estan registrados');", true);
                    }
                }
                else
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Hay datos inválidos. Solo se permiten numeros');", true);
            }
            catch (Exception ex)
            {
                Session["mensajeError"] = "Ha ocurrido un error al buscar la persona. " + ex;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO DEBE HABER CAMPOS VACÍOS');", true);
                // Response.Redirect("Error.aspx", false);
            }
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                DonacionesController donacionCtrl = new DonacionesController();
                Donacion donar = new Donacion();
                if (donacionCtrl.validarCampoNumerico(txtMonto.Text)) {
                    var respuesta = false;
                    donar._nombre = txtNombrePresonaEmpresa.Text;
                    donar._cedulaRif = txtTipoDocumento.Text;
                    donar._numCedRif = int.Parse(txtNumeroRifCedula.Text);
                    donar._fechaDonacion = txtFecha.Text;
                    donar._formaDePago = dplPago.Text;
                    donar._monto = Convert.ToDouble(txtMonto.Text);
                    donar._moneda = dplMoneda.Text;
                    donar._tipoDeDonacion = dplTipo.Text;
                    respuesta = donacionCtrl.agregarDonaciones(donar);


                    if (respuesta)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La donacion ha sido registrado exitosamente');" +
                             "window.location ='Home.aspx';", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La donacion no pudo ser registrada');" +
                            "window.location ='Home.aspx';", true);
                        //Response.Write("<script language=javascript>alert('El usuario no pudo ser registrado');</script>");
                    }
                }
                else
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Hay datos inválidos. Revise que no tenga caracteres especiales');", true);
            }
            catch (Exception ex)
            {

                Session["mensajeError"] = "Ha ocurrido un error al registrar la persona. " + ex;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO DEBE HABER CAMPOS VACÍOS');", true);

                // Response.Redirect("Error.aspx", false);
            }
        }
    }
}