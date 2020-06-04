using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Models
{
    public class Personas
    {
        public int _id { get; set; }
        public string _tipo { get; set; } 
        public string _nombre { get; set; } 
        public string _sexo { get; set; }
        public string _edad { get; set; }
        public string _estadoCivil { get; set; }
        public string _correo { get; set; }
        public string _identificacion { set; get; }
        public string _direccion { get; set; }
        public string _pais { get; set; }
        public string _estado { get; set; }
        public string _zonaPostal { get; set; }
        public string _movil1 { get; set; }
        public string _movil2 { get; set; }
        public string _profesion { get; set; }

    }
}