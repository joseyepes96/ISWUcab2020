using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProdeinWebApp.Models
{
    public class Usuario
    {
        // Datos para el login del Admin y del Usuario
        public int _id { get; set; }
        public string _nombre { get; set; }
        public string _password { get; set; } // se encriptara despues
        public string _rol { get; set; } // admin o user
        public string _permisos { get; set; } // todo, crear, mod, cons y elim
    }
}