using ProdeinWebApp.Controllers;
using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProdeinWebApp.Views.User.Persona
{
    public partial class RegistrarPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaController personaCtrl = new PersonaController();
                var persona = new Personas(); /// para llenar la persona y pasar el objeto
                var respuesta = false;

                //verfica persona porcedula para evitar repetidos
                var loginPersona = personaCtrl.verificarPersona(dplCedula.SelectedValue, txtCedula.Text);

                if (!string.IsNullOrEmpty(loginPersona._nombre)) // si existe el usuario
                {
                    Response.Write("<script language=javascript>alert('El usuario que ha ingresado ya esta registrado');</script>");

                }
                else
                {
                    // se llena el objeto a registrar
                    persona._nombre = txtNombre.Text;
                    persona._cedulaRif = dplCedula.SelectedValue;
                    persona._numeroCedulaRif = int.Parse(txtCedula.Text);
                    persona._sexo = dplSexo.SelectedValue;
                    persona._estadoCivil = dplEstadoCivil.SelectedValue;
                    persona._edad = int.Parse(txtEdad.Text);
                    persona._profesion = txtProfesion.Text;
                    persona._correo = txtCorreo.Text;
                    persona._direccion = txtDireccion.Text;
                    persona._pais = dplPais.SelectedValue;
                    persona._estado = txtEstado.Text;
                    persona._zonaPostal = int.Parse(txtZonaPostal.Text);
                    persona._telf1 = int.Parse(txtTelefono1.Text);
                    persona._telf2 = int.Parse(txtTelefono2.Text);

            
                    respuesta = personaCtrl.agregarPersona(persona);
                    if (respuesta)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La persona ha sido registrado exitosamente');" +
                             "window.location ='../Home.aspx';", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La persona no pudo ser registrada');" +
                            "window.location ='Home.aspx';", true);
                        //Response.Write("<script language=javascript>alert('El usuario no pudo ser registrado');</script>");
                    }
                }
            }
            catch (Exception ex)
            {

                Session["mensajeError"] = "Ha ocurrido un error al registrar el usuario. " + ex;
                Response.Redirect("../Error.aspx", false);
            }
        
        }
    

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Home.aspx", false);
        }
    }
}