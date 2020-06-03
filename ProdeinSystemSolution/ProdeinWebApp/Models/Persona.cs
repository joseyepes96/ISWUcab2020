using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Models
{
    public class Persona
    {
        public int _id { get; set; }
        public string _trato { get; set; }
        public string _tipo { get; set; } 
        public string _nombre { get; set; } 
        public string _apellido1 { get; set; }
        public string _apellido2 { get; set; }
        public string _sexo { get; set; }
        public DateTime _fechaNacimiento { get; set; }
        public int _edad { get; set; }
        public string _estadoCivil { get; set; }
        public string _razonSocial { get; set; }
        public string _correo { get; set; }
        public string _identificacion { set; get; }
        public string _direccion { get; set; }
        public string _pais { get; set; }
        public string _estado { get; set; }
        public int _zonaPostal { get; set; }
        public long _movil1 { get; set; }
        public long _movil2 { get; set; }
        public long _local1 { get; set; }
        public long _local2 { get; set; }
        public string _profesion { get; set; }
        public string _facebook { get; set; }
        public string _instagram { get; set; }

    }
}