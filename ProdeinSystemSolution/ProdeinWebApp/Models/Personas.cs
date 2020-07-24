using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Models
{
    public class Personas
    {
        public int _id { get; set; }
        public string _nombre { get; set; }
        public string _cedulaRif { get; set; }    // Si es V,E, P
        public int _numeroCedulaRif { get; set; }
        public string _sexo { get; set; }
        public int _edad { get; set; }
        public string _estadoCivil { get; set; }
        public string _profesion { get; set; }
        public string _correo { get; set; }
        public string _direccion { get; set; }
        public string _pais { get; set; }
        public string _estado { get; set; }
        public int _zonaPostal { get; set; }
        public long _telf1 { get; set; }
        public long _telf2 { get; set; }
    }
}