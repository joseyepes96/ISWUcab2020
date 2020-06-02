using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProdeinWebApp.Views
{
    public partial class Error : System.Web.UI.Page
    {
        public string mensaje { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // si entra por primera vez
            {

            }
            mensaje = Session["mensajeError"].ToString();
            lblMostrarError.Text = mensaje; // muestra el mensaje en la pagina
        }

        protected void linkHome_Click(object sender, EventArgs e)
        {
            try
            {
                // verifico que rol tiene para redirigirlo a su home
                Usuario usuarioSesion = Session["usuarioLogueado"] as Usuario;
                if (usuarioSesion._rol == "admin")
                {
                    Response.Redirect("Admin/Home.aspx");
                }
                if (usuarioSesion._rol == "user")
                {
                    Response.Redirect("User/Home.aspx");
                }
            }
            catch (Exception ex)
            {
                lblMostrarError.Text = "No hay usuario logueado. Favor intente loguearse." + ex;
            }
            
        }
    }
}