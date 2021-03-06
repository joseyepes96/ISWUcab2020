﻿using ProdeinWebApp.Controllers;
using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProdeinWebApp.Views.User.Empresa
{
    public partial class RegistrarEmpresa : System.Web.UI.Page
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
                EmpresasController empresaCtrl = new EmpresasController();
                var empresa = new Empresas(); /// para llenar la empresa y pasar el objeto
                var respuesta = false;

                //verfica empresa por rif para evitar repetidos
                var loginEmpresa = empresaCtrl.verificarEmpresa(dplRif.SelectedValue, txtNumeroRif.Text);

                
                if (!string.IsNullOrEmpty(loginEmpresa._nombre)) // si existe la empresa           
                    Response.Write("<script language=javascript>alert('La empresa ya esta registrado');</script>");
                    
                else
                {
                    if (empresaCtrl.validarTexto(txtNombreEmpresa.Text) && empresaCtrl.validarTexto(txtEstado.Text)
                        && empresaCtrl.validarCampoCorreo(txtCorreo.Text) && empresaCtrl.validarCampoNumerico(txtNumeroRif.Text)
                        && empresaCtrl.validarCampoNumerico(txtZonaPostal.Text) && empresaCtrl.validarCampoNumerico(txtTelefono1.Text) && empresaCtrl.validarCampoNumerico(txtTelefono2.Text))
                    {
                        // se llena el objeto a registrar
                        empresa._nombre = txtNombreEmpresa.Text;
                        empresa._rif = dplRif.SelectedValue;
                        empresa._numeroRif = int.Parse(txtNumeroRif.Text);
                        empresa._correo = txtCorreo.Text;
                        empresa._direccion = txtDireccion.Text;
                        empresa._pais = dplPais.SelectedValue;
                        empresa._estado = txtEstado.Text;
                        empresa._zonaPostal = int.Parse(txtZonaPostal.Text);
                        empresa._telf1 = int.Parse(txtTelefono1.Text);
                        empresa._telf2 = int.Parse(txtTelefono2.Text);


                        respuesta = empresaCtrl.agregarEmpresa(empresa);

                        if (respuesta)
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Empresa ha sido registrado exitosamente');" +
                                 "window.location ='Home.aspx';", true);
                        else
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La Empresa no pudo ser registrada');" +
                                "window.location ='Home.aspx';", true);
                    }
                    else
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Hay datos inválidos. Revise que no tenga caracteres especiales y que tenga el formato de correo correcto');", true);

                }
            }
            catch (Exception ex)
            {
                Session["mensajeError"] = "Ha ocurrido un error al registrar la empresa. " + ex;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO DEBE HABER CAMPOS VACÍOS');", true);
                //Response.Redirect("Error.aspx", false);
            }
        }
    }
}