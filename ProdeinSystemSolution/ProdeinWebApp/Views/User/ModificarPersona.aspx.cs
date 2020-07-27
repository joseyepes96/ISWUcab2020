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
    public partial class ModificarPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaController personaCtrl = new PersonaController();
                Personas persona = personaCtrl.verificarPersona(Convert.ToInt32(txtBuscar.Text));
                if (!string.IsNullOrEmpty(persona._nombre))
                {
                    txtIdentificacion.Text = Convert.ToString(persona._numeroCedulaRif);
                    txtNombre.Text = persona._nombre;
                    txtEdad.Text = Convert.ToString(persona._edad);
                    txtProfesion.Text = persona._profesion;
                    txtCorreo.Text = persona._correo;
                    txtDireccion.Text = persona._direccion;
                    txtEstado.Text = persona._estado;
                    txtZonaPostal.Text = Convert.ToString(persona._zonaPostal);
                    txtTlf1.Text = Convert.ToString(persona._telf1);
                    txtTlf2.Text = Convert.ToString(persona._telf2);
                }
                else
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La persona no existe o está mal escrito');", true);
            }
            catch (Exception ex)
            {
                Session["mensajeError"] = "Ha ocurrido un error al buscar la persona. " + ex;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO DEBE HABER CAMPOS VACÍOS Y DEBE ESCRIBIR SOLO NUMEROS');", true);

                // Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaController personaCtrl = new PersonaController();
                bool respuesta = false;
                Personas persona = personaCtrl.verificarPersona(Convert.ToInt32(txtIdentificacion.Text));
                if (!string.IsNullOrEmpty(persona._nombre))
                {
                    if (personaCtrl.validarTexto(txtNombre.Text) && personaCtrl.validarTexto(txtProfesion.Text) && personaCtrl.validarTexto(txtEstado.Text)
                        && personaCtrl.validarCampoCorreo(txtCorreo.Text) && personaCtrl.validarCampoNumerico(txtIdentificacion.Text) && personaCtrl.validarCampoNumerico(txtEdad.Text)
                        && personaCtrl.validarCampoNumerico(txtZonaPostal.Text) && personaCtrl.validarCampoNumerico(txtTlf1.Text) && personaCtrl.validarCampoNumerico(txtTlf2.Text))
                    {
                        persona._cedulaRif = dplCedula.Text;
                        persona._numeroCedulaRif = Convert.ToInt32(txtIdentificacion.Text);
                        persona._nombre = txtNombre.Text;
                        persona._estadoCivil = dplEstadoCivil.Text;
                        persona._edad = Convert.ToInt32(txtEdad.Text);
                        persona._profesion = txtProfesion.Text;
                        persona._correo = txtCorreo.Text;
                        persona._direccion = txtDireccion.Text;
                        persona._pais = dplPais.Text;
                        persona._estado = txtEstado.Text;
                        persona._zonaPostal = Convert.ToInt32(txtZonaPostal.Text);
                        persona._telf1 = Convert.ToInt32(txtTlf1.Text);
                        persona._telf2 = Convert.ToInt32(txtTlf2.Text);
                        persona._sexo = dplSexo.SelectedValue;
                        respuesta = personaCtrl.modificarPersona(persona);

                        if (respuesta)
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La persona se ha Modificado exitosamente');" +
                                  "window.location ='ModificarPersona.aspx';", true);
                        else
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La persona no pudo ser registrada');" +
                                "window.location ='ModificarPersona.aspx';", true);
                    }
                    else
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Hay datos inválidos. Revise que no tenga caracteres especiales y que tenga el formato de correo correcto');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La persona no existe');", true);
                }
            }
            catch (Exception ex)
            {
                Session["mensajeError"] = "Ha ocurrido un error al modificar la persona. " + ex;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('NO DEBE HABER CAMPOS VACÍOS ');", true);

                // Response.Redirect("Error.aspx", false);
            }
            //Response.Redirect("Home.aspx", false);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
    }
}