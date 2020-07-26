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
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

            DonacionesController donacionCtrl = new DonacionesController();
            Donacion donar = new Donacion();
                var respuesta = false;
                    donar._nombre = txtNombrePresonaEmpresa.Text;
                    donar._cedulaRif = dplRifCedula.SelectedValue;
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
    }
}