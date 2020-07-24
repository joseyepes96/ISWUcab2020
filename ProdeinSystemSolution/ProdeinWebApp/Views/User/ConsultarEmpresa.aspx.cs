using ProdeinWebApp.Controllers;
using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProdeinWebApp.Views.User.Empresa
{
    public partial class ConsultarEmpresa : System.Web.UI.Page
    {
        public string tabla; // para contruir y mostrar la tabla con html 

        List<Empresas> listaEmpresas = new List<Empresas>();
        EmpresasController empreCtrl = new EmpresasController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                listaEmpresas = empreCtrl.consultarEmpresa();
                // tabla de html
                listaEmpresaTabla.InnerHtml = tabla = mostrarTabla(listaEmpresas);

            }
        }

        public string mostrarTabla(List<Empresas> listaEmpresas)
        {
            if (listaEmpresas.Count > 0)
            {
                /// imprimo la cabecera de la tabla de esta manera
                /// para no perder los estilos de bootstrap
                tabla += "<table id='example' class='table table-striped table-bordered second' style='width: 100%'>";
                tabla += "<thead>";
                tabla += "<tr>";
                tabla += "<th>ID</th>";
                tabla += "<th>T. De Documento</th>";
                tabla += "<th>Nro. Rif</th>";
                tabla += "<th>Razón Social</th>";
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
                foreach (Empresas item in listaEmpresas)
                {
                    tabla += "<tr>";
                    tabla += "<td>" + item._id + "</td>";
                    tabla += "<td>" + item._rif + "</td>";
                    tabla += "<td>" + item._numeroRif + "</td>";
                    tabla += "<td>" + item._nombre + "</td>";
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

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx", false);
        }
    }
}