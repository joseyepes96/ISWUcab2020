using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Models
{
    public class Empresas
    {
        public int _id { get; set; }
        public string _nombre { get; set; }
        public string _rif { get; set; }    // Si es J o G
        public int _numeroRif { get; set; }
        public string _correo { get; set; }
        public string _direccion { get; set; }
        public string _pais { get; set; }
        public string _estado { get; set; }
        public int _zonaPostal { get; set; }
        public long _telf1 { get; set; }
        public long _telf2 { get; set; }
    }
}