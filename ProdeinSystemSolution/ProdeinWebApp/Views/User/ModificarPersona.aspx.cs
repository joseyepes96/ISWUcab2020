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
                Personas persona = personaCtrl.verificarPersona(txtBuscar.Text);
                if (!string.IsNullOrEmpty(persona._nombre))
                {
                    txtTipo.Text = persona._tipo;
                    txtIdentificacion.Text = persona._identificacion;
                    txtNombre.Text = persona._nombre;
                    txtEstCivil.Text = persona._estadoCivil;
                    txtEdad.Text = persona._edad;
                    txtProfesion.Text = persona._profesion;
                    txtCorreo.Text = persona._correo;
                    txtDireccion.Text = persona._direccion;
                    txtPais.Text = persona._pais;
                    txtEstado.Text = persona._estado;
                    txtZonaPostal.Text = persona._zonaPostal;
                    txtTlf1.Text = persona._movil1;
                    txtTlf2.Text = persona._movil2;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El usuario no existe');", true);
                }
            }
            catch (Exception ex)
            {
                Session["mensajeError"] = "Ha ocurrido un error al buscar el usuario. " + ex;
                Response.Redirect("../Error.aspx", false);
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaController personaCtrl = new PersonaController();
                bool respuesta = false;
                Personas persona = personaCtrl.verificarPersona(txtIdentificacion.Text);
                if (!string.IsNullOrEmpty(persona._identificacion))
                {
                    persona._tipo = txtTipo.Text;
                    persona._identificacion = txtIdentificacion.Text;
                    persona._nombre = txtNombre.Text;
                    persona._estadoCivil = txtEstCivil.Text;
                    persona._edad = txtEdad.Text;
                    persona._profesion = txtProfesion.Text;
                    persona._correo = txtCorreo.Text;
                    persona._direccion = txtDireccion.Text;
                    persona._pais = txtPais.Text;
                    persona._estado = txtEstado.Text;
                    persona._zonaPostal = txtZonaPostal.Text;
                    persona._movil1 = txtTlf1.Text;
                    persona._movil2 = txtTlf2.Text;
                    persona._sexo = dplSexo.SelectedValue;
                    respuesta = personaCtrl.modificarPersona(persona);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('La persona se ha Modificado');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El usuario no existe');", true);
                }
            }
            catch (Exception ex)
            {
                Session["mensajeError"] = "Ha ocurrido un error al modificar el usuario. " + ex;
                Response.Redirect("../Error.aspx", false);
            }
            Response.Redirect("Home.aspx", false);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
    }
}