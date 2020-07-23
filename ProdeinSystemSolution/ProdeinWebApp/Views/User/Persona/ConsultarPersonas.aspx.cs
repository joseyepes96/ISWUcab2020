using ProdeinWebApp.Controllers;
using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProdeinWebApp.Views.User.Persona
{
    public partial class ConsultarPersonas : System.Web.UI.Page
    { 
        public string tabla; // para contruir y mostrar la tabla con html 

         List<Personas> listaPersonas= new List<Personas>();
         PersonaController userCtrl = new PersonaController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //DataTable dt = new DataTable();
                //dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Id", typeof(int)),
                //            new DataColumn("Nombre", typeof(string)),
                //            new DataColumn("Ciudad",typeof(string)) });
                //dt.Rows.Add(1, "Jonathan Orozco", "Monterrey");
                //dt.Rows.Add(2, "Jesus Corona", "México");
                //dt.Rows.Add(3, "Cirilo Zaucedo", "Tijuana");
                //dt.Rows.Add(4, "Humberto Suazo", "Chile");
                //GridView1.DataSource = dt;
                //GridView1.DataBind();

                listaPersonas = userCtrl.consultarPersona();
                // tabla de html
                listaPersonaTabla.InnerHtml = tabla = mostrarTabla(listaPersonas);

            }
        }

        public string mostrarTabla(List<Personas> listaPersonas)
        {
            if (listaPersonas.Count > 0)
            {
                /// imprimo la cabecera de la tabla de esta manera
                /// para no perder los estilos de bootstrap
                tabla += "<table id='example' class='table table-striped table-bordered second' style='width: 100%'>";
                tabla += "<thead>";
                tabla += "<tr>";
                tabla += "<th>ID</th>";
                tabla += "<th>T. De Documento</th>";
                tabla += "<th>Nro. Cédula</th>";
                tabla += "<th>Nombre o Razón Social</th>";
                tabla += "<th>Sexo</th>";
                tabla += "<th>Estado Civil</th>";
                tabla += "<th>Edad</th>";
                tabla += "<th>Profesión</th>";
                tabla += "<th>Correo</th>";
                tabla += "<th>Direccion</th>";
                tabla += "<th>Pais</th>";
                tabla += "<th>Estado</th>";
                tabla += "<th>Zona Postal</th>";
                tabla += "<th>Telefono1</th>";
                tabla += "<Telefono2</th>";
                tabla += "</tr>";
                tabla += "</thead>";

                tabla += "<tbody>";

                /// cuerpo o contenido de la tabla
                foreach (Personas item in listaPersonas)
                {
                    tabla += "<tr>";
                    tabla += "<td>" + item._id + "</td>";
                    tabla += "<td>" + item._cedulaRif + "</td>";
                    tabla += "<td>" + item._numeroCedulaRif + "</td>";
                    tabla += "<td>" + item._nombre + "</td>";
                    tabla += "<td>" + item._sexo + "</td>";
                    tabla += "<td>" + item._estadoCivil + "</td>";
                    tabla += "<td>" + item._edad + "</td>";
                    tabla += "<td>" + item._profesion + "</td>";
                    tabla += "<td>" + item._correo + "</td>";
                    tabla += "<td>" + item._direccion + "</td>";
                    tabla += "<td>" + item._pais + "</td>";
                    tabla += "<td>" + item._estado + "</td>";
                    tabla += "<td>" + item._zonaPostal + "</td>";
                    tabla += "<td>" + item._telf1 + "</td>";
                    tabla += "<td>" + item._telf2 + "</td>";
                    tabla += "</tr>";
                }
                tabla += "</tbody>";
             
                tabla += "</table>";
            }
        
            return tabla;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Home.aspx", false);
        }
    }
}