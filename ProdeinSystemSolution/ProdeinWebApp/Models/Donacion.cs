using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Models
{
    public class Donacion
    {
        public int _id { get; set; }
        public string _nombre { get; set; }
        public string _cedulaRif { get; set; } //V,E,P,J,G
        public int _numCedRif { get; set; }
        public string _fechaDonacion { get; set; }
        public double _monto { get; set; }
        public string _formaDePago { get; set; }
        public string _moneda { get; set; }
        public string _tipoDeDonacion { get; set; } //periodica,unica
    }
}