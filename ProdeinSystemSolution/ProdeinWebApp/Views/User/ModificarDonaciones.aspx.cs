﻿using System;
using ProdeinWebApp.Controllers;
using ProdeinWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProdeinWebApp.Views.User.Donaciones
{
    public partial class ModificarDonaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DonacionesController donacionCtrl = new DonacionesController();
                if (donacionCtrl.validarCampoNumerico(txtBuscar.Text))
                {
                    Donacion donacion = donacionCtrl.verificarDonacion(Convert.ToInt32(txtBuscar.Text));
                    if (!string.IsNullOrEmpty(donacion._nombre))
                    {
                        txtNumeroRifCedula.Text = Convert.ToString(donacion._numCedRif);
                        txtNombrePresonaEmpresa.Text = donacion._nombre;
                        txtMonto.Text = Convert.ToString(donacion._monto);
                        txtFecha.Text = donacion._fechaDonacion;
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La donacion no existe');", true);
                    }
                }
                else
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Hay datos inválidos. Solo se permiten numeros');", true);
            }
            catch (Exception ex)
            {
                Session["mensajeError"] = "Ha ocurrido un error al buscar la donacion. " + ex;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO DEBE HABER CAMPOS VACÍOS ');", true);
                //Response.Redirect("Error.aspx", false);
            }
        }
        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                DonacionesController donacionCtrl = new DonacionesController();
                bool respuesta = false;
                Donacion donacion = donacionCtrl.verificarDonacion(Convert.ToInt32(txtBuscar.Text));
                if (!string.IsNullOrEmpty(donacion._nombre))
                {
                    if (donacionCtrl.validarCampoNumerico(txtNumeroRifCedula.Text) && donacionCtrl.validarCampoNumericoDecimal(txtMonto.Text) && donacionCtrl.validarTexto(txtNombrePresonaEmpresa.Text))
                    {
                        donacion._cedulaRif = dplRifCedula.Text;
                        donacion._numCedRif = Convert.ToInt32(txtNumeroRifCedula.Text);
                        donacion._nombre = txtNombrePresonaEmpresa.Text;
                        donacion._moneda = dplMoneda.Text;
                        donacion._monto = Convert.ToDouble(txtMonto.Text);
                        donacion._fechaDonacion = txtFecha.Text;
                        donacion._tipoDeDonacion = dplTipo.Text;
                        donacion._formaDePago = dplPago.Text;
                        respuesta = donacionCtrl.modificarDonacion(donacion);
                        if (respuesta)
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La donacion se ha Modificado');" +
                                "window.location ='ModificarDonaciones.aspx';", true);
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La donacion no pudo ser modificada');" +
                                "window.location ='ModificarDonaciones.aspx';", true);
                        }
                    }
                    else
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Hay datos inválidos. Revise que no tenga caracteres especiales');", true);

                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La donacion no existe');", true);
                }
            }
            catch (Exception ex)
            {
                Session["mensajeError"] = "Ha ocurrido un error al modificar la persona. " + ex;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO DEBE HABER CAMPOS VACÍOS ');", true);
                //Response.Redirect("Error.aspx", false);
            }
           // Response.Redirect("Home.aspx", false);
        }
    }
}