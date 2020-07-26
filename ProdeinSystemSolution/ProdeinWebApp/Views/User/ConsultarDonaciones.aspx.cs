using System;
using System.Collections.Generic;
using ProdeinWebApp.Controllers;
using ProdeinWebApp.Models;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProdeinWebApp.Views.User.Donaciones
{
    public partial class ConsultarDonaciones : System.Web.UI.Page
    {
        public string tabla;  

        List<Donacion> listaDonaciones = new List<Donacion>();
        DonacionesController donaCtrl = new DonacionesController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaDonaciones = donaCtrl.consultarDonacion();
                listaDonacionesTabla.InnerHtml = tabla = mostrarTabla(listaDonaciones);

            }
        }
        public string mostrarTabla(List<Donacion> listaDonaciones)
        {
            if (listaDonaciones.Count > 0)
            {

                tabla += "<table id='example' class='table table-striped table-bordered second' style='width: 100%'>";
                tabla += "<thead>";
                tabla += "<tr>";
                tabla += "<th>ID</th>";
                tabla += "<th>Nombre</th>";
                tabla += "<th>Tipo de Documento</th>";
                tabla += "<th>Numero de Cedula o Rif</th>";
                tabla += "<th>Fecha</th>";
                tabla += "<th>Tipo de Donacion</th>";
                tabla += "<th>Forma de Pago</th>";
                tabla += "<th>Monto</th>";
                tabla += "<th>Moneda de Pago</th>";
                tabla += "</tr>";
                tabla += "</thead>";

                tabla += "<tbody>";

                /// cuerpo o contenido de la tabla
                foreach (Donacion item in listaDonaciones)
                {
                    tabla += "<tr>";
                    tabla += "<td>" + item._id + "</td>";
                    tabla += "<td>" + item._nombre+ "</td>";
                    tabla += "<td>" + item._cedulaRif + "</td>";
                    tabla += "<td>" + item._numCedRif + "</td>";
                    tabla += "<td>" + item._fechaDonacion + "</td>";
                    tabla += "<td>" + item._tipoDeDonacion + "</td>";
                    tabla += "<td>" + item._formaDePago + "</td>";
                    tabla += "<td>" + item._monto + "</td>";
                    tabla += "<td>" + item._moneda + "</td>";
                    tabla += "</tr>";
                }
                tabla += "</tbody>";

                tabla += "</table>";
            }

            return tabla;
        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
    }
}