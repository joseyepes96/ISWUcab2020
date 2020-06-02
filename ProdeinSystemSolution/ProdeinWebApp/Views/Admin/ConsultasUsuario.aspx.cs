using ProdeinWebApp.Controllers;
using ProdeinWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProdeinWebApp.Views.Admin
{
    public partial class ConsultasUsuario : System.Web.UI.Page
    {
        public string tabla; // para contruir y mostrar la tabla con html 

        List<Usuario> listaUsuarios = new List<Usuario>();
        UsuarioController userCtrl = new UsuarioController();

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

                listaUsuarios = userCtrl.consultarUsuarios();
                // tabla de html
                listaUsuariosTabla.InnerHtml = tabla = mostrarTabla(listaUsuarios);

            }
        }

        public string mostrarTabla(List<Usuario> listaUsuarios)
        {
            if (listaUsuarios.Count > 0)
            {
                /// imprimo la cabecera de la tabla de esta manera
                /// para no perder los estilos de bootstrap
                tabla += "<table id='example' class='table table-striped table-bordered second' style='width: 100%'>";
                tabla += "<thead>";
                tabla += "<tr>";
                    tabla += "<th>ID</th>";
                    tabla += "<th>Nombre</th>";
                    tabla += "<th>Rol</th>";
                    tabla += "<th>Permisos</th>";
                tabla += "</tr>";
                tabla += "</thead>";

                tabla += "<tbody>";

                /// cuerpo o contenido de la tabla
                foreach (Usuario item in listaUsuarios)
                {
                    tabla += "<tr>";
                        tabla += "<td>" + item._id + "</td>";
                        tabla += "<td>" + item._nombre + "</td>";
                        tabla += "<td>" + item._rol + "</td>";
                        tabla += "<td>" + item._permisos + "</td>";
                    tabla += "</tr>";
                }
                tabla += "</tbody>";
                    tabla += "<tfoot>";
                        tabla += "<tr>";
                            tabla += "<th>ID</th>";
                            tabla += "<th>Nombre</th>";
                            tabla += "<th>Rol</th>";
                            tabla += "<th>Permisos</th>";
                        tabla += "</tr>";
                    tabla += "</tfoot>";
                tabla += "</table>";
            }                                          
            return tabla;
        }
    }
}